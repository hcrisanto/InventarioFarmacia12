using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>//Datos de inicio creera la bd si no existe no me los volvera a pedir mi bd

    {
        protected override void Seed(Contexto contexto)//Seed= es una semilla para inicializar los datos en una bd.
        {
            var usuarioAdmin = new Usuario();//se crea un usuario 
            usuarioAdmin.Nombre = "admin";    //se le crea un nombre
            usuarioAdmin.Contraseña = "123"; //y su contrasena y lo mismo se hace con categoria.
            usuarioAdmin.TipoUsuario = "Administradores";
            contexto.Usuarios.Add(usuarioAdmin);

            var usuarioCaja = new Usuario();//se crea un usuario 
            usuarioCaja.Nombre = "caja";    //se le crea un nombre
            usuarioCaja.Contraseña = "456"; //y su contrasena y lo mismo se hace con categoria.
            usuarioCaja.TipoUsuario = "Caja";
            contexto.Usuarios.Add(usuarioCaja);

            var categoria1 = new Categoria();//llama a la descripcion y nos dara un mensaje
            categoria1.Descripcion = "Infantil y Adulto";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Higiene Vocal y Coporal";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Cosmeticos";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Abbarroteria";
            contexto.Categorias.Add(categoria4);

            var categoria5 = new Categoria();
            categoria5.Descripcion = "Medicamentos Naturales";
            contexto.Categorias.Add(categoria5);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Medicamentos";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Financieros"; // las farmacias trabajan mancomunados atreaves de polizas de seguro
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Tecnico";//Medicos en farmacia que hay
            contexto.Tipos.Add(tipo3);

            var tipo4 = new Tipo();
            tipo4.Descripcion = "Humanos"; // personal de la farmacia
            contexto.Tipos.Add(tipo4);

            string path = Directory.GetCurrentDirectory();

            var archivo = "../../../clientes.csv";
            using (var reader = new StreamReader(archivo))
            {
                reader.ReadLine(); // Lee primera fila de encabezados

                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    var valores = linea.Split(',');

                    var clienteNuevo = new Cliente();
                    clienteNuevo.Nombre = valores[0].ToString();
                    clienteNuevo.Apellido = valores[1].ToString();
                    clienteNuevo.Correo = valores[2].ToString();
                    clienteNuevo.Direccion = valores[3].ToString();
                    clienteNuevo.Rtn = valores[4].ToString();
                    
                    contexto.Clientes.Add(clienteNuevo);
                }
            
              }
                                
            base.Seed(contexto);
        }
    }
}

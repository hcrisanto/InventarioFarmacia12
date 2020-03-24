using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public  class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>//Datos de inicio creera la bd si no existe no me los volvera a pedir mi bd

    {
        protected override void Seed(Contexto contexto)//Seed= es una semilla para inicialisar los datos en una bd.
        {
            var usuarioAdmin = new Usurario();//se crea un usuario 
            usuarioAdmin.Nombre = "admin";    //se le crea un nombre
            usuarioAdmin.Contraseña = "123"; //y su contrasena y lo mismo se hace con categoria.

            contexto.Usuarios.Add(usuarioAdmin);

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

            
            base.Seed(contexto);//Con la instruccion "base.Seed" se embia a la b.d. y se crean los datos de prueba

        }
    }
}

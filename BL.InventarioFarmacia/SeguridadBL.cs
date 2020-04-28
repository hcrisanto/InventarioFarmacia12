using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public class SeguridadBL
    {
                
        Contexto _contexto;

        public BindingList<Usuario> ListadeUsuarios { get; set; }

        public SeguridadBL()
        {
           
           _contexto = new Contexto();
            ListadeUsuarios = new BindingList<Usuario>();

            var usuario1 = new Usuario();
            usuario1.Nombre = "admin";
            usuario1.Contraseña = "123";

            var usuario2 = new Usuario();
            usuario2.Nombre = "Caja";
            usuario2.Contraseña = "4567";

            ListadeUsuarios.Add(usuario1);
            ListadeUsuarios.Add(usuario2);

        }
      
        public BindingList<Usuario> ObtenerUsuarios()
        {
            _contexto.Usuarios.Load(); // Productos es una lista de la base de datos, le decimos que a la tabla cargue los datos
            ListadeUsuarios = _contexto.Usuarios.Local.ToBindingList();//transforma los datos que traiga productos hacia un baindinlist

            return ListadeUsuarios;

        }

        
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())  
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exitoso == false)

            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            resultado.Mensaje = "Usuario Guardado Exitosamente";
            return resultado;
        }   
                                
        public void  AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            _contexto.Usuarios.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListadeUsuarios.ToList())
            {
                if (usuario.Id == id)
                {
                    ListadeUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (resultado == null)
            {
                resultado.Mensaje = "Agregue un Usuario Valido";
                resultado.Exitoso = false;

                return resultado;
            }
                       
            return resultado;
        }

        public Usuario Autorizar(string nombreUsuario, string contrasenia1)

        {
            var usuario = _contexto.Usuarios.ToList();//traiga a la lista todos los usuarios estara preguntado a todos los usuarios

            foreach (var usuarioDB in usuario)

            {
                if (nombreUsuario == usuarioDB.Nombre && contrasenia1 == usuarioDB.Contraseña)
                {
                    return usuarioDB;
                }
            }

            return null;
        }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }

        }

    }
    public class Usuario
    {  //propiedades para el Usuario
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string TipoUsuario { get; set; }
    }

}

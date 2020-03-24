
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public class SeguridadBL
    {

        List<Usurario> ListadeUsusarios;

        Contexto _contexto;

        public SeguridadBL()
        {

            _contexto = new Contexto();
            ListadeUsusarios = new List<Usurario>();

            var usuario1 = new Usurario();
            usuario1.Nombre = "admin";
            usuario1.Contraseña = "123";

            var usuario2 = new Usurario();
            usuario2.Nombre = "administrador";
            usuario2.Contraseña = "4567";

            ListadeUsusarios.Add(usuario1);
            ListadeUsusarios.Add(usuario2);

        }
        public bool Autorizar(string usuario1, string contraseña1)

        {
            var usuario = _contexto.Usuarios.ToList();//traiga a la lista todos los usuarios estara preguntado a todos los usuarios

            foreach (var usuarioDB in usuario)

            {
                if (usuario1 == usuarioDB.Nombre && contraseña1 == usuarioDB.Contraseña)
                {
                    return true;
                }
            }

            return false;
        }
    }

}
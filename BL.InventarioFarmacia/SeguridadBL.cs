using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public class SeguridadBL
    {

        List<Usurario> ListadeUsusarios;

        public SeguridadBL()
        {
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
      public  bool Autorizar(string usuario1, string contrasena1 )

        {
            if (usuario1 == "admin" && contrasena1 == "123")
            {
                return true;
            } else

            {
                if (usuario1 == "administrator" && contrasena1 == "4567")

                {
                    return true;
            }

          }

            return false;
        }
    }
}

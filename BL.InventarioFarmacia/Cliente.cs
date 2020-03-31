using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
   public class Cliente
    {
        public int Id { get; set; }
        public string Rtn { get; set; }//campo para identidad o rtn
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
    }

}
    
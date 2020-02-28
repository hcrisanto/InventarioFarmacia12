using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
   public class ProveedorBL
    {
        public BindingList<Proveedor> ListadeProvedores { get; set; }

        public ProveedorBL()
        {
            ListadeProvedores = new BindingList<Proveedor>();

            var proveedor1 = new Proveedor();

            proveedor1.RTN = 1084-1988-01147;
            proveedor1.Empresa = "Industrias Chamer";
            proveedor1.Direccion = "San Pedro Sula, Cortes";
            proveedor1.Telefono = "00-00-00-00";
            proveedor1.Disponible= true;



            var proveedor2 = new Proveedor();

            proveedor2.RTN = 1084 - 1988 - 01147;
            proveedor2.Empresa = "Grupo Farinter";
            proveedor2.Direccion = "Choluteca";
            proveedor2.Telefono = "00-00-00-00";
            proveedor2.Disponible = true;


            var proveedor3 = new Proveedor();

            proveedor3.RTN = 1084 - 1988 - 01147;
            proveedor3.Empresa = "Laboratorios Ubiopharma";
            proveedor3.Direccion = "Guadalajara, Mexico";
            proveedor3.Telefono = "00-00-00-00";
            proveedor3.Disponible = true;

            var proveedor4 = new Proveedor();

            proveedor4.RTN = 0000 - 1111 - 2222 - 0123;
            proveedor4.Empresa = "Astropharma";
            proveedor4.Direccion = " Tegucigalpa";
            proveedor4.Telefono = "9999-9999";
            proveedor4.Disponible = true;


            ListadeProvedores.Add(proveedor1);
            ListadeProvedores.Add(proveedor2);
            ListadeProvedores.Add(proveedor3);
            ListadeProvedores.Add(proveedor4);
        }

        public BindingList<Proveedor> ObtenerProveedor()
        {
            return ListadeProvedores;

        }
    }

    public class Proveedor
    {
        public int RTN { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Disponible { get; set; }

    }
}


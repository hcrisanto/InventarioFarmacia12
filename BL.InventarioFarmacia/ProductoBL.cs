using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
   public class ProductoBL
    {
       public BindingList<Producto> ListaProductos { get; set; }

        public ProductoBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();

            producto1.Id = 01;
            producto1.Medicamento = "Acetaminofen";
            producto1.Descripcion= "Para dolor de cabeza.";
            producto1.Precio = 5 ;
            producto1.Litera = " A " ;
            producto1.Existencia = 50;
            producto1.Disponible = true;



            var producto2 = new Producto();

            producto2.Id = 02;
            producto2.Medicamento = "Tosan";
            producto2.Descripcion = "Jarabe para la Tos";
            producto2.Precio = 20;
            producto2.Litera = " B ";
            producto2.Existencia = 10;
            producto2.Disponible = true;

            var producto3 = new Producto();

            producto3.Id = 03;
            producto3.Medicamento = "Vitaflenaco";
            producto3.Descripcion = "Para el dolor muscular";
            producto3.Precio = 15;
            producto3.Litera = " A ";
            producto3.Existencia = 100;
            producto3.Disponible = true;


            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);
            ListaProductos.Add(producto3);

        }

        public BindingList<Producto> ObtenerProducto()
        {
            return ListaProductos;

        }

        public bool GuardarProducto(Producto productos)
        {
            if (productos.Id == 0)
            {
                productos.Id = ListaProductos.Max(item => item.Id) + 1;
            }
            return true;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Medicamento { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Litera { get; set; }
        public int Existencia { get; set; }
        public bool Disponible { get; set; }

    }
}

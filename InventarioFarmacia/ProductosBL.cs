using BL.InventarioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFarmacia
{
    internal class ProductosBL
    {
        private Contexto _contexto;

        public ProductosBL()
        {
            _contexto = new Contexto();

            ListaProductos = new BindingList<Producto>();
        }

        public BindingList<Producto> ListaProductos { get; private set; }

        public BindingList<Producto> ObtenerProducto()
        {
            _contexto.Productos.Load(); // Productos es una lista de la base de datos, le decimos que a la tabla cargue los datos
            ListaProductos = _contexto.Productos.Local.ToBindingList();//transforma los datos que traiga productos hacia un baindinlist

            return ListaProductos;

        }

        public BindingList<Producto> ObtenerProducto(string buscar)
        {
            var query = _contexto.Productos
               .Where(p => p.Descripcion.ToLower()
                .Contains(buscar.ToLower()) == true)
                       .ToList();

            var resultado = new BindingList<Producto>(query);

            return resultado;
        }

        /* internal object ObtenerProductos()
         {
             throw new NotImplementedException();
         }*/
    }
}
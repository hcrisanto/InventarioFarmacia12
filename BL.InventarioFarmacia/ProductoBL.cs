using BL.InventarioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia                     
{
   public class productosBL
    {
        Contexto _contexto;
       public BindingList<Producto> ListaProductos { get; set; }

        public productosBL()
        {

            _contexto = new Contexto();

            ListaProductos = new BindingList<Producto>();

        }

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

        internal object ObtenerProductos()
        {
            throw new NotImplementedException();
        }

        public BindingList<Producto> BuscarProducto(string nombre)
        {
            var resultado = _contexto.Productos
            .Where(a => a.Descripcion.ToLower().Contains(nombre.ToLower()) == true)
            .ToList();

            ListaProductos = new BindingList<Producto>(resultado);

            return ListaProductos;

        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())//Contexto = guarda una memoria de todo lo que trajo  de la bd.// Tracker = son todos los cabios eliminar, agregar,actualizar,
            {                                                      //Entries = Pueden ser generados de un cliente,factura,un producto,y queda almacenado ChangeTracker.
                item.State = EntityState.Unchanged;
                item.Reload();

            }
        }

        public Resultado GuardarProducto(Producto productos)
        {
            var resultado = Validar(productos);
            if (resultado.Exitoso == false)

            {
               return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            resultado.Mensaje = "Producto Guardado Exitosamente";
            return resultado;
        }


        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            _contexto.Productos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach(var Producto in ListaProductos)
            {
                if(Producto.Id == id)
                {
                    
                    ListaProductos.Remove(Producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (producto == null)
            {
                resultado.Mensaje = "Agregue un Producto Valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una Descripcion";
                resultado.Exitoso = false;
            }


            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia tiene que ser mayor que cero";
                resultado.Exitoso = false;
            }


            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El precio tiene que ser mayor que cero";
                resultado.Exitoso = false;
            }
            if(producto.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione una Tipo";
                resultado.Exitoso = false;

            }
            if (producto.CategoriaId == 0)
            {
                resultado.Mensaje = "Seleccione una Categoria";
                resultado.Exitoso = false;

            }

            return resultado;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Medicamento { get; set; }//tipo de presentacion del medicamento, pastillas
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Litera { get; set; }//Repisas que se encuentran en un estante ordenadas alfabeticamente de la A asta Z
        public int Existencia { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int TipoId { get; set; }//preguntara deme el "tipo" y lo creara un campo foraneo
        public Tipo Tipo { get; set; }
        public byte[] Foto { get; set; }//La imagen se creara en nuestra base de dato byte
        public bool Disponible { get; set; }
        public bool Activo { get; private set; }

        public Producto()
        {
            Activo = true;
        }

    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}

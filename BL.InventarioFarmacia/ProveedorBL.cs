using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public class ProveedorBL
    {
        Contexto _contexto;
        public BindingList<Proveedor> ListaProveedores { get; set; }

        public ProveedorBL()
        {
            _contexto = new Contexto();

            ListaProveedores = new BindingList<Proveedor>(); //decimos que a la tabla producto 
                                                             //noscargue los datos           
        }

        public BindingList<Proveedor> ObtenerProveedor()
        {
            _contexto.Proveedor.Load();
           ListaProveedores = _contexto.Proveedor.Local.ToBindingList();

            return ListaProveedores;

        }

      public BindingList<Proveedor> BuscarProveedor(string nombre)
        {
            var resultado = _contexto.Proveedor
           .Where(a => a.Telefono.ToLower().Contains(nombre.ToLower()) == true)
            .ToList();

            ListaProveedores = new BindingList<Proveedor>(resultado);

           return ListaProveedores;

        }
        
        public Resultado GuardarProveedor(Proveedor proveedor)
        {
            var resultado = Validar(proveedor);
            if (resultado.Exitoso == false)

            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            resultado.Mensaje = "Proveedor Guardado Exitosamente";
            return resultado;
        }
        
        public void AgregarProveedor()
        {
            var nuevoProveedor = new Proveedor();
            ListaProveedores.Add(nuevoProveedor);


        }

        public bool EliminarProveedor(int id)
        {
            foreach (var Proveedor in ListaProveedores)
            {
                if (Proveedor.Id == id)
                {
                    ListaProveedores.Remove(Proveedor);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())//Contexto = guarda una memoria de todo lo que trajo  de la bd.// Tracker = son todos los cabios eliminar, agregar,actualizar,
            {                                                      //Entries = Pueden ser generados de un cliente,factura,un producto,y queda almacenado ChangeTracker.
                item.State = EntityState.Unchanged;
                item.Reload();

            }
        }

        private Resultado Validar(Proveedor proveedor)
          {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(proveedor.Empresa) == true)
            {
                resultado.Mensaje = "Ingrese el nombre de la empresa";
                resultado.Exitoso = false;
            }


            if (proveedor.RTN < 0)
            {
                resultado.Mensaje = "El RTN no debe estar vacio";
                resultado.Exitoso = false;
            }


            if (proveedor.Direccion == null)
            {
                resultado.Mensaje = "LA direccion no debe estar Vacia";
                resultado.Exitoso = false;
            }

            return resultado;
          }


    }
    public class Proveedor
    {
        public int Id { get; set; }
        public int RTN { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Disponible { get; set; }

    }

}


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
public  class ClienteBL
    {
        Contexto _contexto;

        public BindingList<Cliente> ListadeClientes{ get; set; }

        public ClienteBL()
        {
            _contexto = new Contexto();
            ListadeClientes= new BindingList<Cliente>();
                              
        }
        public BindingList<Cliente> ObtenerClientes()
        {
            //   _contexto.Clientes.Load();
            //   ListadeClientes = _contexto.Clientes.Local.ToBindingList();

            ListadeClientes = new  BindingList<Cliente>(
                 _contexto.Clientes.OrderBy(o => o.Nombre).ToList()
             );


            return ListadeClientes;
        }

        public BindingList<Cliente> ObtenerCliente(string buscar)
        {
            var query = _contexto.Clientes
               .Where(p => p.Nombre.ToLower()
                .Contains(buscar.ToLower()) == true)
                       .ToList();

            var resultado = new BindingList<Cliente>(query);

            return resultado;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())//Contexto = guarda una memoria de todo lo que trajo  de la bd.// Tracker = son todos los cabios eliminar, agregar,actualizar,
            {                                                      //Entries = Pueden ser generados de un cliente,factura,un producto,y queda almacenado ChangeTracker.
                item.State = EntityState.Unchanged;
                item.Reload();

            }
        }
        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (cliente == null)
            {
                resultado.Mensaje = "Agregue un Cliente Valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(cliente.Correo) == true)
            {
                resultado.Mensaje = "Ingrese un Correo";
                resultado.Exitoso = false;

            }
            return resultado;
        }
        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Mensaje = "Cliente Guardado Exitosamente";
            resultado.Exitoso = true;
            return resultado;

        }    
        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            _contexto.Clientes.Add(nuevoCliente);
        }

        public BindingList<Cliente> ObtenerCliente()
        {
            _contexto.Clientes.Load(); 

            ListadeClientes = _contexto.Clientes.Local.ToBindingList();

            return ListadeClientes;
        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListadeClientes.ToList())
            {
                if (cliente.Id ==  id)
                {
                    ListadeClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        

    }
    public class Cliente
    {

        public int Id { get; set; }
        public string Rtn { get; set; }//campo para identidad o rtn
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }

        public Cliente()
        {
            Activo = true;
        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
public  class ClienteBL
    {

        public BindingList<Cliente> ListadeClientes{ get; set; }

        public ClienteBL()
        {
            ListadeClientes= new BindingList<Cliente>();
            
                    
            var cliente1 = new Cliente();

            cliente1.Id = 01;
            cliente1.Nombre = "Juan";
            cliente1.Apellido = "Lozano";
            cliente1.Direccion = "Puerto Cortes";
            cliente1.Edad = "23";
           



            var cliente2 = new Cliente();

            cliente2.Id = 02;
            cliente2.Nombre = "Maria";
            cliente2.Apellido = "Mendoza";
            cliente2.Direccion = "El Progreso, Yoro";
            cliente2.Edad = "20";


            var cliente3 = new Cliente();

            cliente3.Id = 03;
            cliente3.Nombre = "Miguel";
            cliente3.Apellido = "Lizano";
            cliente3.Direccion = "Puerto Cortes";
            cliente3.Edad = "23";


            var cliente4 = new Cliente();

            cliente4.Id = 04;
            cliente4.Nombre = "Mario";
            cliente4.Apellido = "Poritllo";
            cliente4.Direccion = "Puerto Lempira";
            cliente4.Edad = "26";

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
            ListadeClientes.Add(cliente4);


        }


        public BindingList<Cliente> ObtenerCliente()
        {
            return ListadeClientes;
        }


        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Direccion { get; set; }
            public string Edad { get; set; }
           

        }
    }

}

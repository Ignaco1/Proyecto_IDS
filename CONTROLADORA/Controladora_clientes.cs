using Microsoft.EntityFrameworkCore;
using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_clientes
    {
        private static Controladora_clientes instancia;
        //private Context contextClientes;
        public static Controladora_clientes Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_clientes();
                }
                return instancia;
            }
        }

        public Controladora_clientes()
        {
           
        }

        public ReadOnlyCollection<Cliente> ListarClientes()
        {
            using (var context = new Context())
            {
                return context.Clientes.ToList().AsReadOnly();
            }

        }

        public Cliente CrearCliente(string nombre, string dni, string email, string telefono)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = nombre;
            cliente.Dni = dni;
            cliente.Email = email;
            cliente.Telefono = telefono;
            return cliente;
        }

        public string AgregarCliente(Cliente nuevoCliente)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevoCliente);
                    context.SaveChanges();
                    return $"Nuevo cliente agregado al sistema con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }

            
        }

        public string ModificarCliente(Cliente cliente)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Update(cliente);
                    context.SaveChanges();
                    return $"Cliente modificado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }

           
        }

        public string EliminarCliente(Cliente cliente)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Remove(cliente);
                    context.SaveChanges();
                    return $"Cliente eliminado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }

            
        }
    }
}

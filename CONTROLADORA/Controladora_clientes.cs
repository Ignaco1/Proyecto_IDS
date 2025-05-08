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
        private Context contextClientes;
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
            contextClientes = new Context();
        }

        public ReadOnlyCollection<Cliente> ListarClientes()
        {
            return contextClientes.Clientes.ToList().AsReadOnly();
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
            try
            {
                contextClientes.Add(nuevoCliente);
                contextClientes.SaveChanges();
                return $"Nuevo cliente agregado al sistema con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }

        public string ModificarCliente(Cliente cliente)
        {
            try
            {
                contextClientes.Update(cliente);
                contextClientes.SaveChanges();
                return $"Cliente modificado con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }

        public string EliminarCliente(Cliente cliente)
        {
            try
            {
                contextClientes.Remove(cliente);
                contextClientes.SaveChanges();
                return $"Cliente eliminado con exito";
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el sistema: " + ex.Message;
            }
        }
    }
}

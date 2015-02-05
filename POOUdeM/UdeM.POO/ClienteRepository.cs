using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeM.POO
{
    public class ClienteRepository
    {
        public void CrearCliente(Cliente cliente)
        {
            Console.WriteLine(cliente.Nombre);
            Console.ReadLine();
        }
    }
}

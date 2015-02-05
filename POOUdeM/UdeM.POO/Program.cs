using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeM.POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente()
            {
                IdCliente = 1,
                Nombre = "piedad cordoba",
                Acompanyantes = 3
            };
            ClienteRepository repositorio = new ClienteRepository();
            repositorio.CrearCliente(cliente);
        }
    }
}

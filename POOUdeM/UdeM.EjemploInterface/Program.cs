using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeM.EjemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IHablable patoLucas = new PatoDonald();
            patoLucas.Hablar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeM.EjemploInterface
{
    class PatoLucas : IHablable
    {
        public void Hablar()
        {
            Console.WriteLine("Hola soy lucas");
            Console.ReadLine();
        }
    }
}

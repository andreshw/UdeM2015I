using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeM.EjemploInterface
{
    class PatoDonald : IHablable
    {
        public void Hablar()
        {
            Console.WriteLine("Soy Donald");
            Console.ReadLine();
        }
    }
}

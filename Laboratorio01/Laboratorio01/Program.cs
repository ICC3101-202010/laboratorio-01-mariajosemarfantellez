using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            {
                int Cachipun = rnd.Next(0, 3);
                Console.WriteLine(Cachipun);
            }

            clsPerson Persona = new clsPerson("Bob", "Kunga");
            Console.WriteLine(Persona.Name + " " + Persona.LastName);
        }
    }
}

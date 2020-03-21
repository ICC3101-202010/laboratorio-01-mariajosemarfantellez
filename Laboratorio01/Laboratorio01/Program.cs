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
            clsPerson Persona = new clsPerson("Bob", "Kunga");
            Console.WriteLine(Persona.Name + " " + Persona.LastName);
            Console.WriteLine("En el lanzamiento salió "+Persona.Lanzar());
            Console.ReadLine( );
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    class clsPerson
    {
        public string Name;
        public string LastName;

        public clsPerson(string Name, string LastName)
        {
            this.Name = Name;
            this.LastName = LastName;
        }
        public int Lanzar()
        {
            Random rnd = new Random();
            int Cachipun = rnd.Next(0, 3);

            return(Cachipun);
        }
    }
}

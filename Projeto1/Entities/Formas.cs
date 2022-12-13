using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto1.Entities;
using Projeto1.Entities.Enums;

namespace Projeto1.Entities
{
    public abstract class Formas
    {
        public Cores cores { get; set; }


        public Formas(Cores cores)
        {  

    }

        public abstract double Areas();

    }
}
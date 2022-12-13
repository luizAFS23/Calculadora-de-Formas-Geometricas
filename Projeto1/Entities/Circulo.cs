using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto1.Entities;
using Projeto1.Entities.Enums;

namespace Projeto1.Entities
{
    public class Circulo : Formas
    {
        public double Radio { get; set; }

  
        public Circulo(double radio, Cores cores) : base(cores){
            Radio = radio;
        }

        public override double Areas()
        {
            return Math.PI * Radio * Radio;
        }
    }

}
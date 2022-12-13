using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto1.Entities;
using Projeto1.Entities.Enums;


namespace Projeto1.Entities
{
    public class Retangulo : Formas
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cores cores) : base(cores){
            Largura = largura;
            Altura = altura;
        }

        public override double Areas(){
            return Largura * Altura;
        }

    }
}
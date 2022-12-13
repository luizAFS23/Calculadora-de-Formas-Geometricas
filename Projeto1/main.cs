using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography;
using System.Collections.Generic;
using Projeto1.Entities;
using Projeto1.Entities.Enums;

namespace Projeto1
{
    class main
    {
        static void Main (string []args){
            try{
                Console.WriteLine("################## Calculadora de Áreas de Formas Geométricas ##################")
                Console.Write("Quantas formas geométricas você deseja inserir? ");
                int numero_de_formas = int.Parse(Console.ReadLine());
                List<Formas> list = new List<Formas>();

                for (int i = 1; i < numero_de_formas; i++) {
                    Console.WriteLine($"Informações da forma #{i}: ");

                        Console.WriteLine("Retângulo ou círculo (r/c)? ");
                        char escolha_forma = char.Parse(Console.ReadLine());
                        Console.WriteLine("Cor da forma geométrica (Vermelho/Azul/Preto): ");
                        Cores escolha_cores = Enum.Parse<Cores>(Console.ReadLine());
                        if(escolha_forma == 'r'){
                            Console.Write("Largura: ");
                            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Altura: ");
                            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            list.Add(new Retangulo(largura, altura, escolha_cores));

                        }else{
                            Console.Write("Radio: ");
                            double radio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            list.Add(new Circulo(radio, escolha_cores));  
                        }
                    
                }

                Console.WriteLine("Valor da área das formas geométrica inseridas: ");
                    foreach(Formas forma in list){
                        Console.WriteLine(forma.Areas().ToString("F2", CultureInfo.InvariantCulture));
                    }
            }catch(Exception e){
                System.Console.WriteLine("O programa encontrou um erro: " + e);
            }
        }
    }
}
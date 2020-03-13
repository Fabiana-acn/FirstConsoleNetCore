using System;
using P1;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var carro =new Automovel(){
                Cor="azul"
            };
            Console.WriteLine("Portas: "+carro.Portas+" Do Carro");
            Console.WriteLine(string.Format("Portas: {0} Do Carro", carro.Portas));
            Console.WriteLine($"Portas: {carro.Portas} Do Carro");
            
            carro.Portas=2;

            carro.Nome = "HRV";
            Console.WriteLine(carro.Nome);
            Console.WriteLine(carro.Cor);
            Console.WriteLine(carro.Portas);
            Console.WriteLine(carro.Rodas);
            Console.WriteLine(carro.Rodas2);
        }
    }
}

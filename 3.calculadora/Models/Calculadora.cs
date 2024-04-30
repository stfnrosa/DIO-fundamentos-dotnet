using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3.calculadora.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x*y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        }
        public void Seno(double angulo)
        {
            double radiando = angulo * (Math.PI /180);
            double seno = Math.Sin(radiando);
            Console.WriteLine($"Seno de {angulo} = {seno}");
        }
        public void Coseno(double angulo)
        {
            double radiando = angulo * (Math.PI /180);
            double coseno = Math.Cos(radiando);
            Console.WriteLine($"Coseno de {angulo} = {coseno}");
        }
        public void Tangente(double angulo)
        {
            double radiando = angulo * (Math.PI /180);
            double tangente = Math.Tan(radiando);
            Console.WriteLine($"Tangente de {angulo} = {tangente}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_genetic_algorithms_1.Class
{
    public abstract class Constants
    {
        // Tamanho do indivíduo
        public static int SizeCromossomo = 9;

        // Tamanho da população
        public static int SizePopulacao = 100;

        // Função como em 0 até 2 exponencial tamanho do cromossomo
        public static int FunctionXSize = (int) Math.Pow(2, SizeCromossomo);

        // Objeto randomico, gera numeros pelo clock do processador
        public static Random Random = new Random((int) DateTime.Now.Ticks);

        public static double Function1(double x)
        {
            return (double)(100 + Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))));
        }
    }
}

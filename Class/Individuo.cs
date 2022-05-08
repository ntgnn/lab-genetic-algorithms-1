using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_genetic_algorithms_1.Class
{
    public class Individuo
    {
        // Vetor de bits, possui apenas 2 estados: true ou false
        private BitArray _cromossomo;

        // Nota de aptidão do indivíduo
        private double _fitness;

        // A porcentagem do indivíduo, o quão apto ele é para reproduzir
        private double _fitnessPercent;

        // Faixa da pizza em que é provável que ele seja selecionado
        private double[] _faixaRoleta = { 0, 0 };

        public Individuo()
        {
            // Instancia o cromossomo com a quantidade de bits informados na classe Constants
            _cromossomo = new BitArray(Constants.SizeCromossomo);

            // Para cada posição do cromossomo sorteamos um valor aleatório, podendo ser verdadeiro ou falso
            for (int i = 0; i < _cromossomo.Length; i++)
            {
                _cromossomo[i] = (Constants.Random.NextDouble() > 0.5f) ? true : false;
            }
        }

        public BitArray GetCromossomo()
        {
            return _cromossomo;
        }

        // Inserir valor booleano em determinado local do vetor do cromossomo
        public void SetGene(int posicao, bool gene)
        {
            _cromossomo[posicao] = gene;
        }

        public bool GetGene(int posicao)
        {
            return _cromossomo[posicao];
        }

        public void SetFitness(double fitness)
        {
            _fitness = fitness;
        }

        public double GetFitness()
        {
            return _fitness;
        }

        public void SetFitnessPercent(double fitnessPercent)
        {
            _fitnessPercent = fitnessPercent;
        }

        public double GetFitnessPercent()
        {
            return Math.Round(_fitnessPercent, 7);
        }

        public void MutarBit(int posicao)
        {
            if (posicao < _cromossomo.Length)
                _cromossomo.Set(posicao, (_cromossomo[posicao] == false) ? true : false);
        }

        public void SetRangeRoleta(double inicio, double fim)
        {
            _faixaRoleta[0] = inicio;
            _faixaRoleta[1] = fim;
        }

        public double[] GetRangeRoleta()
        {
            return _faixaRoleta;
        }

        public int GetInt()
        {
            if (_cromossomo.Length > 32)
                throw new ArgumentException("O comprimento do cromossomo deve ser no máximo 32 bits");

            int[] array = new int[1];
            _cromossomo.CopyTo(array, 0);

            return array[0];
        }

        public string PrintIndividuo()
        {
            string result = string.Empty;
            result += "Bits: ";

            for (int i = _cromossomo.Length - 1; i >=0 ; i--)
            {
                result = result + (_cromossomo[i] == false ? "0" : "1");
            }

            result += $"\t| Int: {GetInt()}\t| Aptidão: {GetFitness()}\t| Porcentagem: {GetFitnessPercent()}\t|";

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_genetic_algorithms_1.Class
{
    public class AlgoritmoGenetico
    {
        private double _taxaCrossover;
        private double _taxaMutacao;

        public AlgoritmoGenetico(double taxaCrossover, double taxaMutacao)
        {
            _taxaCrossover = taxaCrossover;
            _taxaMutacao = taxaMutacao;
        }

        public Populacao Executar(Populacao populacao)
        {
            // Início AG
            // Avaliacao População
            var novaPopulacao = new Populacao();
            var popBuffer = new List<Individuo>();

            for (int i = 0; i < Constants.SizePopulacao / 2; i++)
            {
                // Selecionar os pais para cruzamento
                var pai = Roleta(populacao);
                var mae = Roleta(populacao);

                // Realizar o cruzamento
                var filhos = Crossover(pai, mae);

                // Aplicar a mutação
                var filhoA = Mutacao(filhos[0]);
                var filhoB = Mutacao(filhos[1]);

                popBuffer.Add(filhoA);
                popBuffer.Add(filhoB);
            }

            // Apagar os velhos membros
            // Inserir novos membros
            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                novaPopulacao.SetIndividuo(i, popBuffer[i]);
            }
            popBuffer = null;

            // Re-avaliar a população 
            novaPopulacao.AtualizarValores();

            return novaPopulacao;
        }

        public Individuo[] Crossover(Individuo pai, Individuo mae)
        {
            Individuo[] filhos = new Individuo[2];
            int pontoDeCorte = Constants.Random.Next(0, Constants.SizeCromossomo - 1);

            var paiBuffer = new Individuo();
            var maeBuffer = new Individuo();

            filhos[0] = new Individuo();
            filhos[1] = new Individuo();

            for (int i = 0; i < Constants.SizeCromossomo; i++)
            {
                paiBuffer.SetGene(i, pai.GetGene(i));
                maeBuffer.SetGene(i, mae.GetGene(i));

                filhos[0].SetGene(i, pai.GetGene(i));
                filhos[1].SetGene(i, mae.GetGene(i));
            }

            if(Constants.Random.NextDouble() < _taxaCrossover)
            {
                //Debug.WriteLine("Caiu na taxa de crossover! Ponto de corte: " + pontoDeCorte);

                for (int i = pontoDeCorte; i < Constants.SizeCromossomo; i++)
                {
                    filhos[0].SetGene(i, maeBuffer.GetGene(i));
                    filhos[1].SetGene(i, paiBuffer.GetGene(i));
                }
            }

            return filhos;
        }

        public Individuo Mutacao(Individuo individuo)
        {
            if(Constants.Random.NextDouble() <= _taxaMutacao)
            {
                var posicao = Constants.Random.Next(0, Constants.SizeCromossomo);
                individuo.MutarBit(posicao);
            }

            return individuo;
        }

        public Individuo Roleta(Populacao populacao)
        {
            double numeroSorteado = (Constants.Random.NextDouble() * 100);

            foreach (var individuo in populacao.GetPopulacao())
            {
                if(numeroSorteado >= individuo.GetRangeRoleta()[0] && numeroSorteado <= individuo.GetRangeRoleta()[1])
                {
                    return individuo;
                }
            }

            return null;
        }
    }
}

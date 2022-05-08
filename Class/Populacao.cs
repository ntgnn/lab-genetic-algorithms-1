using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_genetic_algorithms_1.Class
{
    public class Populacao
    {
        // Grupo de indivíduos, vetor com N individuos
        private readonly Individuo[] _populacao;

        public Populacao()
        {
            _populacao = new Individuo[Constants.SizePopulacao];

            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                _populacao[i] = new Individuo();
            }

            // Avaliacao da população
            CalcularFitness();
            CalcularFitnessPercent();
            CalcularRangeRoleta();
        }

        public void CalcularFitness()
        {
            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                // Para calcular, aplique o valor inteiro do indivíduo na função de aptidão
                var individuo = _populacao[i];
                var fitness = Constants.Function1(individuo.GetInt());
                individuo.SetFitness(fitness);
            }
        }

        public void CalcularFitnessPercent()
        {
            double somatoriaFitness = 0;

            // Somatória de todos os valores de aptidão
            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                somatoriaFitness += _populacao[i].GetFitness();
            }

            // 
            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                var individuo = _populacao[i];
                var fitnessPercent = (individuo.GetFitness() * 100) / somatoriaFitness;
                individuo.SetFitnessPercent(fitnessPercent);
            }
        }

        public void AtualizarValores()
        {
            CalcularFitness();
            CalcularFitnessPercent();
            CalcularRangeRoleta();
        }

        // Calcula o Range da roleta em que o indivíduo faz parte
        public void CalcularRangeRoleta()
        {
            // Primeiramente deve-se ordenar a população em ordem crescente
            // Chamar método para ordenar a população
            OrdenarPopulacao();

            double somatoria = 0;
            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                if(i == 0)
                {
                    somatoria += _populacao[i].GetFitnessPercent();
                    _populacao[i].SetRangeRoleta(0, somatoria);
                }
                else if (i == (Constants.SizePopulacao - 1))
                {
                    _populacao[i].SetRangeRoleta(somatoria, 100f);
                }
                else
                {
                    _populacao[i].SetRangeRoleta(somatoria, somatoria + _populacao[i].GetFitnessPercent());
                    somatoria += _populacao[i].GetFitnessPercent();
                }
            }
        }

        // Método para ordenar a população
        public void OrdenarPopulacao()
        {
            var aux = new Individuo();
            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                for (int j = 0; j < Constants.SizePopulacao; j++)
                {
                    if (_populacao[i].GetFitnessPercent() < _populacao[j].GetFitnessPercent())
                    {
                        aux = _populacao[i];
                        _populacao[i] = _populacao[j];
                        _populacao[j] = aux;
                    }
                }
            }
        }

        public Individuo[] GetPopulacao()
        {
            return _populacao;
        }

        public void SetIndividuo(int posicao, Individuo individuo)
        {
            _populacao[posicao] = individuo;
        }

        public double GetMediaPopulacao()
        {
            double soma = 0;
            foreach (var individuo in _populacao)
            {
                soma += individuo.GetFitness();
            }

            return soma / Constants.SizePopulacao;
        }

        public string PrintPopulacao()
        {
            var result = string.Empty;
            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                result += _populacao[i].PrintIndividuo() + "\t| " +
                          _populacao[i].GetInt().ToString() + "\t| " +
                          _populacao[i].GetFitness().ToString() + "\t| " +
                          _populacao[i].GetFitnessPercent().ToString() + "\t| " +
                          _populacao[i].GetRangeRoleta()[0].ToString() + ":" +
                          _populacao[i].GetRangeRoleta()[1].ToString() + "\n";

            }
            return result;
        }
    }
}

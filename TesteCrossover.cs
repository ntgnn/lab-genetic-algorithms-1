using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab_genetic_algorithms_1.Class;

namespace lab_genetic_algorithms_1
{
    public partial class TesteCrossover : Form
    {
        private Populacao populacao = new Populacao();
        private AlgoritmoGenetico algoritmo = new AlgoritmoGenetico(0.8f, 0.01f);

        public TesteCrossover()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            
            var pai = new Individuo();
            txtPai.Text = pai.PrintIndividuo();

            var mae = new Individuo();
            txtMae.Text = mae.PrintIndividuo();

            var filhos = algoritmo.Crossover(pai, mae);
            txtFilho1.Text = filhos[0].PrintIndividuo();
            txtFilho2.Text = filhos[1].PrintIndividuo();

        }

        private void btnInterar_Click(object sender, EventArgs e)
        {
            populacao = algoritmo.Executar(populacao);
            txtPopulacao.Text = populacao.PrintPopulacao();

            lblMedia.Text = populacao.GetMediaPopulacao().ToString();
        }
    }
}

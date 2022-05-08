using lab_genetic_algorithms_1.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_genetic_algorithms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var individuo = new Individuo();
            txtIndividuo.Text = individuo.PrintIndividuo();

            var populacao = new Populacao();
            txtPopulacao.Text = populacao.PrintPopulacao();
        }
    }
}

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
using ZedGraph;

namespace lab_genetic_algorithms_1
{
    public partial class TelaPrincipal : Form
    {
        private Populacao _populacao;
        private GraphPane _panePopulacao;
        private GraphPane _paneMediaPopulacao;

        private PointPairList _curvaGrafico = new PointPairList();
        private PointPairList _populacaoGrafico = new PointPairList();
        private PointPairList _mediaPopulacaoGrafico = new PointPairList();

        public TelaPrincipal()
        {
            InitializeComponent();
            btnExecutar.Enabled = false;

            _panePopulacao = zedPopulacao.GraphPane;
            _panePopulacao.Title.Text = "Evolução";
            _panePopulacao.XAxis.Title.Text = "Gerações";
            _panePopulacao.YAxis.Title.Text = "Indivíduos";
            zedPopulacao.Refresh();

            _paneMediaPopulacao = zedMediaPopulacao.GraphPane;
            _paneMediaPopulacao.Title.Text = "Média da População";
            _paneMediaPopulacao.XAxis.Title.Text = "Gerações";
            _paneMediaPopulacao.YAxis.Title.Text = "Média Fitness";
            zedMediaPopulacao.Refresh();

            for (int x = 0; x < Constants.FunctionXSize; x++)
            {
                var y = Constants.Function1(x);
                _curvaGrafico.Add(x, y);
            }

            var funcao = _panePopulacao.AddCurve("Função", _curvaGrafico, Color.Red, SymbolType.None);

            zedPopulacao.AxisChange();
            zedPopulacao.Invalidate();
            zedPopulacao.Refresh();

            zedMediaPopulacao.AxisChange();
            zedMediaPopulacao.Invalidate();
            zedMediaPopulacao.Refresh();
        }

        private void btnCriarPopulacao_Click(object sender, EventArgs e)
        {
            btnExecutar.Enabled = true;

            _populacao = new Populacao();
            _populacaoGrafico = new PointPairList();

            for (int i = 0; i < Constants.SizePopulacao; i++)
            {
                var x = _populacao.GetPopulacao()[i].GetInt();
                var y = _populacao.GetPopulacao()[i].GetFitness();

                _populacaoGrafico.Add(x, y);
            }

            var individuos = _panePopulacao.AddStick("Indivíduos", _populacaoGrafico, Color.Blue);
            zedPopulacao.AxisChange();
            zedPopulacao.Invalidate();
            zedPopulacao.Refresh();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var taxaMutacao = double.Parse(txtTaxaMutacao.Text);
            var taxaCrossover = double.Parse(txtTaxaCrossover.Text);
            var evolucoes = int.Parse(txtEvolucoes.Text);

            var algoritmo = new AlgoritmoGenetico(taxaCrossover, taxaMutacao);
            for (int x = 0; x < evolucoes; x++)
            {
                _populacao = algoritmo.Executar(_populacao);

                var y = _populacao.GetMediaPopulacao();
                _mediaPopulacaoGrafico.Add(x, y);

                zedMediaPopulacao.GraphPane.CurveList.Clear();
                zedMediaPopulacao.GraphPane.GraphObjList.Clear();

                zedPopulacao.GraphPane.CurveList.Clear();
                zedPopulacao.GraphPane.GraphObjList.Clear();

                _populacaoGrafico = new PointPairList();

                for (int i = 0; i < Constants.SizePopulacao; i++)
                {
                    var individuo = _populacao.GetPopulacao()[i];
                    _populacaoGrafico.Add(individuo.GetInt(), individuo.GetFitness());
                }

                var media = _paneMediaPopulacao.AddCurve("Média", _mediaPopulacaoGrafico, Color.Red, SymbolType.None);
                var funcao = _panePopulacao.AddCurve("Função", _curvaGrafico, Color.Red, SymbolType.None);
                var individuos = _panePopulacao.AddStick("Indivíduo", _populacaoGrafico, Color.Blue);

                zedPopulacao.AxisChange();
                zedPopulacao.Invalidate();
                zedPopulacao.Refresh();

                zedMediaPopulacao.AxisChange();
                zedMediaPopulacao.Invalidate();
                zedMediaPopulacao.Refresh();
            }

            _populacao.OrdenarPopulacao();

            var pioresIndividuos = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                var individuo = _populacao.GetPopulacao()[i];
                pioresIndividuos += individuo.PrintIndividuo() + "\n";
            }

            var melhoresIndividuos = string.Empty;
            for (int i = Constants.SizePopulacao - 1; i > (Constants.SizePopulacao - 11); i--)
            {
                var individuo = _populacao.GetPopulacao()[i];
                melhoresIndividuos += individuo.PrintIndividuo() + "\n";
            }

            txtPioresIndividuos.Text = pioresIndividuos;
            txtMelhoresIndividuos.Text = melhoresIndividuos;
        }
    }
}

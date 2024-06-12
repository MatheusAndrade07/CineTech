using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineTech
{
    public partial class CineTechForms : Form
    {
        public CineTechForms()
        {           
            InitializeComponent();

            
            cmbSelecionarFilme.Items.Add(new Filme("Filme 1", 0, 12));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 2", 3, 12));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 3", 13, 15));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 4", 16, 19));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 5", 20, 39));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 6", 40, 49));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 7", 50, 59));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 8", 60, 74));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 9", 75, 84));
            cmbSelecionarFilme.Items.Add(new Filme("Filme 10", 85, 150));
            
            ExibirCapaFilme(cmbSelecionarFilme.SelectedIndex);
        }
        private void ExibirCapaFilme(int indice)
        {

        }

        private void btnSelecionarFilme_Click(object sender, EventArgs e)
        {
            if (cmbSelecionarFilme.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um filme.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ExibirCapaFilme(cmbSelecionarFilme.SelectedIndex);
            }
        }

        private void mskDataNascimento_Leave(object sender, EventArgs e)
        {
            if (mskDataNascimento.MaskFull == false)
            {
                MessageBox.Show("Por favor, insira uma data de nascimento válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime dataNascimento = DateTime.Parse(mskDataNascimento.Text);
                DateTime dataAtual = DateTime.Now;
                TimeSpan diferenca = dataAtual - dataNascimento;
                int idade = (int)diferenca.TotalDays / 365;

                if (idade < 1)
                {
                    MessageBox.Show("Você deve ter pelo menos 1 ano de idade para assistir a filmes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAssistirFilme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeDeUsuario.Text) || mskDataNascimento.MaskFull == false || cmbSelecionarFilme.SelectedIndex == -1)
            {
                if (string.IsNullOrEmpty(txtNomeDeUsuario.Text))
                {
                    MessageBox.Show("Por favor, digite seu nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (mskDataNascimento.MaskFull == false)
                {
                    MessageBox.Show("Por favor, insira uma data de nascimento válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (cmbSelecionarFilme.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecione um filme.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Filme filmeSelecionado = (Filme)cmbSelecionarFilme.SelectedItem;
                DateTime dataNascimento = DateTime.Parse(mskDataNascimento.Text);
                TimeSpan diferenca = DateTime.Now - dataNascimento;
                int idade = (int)diferenca.TotalDays / 365;

                string classificacao = "";

                if (idade >= filmeSelecionado.IdadeMinima && idade <= filmeSelecionado.IdadeMaxima)
                {
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                    classificacao = "Classificação permitida!";
                }
                else
                {
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                    classificacao = "Classificação não permitida!";
                }                
            }
        }
    }    
    
}

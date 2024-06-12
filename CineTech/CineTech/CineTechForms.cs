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

            // Adiciona os filmes ao ComboBox com a respectiva imagem
            cmbSelecionarFilme.Items.Add(new Filme("Filme 1", 16, 150, "Filme1")); // Mínimo 16 anos
            cmbSelecionarFilme.Items.Add(new Filme("Filme 2", 18, 150, "Filme2")); // Mínimo 18 anos
            cmbSelecionarFilme.Items.Add(new Filme("Filme 3", 13, 150, "Filme3")); // Mínimo 13 anos
            cmbSelecionarFilme.Items.Add(new Filme("Filme 4", 0, 12, "Filme4")); // Livre
            cmbSelecionarFilme.Items.Add(new Filme("Filme 5", 10, 150, "Filme5")); // Mínimo 10 anos
            cmbSelecionarFilme.Items.Add(new Filme("Filme 6", 21, 150, "Filme6")); // Mínimo 21 anos
            cmbSelecionarFilme.Items.Add(new Filme("Filme 7", 7, 150, "Filme7")); // Mínimo 7 anos
            cmbSelecionarFilme.Items.Add(new Filme("Filme 8", 5, 150, "Filme8")); // Mínimo 5 anos
            cmbSelecionarFilme.Items.Add(new Filme("Filme 9", 15, 150, "Filme9")); // Mínimo 15 anos
            cmbSelecionarFilme.Items.Add(new Filme("Filme 10", 3, 150, "Filme10")); // Mínimo 3 anos

            ExibirCapaFilme(cmbSelecionarFilme.SelectedIndex);
        }

        private void ExibirCapaFilme(int indice)
        {
            if (indice >= 0 && indice < cmbSelecionarFilme.Items.Count)
            {
                Filme filmeSelecionado = (Filme)cmbSelecionarFilme.SelectedItem;

                switch (filmeSelecionado.NomeDoArquivo)
                {
                    case "Filme1":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme2":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme3":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme4":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme5":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme6":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme7":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme8":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme9":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    case "Filme10":
                        pbCartazDoFilme.Image = Properties.Resources.AmericanPieFilme;
                        break;
                    default:
                        pbCartazDoFilme.Image = null;
                        break;
                }
            }
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
                DateTime dataNascimento;
                if (DateTime.TryParse(mskDataNascimento.Text, out dataNascimento))
                {
                    DateTime dataAtual = DateTime.Now;
                    TimeSpan diferenca = dataAtual - dataNascimento;
                    int idade = (int)diferenca.TotalDays / 365;

                    string classificacao = "";

                    if (idade >= filmeSelecionado.IdadeMinima && idade <= filmeSelecionado.IdadeMaxima)
                    {
                        classificacao = "Classificação permitida!";
                    }
                    else
                    {
                        classificacao = "Classificação não permitida!";
                    }

                    
                }
                else
                {
                    MessageBox.Show("Por favor, insira uma data de nascimento válida no formato dd/MM/yyyy.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void mskDataNascimento_TextChanged_1(object sender, EventArgs e)
        {
            if (mskDataNascimento.MaskFull)
            {
                DateTime dataNascimento;
                if (DateTime.TryParse(mskDataNascimento.Text, out dataNascimento))
                {
                    if (dataNascimento < DateTime.Now)
                    {
                        
                        DateTime dataAtual = DateTime.Now;
                        TimeSpan diferenca = dataAtual - dataNascimento;
                        int idade = (int)diferenca.TotalDays / 365;

                        
                        if (cmbSelecionarFilme.SelectedIndex >= 0)
                        {
                            Filme filmeSelecionado = (Filme)cmbSelecionarFilme.SelectedItem;
                            if (idade >= filmeSelecionado.IdadeMinima)
                            {                                
                                lblClassificacao.Text = "Classificação permitida!";
                                lblClassificacao.ForeColor = Color.Green;
                            }
                            else
                            {                                
                                lblClassificacao.Text = "Classificação não permitida!";
                                lblClassificacao.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        lblClassificacao.Text = "Data de nascimento inválida.";
                        lblClassificacao.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblClassificacao.Text = "Data de nascimento inválida.";
                    lblClassificacao.ForeColor = Color.Red;
                }
            }
            else
            {
                lblClassificacao.Text = ""; 
            }
        }
        // TESTE FUTURO         FilmeInfoForm formularioFilmeInfo = new FilmeInfoForm(txtNomeDeUsuario.Text, filmeSelecionado.Nome, classificacao);
        //TESTE FUTURO    formularioFilmeInfo.Show();
    }
    }

    public class Filme
    {
        public string Nome { get; set; }
        public int IdadeMinima { get; set; }
        public int IdadeMaxima { get; set; }
        public string NomeDoArquivo { get; set; } 

        public Filme(string nome, int idadeMinima, int idadeMaxima, string nomeDoArquivo)
        {
            Nome = nome;
            IdadeMinima = idadeMinima;
            IdadeMaxima = idadeMaxima;
            NomeDoArquivo = nomeDoArquivo;
        }

        public override string ToString()
        {
            return Nome;
        }
    }

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
            // Substitua essa lógica pela exibição real da capa
            // Ex: pictureBox1.Image = Image.FromFile($"Imagens/{cmbSelecionarFilme.SelectedItem}.jpg");
            // Aqui você deve carregar a imagem da capa do filme selecionado

            // Assumindo que você tem as imagens das capas na pasta "Imagens" 
            // e que o nome do arquivo da imagem é o mesmo nome do filme
            Filme filmeSelecionado = (Filme)cmbSelecionarFilme.SelectedItem;
            string caminhoDaImagem = $"Imagens/{filmeSelecionado.Nome}.jpg"; // Caminho da imagem da capa

            try
            {
                pbCartazDoFilme.Image = Image.FromFile(caminhoDaImagem);
            }
            catch (FileNotFoundException)
            {
                // Se o arquivo não for encontrado, exibe uma imagem padrão ou um aviso
                MessageBox.Show($"Cartaz para '{filmeSelecionado.Nome}' não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pbCartazDoFilme.Image = null; // Remove a imagem da PictureBox
            }
        }
    }
}

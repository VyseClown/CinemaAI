using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using System.IO;

namespace CinemaAIDesktop
{
    public partial class Form1 : Form
    {
        FileInfo file1;
        string caminhoImage1 = "";
        string nomeimagem1 = "";
        int idfilme = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilmeDominio objBus = new FilmeDominio();
            cbGenero.DataSource = objBus.listarGeneros();
            cbGenero.ValueMember = "gen_id";
            cbGenero.DisplayMember = "gen_filme";

            cbFilmes.DataSource = objBus.listarFilmes();
            cbFilmes.ValueMember = "fil_id";
            cbFilmes.DisplayMember = "fil_titulo";

            cbSalas.DataSource = objBus.listarSalas();
            cbSalas.ValueMember = "sal_id";
            cbSalas.DisplayMember = "sal_desc";
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            FilmeDominio fildom = new FilmeDominio();
            int idfilme = fildom.SelecionarUltimoFilme().fil_id;
            string iddofilme = (idfilme + 1).ToString();
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                file1 = new FileInfo(openFileDialog1.FileName);
                caminhoImage1 = System.IO.Path.GetFullPath(@"..\..\..\" + @"\CinemaAI\imgFilmes\" + file1.Name);

                if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), caminhoImage1)))//será que isso deu certo ?
                {
                    int i = 1;
                    caminhoImage1 = System.IO.Path.GetFullPath(@"..\..\..\" + @"\CinemaAI\imgFilmes\" + iddofilme + file1.Name);//agora vai

                    nomeimagem1 = iddofilme + file1.Name;
                    while (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), caminhoImage1)))
                    {
                        caminhoImage1 = System.IO.Path.GetFullPath(@"..\..\..\" + @"\CinemaAI\imgFilmes\" + iddofilme + i + file1.Name);
                        nomeimagem1 = iddofilme + i + file1.Name;
                        i++;
                    }
                    lblImg.Text = "Imagem selecionada";
                    //pega o ID que estaria no imovel adicionado e sempre colocar ele antes de cada imagem adicionada, nunca terá o ID no inicio
                    //igual !


                    //solução mais tosca
                    //MessageBox.Show("Informe outro nome para a imagem !");
                    //caminhoImage1 = "";
                }
                else
                {
                    nomeimagem1 = file1.Name;
                    lblImg.Text = "Imagem 1 selecionada";
                }



            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FilmeDominio fildom = new FilmeDominio();
            if (idfilme != 0)
            {
                //colocar o alterar o filme aqui, se for fazer
            }
            else if (nomeimagem1 != "") //if () para validar campos em branco
            {
                Filme fil = new Filme();
                fil.fil_descricao = txtDescricao.Text;
                fil.fil_datalan = dtpLancamento.Value.Date;
                fil.fil_idademin = int.Parse(txtIdade.Text);
                fil.fil_tempo = dtpTempo.Value;
                fil.fil_titulo = txtTitulo.Text;
                fil.fil_imagem = nomeimagem1;
                fil.gen_id = int.Parse(cbGenero.SelectedValue.ToString());
                file1.CopyTo(@caminhoImage1);
                fildom.Adicionar(fil);
                MessageBox.Show("Filme Cadastrado !");

                nomeimagem1 = "";

                limparTextBoxEMasked(tabPage4);
            }
            else
                MessageBox.Show("Selecione uma imagem !");

        }
        private void btnSalvarSala_Click(object sender, EventArgs e)
        {
            FilmeDominio objdom = new FilmeDominio();
            Salas sala = new Salas();

            sala.sal_desc = txtDescricaoSala.Text;
            sala.sal_qtdcadeira = int.Parse(txtQtdSala.Text);
            objdom.Adicionar(sala);
            MessageBox.Show("Sala adicionada !");
            limparTextBoxEMasked(tabPage3);
        }
        private void limparTextBoxEMasked(TabPage tab)
        {
            foreach (Control verifica in tab.Controls)
            {


                if (verifica is TextBox || verifica is MaskedTextBox)
                {
                    if (verifica.Text != string.Empty)
                    {
                        verifica.Text = "";

                    }


                }
            }
        }

        private void btnSalvarSessao_Click(object sender, EventArgs e)
        {
            FilmeDominio objdom = new FilmeDominio();
            Sessoes sess = new Sessoes();

            sess.ses_data = dtpDataSessao.Value;
            sess.ses_horario = TimeSpan.Parse(dtpHorarioSessao.Value.ToShortTimeString());
            sess.ses_idFilme = int.Parse(cbFilmes.SelectedValue.ToString());
            sess.ses_num = int.Parse(cbSalas.SelectedValue.ToString());
            sess.ses_qtdLugares = objdom.retornarSala(int.Parse(cbSalas.SelectedValue.ToString())).sal_qtdcadeira;


            objdom.Adicionar(sess);
            MessageBox.Show("Sessao adicionada !");
            limparTextBoxEMasked(tabPage2);
        }
    }
}

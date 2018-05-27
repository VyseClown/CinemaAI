namespace CinemaAIDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtpLancamento = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dtpTempo = new System.Windows.Forms.DateTimePicker();
            this.txtDescricaoSala = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtdSala = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalvarSala = new System.Windows.Forms.Button();
            this.btnAlterarSessao = new System.Windows.Forms.Button();
            this.btnSalvarSessao = new System.Windows.Forms.Button();
            this.dtpHorarioSessao = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpDataSessao = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbSalas = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbFilmes = new System.Windows.Forms.ComboBox();
            this.dgvSessoes = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 344);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSessoes);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.cbFilmes);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.cbSalas);
            this.tabPage2.Controls.Add(this.dtpDataSessao);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.dtpHorarioSessao);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.btnAlterarSessao);
            this.tabPage2.Controls.Add(this.btnSalvarSessao);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro de Sessão";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSalvarSala);
            this.tabPage3.Controls.Add(this.txtDescricaoSala);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtQtdSala);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(385, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastro de Sala";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dtpTempo);
            this.tabPage4.Controls.Add(this.dtpLancamento);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.lblImg);
            this.tabPage4.Controls.Add(this.btnSelecionarImagem);
            this.tabPage4.Controls.Add(this.btnSalvar);
            this.tabPage4.Controls.Add(this.cbGenero);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtDescricao);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtTipo);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtIdade);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtTitulo);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(385, 318);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cadastro de Filmes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtpLancamento
            // 
            this.dtpLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLancamento.Location = new System.Drawing.Point(9, 106);
            this.dtpLancamento.Name = "dtpLancamento";
            this.dtpLancamento.Size = new System.Drawing.Size(100, 20);
            this.dtpLancamento.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Gênero";
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(6, 242);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(113, 13);
            this.lblImg.TabIndex = 21;
            this.lblImg.Text = "Imagem a selecionar...";
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Location = new System.Drawing.Point(6, 259);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(121, 23);
            this.btnSelecionarImagem.TabIndex = 20;
            this.btnSelecionarImagem.Text = "Selecionar Imagem";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(133, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(160, 155);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tempo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(9, 195);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(272, 44);
            this.txtDescricao.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Descrição";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(160, 56);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(9, 155);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Idade Minima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Lançamento";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(9, 55);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Titulo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtpTempo
            // 
            this.dtpTempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTempo.Location = new System.Drawing.Point(160, 106);
            this.dtpTempo.Name = "dtpTempo";
            this.dtpTempo.Size = new System.Drawing.Size(100, 20);
            this.dtpTempo.TabIndex = 25;
            // 
            // txtDescricaoSala
            // 
            this.txtDescricaoSala.Location = new System.Drawing.Point(160, 38);
            this.txtDescricaoSala.Name = "txtDescricaoSala";
            this.txtDescricaoSala.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoSala.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descrição";
            // 
            // txtQtdSala
            // 
            this.txtQtdSala.Location = new System.Drawing.Point(9, 37);
            this.txtQtdSala.Name = "txtQtdSala";
            this.txtQtdSala.Size = new System.Drawing.Size(100, 20);
            this.txtQtdSala.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Quantidade de cadeiras";
            // 
            // btnSalvarSala
            // 
            this.btnSalvarSala.Location = new System.Drawing.Point(9, 72);
            this.btnSalvarSala.Name = "btnSalvarSala";
            this.btnSalvarSala.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarSala.TabIndex = 18;
            this.btnSalvarSala.Text = "Salvar";
            this.btnSalvarSala.UseVisualStyleBackColor = true;
            this.btnSalvarSala.Click += new System.EventHandler(this.btnSalvarSala_Click);
            // 
            // btnAlterarSessao
            // 
            this.btnAlterarSessao.Location = new System.Drawing.Point(90, 107);
            this.btnAlterarSessao.Name = "btnAlterarSessao";
            this.btnAlterarSessao.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarSessao.TabIndex = 26;
            this.btnAlterarSessao.Text = "Alterar";
            this.btnAlterarSessao.UseVisualStyleBackColor = true;
            this.btnAlterarSessao.Click += new System.EventHandler(this.btnAlterarSessao_Click);
            // 
            // btnSalvarSessao
            // 
            this.btnSalvarSessao.Location = new System.Drawing.Point(9, 107);
            this.btnSalvarSessao.Name = "btnSalvarSessao";
            this.btnSalvarSessao.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarSessao.TabIndex = 25;
            this.btnSalvarSessao.Text = "Salvar";
            this.btnSalvarSessao.UseVisualStyleBackColor = true;
            this.btnSalvarSessao.Click += new System.EventHandler(this.btnSalvarSessao_Click);
            // 
            // dtpHorarioSessao
            // 
            this.dtpHorarioSessao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioSessao.Location = new System.Drawing.Point(9, 37);
            this.dtpHorarioSessao.Name = "dtpHorarioSessao";
            this.dtpHorarioSessao.ShowUpDown = true;
            this.dtpHorarioSessao.Size = new System.Drawing.Size(100, 20);
            this.dtpHorarioSessao.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Horario";
            // 
            // dtpDataSessao
            // 
            this.dtpDataSessao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSessao.Location = new System.Drawing.Point(157, 37);
            this.dtpDataSessao.Name = "dtpDataSessao";
            this.dtpDataSessao.Size = new System.Drawing.Size(100, 20);
            this.dtpDataSessao.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(154, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Data";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Salas";
            // 
            // cbSalas
            // 
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.Location = new System.Drawing.Point(9, 80);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.Size = new System.Drawing.Size(121, 21);
            this.cbSalas.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(154, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Filmes";
            // 
            // cbFilmes
            // 
            this.cbFilmes.FormattingEnabled = true;
            this.cbFilmes.Location = new System.Drawing.Point(154, 80);
            this.cbFilmes.Name = "cbFilmes";
            this.cbFilmes.Size = new System.Drawing.Size(121, 21);
            this.cbFilmes.TabIndex = 33;
            // 
            // dgvSessoes
            // 
            this.dgvSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessoes.Location = new System.Drawing.Point(9, 148);
            this.dgvSessoes.Name = "dgvSessoes";
            this.dgvSessoes.Size = new System.Drawing.Size(301, 150);
            this.dgvSessoes.TabIndex = 35;
            this.dgvSessoes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSessoes_CellMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 369);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dtpLancamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpTempo;
        private System.Windows.Forms.Button btnSalvarSala;
        private System.Windows.Forms.TextBox txtDescricaoSala;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQtdSala;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataSessao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpHorarioSessao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAlterarSessao;
        private System.Windows.Forms.Button btnSalvarSessao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbFilmes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbSalas;
        private System.Windows.Forms.DataGridView dgvSessoes;
    }
}


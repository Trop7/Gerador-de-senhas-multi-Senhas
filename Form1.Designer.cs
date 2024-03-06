namespace teste03
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            BtnSair = new Button();
            panel01 = new Panel();
            CaractEspecial = new CheckBox();
            LetPequena = new CheckBox();
            LetGrande = new CheckBox();
            pictureBox1 = new PictureBox();
            checkBoxMulti = new CheckBox();
            checkBoxUnica = new CheckBox();
            BtnGera = new Button();
            pictureBox2 = new PictureBox();
            MostrarSenhas = new ListBox();
            lblQuant = new Label();
            txtQuant = new TextBox();
            lblQuantSenha = new Label();
            txtQuantSenhas = new TextBox();
            btnCopia = new Button();
            btnSalvar = new Button();
            SenhasLidas = new ListBox();
            button1 = new Button();
            lblTemp = new Label();
            lblbtest = new Label();
            btnAtualizar = new Button();
            progressBar1 = new ProgressBar();
            panel01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.LightSkyBlue;
            BtnSair.FlatAppearance.BorderColor = Color.RoyalBlue;
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.FlatAppearance.MouseDownBackColor = Color.Salmon;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Location = new Point(1284, 430);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(65, 29);
            BtnSair.TabIndex = 0;
            BtnSair.Text = "X";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // panel01
            // 
            panel01.BackColor = Color.LightSkyBlue;
            panel01.Controls.Add(CaractEspecial);
            panel01.Controls.Add(LetPequena);
            panel01.Controls.Add(LetGrande);
            panel01.Controls.Add(pictureBox1);
            panel01.Controls.Add(checkBoxMulti);
            panel01.Controls.Add(checkBoxUnica);
            panel01.Controls.Add(BtnGera);
            panel01.Location = new Point(2, 2);
            panel01.Name = "panel01";
            panel01.Size = new Size(370, 452);
            panel01.TabIndex = 1;
            // 
            // CaractEspecial
            // 
            CaractEspecial.AutoSize = true;
            CaractEspecial.BackColor = Color.DarkTurquoise;
            CaractEspecial.FlatAppearance.BorderSize = 0;
            CaractEspecial.FlatStyle = FlatStyle.Flat;
            CaractEspecial.Location = new Point(121, 354);
            CaractEspecial.Name = "CaractEspecial";
            CaractEspecial.Size = new Size(160, 24);
            CaractEspecial.TabIndex = 6;
            CaractEspecial.Text = "Caracteres especiais";
            CaractEspecial.UseVisualStyleBackColor = false;
            // 
            // LetPequena
            // 
            LetPequena.AutoSize = true;
            LetPequena.BackColor = Color.DarkTurquoise;
            LetPequena.FlatAppearance.BorderSize = 0;
            LetPequena.FlatStyle = FlatStyle.Flat;
            LetPequena.Location = new Point(121, 324);
            LetPequena.Name = "LetPequena";
            LetPequena.Size = new Size(132, 24);
            LetPequena.TabIndex = 5;
            LetPequena.Text = "Letras Pequenas";
            LetPequena.UseVisualStyleBackColor = false;
            // 
            // LetGrande
            // 
            LetGrande.AutoSize = true;
            LetGrande.BackColor = Color.DarkTurquoise;
            LetGrande.FlatAppearance.BorderSize = 0;
            LetGrande.FlatStyle = FlatStyle.Flat;
            LetGrande.Location = new Point(121, 294);
            LetGrande.Name = "LetGrande";
            LetGrande.Size = new Size(124, 24);
            LetGrande.TabIndex = 4;
            LetGrande.Text = "Letras Grandes";
            LetGrande.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // checkBoxMulti
            // 
            checkBoxMulti.BackColor = Color.DarkTurquoise;
            checkBoxMulti.FlatAppearance.BorderSize = 0;
            checkBoxMulti.FlatStyle = FlatStyle.Flat;
            checkBoxMulti.Font = new Font("Segoe UI", 12F);
            checkBoxMulti.Location = new Point(194, 244);
            checkBoxMulti.Name = "checkBoxMulti";
            checkBoxMulti.Size = new Size(161, 32);
            checkBoxMulti.TabIndex = 2;
            checkBoxMulti.Text = "Senha Multipla";
            checkBoxMulti.UseMnemonic = false;
            checkBoxMulti.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnica
            // 
            checkBoxUnica.AutoSize = true;
            checkBoxUnica.BackColor = Color.DarkTurquoise;
            checkBoxUnica.FlatAppearance.BorderSize = 0;
            checkBoxUnica.FlatStyle = FlatStyle.Flat;
            checkBoxUnica.Font = new Font("Segoe UI", 12F);
            checkBoxUnica.Location = new Point(21, 244);
            checkBoxUnica.Name = "checkBoxUnica";
            checkBoxUnica.Size = new Size(137, 32);
            checkBoxUnica.TabIndex = 1;
            checkBoxUnica.Text = "Senha Unica";
            checkBoxUnica.UseVisualStyleBackColor = false;
            // 
            // BtnGera
            // 
            BtnGera.FlatAppearance.BorderSize = 2;
            BtnGera.FlatStyle = FlatStyle.Flat;
            BtnGera.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGera.ForeColor = SystemColors.ActiveCaptionText;
            BtnGera.Location = new Point(8, 391);
            BtnGera.Name = "BtnGera";
            BtnGera.Size = new Size(356, 51);
            BtnGera.TabIndex = 0;
            BtnGera.Text = "Gerar";
            BtnGera.UseVisualStyleBackColor = true;
            BtnGera.Click += BtnGera_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(375, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(558, 389);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // MostrarSenhas
            // 
            MostrarSenhas.FormattingEnabled = true;
            MostrarSenhas.Location = new Point(935, 3);
            MostrarSenhas.Name = "MostrarSenhas";
            MostrarSenhas.Size = new Size(414, 164);
            MostrarSenhas.TabIndex = 4;
            MostrarSenhas.Tag = "MostrarSenhas";
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Font = new Font("Segoe UI", 10.2F);
            lblQuant.Location = new Point(432, 396);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(172, 23);
            lblQuant.TabIndex = 4;
            lblQuant.Text = "Quantidade de Vezes";
            lblQuant.Visible = false;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(448, 422);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(132, 27);
            txtQuant.TabIndex = 5;
            txtQuant.Visible = false;
            txtQuant.KeyPress += txtQuant_KeyPress;
            // 
            // lblQuantSenha
            // 
            lblQuantSenha.AutoSize = true;
            lblQuantSenha.Font = new Font("Segoe UI", 10.2F);
            lblQuantSenha.Location = new Point(651, 396);
            lblQuantSenha.Name = "lblQuantSenha";
            lblQuantSenha.Size = new Size(180, 23);
            lblQuantSenha.TabIndex = 6;
            lblQuantSenha.Text = "Quantidade de digitos";
            lblQuantSenha.Visible = false;
            // 
            // txtQuantSenhas
            // 
            txtQuantSenhas.Location = new Point(667, 422);
            txtQuantSenhas.Name = "txtQuantSenhas";
            txtQuantSenhas.Size = new Size(132, 27);
            txtQuantSenhas.TabIndex = 7;
            txtQuantSenhas.Visible = false;
            txtQuantSenhas.KeyPress += txtQuantSenhas_KeyPress;
            // 
            // btnCopia
            // 
            btnCopia.BackColor = Color.FromArgb(255, 255, 192);
            btnCopia.Location = new Point(935, 342);
            btnCopia.Name = "btnCopia";
            btnCopia.Size = new Size(62, 33);
            btnCopia.TabIndex = 8;
            btnCopia.Text = "Copiar";
            btnCopia.UseVisualStyleBackColor = false;
            btnCopia.Click += btnCopia_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.Location = new Point(1003, 343);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(62, 33);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // SenhasLidas
            // 
            SenhasLidas.FormattingEnabled = true;
            SenhasLidas.Location = new Point(935, 172);
            SenhasLidas.Name = "SenhasLidas";
            SenhasLidas.Size = new Size(414, 164);
            SenhasLidas.TabIndex = 10;
            SenhasLidas.Tag = "SenhasLidas";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(1272, 343);
            button1.Name = "button1";
            button1.Size = new Size(77, 33);
            button1.TabIndex = 11;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemp.Location = new Point(671, 56);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(115, 23);
            lblTemp.TabIndex = 12;
            lblTemp.Text = "00:00:00:000";
            // 
            // lblbtest
            // 
            lblbtest.AutoSize = true;
            lblbtest.Location = new Point(924, 434);
            lblbtest.Name = "lblbtest";
            lblbtest.Size = new Size(15, 20);
            lblbtest.TabIndex = 13;
            lblbtest.Text = "-";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(192, 255, 192);
            btnAtualizar.Location = new Point(1071, 343);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(81, 33);
            btnAtualizar.TabIndex = 15;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Black;
            progressBar1.Location = new Point(956, 434);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(309, 21);
            progressBar1.TabIndex = 16;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            ClientSize = new Size(1350, 460);
            Controls.Add(progressBar1);
            Controls.Add(btnAtualizar);
            Controls.Add(lblbtest);
            Controls.Add(lblTemp);
            Controls.Add(button1);
            Controls.Add(SenhasLidas);
            Controls.Add(btnSalvar);
            Controls.Add(btnCopia);
            Controls.Add(txtQuantSenhas);
            Controls.Add(lblQuantSenha);
            Controls.Add(txtQuant);
            Controls.Add(lblQuant);
            Controls.Add(MostrarSenhas);
            Controls.Add(panel01);
            Controls.Add(BtnSair);
            Controls.Add(pictureBox2);
            ForeColor = SystemColors.ControlDarkDark;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form";
            ShowIcon = false;
            StartPosition = FormStartPosition.WindowsDefaultLocation;
            Style = MetroFramework.MetroColorStyle.Default;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            TransparencyKey = Color.Empty;
            Load += Form_Load;
            panel01.ResumeLayout(false);
            panel01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSair;
        private Panel panel01;
        private Button BtnGera;
        private CheckBox checkBoxMulti;
        private CheckBox checkBoxUnica;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblQuant;
        private TextBox txtQuant;
        private Label lblQuantSenha;
        private TextBox txtQuantSenhas;
        private Button btnCopia;
        private ListBox MostrarSenhas;
        private Button btnSalvar;
        private ListBox SenhasLidas;
        private Button button1;
        private Label lblTemp;
        private Label lblbtest;
        private Button btnAtualizar;
        private ProgressBar progressBar1;
        private CheckBox CaractEspecial;
        private CheckBox LetPequena;
        private CheckBox LetGrande;
    }
}

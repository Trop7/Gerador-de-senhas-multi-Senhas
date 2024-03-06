using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Text;


namespace teste03
{
    
    public partial class Form : MetroFramework.Forms.MetroForm
    {
       
        public Form()
        {
            InitializeComponent();


        }
        //
             const string Uper = "ABCDEFGHIJLNMOKPQRSTUVXZ";
             const string Low = "abcdefghijlnmokpqrstuvxz";
             const string Caracter = "-!#$%&*,./?@_|~+<=>";
        //
        StringBuilder letra = new StringBuilder();

        List<string> letras = new List<string>();

        const string path = $"C:\\Users\\NOTEBOOK\\source\\repos\\teste03\\Senha.txt";
        List<string> ResultadoLinhas;
        List<string> ResultadoLinha;
        bool start = false;
        bool inicio = false;
        ///////////////////////////////////////////////////////////////////////////////
        
        private void BtnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void BtnGera_Click(object sender, EventArgs e)
        {
            MostrarSenhas.Items.Clear();

            Selecionado();

            if (checkBoxUnica.Checked)
            {
                try
                {
                    string ler = "";
                    
                    MostrarSenhas.BackColor = Color.Aquamarine;

                    int num = int.Parse(txtQuant.Text);

                    List<string> result = Gerador.GeradorN(num, letras);


                    ResultadoLinha = result;
                    start = true;


                    foreach (var item in result)
                    {
                        ler = item;
                    }
                    MostrarSenhas.Items.Add(ler);

                }
                catch (Exception ze)
                {
                    MessageBox.Show(ze.Message + "Não cometa erro desta vez...", caption: "Escolha uma opção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (checkBoxMulti.Checked)
            {
                try
                {
                    MostrarSenhas.BackColor = Color.Bisque;

                    MostrarSenhas.Items.Clear();

                    Selecionado();

                    int Digito = int.Parse(txtQuant.Text);
                    int Quantvez = int.Parse(txtQuantSenhas.Text);

                    List<string> result = Gerador.GeradorN(Digito, Quantvez, letras);

                    ResultadoLinhas = result;
                    inicio = true;

                    foreach (var item in result)
                    {
                        MostrarSenhas.Items.Add($" " + item);
                    }
                }
                catch (Exception je)
                {
                    MessageBox.Show(je.Message + "Não cometa erro desta vez...", caption: "Escolha uma opção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string Selecionado()
        {
            letra.Clear();
            letras.Clear();

            if (LetGrande.Checked)
            {
                 letra.Append(Uper);
            }
            if(LetPequena.Checked) 
            {
                 letra.Append(Low);
            }
            if(CaractEspecial.Checked)
            {
                letra.Append(Caracter);
            }
            if(!LetGrande.Checked && !LetPequena.Checked && !CaractEspecial.Checked)
            {
                letra.Append(Uper + Low + Caracter);
            }

            letras.Add(letra.ToString());

            return letras.ToString();
        }
        private void btnCopia_Click(object sender, EventArgs e)
        {
            string copia = MostrarSenhas.SelectedItem.ToString();

            Clipboard.SetText(copia);
            Button cor = new Button();
            cor.BackColor = Color.BlueViolet;

        }


        private void Form_Load(object sender, EventArgs e)
        {

            
            Thread progresso = new Thread(ProcessamentoDemorado);
            progresso.Start();

            //////////////////////////////////////////////////////////
            //Relogio
            Thread tempoRelogio = new Thread(InicioRelogio);
            tempoRelogio.IsBackground = true;
            tempoRelogio.Start();
            //////////////////////////////////////////////////////////
            ///
           

            Thread.Sleep(500);
            List<string> Lido = Gerador.Ler(path);

            foreach (string item in Lido)
            {
                SenhasLidas.Items.Add(item);
            }

            checkBoxUnica.Checked = true;
            lblQuant.Visible = true;
            txtQuant.Visible = true;
            txtQuant.Focus();

            checkBoxMulti.CheckedChanged += (sender, e) =>
            {

                if (checkBoxMulti.Checked)
                {
                    checkBoxUnica.Checked = false;
                    checkBoxMulti.Checked = true;

                    lblQuant.Visible = true;
                    txtQuant.Visible = true;
                    lblQuantSenha.Visible = true;
                    txtQuantSenhas.Visible = true;
                }
                else
                {
                    return;// MessageBox.Show("Escolha uma opcao", " Senha Multiplas.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
            };
            checkBoxUnica.CheckedChanged += (sender, e) =>
            {
                if (checkBoxUnica.Checked)
                {
                    checkBoxMulti.Checked = false;
                    checkBoxUnica.Checked = true;

                    lblQuant.Visible = true;
                    txtQuant.Visible = true;

                    lblQuantSenha.Visible = false;
                    txtQuantSenhas.Visible = false;
                }
                else
                {
                    return;// MessageBox.Show("Escolha uma opcao", " Senha Unica.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
            };
        }
        private void txtQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantSenhas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (start)
            {
                Thread.Sleep(300);
                Gerador.Salvar(ResultadoLinha, path);
                start = false;
            }
            else if (inicio)
            {
                Thread.Sleep(300);
                Gerador.Salvar(ResultadoLinhas, path);
                inicio = false;
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            List<string> linhas = new List<string>();

            string[] leitura;

            SenhasLidas.Items.Clear();

            if (!File.Exists(path))
            {
                MessageBox.Show("Arquivo nao existe.");
            }else
            {
                leitura = File.ReadAllLines(path);

                linhas.AddRange(leitura);

                foreach (var item in linhas)
                {
                    SenhasLidas.Items.Add(item);
                }
                SenhasLidas.Update();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MostrarSenhas.SelectedIndex >= 0)
            {
                MostrarSenhas.Items.RemoveAt(MostrarSenhas.SelectedIndex);
                MostrarSenhas.Update();
            }
            else if (SenhasLidas.SelectedIndex >= 0)
            {
                SenhasLidas.Items.RemoveAt(SenhasLidas.SelectedIndex);
                SenhasLidas.Update();
            }
            else
            {
                MessageBox.Show("Item nao existe");
            }

        }
        public void InicioRelogio()
        {
            while (true)
            {
                Invoke(new Action(() => lblTemp.Text = DateTime.Now.ToString("HH:mm:ss:fff")));
                Thread.Sleep(100);
            }

        }
        ////////////////////////////////////////////////////////////////////////////
        private void ProcessamentoDemorado()
        {
            int i = 0;

            for (; i <= 99; i++)
            {
                AtualizarProgresso(i + 1);
                Thread.Sleep(100);
            }
            Thread.Sleep(500);

            if (progressBar1.Value == 100)
            {
                for (i = 100; i > 0; i--)
                {
                    AtualizarProgresso(i - 1);
                    Thread.Sleep(100);
                }
            }
            Thread.Sleep(500);
            ProcessamentoDemorado();
        }
        private void AtualizarProgresso(int valor)
        {
            this.Invoke((MethodInvoker)delegate
            {
                    progressBar1.Value = valor;
                    lblbtest.Text = $"{valor}%";
            });
        }
    }
}

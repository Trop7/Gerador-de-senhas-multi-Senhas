using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste03
{

    class Gerador
    {
       // const string Caracteres = "ABCDEFGHIJLNMOKPQRSTUVXZabcdefghijlnmokpqrstuvxzç0123456789-!#$%&*,./?@_|~+<=>";


       // const string Uper = "ABCDEFGHIJLNMOKPQRSTUVXZ";
       // const string Low = "abcdefghijlnmokpqrstuvxz";
       // const string Caracter = "-!#$%&*,./?@_|~+<=>";

        private int quantDigito;
        private int quantVezes;

        public int Quantidade { get => quantDigito; set => quantDigito = value; }
        public int QuantVezes { get => quantVezes; set => quantVezes = value; }

        public static List<string> GeradorN(int quantDigito, List<string> Letra)
        {
            string let = "";
            Random Sorteio = new Random();

            foreach (var item in Letra)
            {
                 let = item;
            }

            List<string> retorno = new List<string>();

            StringBuilder pass = new StringBuilder();

            for (int i = 0; i < quantDigito; i++)
            {
                int sorteado = Sorteio.Next(let.Length);
                pass.Append(let[sorteado]);
            }
            retorno.Add(pass.ToString());

            return retorno;
        }
        public static List<string> GeradorN(int quantDigito, int quantVezes, List<string> Letra)

        {
            Random Sorteio = new Random();

            string lett = "";

            foreach (var item in Letra)
            {
                lett = item;
            }

            List<string> retorno = new List<string>();

            for (int X = 0; X < quantDigito; X++)
            {
                StringBuilder pass = new StringBuilder();
                for (int j = 0; j < quantVezes; j++)
                {
                    int sorteado = Sorteio.Next(lett.Length);
                    pass.Append(lett[sorteado]);
                }
                retorno.Add(pass.ToString());
            }
            return retorno;
        }

        public static void Salvar(List<string> linhas, string caminhoArquivo)
         {
            try {

                if(!File.Exists(caminhoArquivo))
                {
                    using(StreamWriter ss = File.CreateText(caminhoArquivo)) 
                    {
                        foreach (var item in linhas)
                        {
                            ss.WriteLine(item);
                        }
                        ss.WriteLine("-------------------------------- " + DateTime.Now.ToString("HH:mm:ss:fff"));
                        Thread.Sleep(300);
                    }
                }
                using(StreamWriter ss = File.AppendText(caminhoArquivo))
                {
                    foreach (var item in linhas)
                    {
                        ss.WriteLine(item);
                    }
                   ss.WriteLine("-------------------------------- " + DateTime.Now.ToString("HH:mm:ss:fff"));
                    Thread.Sleep(300);
                }

                //File.WriteAllLines(caminhoArquivo, linhas);
                MessageBox.Show("Salvo com Sucesso. ");
            }
            catch(Exception ex)
            {
               MessageBox.Show($"Ocorreu um erro ao salvar o arquivo: {ex.Message}");
            }
         }
        public static List<string> Ler(string caminhoArquivo)
        {
            List<string> linhas = new List<string>();

            try
            { 

                string[] listas =File.ReadAllLines(caminhoArquivo);

                linhas.AddRange(listas);
            }
            
            catch (Exception xx)
            {

                MessageBox.Show(xx.Message);
            }
            MessageBox.Show("Lido com sucesso. ");
            return linhas;
        }
    }
}

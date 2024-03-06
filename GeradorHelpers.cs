using System.Text;

internal static class GeradorHelpers
{

    const string Caracteres = "ABCDEFGHIJLNMOKPQRSTUVXZÇabcdefghijlnmokpqrstuvxzç0123456789-!#$%&*,./?@_|~+<=>";

    public static string GeradorX(int quantidade, int quantVezes)
    {
        Random Sorteio = new Random();
        StringBuilder pass = new StringBuilder();

        for (int i = 0; i < quantidade; i++)
        {
            

            for (int j = 0; j < quantVezes; j++)
            {
                int sorteado = Sorteio.Next(Caracteres.Length);
                pass.Append(Caracteres[sorteado]);
            }
           pass.Clear();
        }
        return pass.ToString();
    }
}
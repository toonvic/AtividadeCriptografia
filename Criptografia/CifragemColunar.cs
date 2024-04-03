//Alunos: Rossana Rocha da Silva e Victor do Amaral

namespace Criptografia;

public class CifragemColunar
{
    public static string Cifrar(string texto, int colunas)
    {
        texto = texto.Replace(" ", "");

        int linhas = (int)Math.Ceiling((double)texto.Length / colunas);

        char[,] matriz = new char[linhas, colunas];

        int index = 0;

        for (int linha = 0; linha < linhas; linha++)
        {
            for (int coluna = 0; coluna < colunas; coluna++)
            {
                if (index < texto.Length)
                {
                    matriz[linha, coluna] = texto[index];
                    index++;
                }
                else
                {
                    matriz[linha, coluna] = 'X';
                }
            }
        }

        var textoCifrado = "";

        for (int coluna = 0; coluna < colunas; coluna++)
        {
            for (int linha = 0; linha < linhas; linha++)
            {
                textoCifrado += matriz[linha, coluna];
            }
        }

        return textoCifrado;
    }

    public static string Decifrar(string texto, int colunas)
    {
        var textoDecifrado = "";

        int linhas = (int)Math.Ceiling((double)texto.Length / colunas);

        char[,] matriz = new char[linhas, colunas];

        var indice = 0;

        for (int coluna = 0; coluna < colunas; coluna++)
        {
            for (int linha = 0; linha < linhas; linha++)
            {
                matriz[linha, coluna] = texto[indice];
                indice++;
            }
        }

        foreach (var caracter in matriz)
        {
            textoDecifrado += caracter;
        }

        return textoDecifrado;
    }
}

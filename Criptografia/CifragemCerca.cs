//Alunos: Rossana Rocha da Silva e Victor do Amaral

namespace Criptografia;

public class CifragemCerca
{
    public static string Cifrar(string texto, int trilhos)
    {
        texto = texto.Replace(" ", "");

        string[] trilhas = new string[trilhos];
        for (int i = 0; i < trilhos; i++)
        {
            trilhas[i] = "";
        }

        int direcao = 1;
        int trilhoAtual = 0;
        for (int i = 0; i < texto.Length; i++)
        {
            trilhas[trilhoAtual] += texto[i];

            if (trilhoAtual == 0)
                direcao = 1;
            else if (trilhoAtual == trilhos - 1)
                direcao = -1;

            trilhoAtual += direcao;
        }

        string textoCifrado = "";
        foreach (string trilho in trilhas)
        {
            textoCifrado += trilho;
        }

        return textoCifrado;
    }

    public static string Decifrar(string texto, int trilhos)
    {
        string[] trilhas = new string[trilhos];
        for (int i = 0; i < trilhos; i++)
        {
            trilhas[i] = "";
        }

        int direcao = 1;
        int trilhoAtual = 0;
        for (int i = 0; i < texto.Length; i++)
        {
            trilhas[trilhoAtual] += "@";

            if (trilhoAtual == 0)
                direcao = 1;
            else if (trilhoAtual == trilhos - 1)
                direcao = -1;

            trilhoAtual += direcao;
        }

        var ultimoIndiceFrase = 0;

        for (int i = 0; i < trilhas.Length; i++)
        {
            var novoIndice = trilhas[i].Length;

            trilhas[i] = texto.Substring(ultimoIndiceFrase, novoIndice);

            ultimoIndiceFrase += novoIndice;
        }

        var textoDecifrado = "";

        direcao = 1;
        trilhoAtual = 0;
        for (int i = 0; i < texto.Length; i++)
        {
            textoDecifrado += trilhas[trilhoAtual].Substring(0, 1);
            trilhas[trilhoAtual] = trilhas[trilhoAtual].Remove(0, 1);

            if (trilhoAtual == 0)
                direcao = 1;
            else if (trilhoAtual == trilhos - 1)
                direcao = -1;

            trilhoAtual += direcao;
        }

        return textoDecifrado;
    }
}

//Alunos: Rossana Rocha da Silva e Victor do Amaral

namespace Criptografia;

public class CifragemVegenere
{
    public static string Cifrar(string texto, string chave)
    {
        texto = texto.ToUpper();
        chave = chave.ToUpper();

        string textoCriptografado = "";

        var index = 0;
        for (int i = 0; i < texto.Length; i++)
        {
            char caractere = texto[i];
            if (char.IsLetter(caractere))
            {
                int deslocamentoChave = chave[index % chave.Length] - 'A';

                char caractereCriptografado = (char)(((caractere - 'A' + deslocamentoChave) % 26) + 'A');
                textoCriptografado += caractereCriptografado;
                index++;

                continue;
            }
            
            textoCriptografado += caractere;
        }

        return textoCriptografado;
    }

    public static string Decifrar(string textoCriptografado, string chave)
    {
        textoCriptografado = textoCriptografado.ToUpper();
        chave = chave.ToUpper();

        string textoDescriptografado = "";

        var index = 0;
        for (int i = 0; i < textoCriptografado.Length; i++)
        {
            char caractere = textoCriptografado[i];
            if (char.IsLetter(caractere))
            {
                int deslocamentoChave = chave[index % chave.Length] - 'A';

                char caractereDescriptografado = (char)(((caractere - 'A' - deslocamentoChave + 26) % 26) + 'A');
                textoDescriptografado += caractereDescriptografado;
                index++;

                continue;
            }

            textoDescriptografado += caractere;
        }

        return textoDescriptografado;
    }
}

//Alunos: Rossana Rocha da Silva e Victor do Amaral

using Criptografia;

while (true)
{
    Console.WriteLine("Selecione o tipo de criptografia:");
    Console.WriteLine("1 - Cifragem Colunar");
    Console.WriteLine("2 - Cifragem Cerca Ferroviária");
    Console.WriteLine("3 - Cifragem Vegenere");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("");
    Console.Write("Escolha: ");
    string escolha = Console.ReadLine();

    if (escolha == "1")
    {
        Console.WriteLine("Digite o texto para cifrar:");
        string texto = Console.ReadLine();

        Console.WriteLine("Digite o número de colunas:");
        int colunas = int.Parse(Console.ReadLine());

        string textoCifrado = CifragemColunar.Cifrar(texto, colunas);
        Console.WriteLine("Texto cifrado: " + textoCifrado);

        string textoDecifrado = CifragemColunar.Decifrar(textoCifrado, colunas);
        Console.WriteLine("Texto decifrado: " + textoDecifrado);

        Console.WriteLine("");
        Console.WriteLine("-----");
        Console.WriteLine("");

        continue;
    }

    if (escolha == "2")
    {
        Console.WriteLine("Digite o texto para cifrar:");
        string texto = Console.ReadLine();

        Console.WriteLine("Digite a quantidade de trilhos:");
        int trilhos = int.Parse(Console.ReadLine());

        string textoCifrado = CifragemCerca.Cifrar(texto, trilhos);
        Console.WriteLine("Texto cifrado: " + textoCifrado);

        string textoDecifrado = CifragemCerca.Decifrar(textoCifrado, trilhos);
        Console.WriteLine("Texto decifrado: " + textoDecifrado);

        Console.WriteLine("");
        Console.WriteLine("-----");
        Console.WriteLine("");

        continue;
    }

    if (escolha == "3")
    {
        Console.WriteLine("Digite o texto para cifrar:");
        string texto = Console.ReadLine();

        Console.WriteLine("Digite a chave:");
        string chave = Console.ReadLine();

        string textoCriptografado = CifragemVegenere.Cifrar(texto, chave);
        Console.WriteLine("Texto cifrado: " + textoCriptografado);

        string textoDescriptografado = CifragemVegenere.Decifrar(textoCriptografado, chave);
        Console.WriteLine("Texto decifrado: " + textoDescriptografado);

        Console.WriteLine("");
        Console.WriteLine("-----");
        Console.WriteLine("");
    }

    if (escolha == "4")
    {
        break;
    }
}
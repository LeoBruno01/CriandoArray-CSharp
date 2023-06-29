Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestaArrays()
{
    int[] idades = new int[5];
    idades[0] = 15;
    idades[1] = 25;
    idades[2] = 22;
    idades[3] = 20;
    idades[4] = 30;

    Console.WriteLine($"A quantidade de idades que possui são {idades.Length} idades.");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Idade: [{i}] = {idade}");
        acumulador += idade;
    }

    double media = acumulador / idades.Length;
    Console.WriteLine($"A média de idades é {media}");
}

TestaArrays();  
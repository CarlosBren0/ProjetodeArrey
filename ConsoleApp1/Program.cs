





TestarArreyInt();
void TestarArreyInt()
{
    int[] idades = new int[5];

    idades[0] = 30;
    idades[1] = 24;
    idades[2] = 17;
    idades[3] = 29;
    idades[4] = 40;

    Console.WriteLine($"Tamanho do arrey {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Indice [{i}] = [{idade}]");
        acumulador += idade;
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"A media de idades é {media}");    
    }








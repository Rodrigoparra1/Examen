
Console.WriteLine("Ingrese un número N seguido de espacio y de un dígito K:");

string valor = Console.ReadLine();

string[] valores = valor.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

if (!int.TryParse(valores[0], out int n) || !int.TryParse(valores[1], out int k))
{
    Console.WriteLine("Entrada inválida para n o k. Deben ser números enteros.");
    return;
}


int contadorK = 0;

Console.WriteLine($"Ingrese {n} líneas de números:");

for (int i = 0; i < n; i++)
{
    string valorN = Console.ReadLine();

    foreach (char digito in valorN)
    {
        if (digito == (char)(k + '0'))
        {
            contadorK++;
        }
    }
}

Console.WriteLine($"El dígito {k} aparece {contadorK} veces en las líneas ingresadas.");
    
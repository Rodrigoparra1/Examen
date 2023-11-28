int indice = 0;

Console.WriteLine("Numero de filas y columas");

int filasYcolumnas = int.Parse(Console.ReadLine());
int[,] matriz = new int[filasYcolumnas, filasYcolumnas];


Console.WriteLine($"Ingrese numeros en la matriz separados por espacions");
string numeros = Console.ReadLine();

string[] valores = numeros.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

int tamano = (int)Math.Sqrt(valores.Length);

if (tamano * tamano != valores.Length)
{
    Console.WriteLine("La entrada no representa una matriz cuadrada.");
    return;
}


for (int f = 0; f < matriz.GetLength(0); f++)
{
    for (int c = 0; c < matriz.GetLength(1); c++)
    {
        matriz[f, c] = int.Parse(valores[indice]);
        indice++; ;

    }

}

int primerNumero = matriz[0, 0];
bool verificar = false;

Console.WriteLine("La matriz es");

for (int f = 0; f < matriz.GetLength(0); f++)
{
    for (int c = 0; c < matriz.GetLength(1); c++)
    {
        Console.Write($"{matriz[f, c]} ");

    }
    Console.WriteLine("");

}

for (int i = 1; i < tamano; i++)
{
    if (matriz[i, i] != primerNumero)
    {
        verificar = false;
    }
    else
    {
        verificar = true;
    }
}

if (verificar == true)
{
    Console.WriteLine("Si");
}
else
{
    Console.WriteLine("No");
}










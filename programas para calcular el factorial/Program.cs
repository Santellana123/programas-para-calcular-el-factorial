Console.Write("Ingresa un número: ");
int num = int.Parse(Console.ReadLine());

int factorial = CalcularFactorialIterativo(num);
Console.WriteLine($"El factorial de {num} es {factorial}");
        

static int CalcularFactorialIterativo(int n)
{
    int resultado = 1;
    for (int i = 1; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;
}

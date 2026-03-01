// Calcular el factorial de un número ingresado.

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());

int factorial = 1;

while (num > 0)
{
    factorial *= num;
    num--;
}

Console.WriteLine("El factorial es: "+ factorial);

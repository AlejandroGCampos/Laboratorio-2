using System;

decimal num1, num2;
decimal suma, resta, multiplicacion;
decimal division;

try
{
    Console.WriteLine("Ingresa el primer valor: ");
    num1 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Ingresa el segundo valor: ");
    num2 = Convert.ToDecimal(Console.ReadLine());

    suma = num1 + num2;
    Console.WriteLine("La suma de los dos valores es: " + suma);
    resta = num1 - num2;
    Console.WriteLine("La resta de los dos valores es: " + resta);
    multiplicacion = num1 * num2;
    Console.WriteLine("La multiplicación de los dos valores es: " + multiplicacion);

    if (num2 != 0)
    {
        division = num1 / num2;
        Console.WriteLine("La división de los dos valores es: " + division);
    }
    else
    {
        Console.WriteLine("No se puede dividir por cero.");
    }
}

catch (FormatException)
{
    Console.WriteLine("Por favor, ingresa un número válido.");
}

catch (Exception ex)
{
    Console.WriteLine("Ocurrió un error: " + ex.Message);
}
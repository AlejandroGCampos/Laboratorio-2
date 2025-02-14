using System;

byte num1, num2, suma, resta, multiplicacion;
float division;

try
{
    Console.WriteLine("Ingresa el primer valor: ");
    num1 = Convert.ToByte(Console.ReadLine());

    Console.WriteLine("Ingresa el segundo valor: ");
    num2 = Convert.ToByte(Console.ReadLine());

    suma = (byte)(num1 + num2);
    Console.WriteLine("La suma de los dos valores es: " + suma);
    resta = (byte)(num1 - num2);
    Console.WriteLine("La resta de los dos valores es: " + resta);
    multiplicacion = (byte)(num1 * num2);
    Console.WriteLine("La multiplicación de los dos valores es: " + multiplicacion);

    if (num2 != 0)
    {
        division = (float)num1 / num2;
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
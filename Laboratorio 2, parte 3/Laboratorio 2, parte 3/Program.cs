using System;

double valor1, valor2;

Console.WriteLine("Introduce el primer valor numérico:");
valor1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduce el segundo valor numérico:");
valor2 = Convert.ToDouble(Console.ReadLine());

if (valor1 > valor2)
{
    Console.WriteLine($"{valor1} es mayor que {valor2}");
}
else if (valor1 < valor2)
{
    Console.WriteLine($"{valor1} es menor que {valor2}");
}
else
{
    Console.WriteLine($"{valor1} es igual a {valor2}");
}

// Acá hacemos las comparaciones
Console.WriteLine($"¿{valor1} es mayor que {valor2}? {valor1 > valor2}");
Console.WriteLine($"¿{valor1} es menor que {valor2}? {valor1 < valor2}");
Console.WriteLine($"¿{valor1} es igual a {valor2}? {valor1 == valor2}");

bool andResult = (valor1 > 0) && (valor2 > 0);
bool orResult = (valor1 > 0) || (valor2 > 0);

Console.WriteLine($"¿Ambos valores son mayores que 0? {andResult}");
Console.WriteLine($"¿Alguno de los valores es mayor que 0? {orResult}");
using System;

            // Declaración de variables dadas
            int numEntero;
            double numDecimal;
            string texto;
            bool valorBooleano;

            // Solicitud de valores por teclado
            Console.WriteLine("Ingresa un número entero:");
            numEntero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa un número decimal:");
            numDecimal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa un texto:");
            texto = Console.ReadLine();

            Console.WriteLine("Ingresa un valor verdadero o falso (true/false):");
            valorBooleano = Convert.ToBoolean(Console.ReadLine());

            // Mostrar los valores dados en la consola
            Console.WriteLine("\nValores ingresados:");
            Console.WriteLine("Número entero: " + numEntero);
            Console.WriteLine("Número decimal: " + numDecimal);
            Console.WriteLine("Texto: " + texto);
            Console.WriteLine("Valor booleano: " + valorBooleano);

            Console.ReadKey(); // Mantiene la consola abierta
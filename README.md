# Laboratorio-2
Trabajo de laboratorio 2 para la clase de Programación 1
¿Para qué crees que se usan los operadores lógicos en programación?
R// nos permiten crear condiciones complejas y tomar decisiones en nuestros programas.
¿Por qué es importante declarar correctamente el tipo de dato de una variable?
R// Declarar nos sirve a definir por la seguridad y evitar errores, da eficiencia y legibilidad.

# Enunciados
Enunciado 1:

```csharp
int edad;
string resultado;

Console.WriteLine("Ingrese la edad de la persona:");
edad = Convert.ToInt32(Console.ReadLine());

if (edad < 12)
{
    resultado = "Niño";
}
else if (edad >= 12 && edad <= 17)
{
    resultado = "Adolescente";
}
else if (edad >= 18 && edad <= 59)
{
    resultado = "Adulto";
}
else
{
    resultado = "Adulto Mayor";
}

Console.WriteLine(resultado);
```
R// Use "if-else" para determinar el grupo de edad de una persona por la versatilidad de esta.

Enunciado 2:

```csharp
int num;
string dia;

Console.WriteLine("Digite un número de 1 a 7 y este le devolvera el dia correspondiente");
num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        dia = "Domingo";
        break;
    case 2:
        dia = "Lunes";
        break;
    case 3:
        dia = "Martes";
        break;
    case 4:
        dia = "Miercoles";
        break;
    case 5:
        dia = "Jueves";
        break;
    case 6:
        dia = "Viernes";
        break;
    case 7:
        dia = "Sabado";
        break;
    default:
        dia = "Numero no valido";
        break;
}

Console.WriteLine("El día correspondiente es: " + dia);
```
R// Use switch en este caso, para que al momento de introducir un numero me haga una función exacta para el caso.

Enunciado 3:

```csharp
string user = "Alejandro";
string contraseña = "123567";

Console.Write("Ingrese su nombre de usuario: ");
string? userIngresado = Console.ReadLine();

Console.Write("Ingrese su contraseña: ");
string? contraseñaIngresada = Console.ReadLine();

if (userIngresado == user && contraseñaIngresada == contraseña){
    Console.WriteLine("Acceso concedido");
}
else if (userIngresado == user && contraseñaIngresada != contraseña){
    Console.WriteLine("Contraseña incorrecta");
}
else{
    Console.WriteLine("Usuario no registrado");
}
```
R// Acá use "if-else" para poder evaluar las condiciones de acceso al sistema.

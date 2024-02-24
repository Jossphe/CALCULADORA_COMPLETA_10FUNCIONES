using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("|-----------WELCOME TO MY CALCULATOR----------|");
            Console.WriteLine("|-------UNIVERSIDAD DOCTOR ANDRES BELLO-------|");
            Console.WriteLine("|-----FACULTAD DE TECNOLOGIA E IMNOVACION-----|");
            Console.WriteLine("|----------PROGRAMACION lll, LAB 1------------|");
            Console.WriteLine("|---------JOSE RIGOBERTO MENDOZA RIVAS--------|");
            Console.WriteLine(" ");
            Console.WriteLine("Por favor, ingrese el número de opción, según el cálculo que desea realizar");
            Console.WriteLine(" ");
            Console.WriteLine("1. Calcular el Área de un rectángulo");
            Console.WriteLine("2. Calcular el Área de un triángulo");
            Console.WriteLine("3. Calcular el Área de un círculo");
            Console.WriteLine("4. Calcular el Volumen de un cilindro");
            Console.WriteLine("5. Calcular el Volumen de una esfera");
            Console.WriteLine("6. Suma");
            Console.WriteLine("7. Resta");
            Console.WriteLine("8. Multiplicación");
            Console.WriteLine("9. División");
            Console.WriteLine("10. Potenciación");
            Console.WriteLine("11. SALIR");
            Console.WriteLine(" ");
            Console.Write("Opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                continue;
            }

            switch (opcion)
            {
                case 1:
                    CalcularAreaRectangulo();
                    break;
                case 2:
                    CalcularAreaTriangulo();
                    break;
                case 3:
                    CalcularAreaCirculo();
                    break;
                case 4:
                    CalcularVolumenCilindro();
                    break;
                case 5:
                    CalcularVolumenEsfera();
                    break;
                case 6:
                    CalcularSuma();
                    break;
                case 7:
                    CalcularResta();
                    break;
                case 8:
                    CalcularMultiplicacion();
                    break;
                case 9:
                    CalcularDivision();
                    break;
                case 10:
                    Console.Write("Ingrese la base: ");
                    double baseNum = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el exponente: ");
                    double exponente = double.Parse(Console.ReadLine());
                    CalcularPotencia(baseNum, exponente);
                    break;
                case 11:
                    Console.WriteLine("CERRANDO :(");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            Console.WriteLine(" ");
            Console.WriteLine("presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();

        } while (opcion != 11);
    }

    static void CalcularAreaRectangulo()
    {
        Console.Write("Ingrese la base del rectángulo: ");
        if (!double.TryParse(Console.ReadLine(), out double baseRectangulo))
        {
            Console.WriteLine("Por favor, ingrese un valor numérico.");
            return;
        }

        Console.Write("Ingrese la altura del rectángulo: ");
        if (!double.TryParse(Console.ReadLine(), out double alturaRectangulo))
        {
            Console.WriteLine("Por favor, ingrese un valor numérico.");
            return;
        }

        double area = baseRectangulo * alturaRectangulo;
        Console.WriteLine($"El área del rectángulo es: {area:#.##}");
    }

    static void CalcularAreaTriangulo()
    {
        Console.Write("Ingrese la base del triángulo: ");
        if (!double.TryParse(Console.ReadLine(), out double baseTriangulo))
        {
            Console.WriteLine("Por favor, ingrese un valor numérico.");
            return;
        }

        Console.Write("Ingrese la altura del triángulo: ");
        if (!double.TryParse(Console.ReadLine(), out double alturaTriangulo))
        {
            Console.WriteLine("Por favor, ingrese un valor numérico.");
            return;
        }

        double area = (baseTriangulo * alturaTriangulo) / 2;
        Console.WriteLine($"El área del triángulo es: {area:#.##}");
    }

    static void CalcularAreaCirculo()
    {
        Console.Write("Ingrese el radio del círculo: ");
        if (!double.TryParse(Console.ReadLine(), out double radioCirculo))
        {
            Console.WriteLine("Por favor, ingrese un valor numérico.");
            return;
        }

        double area = Math.PI * Math.Pow(radioCirculo, 2);
        Console.WriteLine($"El área del círculo es: {area:#.##}");
    }

    static void CalcularVolumenCilindro()
    {
        Console.Write("Ingrese el radio del cilindro: ");
        if (!double.TryParse(Console.ReadLine(), out double radioCilindro))
        {
            Console.WriteLine("Por favor, ingrese un valor numérico.");
            return;
        }

        Console.Write("Ingrese la altura del cilindro: ");
        if (!double.TryParse(Console.ReadLine(), out double alturaCilindro))
        {
            Console.WriteLine("Por favor, ingrese un valor numérico.");
            return;
        }

        double volumen = Math.PI * Math.Pow(radioCilindro, 2) * alturaCilindro;
        Console.WriteLine($"El volumen del cilindro es: {volumen:#.##}");
    }

    static void CalcularVolumenEsfera()
    {
        Console.Write("Ingrese el radio de la esfera: ");
        if (!double.TryParse(Console.ReadLine(), out double radioEsfera))
        {
            Console.WriteLine("Por favor, ingrese un valor numérico.");
            return;
        }

        double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
        Console.WriteLine($"El volumen de la esfera es: {volumen:#.##}");
    }

    static void CalcularSuma()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
    }

    static void CalcularResta()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
    }

    static void CalcularMultiplicacion()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"El resultado de la multiplicación es: {num1 * num2}");
    }

    static void CalcularDivision()
    {
        Console.Write("Ingrese el dividendo: ");
        double dividendo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el divisor: ");
        double divisor = double.Parse(Console.ReadLine());
    }
    static void CalcularPotencia(double baseNum, double exponente)
    {
            double resultado = Math.Pow(baseNum, exponente);
            Console.WriteLine($"El resultado de la potencia es: {resultado.ToString("#.##")}");   
    }
}




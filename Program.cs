using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" MENÚ DE OPCIONES:");
            Console.WriteLine("1. Invertir una palabra");
            Console.WriteLine("2. Verificar si una palabra es palíndroma");
            Console.WriteLine("3. Convertir a mayúsculas las letras en posición par");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        InvertirPalabra();
                        break;
                    case 2:
                        VerificarPalindromo();
                        break;
                    case 3:
                        ConvertirMayusculasPosicionPar();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine(" Opción inválida. Intenta de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine(" Entrada inválida. Por favor, ingresa un número.");
                opcion = 0;
            }

        } while (opcion != 4);
    }

    static void InvertirPalabra()
    {
        Console.WriteLine("-------------------------------------------------------");
        Console.Write("Ingresa una palabra o frase: ");
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string resultado = new string(arr);
        Console.WriteLine($"Palabra invertida: {resultado}");
    }

    static void VerificarPalindromo()
    {
        Console.WriteLine("-------------------------------------------------------");
        Console.Write("Ingresa una palabra: ");
        string input = Console.ReadLine().ToLower().Replace(" ", ""); 
        string inversa = new string(input.Reverse().ToArray());

        if (input == inversa)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"La palabra '{input}' es palíndroma.");
            Console.WriteLine("-------------------------------------------------------");
        }
        else
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"La palabra '{input}' NO es palíndroma.");
            Console.WriteLine("-------------------------------------------------------");
        }
    }

    static void ConvertirMayusculasPosicionPar()
    {
        Console.WriteLine("-------------------------------------------------------");
        Console.Write("Ingresa un texto: ");
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 1 && char.IsLetter(arr[i]))
            {
                arr[i] = char.ToUpper(arr[i]);
            }
        }

        string resultado = new string(arr);
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($"Texto transformado: {resultado}");

    }
}

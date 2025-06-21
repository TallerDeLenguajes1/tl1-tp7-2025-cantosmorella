using EspacioCalculadora;
Console.WriteLine("""Hello, World!""");
int operacion,num = 0;
string? s1,s2;
Calculadora calcu = new Calculadora();
do
{
    Console.WriteLine($"Ingrese la operacion:\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division\n5.Limpiar\nResultado {calcu.Resultado}");
    s1 = Console.ReadLine();
    bool resultado = int.TryParse(s1, out operacion);

    switch (operacion)
    {
        case 1:
            Console.WriteLine("Ingrese el numero a sumar");
            s2 = Console.ReadLine();
            resultado = int.TryParse(s2, out num);
            calcu.Sumar(num);
            break;
    }

} while (operacion < 5);
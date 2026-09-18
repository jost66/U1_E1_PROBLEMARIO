using System;

Console.WriteLine("EJERCICIO 1");
Console.WriteLine("CÁLCULO Y CLASIFICACIÓN DE POTENCIA DE UN MOTOR CD");
Console.WriteLine();

Console.Write("Ingrese el voltaje del motor (V): ");
double voltaje = Convert.ToDouble(Console.ReadLine()); // Voltaje ingresado por el usuario

Console.Write("Ingrese la corriente consumida (I): ");
double corriente = Convert.ToDouble(Console.ReadLine()); // Corriente ingresada por el usuario

double potencia = voltaje * corriente; // P = V * I

Console.WriteLine();
Console.WriteLine($"La potencia calculada es: {potencia:F2} W");

if (potencia <= 120)
{
    Console.WriteLine("CONSUMO NORMAL");
}
else
{
    Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO");
}
using System;

namespace Ejercicio1DeNahemiasZampelunghe
{
    class Program
    {
        static void Main(string[] args)
        {

			//definir distancia, velocidad, tiempo, kms como real;
			//escribir Sin Saltar "Ingrese la velocidad en la que se desplaza el móvil:";
			//leer velocidad;
			//Escribir Sin Saltar "Ingrese el tiempo que se desplaza el móvil en segundos:";
			//leer tiempo;

			//distancia = velocidad * tiempo;
			//Escribir "La distancia recorrida es de ",distancia," M/S.";
			//kms = distancia * 0.001;
			//Escribir "La distancia recorrida en KM es de ",kms,".";
			Console.Title = "Velocidad de un móvil";

			Console.Write("Ingrese a la velocidad a la que se desplaza el móvil:");
			var velocidad = float.Parse(Console.ReadLine());
			Console.Write("Ingrese el tiempo que se desplaza el móvil en segundos:");
			var tiempo = float.Parse(Console.ReadLine());
			var distancia = velocidad * tiempo;
			Console.WriteLine($"La distancia recorrida es de {distancia} Mts.");
			var km = distancia * 0.001f;
			Console.WriteLine($"La distancia recorridad en Kilómetros es de {km}KM.");
			Console.ReadKey();
		}
    }
}

using System;
using System.Collections.Generic;
namespace Rodri
{
    class Program
    {
        static void Main(string[] args)
        {
            List<contratistas> contratistas = new List<contratistas>();
            int horasDeTrabajo;
            int presupuesto;

            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());

            contratistas.Add(new Plomero());
            contratistas.Add(new Plomero());
            contratistas.Add(new Plomero());
            contratistas.Add(new Plomero());
            contratistas.Add(new Plomero());

            contratistas.Add(new Albañil(23, false));
            contratistas.Add(new Albañil(93, false));
            contratistas.Add(new Albañil(33, true));
            contratistas.Add(new Albañil(101, false));
            contratistas.Add(new Albañil(51, true));

            Console.WriteLine("Ingrese horas de trabajo y el presupuesto para la obra");
            horasDeTrabajo = Int32.Parse(Console.ReadLine());
            presupuesto = Int32.Parse(Console.ReadLine());

            Constructora constructora = new Constructora(presupuesto, horasDeTrabajo, contratistas);

            Console.WriteLine("Se puede armar? no jaja xd uwu a pero: " + constructora.sePuede());

        }
    }
}

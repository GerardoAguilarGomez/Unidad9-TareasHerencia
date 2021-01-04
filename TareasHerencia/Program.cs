﻿using System;

namespace TareasHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             EJERCICIO 1-CLASE CUENTA
            Cuenta C1 = new Cuenta("Federico");
            C1.toString();
            Cuenta C2 = new Cuenta("Alejandro", 253.8);
            C2.toString();
            C2.Ingresar(-4);
            C2.toString();
            C2.Ingresar(325.4);
            C2.toString();
            C2.Retirar(100);
            C2.toString();
            C2.Retirar(1000);
            C2.toString();
            */


            /*
             PRUEBAS CLASE EJERCICIO 2-CLASE PERSONA
            Persona P1 = new Persona("Gerardo", 36,  'H', 82,1.84);
            P1.toString();
            Console.WriteLine(P1.calcularIMC());
            Console.WriteLine(P1.MayorEdad());
            */

            Console.WriteLine("Inserta nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserta edad:");
            string edad = Console.ReadLine();
            Console.WriteLine("Inserta sexo:");
            string sexo = Console.ReadLine();
            Console.WriteLine("Inserta peso:");
            string peso = Console.ReadLine();
            Console.WriteLine("Inserta altura:");
            string altura = Console.ReadLine();

            Persona P1 = new Persona(nombre, Convert.ToInt32(edad), Convert.ToChar(sexo), Convert.ToInt32(peso), Convert.ToDouble(altura));
            P1.toString();

            if (P1.calcularIMC() == -1)
            {
                Console.WriteLine("Peso por debajo del ideal");
            }
            else if (P1.calcularIMC() == 0)
            {
                Console.WriteLine("Peso en el intervalo ideal");
            }
            else if (P1.calcularIMC() == 1) { 
                Console.WriteLine("Peso por encima del ideal");
            }
            if (P1.MayorEdad() == true)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }


        Persona P2 = new Persona(nombre, Convert.ToInt32(edad), Convert.ToChar(sexo));
            P2.toString();
            if (P2.calcularIMC() == -1)
            {
                Console.WriteLine("Peso por debajo del ideal");
            }
            else if (P2.calcularIMC() == 0)
            {
                Console.WriteLine("Peso en el intervalo ideal");
            }
            else if (P2.calcularIMC() == 1)
            {
                Console.WriteLine("Peso por encima del ideal");
            }
            if (P2.MayorEdad() == true)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }


            Persona P3 = new Persona();
            P3.toString();
            if (P3.calcularIMC() == -1)
            {
                Console.WriteLine("Peso por debajo del ideal");
            }
            else if (P3.calcularIMC() == 0)
            {
                Console.WriteLine("Peso en el intervalo ideal");
            }
            else if (P3.calcularIMC() == 1)
            {
                Console.WriteLine("Peso por encima del ideal");
            }
            if (P3.MayorEdad() == true)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }
    }
}

using System;

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

            /*
             EJERCICIO 2-CLASE PERSONA
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
            */

            /*
             PRUEBAS CLASE EJERCICIO 3-CLASE PASSWORD
            Password P1 = new Password(25);
            Console.WriteLine(P1.Contraseña);
            Console.WriteLine(P1.EsFuerte());
            */

            /*
             EJERCICIO 3 CLASE PASSWORD
            Console.WriteLine("Indica cuantas passwords quieres generar:");
            string c = Console.ReadLine();
            int cuantas = Convert.ToInt32(c);

            Password[] contraseñas = new Password[cuantas];
            bool[] saber = new bool[cuantas];
            Console.WriteLine("Indica el nº de caracteres de cada password");
            string longitud = Console.ReadLine();

            for (int i=0;i<=contraseñas.Length-1;i++)
            {
                contraseñas[i] = new Password(Convert.ToInt32(longitud));
                saber[i] = contraseñas[i].EsFuerte();

                Console.WriteLine("Contraseña {0}: {1}. Seguridad: {2}", i + 1, contraseñas[i].Contraseña, saber[i]);
            }
            */

            /*
             * PRUEBAS EJERCICIO 4-ELECTRODOMESTICOS
            Electrodomestico e1 = new Electrodomestico(3000,"rojo",'C',75);
            e1.toString();

            Lavadora L1 = new Lavadora();
            Console.WriteLine("Precio base: {0}", L1.Precio_base);
            Lavadora L2 = new Lavadora(2500,47);
            Console.WriteLine("Precio base: {0}. Peso: {1}", L2.Precio_base,L2.Peso);
                       
            Lavadora L3 = new Lavadora(1200,"negro",'A',45,60);
            Console.WriteLine("Precio base: {0}. Peso: {1}. Color: {2}. Consumo: {3}. Carga: {4} kg", L3.Precio_base, L3.Peso,L3.Color,L3.Consumo_energetico,L3.Carga);
            L3.toString();
            Console.WriteLine("Precioooo final: {0}", L3.PrecioFinal());
             */

            Object[] ListaElectrodomesticos =new Object[10];
            //Electrodomestico[] ListaElectrodomesticos = new Electrodomestico[10];
            ListaElectrodomesticos[0] = new Television(1200, "negro", 'A', 45, 50,true);
            ListaElectrodomesticos[1] = new Electrodomestico(600, "blanco", 'C',5);
            ListaElectrodomesticos[2] = new Lavadora(750 ,"azul", 'D', 12,50);
            ListaElectrodomesticos[3] = new Television(800, "", 'C', 15, 15, false);
            ListaElectrodomesticos[4] = new Electrodomestico(850, "verde", 'E', 2);
            ListaElectrodomesticos[5] = new Lavadora(300, "blanco", 'B', 2, 8);
            ListaElectrodomesticos[6] = new Television(650, "negro", 'F', 10, 39, true);
            ListaElectrodomesticos[7] = new Electrodomestico(300, "rojo", 'A', 8);
            ListaElectrodomesticos[8] = new Lavadora(200, "blanco", 'C', 35, 3);
            ListaElectrodomesticos[9] = new Television(150, "negro", 'E', 10, 14, true);

            int precio_televisores = 0;
            int precio_lavadoras = 0;
            int precio_electrodomesticos = 0;


            for (int i = 0; i <= ListaElectrodomesticos.Length - 1; i++)
            {
                /* IMPORTANTE, FORMA DE LLAMAR A UN METODO DE UNA CLASE HEREDADA
                 * 
                 * 
                Television objeto;

                objeto=(Television)ListaElectrodomesticos[i];
                objeto.solotv();
                */
                Electrodomestico objeto;
                objeto = (Electrodomestico)ListaElectrodomesticos[i];
                objeto.toString();

                //Console.WriteLine(ListaElectrodomesticos[i].GetType().Name); ME DA EL TIPO DE OBJETO

                //Console.WriteLine(ListaElectrodomesticos[i].);
                //Console.WriteLine("El precio final del electrodoméstico {0} es {1} euros", i + 1, ListaElectrodomesticos[i].GetType());
                //Console.WriteLine(ListaElectrodomesticos[i].PrecioFinal());
                /*
                Console.WriteLine("El precio final del electrodoméstico {0} es {1} euros", i + 1, ListaElectrodomesticos[i].PrecioFinal());
                

                */
                precio_electrodomesticos = precio_electrodomesticos + objeto.PrecioFinal();

                if (ListaElectrodomesticos[i] is Television == true)
                {
                    precio_televisores = precio_televisores + objeto.PrecioFinal();

                    
                }
                if (ListaElectrodomesticos[i] is Lavadora == true)
                {
                    precio_lavadoras = precio_lavadoras + objeto.PrecioFinal();
                }
                

            }

            Console.WriteLine("Precio de los televisores: {0}", precio_televisores);
            Console.WriteLine("Precio de las lavadoras: {0}", precio_lavadoras);
            Console.WriteLine("Precio de todos los electrodomésticos: {0}", precio_electrodomesticos);


        }

     
    }
}

using System;

namespace TareasHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

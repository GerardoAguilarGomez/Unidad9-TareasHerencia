using System;
using System.Collections.Generic;
using System.Text;

namespace TareasHerencia
{
    class Cuenta
    {
        private string titular;
        private double cantidad;

        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }


        public Cuenta()
        {
            this.titular = "";
            this.cantidad = 0;
        }
        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public void toString()
        {
            Console.WriteLine("Titular: {0}. Cantidad: {1}", this.titular, this.cantidad);
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad < 0)
            {

            }
            else
            {
                this.cantidad = this.cantidad+cantidad;
            }
        }

        public void Retirar(double cantidad)
        {
            if (this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad = this.cantidad - cantidad;
            }
        }
    }
}

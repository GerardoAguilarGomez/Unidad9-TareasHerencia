using System;
using System.Collections.Generic;
using System.Text;

namespace TareasHerencia
{
    public class Television : Electrodomestico
    {
        private int resolucion;
        private bool sintonizadorTDT;

        public Television()
        {
            this.resolucion = 20;
            this.sintonizadorTDT = false;
        }

        public Television(int precio, int peso) : base(precio, peso)
        {
            this.resolucion = 20;
            this.sintonizadorTDT = false;
        }

        public Television(int precio, string color, char consumo, int peso,  int resolucion, bool sint) : base(precio, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sint;
        }

        public int Resolucion{
            get { return this.resolucion; }
        }

        public bool SintonizadorTDT
        {
            get { return this.sintonizadorTDT; }
        }

        public new int PrecioFinal()
        {
            int nuevo_precio = 0;
            if (this.resolucion > 40)
            {
                nuevo_precio = base.PrecioFinal() + (base.PrecioFinal() * 30 / 100);
            }

            if (this.sintonizadorTDT == true)
            {
                nuevo_precio = nuevo_precio + 50;
            }

            return nuevo_precio;
        }

        public override void toString()
        {
            Console.WriteLine("Color: {0}. Consumo: {1}. Peso: {2}. Precio final: {3}. Resolución: {4}. Sintonizador: {5}", Color, Consumo_energetico, Peso, PrecioFinal(), this.resolucion,this.sintonizadorTDT);
        }

        public void solotv()
        {
            Console.WriteLine("solo tv");
        }
    }
}

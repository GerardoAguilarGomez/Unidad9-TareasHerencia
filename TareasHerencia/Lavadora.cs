using System;
using System.Collections.Generic;
using System.Text;

namespace TareasHerencia
{
    public class Lavadora : Electrodomestico
    {
        private int carga;
        const int CARGA_INICIAL = 5;

        public int Carga
        {
            get { return this.carga; }
        }

        public Lavadora()
        {
            this.carga = CARGA_INICIAL;

        }

        public Lavadora(int precio,int peso) : base(precio, peso)
        {
            this.carga = CARGA_INICIAL;
        }

        public Lavadora(int precio,string color,char consumo,int peso,int carga):base(precio,color,consumo,peso)
        {
            this.carga = carga;
        }

        public new int  PrecioFinal()
        {
            int plus_carga = 0;

            if (this.carga > 30)
            {
                plus_carga = 50;
            }

            return base.PrecioFinal()+ plus_carga;
            
        }

        public override void toString()
        {
            Console.WriteLine("Color: {0}. Consumo: {1}. Peso: {2}. Precio final: {3}. Carga: {4}", Color, Consumo_energetico, Peso, PrecioFinal(),this.carga);
        }
    }
}

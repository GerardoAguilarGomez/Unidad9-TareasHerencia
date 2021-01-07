using System;
using System.Collections.Generic;
using System.Text;

namespace TareasHerencia
{
    public class Electrodomestico
    {
        private int precio_base;
        private string color;
        private char consumo_energetico;
        private int peso;

        const int cons_precio=100;
        const string cons_color="Blanco";
        const char cons_consumo='F';
        const int cons_peso=5;

        string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };

        public int Precio_base { get => precio_base; set => precio_base = value; }
        public string Color { get => color; set => color = value; }
        public char Consumo_energetico { get => consumo_energetico; set => consumo_energetico = value; }
        public int Peso { get => peso; set => peso = value; }

        public Electrodomestico()
        {
            this.precio_base = cons_precio;
            this.color = cons_color;
            this.consumo_energetico = cons_consumo;
            this.peso = cons_peso;
        }

        public Electrodomestico(int precio_base, int peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
            this.color = cons_color;
            this.consumo_energetico = cons_consumo;
        }

        public Electrodomestico(int precio_base, string color, char consumo_energetico, int peso)
        {
            this.precio_base = precio_base;
            this.color = ComprobarColor(color);
            this.consumo_energetico = ComprobarConsumo(consumo_energetico);
            this.peso = peso;
        }

        public char ComprobarConsumo(char letra)
        {
            if ((letra != 'A') && (letra != 'B') && (letra != 'C') && (letra != 'D') && (letra != 'E') && (letra != 'F'))
            {
                return cons_consumo;
            }
            else
            {
                return letra;
            }
        }

        public string ComprobarColor(string color)
        {
            bool saber = false;
            for (int i = 0; i <= colores.Length - 1; i++)
            {
                if (colores[i] == color)
                {
                    saber = true;
                }
            }

            if (saber == true)
            {
                return color;
            }
            else
            {
                return cons_color;
            }
        }

        public virtual int PrecioFinal()
        {
            int precio = this.precio_base;

            switch(this.consumo_energetico){
                case 'A': 
                    precio = precio + 100;
                break;
                case 'B':
                    precio = precio + 80;
                    break;
               case 'C':
                    precio = precio + 60;
                    break;
                case 'D':
                    precio = precio + 50;
                    break;
                case 'E':
                    precio = precio + 30;
                    break;
                case 'F':
                    precio = precio + 10;
                    break;
                default:
                   break;
            }

            if (this.peso < 20)
            {
                precio = precio + 10;
            }else if (this.peso < 50)
            {
                precio = precio + 50;
            }
            else if (this.peso < 80)
            {
                precio = precio + 80;
            }
            else
            {
                precio = precio + 100;
            }

            return precio;
        }

        public virtual void toString()
        {
            Console.WriteLine("Color: {0}. Consumo: {1}. Peso: {2}. Precio final: {3}", this.color, this.consumo_energetico, this.peso, PrecioFinal());
        }

        }
    }




using System;
using System.Collections.Generic;
using System.Text;

namespace TareasHerencia
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;
        private char sexo;
        private int peso;
        private double altura;

        const char sexo_defecto = 'H';

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.sexo = sexo_defecto;
            this.peso = 0;
            this.altura = 0;
            this.dni = GenerarDni();
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            ComprobarSexo(sexo);
            this.peso = 0;
            this.altura = 0;
            this.dni = GenerarDni();
        }

        public Persona(string nombre, int edad, char sexo, int peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = GenerarDni();
            ComprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
        }

        public void toString()
        {
            Console.WriteLine("Nombre: {0}. Edad {1}. Dni: {2}. Sexo: {3}. Peso: {4}. Altura: {5}",this.nombre,this.edad,this.dni,this.sexo,this.peso,this.altura);
        }

        public float calcularIMC()
        {
            double resultado = this.peso / Math.Pow(this.altura, 2);
            const float peso_x_debajo = -1;
            const float peso_ideal = 0;
            const float peso_sobrepeso = 1;

            if (resultado < 20)
            {
                return peso_x_debajo;
            }else if (resultado < 26)
            {
                return peso_ideal;
            }
            else
            {
                return peso_sobrepeso;
            }
        }

        public bool MayorEdad()
        {
            if (this.edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ComprobarSexo(char sexo)
        {
            if ((sexo != 'H')&& (sexo != 'M'))
            {
                this.sexo = 'H';
            }
        }

        public string GenerarDni()
        {
            Random r = new Random();
            int parte_numerica = r.Next(1, 99999999);
            int resto = parte_numerica % 23;
            char letra;

            switch (resto)
            {
                case 0:
                    letra = 'T';
                    break;
                case 1:
                    letra = 'R';
                    break;
                case 2:
                    letra = 'W';
                    break;
                case 3:
                    letra = 'A';
                    break;
                case 4:
                    letra = 'G';
                    break;
                case 5:
                    letra = 'M';
                    break;
                case 6:
                    letra = 'Y';
                    break;
                case 7:
                    letra = 'F';
                    break;
                case 8:
                    letra = 'P';
                    break;
                case 9:
                    letra = 'D';
                    break;
                case 10:
                    letra = 'X';
                    break;
                case 11:
                    letra = 'B';
                    break;
                case 12:
                    letra = 'N';
                    break;
                case 13:
                    letra = 'J';
                    break;
                case 14:
                    letra = 'Z';
                    break;
                case 15:
                    letra = 'S';
                    break;
                case 16:
                    letra = 'Q';
                    break;
                case 17:
                    letra = 'V';
                    break;
                case 18:
                    letra = 'H';
                    break;
                case 19:
                    letra = 'L';
                    break;
                case 20:
                    letra = 'C';
                    break;
                case 21:
                    letra = 'K';
                    break;
                case 22:
                    letra = 'E';
                    break;
                default:
                    letra = '0';
                    break;
            }

            return  Convert.ToString(parte_numerica) + letra;

        }
    }
}

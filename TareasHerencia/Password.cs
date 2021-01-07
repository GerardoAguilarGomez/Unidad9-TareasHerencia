using System;
using System.Collections.Generic;
using System.Text;

namespace TareasHerencia
{
    class Password
    {
        private int longitud;
        private string contraseña;

        public int Longitud { set => longitud = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public Password()
        {
            this.longitud = 0;
            this.contraseña = "";
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = GenerarContraseña(this.longitud);
        }



        public string GenerarContraseña(int longitud)
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int num_caracteres = caracteres.Length;
            char letra;

            for (int i = 0; i < this.longitud; i++)
            {
                letra = caracteres[rdn.Next(num_caracteres)];
                this.contraseña += letra.ToString();
            }

            return contraseña;
        }

        public bool EsFuerte()
        {
            int contador_mayusculas = 0;
            int contador_minusculas = 0;
            int contador_numeros = 0;

            for(int i = 0; i <= this.contraseña.Length - 1; i++)
            {
                char caracter = Convert.ToChar(this.contraseña.Substring(i, 1));

                //Console.WriteLine(this.contraseña.Substring(i, 1));
                if (Char.IsNumber(caracter))
                {
                    //Console.WriteLine("{0} - Numero",this.contraseña.Substring(i, 1));
                    contador_numeros++;
                }
                else
                {
                    if (Char.IsUpper(caracter))
                    {
                        //Console.WriteLine("{0} - Mayúsculas", this.contraseña.Substring(i, 1));
                        contador_mayusculas++;
                    }
                    else
                    {
                        //Console.WriteLine("{0} - Minúsculas", this.contraseña.Substring(i, 1));
                        contador_minusculas++;
                    }
                }
            }
            if ((contador_numeros>5)&&(contador_mayusculas>2)&&(contador_minusculas>1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

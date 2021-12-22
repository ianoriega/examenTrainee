using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    public static class Ejercicio2
    {
        public static void EjecutarEjercicio()
        {
            //Funcion para calcular los angulos del reloj
            void CalcularAngulos(int horas, int minutos)
            {

                if (horas >= 0 && horas <= 11 && minutos >= 0 && minutos <= 59)
                {
                    float alfa = (360 / 12) * horas;
                    float beta = (360 / 60) * minutos;

                    Console.WriteLine($"angulo alfa = {alfa}\nangulo beta = {beta}");
                }
                else
                {
                    Console.WriteLine("hora o minutos incorrectos");
                }
            }

            Console.WriteLine("ingrese las horas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese los minutos");
            int minutos = int.Parse(Console.ReadLine());

            
            CalcularAngulos(horas, minutos);
        }
    }
}

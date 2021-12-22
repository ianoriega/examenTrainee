namespace ejercicios
{
    public static class Ejercicio1
    {
        public static void EjecutarEjercicio()
        {
            //Funcion para calcular la secuencia
            List<int> calcular(int numero)
            {
                List<int> secuencia = new List<int>();

                secuencia.Add(numero);

                while (numero > 1)
                {
                    if (numero % 2 == 0)
                    {
                        numero = numero / 2;
                        secuencia.Add(numero);
                    }
                    else
                    {
                        numero = (numero * 3) + 1;
                        secuencia.Add(numero);
                    }
                }

                return secuencia;
            }

            int largoMaximoAux = 0;
            int numeroMaximo = 0;
            List<int> secuenciaAux;
            
            //Iteracion para encontrar la secuencia mas larga de 1 a 1000000
            for (int i = 1; i < 1000000; i++)
            {
                secuenciaAux = calcular(i);
                if (secuenciaAux.Count() > largoMaximoAux)
                {
                    largoMaximoAux = secuenciaAux.Count();
                    numeroMaximo = i;
                }

                if (i % 10000 == 0)
                {
                    Console.WriteLine("calculando...");
                }
            }

            Console.WriteLine($"numero con secuencia mas larga: {numeroMaximo}");

        }
    }
}
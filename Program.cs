//Bibliotecas na versão de C#. São bem mais práticas por conter uma enorme variedade de bibliotecas se compsarada com o C++, porém são mais lentas.
using System;
using System.Globalization;

namespace Course
{//Classe pública que ocupa o programa todo.
    public class Program
    {
        //Corpo principal do código.
        public static void Main(string[] args)
        {   //Uso de Variáveis e Array para definir X e Y.
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");
            //Variáveis para o calculo futuro das áreas.
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);
            //Interfaces interativas para o usuário poder escolher os números do triângulo X e Y.
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //Condicional simples que mostra qual triângulo é maior, X ou Y.
            if (areaX > areaY)
                //Interface padrão mostrada caso X seja maior que Y.
            {
                Console.WriteLine("Maior área: X");
            }
            //Caso seja ao contrário essa interface será mostrada.
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        //
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            double[] medidas = new double[3];

            Console.WriteLine("Entre com as  medidas do Triângulo " + nomeTriangulo + ":");
            for (int i = 0; i < 3; i++)
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            return medidas;
        }

        public static double CalcularAreaTriangulo(double[] medidas)
        {
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p * c));

            return area;
        }
    }
}
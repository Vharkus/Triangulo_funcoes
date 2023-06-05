//Bibliotecas na versão de C#. São bem mais práticas por conter uma enorme variedade de bibliotecas se compsarada com o C++, porém são mais lentas.
using System;
using System.Globalization;
namespace Course
{//Classe pública que ocupa o programa todo.
    public class Program
    {
        //Função principal do código.
        public static void Main(string[] args)
        {   //Uso de Variáveis e Array para definir X e Y.
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");
            //Variáveis para o calculo futuro das áreas.
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);
            //Interface que mostra o valor de X e Y, arredondando até 4 números depois da virgula.
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
        //Função que lê e recebe os valores dos lados do triângulo. 
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {   //Array nova que recebe 3 espaços.
            double[] medidas = new double[3];
            //Interface interativa que recebe os valores do triângulo da string feita anteriormente.
            Console.WriteLine("Entre com as  medidas do Triângulo " + nomeTriangulo + ":");
            //Bloco de repetição for.
            for (int i = 0; i < 3; i++)
            {   //Dentro do for, os valores serão convertidos em double e armazenados em array.
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //Valor retorna ao array medidas.
            return medidas;
        }
        //Função que irá realizar os calculos para descobrir a área do triângulo.
        public static double CalcularAreaTriangulo(double[] medidas)
        {   //Variáveis armazenadas, respectivamente, nos arrays 0,1 e 2, simbolizando um array[3].
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];
            //Calculo feito para ahar o perímetro do triângulo.
            double p = (a + b + c) / 2.0;
            //Conta feita para achar a áriea do triângulo.
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p * c));

            return area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Ling;
using System.Threading.Tasks;


# Ejemplo de perceptron para implementar la puerta lógica AND

namespace Perceptron 
{
    class Program
    {
        static void Main(string[] args)
        {// Conjunto de datos para entrenamiento
            int[,] datos = ({1,1,1},{1,0,0}, {0,1,0}, {0,0,0});
            //Generacion de los valores de peso y umbral
            Random aleatorio = new Random();
            double [] pesos = (aleatorio.NextDouble(),aleatorio.NextDouble(), aleatorio.NextDouble())
            // Etapa de aprendizaje
            bool aprendizaje = true;
            int salidaEntera;
            int epocas = 0;
            while (aprendizaje)
            {
                aprendizaje = False;
                for (int i = 0, i<4, i++){
                    double salidaDoub = datos[i,0] * pesos [0] + datos[i, 1] * pesos[1] + pesos[2];
                    if (salidaDoub > 0) salidaEntera = 1; else salidaEntera=0;
                    if (salidaEntera != datos[i,2]){
                        pesos[0] = aleatorio.NextDouble() - aleatorio.NextDouble();
                        pesos[1] = aleatorio.NextDouble() - aleatorio.NextDouble();
                        pesos[2] = aleatorio.NextDouble() - aleatorio.NextDouble();
                        aprendizaje = true
                    } 
                }
                epocas ++;
            }
            // Finaliza el aprendizaje
            // Verificación de resultados
            for (int i = 0, i < 4, i++){
                double salidaDoub = datos[i, 0]* pesos[0] + datos[i,1] * pesos[1] + pesos[2];
                if (salidaDoub > 0 ) salidaEntera = 1; else salidaEntera=0;
                Console.WriteLine("Entrada: "+ datos[i,0].ToString() + "AND" + datos[i,1].ToString() + " = " + datos[i,2].ToString() + "Perceptron: " + salidaEntera.ToString());
            }
            Console.WriteLine("Epocas " + epocas.ToString());
            Console.WriteLine("Pesos útiles " + pesos[0].ToString() + "p1" + pesos[1].ToString() + "Umbral" + pesos[2].ToString());
            Console.ReadLine();
        }
    }
}
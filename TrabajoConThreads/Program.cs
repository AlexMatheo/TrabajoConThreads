using System;
using System.Configuration;

namespace TrabajoConThreads
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] tiempoEspera = new int[4] {20, 15, 40, 60};
            string[] nombreProceso = new string[4] {"Enviar correo de Bienvenida", "Enviar correo sobre los productos", "Enviar correo sobre los productos", "Enviar correo sobre los productos"};
            string[] data = new string[4] {"Mensaje Predeterminado 1", "Mensaje Predeterminado 2", "Enviar correo sobre productos en promoción de su interés", "Enviar correo de cierre"} ;
            Boolean[] objetivo = new bool[4] {false, false, false, false};
            string[] creador = new string[4] {"Por defecto", "Por defecto", "Por defecto", "Por defecto"};
            int[] paso = new int[4] {1, 2, 3, 4};

            //GuardarLog(typeof));

            for (int i=0; i<4;i++)
            {
                Console.WriteLine("Paso - " + paso[i]);
                Console.WriteLine("El nombre del proceso es: " + nombreProceso[i]);
                Console.WriteLine("La data es: " + data[i]);
                Console.WriteLine("El creador es: " + creador[i]);

                if (objetivo[i] == false)
                {
                    Console.WriteLine("El siguiente paso se ejecutara en: " + tiempoEspera[i] + " segundos.\r\n");
                    Thread.Sleep(tiempoEspera[i] * 1000);
                }
                else
                {
                    Console.WriteLine("Fin del proceso");
                    break;
                }
            }       
        }

        //private static void GuardarLog(Type conversionType)
        //{
        //    string vRutaLog = Convert.ChangeType(ConfigurationManager.AppSettings["RutaLog"], conversionType);

        //    try
        //    {
        //        if (!Directory.Exists(vRutaLog)) { Directory.CreateDirectory(vRutaLog); }

        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
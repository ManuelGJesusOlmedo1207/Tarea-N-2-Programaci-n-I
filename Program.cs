using System;

namespace Tarea_2
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            //Datos
            string datos = "";
            int edad = 0;
            double estatura = 0.0;

            Console.WriteLine("Bienvenido al Parque");

            //Edad 
            Console.WriteLine("Digame su edad para poder entrar:");
            datos = Console.ReadLine();
            edad = Convert.ToInt32(datos);

            if (edad < 20)
            {
                Console.WriteLine("Perdona no posee la edad requerida para entrar al parque");
            }
            else
            {
                //Estatura
                Console.WriteLine("¿Y cuál es su estatura?");
                datos = Console.ReadLine();
                estatura = Convert.ToDouble(datos);
            
               if (estatura > 1.5)
                {
                    Console.WriteLine("Bienvenido a nuestro parque, que pasa un feliz día.");
                
                }    
                 else 
                {
                    Console.WriteLine("Perdona no posse la altura suficiente para poder entrar al parque.");
                }

            }

        }
    }
}


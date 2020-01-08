using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ColeccionEstructura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables necesarias  
            int indice = 0;
            int cantidad = 0;

            //Declaramos el ArrayList
            ArrayList datos = new ArrayList();

            //Adicionamos valores al ArrayList
            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Tenemos incialmente los siguientes datos:");
            Imprime(datos);

            //Hacemos crecer el ArrayList
            datos.Add(4);
            datos.Add(5);

            //Obtenemos el indice
            indice = datos.Add(10);


            Console.WriteLine("Despues lo hacemos crecer:");
            
            Imprime(datos);

            Console.WriteLine("El último elemento tiene el índice "+indice);

            Console.WriteLine("\n----------");

            //Imprimimos un elemnto en particular
            Console.WriteLine("El valor en el indice 2 es "+ datos[2]);
            
            Console.WriteLine("\n----------");
            
            //Modificamos un dato
            datos[3] = 55;

            Console.WriteLine("Después de la Modificación:");
            Imprime(datos);

            cantidad = datos.Count;

            Console.WriteLine("La cantidad del elemento es "+cantidad);
            Console.WriteLine("\n----------");

            //Insertamos un elemento
            datos.Insert(2,88);

            Console.WriteLine("Después de la Inserción:");
            Imprime(datos);

            //Eliminamos un Elemento
            datos.RemoveAt(4);

            Console.WriteLine("Después de la Eliminación:");
            Imprime(datos);

            //Encontramos el indice en donde se encuentra el primer 5
            indice=datos.IndexOf(5);

            Console.WriteLine("El primer 5 se encuentra en el indice " + indice);
            Console.WriteLine("\n----------");

            string mensaje = Console.ReadLine();

        }
        static void Imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
            {
                Console.Write(n+" "); 
            }
            Console.WriteLine("\n----------");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace claseVisualStudio
{
    class Ejercicios
    {
        // Ejercicio: Haz una función que imprima por pantalla
        // los números desde el 0 hasta el 99

        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador < 100)
            {
                contador++;
            } 
        }

        // Primera prueba commit
        // Segundo prueba commit
        // Tercera prueba commit
        // Cuarta prueba commit

        public static void Ejercicio2()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i);
                i++;
            } 
        }

        // Ejercicio igual que el anterior cambiando solo la linea de console
        // para que en pantalla salgan numeros pares

        public static void Ejercicio3()
        {
            int i = 0;
            while (i<100)
            {
                System.Console.WriteLine(i * 2);
                i++;
            }

        }

        public static void  Ejercicio4()
        {
            int i = 0;
            while (i<100)
            {
                System.Console.WriteLine(i * 3 + 1);
                i++;
            }
        }

        public static void Ejercicio5()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * i);
                i++;
            }
        }

        public static  void Ejercicio6()
        {
            int i = 0;
            while (i <  100)
 
            {
                if (Utils.IsEven(i))
                    System.console.writeline(i);
                else
                    System.console.writeline(-i);
            
              i ++;
            }

        }

        Public static void Ejercicio7()

        {
            int a;
            int aa;
            aa = 0;
            a = 0;
            int i = 0;
            while (i<100)
            {
                 System.consoloe.writeline(a + aa);
            }
        }
    }
}

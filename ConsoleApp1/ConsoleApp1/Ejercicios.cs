
namespace ConsoleApp1
{
    class Ejercicios
    {
        //ejercicio: hacer una función que imprima por pantalla los numeros del 0 al 99

        public static void Ejercicio1()
        {
            int contador = 0;

            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                // contador = contador + 1 ;
                // contador =+=1;
                contador++;
            }
        }
        // hacer una funcion que imprima todos los numeros pares desde el 0 hasta n
        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if ((i % 2) == 0)
                    System.Console.WriteLine(i);
            }

        }
        // hacer un programa que imprima si es numero primo o no

        public static void Ejercicio3(int number)
        {
            if (Math.IsPrime(number))
                System.Console.WriteLine("El numero" + number + "es primo");
            else
                System.Console.WriteLine("El numero" + number + "no es primeo");
        }

        // Ejercicio 4 5,4,3,2,1,9,-1,-2

        public static void Ejercicio4()
        {
            for (int i = 5; i < 90; i++)

                System.Console.WriteLine(5 - i);



        }


        //Ejercicio 5 -0,1,-2,3,-4,5,-6...

        public static void Ejercicio5()
        {
            for (int i = 0; i < 90; i++)
            {
                if ((i % 2) == 0)
                    System.Console.WriteLine(-i);
                else
                    System.Console.WriteLine(i);
            }
        }

        //Ejercicio6
        public static void Ejercicio6(int number)
        {
            if (Math.IsPrime(number))
                System.Console.WriteLine("El numero" + number + "es primo");
            else
                System.Console.WriteLine("El numero" + number + "no es primeo");
        }
        
        //Ejercicio7
         
        public static void Ejercicio7(int number)
        {
            int i = 5;
            while (-2 < 5)
            i--;


        }
        //Ejercicio8 0,1,1,2,3,5,8,13,21,34... numero fiboracci

        public static void Ejercicio8()
        {
            int i = 0;
            int number1 = 0;
            int number2 = 1;

            System.Console.WriteLine(number1);
            System.Console.WriteLine(number2);

            while ( i < 90 )
            {
               number2 = number1 + number2;
               number1 = number2 - number1;
               System.Console.WriteLine( "number1 + number 2");

                i++;
            }

        }


    }
}
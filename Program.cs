using System;

namespace T04_Flujo_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int a = 3;
            int b = 8;
            int c = 12;
            int d = a + b + c;
            Console.WriteLine(d);
            Console.ReadKey();

            //2
            Console.WriteLine("Introduce tu nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce la ciudad: ");
            string city = Console.ReadLine();
            Console.WriteLine("Hola " + name + " bienvenido a " + city);
            Console.ReadKey();

            //3
            Console.WriteLine("Introduce tu nombre: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Introduce tu edad: ");
            string age = Console.ReadLine();
            Console.WriteLine("Te llamas " + name2 + " y tienes " + age + " años.");
            Console.ReadKey();

            //4           
            Console.WriteLine("Introduce un número: ");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero mas alto es: " + Math.Max(num1,num2));
            Console.ReadKey();
        }
    }
}

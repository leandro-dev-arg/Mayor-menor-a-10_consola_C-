using System;

namespace U3_programa1
{
    class Program
    {
        static void Main(string[] args)
        {   int n1;
            Console.WriteLine("ingrese un numero por favor");
            n1=int.Parse(Console.ReadLine());
            if (n1>10){
                Console.WriteLine("Es mayor a 10");
            }else{
                Console.WriteLine("No es mayor a 10");
            }
        }
    }
}

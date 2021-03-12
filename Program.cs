using System;

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {

            Estadistica ob1 = new Estadistica();
            Console.WriteLine("Los números son: ");
            ob1.writeData(ob1.arreNum);
            Console.WriteLine("La media es: " + ob1.calcMedia(ob1.arreNum));
            int[] sortedArr = ob1.sortArray(ob1.arreNum);
            Console.WriteLine("El arreglo ordenado: ");
            ob1.writeData(sortedArr);
            Console.WriteLine("El valor mínimo: " + ob1.calcMin(ob1.arreNum));
            Console.WriteLine("El valor máximo: " + ob1.calcMax(ob1.arreNum));
        }
    }
}

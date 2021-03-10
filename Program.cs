using System;

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {

            Estadistica ob1 = new Estadistica();
            ob1.writeData(ob1.arreNum);
            Console.WriteLine("La media es: " + ob1.calcMedia(ob1.arreNum));
        }
    }
}

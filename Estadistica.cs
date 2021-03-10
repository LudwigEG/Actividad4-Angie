using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad4
{
    class Estadistica
    {

        public int[] arreNum = new int[10];

        public Estadistica()
        {
            arreNum = readData();
        }

        public int[] readData()
        {
            int[] arreAux = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingresa un número (" + i + "): " );
                arreAux[i] = Convert.ToInt16(Console.ReadLine());
            }
            return arreAux;
        }


        public void writeData(int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }


        public float calcMedia(int[] x)
        {
            float sum = 0;
            for(int i=0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return (sum / x.Length);
        }

        //public int calcMin(int[] x)
        //{
        //    ;
        //}

    }


}

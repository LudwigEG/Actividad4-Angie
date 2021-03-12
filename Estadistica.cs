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

        public int calcMin(int[] x)
        {
            int minValue = x[0];
            foreach(int element in x)
            {
                if(element < minValue) 
                {
                    minValue = element;
                }
                
            }
            return minValue;
        }

        public int calcMax(int[] x)
        {
            int maxValue = x[0];
            foreach (int element in x)
            {
                if (maxValue < element)
                {
                    maxValue = element;
                }

            }
            return maxValue;
        }

        public int[] sortArray(int[] x)
        {
            for (int pass = 0; pass < x.Length - 1; pass = pass + 1)
            {
                bool doneSwap = false;

                for (int i = 0; i < x.Length - 1; i = i + 1)
                {
                    if (x[i] > x[i + 1])
                    {
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        doneSwap = true;
                    }
                }
                if (!doneSwap)
                    break;
            }
            return x;
        }

    }


}

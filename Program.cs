using System;

namespace menor_distancia_arrays
{


    class Program
    {
        static int DistanceBetweenNumbers(int num1, int num2)
        {
            int distance = num2 - num1;
            if (distance < 0)
            {
                distance = -1 * distance;
            }
            return distance;
        }

        static void Main(string[] args)
        {
            int[] array1 = { 10, 25, 8, 40, 17, 30, 15, 28, 35, 3 };
            int[] array2 = { 12, 28, 45, 55, 20, 36, 25, 42, 13, 29 };

            Console.WriteLine("Array 1:");
            PrintArray(array1);
            Console.WriteLine("\nArray 2:");
            PrintArray(array2);

            int sizeArray1 = array1.Length;
            int sizeArray2 = array2.Length;

            int numArray1 = 0;
            int numArray2 = 0;

            int smallestDistance = 0;
            int currentDistance;

            for (int i = 0; i < sizeArray1; i++)
            {
                for (int j = 0; j < sizeArray2; j++)
                {
                    currentDistance = DistanceBetweenNumbers(array2[j], array1[i]);
                    if (i == 0 && j == 0)
                    {
                        smallestDistance = currentDistance;
                        numArray1 = array1[0];
                        numArray2 = array2[0];
                    }
                    else
                    {
                        if (currentDistance < smallestDistance)
                        {
                            smallestDistance = currentDistance;
                            numArray1 = array1[i];
                            numArray2 = array2[j];
                        }
                    }
                }
            }

            Console.WriteLine("A menor distância é a combinação do número {0} do primeiro array com o número {1} segundo array, é {2} de distância.", numArray1, numArray2, smallestDistance);
        }
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

}
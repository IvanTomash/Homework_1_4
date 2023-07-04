using System;
using System.Transactions;

namespace Homework1_4
{
    /// <summary>
    /// Main class in the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Method from which progmar starts.
        /// </summary>
        /// <param name ="args">
        /// Array of strings.
        /// </param>
        public static void Main(string[] args)
        {
            int n;
            int[] mainArr;
            Console.Write("Enter an array size: ");
            n = Convert.ToInt32(Console.ReadLine());
            mainArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                mainArr[i] = new Random().Next(1, 26);
            }

            int[] evenValues;
            int[] oddValues;
            int amountOfEven = 0;
            for (int i = 0; i < n; i++)
            {
                if (mainArr[i] % 2 == 0)
                {
                    amountOfEven++;
                }
            }

            evenValues = new int[amountOfEven];
            oddValues = new int[n - amountOfEven];
            int counter = 0;
            for (int i = 0; i < mainArr.Length; i++)
            {
                if (mainArr[i] % 2 == 0)
                {
                    evenValues[counter++] = mainArr[i];
                }
            }

            counter = 0;
            for (int i = 0; i < mainArr.Length; i++)
            {
                if (mainArr[i] % 2 == 1)
                {
                    oddValues[counter++] = mainArr[i];
                }
            }

            Console.Write("Main array: ");
            ShowArray(mainArr);
            Console.Write("Only even values array: ");
            ShowArray(evenValues);
            Console.Write("Only odd values array: ");
            ShowArray(oddValues);
        }

        private static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i] + "\n");
                }
                else
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}

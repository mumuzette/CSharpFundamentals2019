﻿using System;

namespace NandNMatrix
{
    class NandNMatrix
    {
        static void Main(string[] args)
        {
            //Write a method that receives a single integer N and prints NxN matrix with that number.
            int matrixBase = int.Parse(Console.ReadLine());
            PrimtMeMatrix(matrixBase);
        }

        static void PrimtMeMatrix(int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

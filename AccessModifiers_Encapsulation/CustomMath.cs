﻿namespace AccessModifiers_Encapsulation
{
    internal class CustomMath
    {
        public int GetSumOfArrayItems(int[] nums) => nums.Where(m => m % 2 == 1).Sum();

        public string CheckNumberByEvenOdd(int number) => number % 2 == 0 ? "Even" : "Odd";

        public double SquereOfEvenNumbers(int[] nums) => Math.Pow(nums.Where(m => m % 2 == 0).Sum(), 2);

        public int MultipleOfNumbers(int n)
        {
            int multiple = 1;
            for (int i = 1; i <= n; i++)
            { 
                multiple *= i;
            }
            return multiple;
        }
       
       
    }
}

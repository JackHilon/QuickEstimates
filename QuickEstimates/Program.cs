using System;

namespace QuickEstimates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quick Estimates
            // https://open.kattis.com/problems/quickestimate 
            // simple (numeric - string) program
            // -- I get Time Limit Exceeded !!! --

            var myCount = EnterCounter();
            var answers = new int[myCount]; 

            for (int k = 0; k < answers.Length; k++)
            {
                answers[k] = EnterCost().ToString().Length;
            }
            PrintArray(answers);

            //var estimates = EstimateMag(answers);
            //PrintArray(estimates);
        }
        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] EstimateMag(int[] arr)
        {
            int[] nums = new int[arr.Length];
            for (int p = 0; p < arr.Length; p++)
            {
                nums[p] = arr[p].ToString().Length;
            }
            return nums;
        }
        private static int EnterCost()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0 || a >1000000000) 
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterCounter();
            }
            return a;
        }
        private static int EnterCounter()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a < 1 || a > 100)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterCounter();
            }
            return a;
        }
    }
}

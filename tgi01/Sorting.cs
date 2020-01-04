using System;

namespace tgi01
{
    internal class Sorting
    {
        public static void Main(string[] args)
        {

            int[] toBeSorted = {13, 25, 4, 15, 9, 16, 19};
            
            PrintIntegerArray(BubbleSort(toBeSorted));

            Console.ReadLine();

        }

        private static void PrintIntegerArray(int[] input)
        {

            string output = "[";
            
            for (int i = 0; i < input.Length; i++)
            {

                output = output += input[i].ToString();

                if (i == input.Length - 1)
                {
                    output += "";
                }
                else
                {
                    output += ", ";
                }

            }

            output += "]";
            
            Console.Out.WriteLine(output);

        }

        private static int[] BubbleSort(int[] toBeSorted)
        {

            for (int i = 0; i < toBeSorted.Length; i++)
            {

                for (int j = 0; j < toBeSorted.Length - 1; j++)
                {

                    if (toBeSorted[j] > toBeSorted[j+1])
                    {
                        int tmp = toBeSorted[j];
                        toBeSorted[j] = toBeSorted[j + 1];
                        toBeSorted[j + 1] = tmp;
                    }
                    
                }
                
            }


            return toBeSorted;

        }
    }
}
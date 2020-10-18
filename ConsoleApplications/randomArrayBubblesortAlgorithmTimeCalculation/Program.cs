using System;
using System.Diagnostics;

namespace randomArrayBubblesortAlgorithmTimeCalculation
{
    class Program
    {
        static double[] generatedArray()
        {
            Random generator = new Random();
            int generatedRandomNumber = generator.Next(3, 20);
            double[] randomArray = new double[generatedRandomNumber];

            for (int index = 0; index < randomArray.Length; index++)
            {
                randomArray[index] = generator.Next(3, 200);
            }
            return randomArray;
        }

        static double getTime(double[] numbrs)
        {
            var counter = new Stopwatch();
            double time;
            counter.Start();

            // bubblesort algorithm
            double temp;
            for (int j = 0; j <= numbrs.Length - 2; j++)
            {
                for (int i = 0; i <= numbrs.Length - 2; i++)
                {
                    if (numbrs[i] > numbrs[i + 1])
                    {
                        temp = numbrs[i + 1];
                        numbrs[i + 1] = numbrs[i];
                        numbrs[i] = temp;
                    }
                }
            }
            counter.Stop();
            Console.WriteLine("Sorted array is: [{0}]", string.Join(", ", numbrs));
            time = counter.Elapsed.TotalMilliseconds * 1000;
            return time;
        }

        static void generatePlot(double[] X, int iterations)
        {
            double[] Y = new double[iterations];
            var plt = new ScottPlot.Plot(400, 600);
            plt.PlotScatter(X, Y);
            plt.SaveFig("graph.png");
        }

        public static void Main(string[] args)
        {
            int iterations = 200;
            double[] results = new double[iterations];
            for (int i = 0; i < iterations; i++)
            {
                double[] returnedArray = generatedArray();
                Console.WriteLine("Random array is: [{0}]", string.Join(", ", returnedArray));
                results[i] = getTime(returnedArray);
                Console.WriteLine("Time is: " + results[i]);
            }
            generatePlot(results, iterations);
        }
    }
}
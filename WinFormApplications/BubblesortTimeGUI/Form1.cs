using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace BubblesortTimeGUI
{
    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double[] generatedArray()
        {
            var rng = new Random();
            int[] randomArray = Enumerable.Repeat(0, 5).Select(i => rng.Next(3, 800)).ToArray();
            rng.Shuffle(randomArray);
            rng.Shuffle(randomArray);
            rng.Shuffle(randomArray);
            rng.Shuffle(randomArray);
            rng.Shuffle(randomArray);
            rng.Shuffle(randomArray);
            return Array.ConvertAll<int, double>(randomArray, x => x);
        }

        public double getTime(double[] numbrs)
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
            time = counter.Elapsed.TotalMilliseconds * 1000;

            // display the ordered array here
            string orderedArrayStr = string.Join(" ", numbrs);
            orderedArrayList.Items.Add(orderedArrayStr);
            return time;
        }

        public void generatePlot(double[] Y, int iterations)
        {
            //double[] X = new double[iterations];
            graphForMiliseconds.plt.PlotSignal(Y);
            graphForMiliseconds.Render();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            int iterations;
            if (int.TryParse(iterations_txtbox.Text, out iterations)) {
                double[] results = new double[iterations];
                for (int i = 0; i < iterations; i++)
                {
                    // get information required
                    double[] returnedArray = generatedArray();

                    // obtain the text of array
                    string unorderedArrayStr = string.Join(" ", returnedArray);

                    // display the information
                    unorderedArrayList.Items.Add(unorderedArrayStr);

                    results[i] = getTime(returnedArray);

                    // display the time
                    timeCalculationList.Items.Add(results[i]);
                }
                generatePlot(results, iterations);
            } else
            {
                MessageBox.Show("Input is not an integer");
            }
        }
    }
}

using ScottPlot;
using ScottPlot.WPF;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows;

namespace Project06
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static double[] Data = new double[100];
        static int Count = 100;
        public MainWindow()
        {
            InitializeComponent();
            Data = Sequence.MainSequence();
            Graphic();
            Dispersion.Text = $"Дисперсия равна: {ResultDispersion()}";
            Mean.Text = $"Среднее значение: {ResultSum(1) / 100}";
        }
        public static void Graphic()
        {
            var plt = new ScottPlot.Plot(600, 400);

            (double[] counts, double[] binEdges) = ScottPlot.Statistics.Common.Histogram(Data, min: 0, max: 100, binSize: 1);
            double[] leftEdges = binEdges.Take(binEdges.Length - 1).ToArray();

            var bar = plt.AddBar(values: Data, positions: leftEdges);
            bar.BarWidth = 1;

            plt.YAxis.Label("Значение");
            plt.XAxis.Label("Номер элемента");
            plt.SetAxisLimits(yMin: 0);
            plt.SetAxisLimits(yMax: 5);

            plt.SaveFig("histogram.png");
            Process.Start("histogram.png");
        }
        public static double ResultDispersion()
        {
            double Ex = ResultSum(1); // Сумма всех чисел массива 
            double Ex2 = ResultSum(2); // Сумма квадратов всех чисел массива

            return (Ex2 - (Ex * Ex) / Count) / (Count - 1);
        }
        public static double ResultSum(int logic)
        {
            double sum;
            switch (logic)
            {
                case 1:
                    sum = 0;
                    for (int i = 0; i < Count; i++)
                    {
                        sum += Data[i];
                    }
                    return sum;
                case 2:
                    sum = 0;
                    for (int i = 0; i < Count; i++)
                    {
                        sum += Data[i] * Data[i];
                    }
                    return sum;
                default:
                    return 0;
            }
        }
    }
}

using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Markup;
using ScottPlot;
using ScottPlot.WPF;

namespace Project08.Windows
{
    /// <summary>
    /// Логика взаимодействия для Result.xaml
    /// </summary>
    public partial class Result : Window
    {
        static double[] Data;
        static double Min;
        static double Max;
        static double Count;
        public Result(double min, double max, int n)
        {
            InitializeComponent();
            Min = min;
            Max = max;
            Count = (max - min) / n;


            Data = IntegralSolution.GetArray(f, min, max, n);
            TextBlockLeft.Text = $"По форумле левых прямоугольников: {IntegralSolution.LeftRectangle(f, min, max, n)}";
            TextBlockCentral.Text = $"По форумле левых прямоугольников: {IntegralSolution.CentralRectangle(f, min, max, n)}";
            TextBlockRight.Text = $"По форумле левых прямоугольников: {IntegralSolution.RightRectangle(f, min, max, n)}";

        }

        double f(double x) => Math.Sqrt(x * x - 0.16) / x;

        private void BtnGetGraphic_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не реализовал");
        }

        //IntegralSolution.LeftRectangle(f, double.Parse(TextBoxLimitsMin.Text), double.Parse(TextBoxLimitsMax.Text), int.Parse(TextBoxCount.Text)).ToString()
    }
}

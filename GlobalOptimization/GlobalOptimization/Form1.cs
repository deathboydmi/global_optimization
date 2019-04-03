using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalOptimization
{
    public partial class Form1 : Form
    {
        private double alpha;
        private double betta;
        private double gamma;
        private double delta;
        private double left_range_x;
        private double right_range_x;
        private int num_of_iterations;
        private double accuracy;
        private double param_method;
        private double[] x_list;
        private double[] y_list;
        private struct Result
        {
            public double min_x;
            public double min_y;
            public double accuracy;
            public int stop_iteration;
            public string method;
            public override string ToString()
            {
                string str_res = method + ":" + Environment.NewLine +
                    "optim value: " + min_y.ToString() + ";" + Environment.NewLine
                    + "stop iteration: " + stop_iteration.ToString() + ";" + Environment.NewLine
                    + "accuracy: " + accuracy.ToString();
                return str_res;
            }
        }
        private Result result;
        public Form1()
        {
            InitializeComponent();
            initialize_plot_parameters();
            initialize_method_parameters();
        }
        private void initialize_plot_parameters()
        {
            alpha = double.Parse(alpha_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            betta = double.Parse(betta_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            gamma = double.Parse(gamma_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            delta = double.Parse(delta_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            left_range_x = double.Parse(range_left_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            right_range_x = double.Parse(range_right_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
        }
        private void initialize_method_parameters()
        {

            num_of_iterations = int.Parse(iterations_textBox.Text);
            accuracy = double.Parse(accuracy_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            param_method = double.Parse(method_param_textBox.Text, System.Globalization.CultureInfo.InvariantCulture);
        }
        private void plot_button_Click(object sender, EventArgs e)
        {
            try
            {
                initialize_plot_parameters();
            }
            catch (System.FormatException)
            {
                return;
            }
            plot_function();
        }

        private double function(double x)
        {
            return (alpha*Math.Sin(betta*x)+gamma*Math.Cos(delta*x));
        }

        private void plot_function()
        {
            plot_chart.ChartAreas[0].AxisX.Maximum = right_range_x;
            plot_chart.ChartAreas[0].AxisX.Minimum = left_range_x;
            plot_chart.Series[0].Points.Clear();
            double x = left_range_x;
            double step = 0.25;
            while (x < right_range_x)
            {
                plot_chart.Series[0].Points.AddXY(x, function(x));
                x += step;
            }
            plot_chart.Series[0].Points.AddXY(right_range_x, function(right_range_x));
        }

        private Result brute_force_method()
        {
            points_chart.ChartAreas[0].AxisX.Maximum = plot_chart.ChartAreas[0].AxisX.Maximum;
            points_chart.ChartAreas[0].AxisX.Minimum = plot_chart.ChartAreas[0].AxisX.Minimum;
            points_chart.Series[0].Points.Clear();
            points_chart.Series[0].Points.AddXY(left_range_x, 10);
            points_chart.Series[0].Points.AddXY(right_range_x, 10);
            double x = left_range_x;
            double y = function(x);
            result.min_x = x;
            result.min_y = y;
            result.stop_iteration = 0;
            if (y > function(right_range_x))
            {
                result.min_y = function(right_range_x);
                result.min_x = right_range_x;
            }
            result.accuracy = (right_range_x - left_range_x) / num_of_iterations;
            if (result.accuracy < accuracy)
                result.accuracy = accuracy;
            x += result.accuracy;
            while (x < right_range_x)
            {
                points_chart.Series[0].Points.AddXY(x, 10);
                y = function(x);
                if (y < result.min_y)
                {
                    result.min_y = y;
                    result.min_x = x;
                }
                result.stop_iteration++;
                x += result.accuracy;
            }
            return result;
        }
        private Result piyavsky_method()
        {
            points_chart.ChartAreas[0].AxisX.Maximum = right_range_x;
            points_chart.ChartAreas[0].AxisX.Minimum = left_range_x;
            points_chart.Series[1].Points.Clear();
            points_chart.Series[1].Points.AddXY(left_range_x, 2);
            points_chart.Series[1].Points.AddXY(right_range_x, 2);
            double x = left_range_x;
            double y = function(x);
            result.min_y = y;
            result.min_x = x;
            if (y > function(right_range_x))
            {
                result.min_y = function(right_range_x);
                result.min_x = right_range_x;
            }
            return result;
        }
        private Result strongin_method()
        {
            points_chart.ChartAreas[0].AxisX.Maximum = right_range_x;
            points_chart.ChartAreas[0].AxisX.Minimum = left_range_x;
            points_chart.Series[2].Points.Clear();
            points_chart.Series[2].Points.AddXY(left_range_x, 2);
            points_chart.Series[2].Points.AddXY(right_range_x, 2);
            double x = left_range_x;
            double y = function(x);
            result.min_y = y;
            result.min_x = x;
            if (y > function(right_range_x))
            {
                result.min_y = function(right_range_x);
                result.min_x = right_range_x;
            }
            return result;
        }


        private void run_button_Click(object sender, EventArgs e)
        {
            try
            {
                initialize_plot_parameters();
                initialize_method_parameters();
            }
            catch (System.FormatException)
            {
                return;
            }
            plot_function();
            if (trivial_radioButton.Checked)
            {
                result.method = "Brute force method";
                brute_force_method();
                result_textBox.AppendText(result.ToString());
                result_textBox.AppendText(Environment.NewLine);
            }
            else if (piyavsky_radioButton.Checked)
            {
                x_list = new double[num_of_iterations + 2];
                y_list = new double[num_of_iterations + 2];
                piyavsky_method();
            }
            else if (strongin_radioButton.Checked)
            {
                x_list = new double[num_of_iterations + 2];
                y_list = new double[num_of_iterations + 2];
                strongin_method();
            }
        }
    }
}

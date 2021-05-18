using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp8
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private double XMin = -1;
    private double XMax = 10;
    private double h = Math.PI/10;
    private double[] x;
    private double[] y;
    
    Chart chart;
    private void CalcFunction()
    {
      int count = (int)Math.Ceiling((XMax - XMin) / h) + 1;
      x = new double[count];
      y = new double[count];
      
      for (int i=0;i<count;i++)
      {
        x[i] = XMin + h * i;
        y[i] = (Math.Sqrt(4.0 + 3.0 * Math.Cos(2.0 * x[i]) * Math.Cos(2.0 * x[i])) - 1) / (Math.Pow(2.0, (1.0 + Math.Log(x[i]))) - Math.Abs(1.0 - Math.Sin(Math.Sqrt(2.0 + x[i]))));
        
      }
    }

    private void CreateChart()
    {
      chart = new Chart();
      chart.Parent = this;
      chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      area.AxisX.Minimum = XMin;
      area.AxisX.Maximum = XMax;
      area.AxisX.MajorGrid.Interval = h;
      chart.ChartAreas.Add(area);

      Series series1 = new Series();
      series1.ChartArea = "myGraph";
      series1.ChartType = SeriesChartType.Spline;
      series1.BorderWidth = 3;
   
      chart.Series.Add(series1);

      
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      CreateChart();
      CalcFunction();
      chart.Series[0].Points.DataBindXY(x, y);
      
    }
  }
}

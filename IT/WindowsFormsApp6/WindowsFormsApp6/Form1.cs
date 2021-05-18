using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    //Вариант 3. Найти произведение элементов массива с четными индексами.
    private void label1_Click(object sender, EventArgs e)
    {

    }
    int[] Mas = new int[15];
    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      textBox1.Text = "";
      for(int i=0;i<15;i++)
      {
        Mas[i] = rand.Next(-50, 50);
        textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;

      }
    }
    int p = 1;
    private void button2_Click(object sender, EventArgs e)
    {
      textBox2.Text = "";
      textBox2.Text +="Элементы массива с четными индексами:"+ Environment.NewLine;
      for (int i = 0; i < 15; i += 2)
      {
       
        textBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;

      }
      for (int i = 0; i < 15; i+=2)
      {
        p *= Mas[i];
      }
      label3.Text = "Произведение элементов массива с четными индексами = " + Convert.ToString(p);
    }
  }
}

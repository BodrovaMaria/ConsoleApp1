using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    //Вариант 3. Поменять местами в  матрице  минимальный  и  максимальный элементы.
    private void button1_Click(object sender, EventArgs e)
    {
      dataGridView1.RowCount = 5;
      dataGridView1.ColumnCount = 5;
      dataGridView2.RowCount = 5;
      dataGridView2.ColumnCount = 5;
      int[,] a = new int[5, 5];
      int i, j;
      Random rand = new Random();
      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          a[i, j] = rand.Next(-100, 100);

      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
      int min, max, imin, jmin, imax, jmax;
      min = a[0, 0];
      max = a[0, 0];
      imin = 0; jmin = 0; imax = 0; jmax = 0;
      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          if(a[i,j]<min)
          {
            min = a[i, j];
            imin = i;
            jmin = j;
          }
      
      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          if (a[i, j] >max)
          {
            max = a[i, j];
            imax = i;
            jmax = j;
          }
      
      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
      
      dataGridView2.Rows[imin].Cells[jmin].Value = Convert.ToString(max);
      dataGridView2.Rows[imax].Cells[jmax].Value = Convert.ToString(min);
    }
  }
}

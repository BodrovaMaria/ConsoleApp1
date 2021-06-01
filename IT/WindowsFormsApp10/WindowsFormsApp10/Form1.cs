using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    //Вариант 3. Разработайте программу анимации двигающегося человечка. 
    private void timer1_Tick(object sender, EventArgs e)
    {
      a += 5;
      x1 += a;
      x2 += a;
      x3 += a;
      x4 += a;
      r1 += a;
      z = a % 2;
      if(z==0)
      {
        x1 += b;
        x2 -= b;
        x4 += b;
        x3 -= b;
      }
      else
      {
        x2 += b;
        x1 -= b;
        x3 += b;
        x4 -= b;
      }
      
      Invalidate();
    }
    
    private void Form1_Load(object sender, EventArgs e)
    {
      x1 = 40; 
      y1 = 60;
      x2 = 90;
      y2 = 160;
      x3 = 90;
      y3 = 60;
      x4 = 40;
      y4 = 160;
      r1 = 40;
      r2 = 60;
      a = 0;
      b = 10;

    }
    private int x1, y1, x2, y2, x3, y3, x4, y4, r1, r2; 
    private int a, b;
    private double z;
    private Pen pen = new Pen(Color.Black, 3);
    private SolidBrush brush1 = new SolidBrush(Color.Black);
    private SolidBrush brush2 = new SolidBrush(Color.Green);
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics; 
      g.DrawLine(pen, x1, y1, x2, y2);
      g.DrawLine(pen, x3, y3, x4, y4);
      Rectangle rect = new Rectangle(r1+10, r2+10, 30, 80);
      g.FillEllipse(brush2, rect);
      Rectangle krug = new Rectangle(r1+10, r2-10, 30, 30);
      g.FillEllipse(brush1, krug);
    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
  public partial class Form1 : Form
  {

    Point[] points = new Point[50];
    Pen pen1 = new Pen(Color.GreenYellow, 2);
    Pen pen2 = new Pen(Color.Red, 6);
    Pen pen3 = new Pen(Color.Gray, 15);
    Pen pen4 = new Pen(Color.Green, 2);
    SolidBrush b1 = new SolidBrush(Color.MediumVioletRed);
    SolidBrush b2 = new SolidBrush(Color.Orange);
    SolidBrush b3 = new SolidBrush(Color.Black);
    Rectangle rect = new Rectangle(200, 200, 200, 200);
    Point[] mn = new Point[8];
    
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.DrawLine(pen1, 0,500, 40, 200);
      g.DrawRectangle(pen2, 40, 80, 40, 120);
      Region reg = new Region(rect);
      g.FillRegion(b1, reg);
      g.DrawPolygon(pen3, points);
      g.DrawEllipse(pen4, rect);
      g.FillPie(b2, rect, 30, 60);
      
      g.FillPolygon(b3, mn);


    }
    public void MN()
    {
      mn[0] = new Point(25, 25);
      mn[1] = new Point(25, 30);
      mn[2] = new Point(40, 30);
      mn[3] = new Point(40, 55);
      mn[4] = new Point(60, 55);
      mn[5] = new Point(60, 30);
      mn[6] = new Point(75, 30);
      mn[7] = new Point(75, 25);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      for(int i=0; i<20;i++)
      {
        int xPos;
        
          xPos = 200;
        
        points[i] = new Point(xPos, 10 * i);
      }
      MN();
    }
  }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TS = Tekla.Structures;
using TSD = Tekla.Structures.Drawing;
using TSG = Tekla.Structures.Geometry3d;

namespace unfolding
	
{
	public partial class MainForm : Form
	{
		
		
		public MainForm()
		{
			InitializeComponent();
			
			diameterTextBox.Text = "2720";
			thicknessTextBox.Text="10";
			chamferTopComboBox.SelectedItem = "Internal";
			chamferBotComboBox.SelectedItem = "Internal";
			angleTrimTextBox.Text = "22,5";
			angleRotateTextBox.Text = "90";
			angleSectorTextBox.Text = "359,958";
			nPartTextBox.Text = "96";
		
		}
		
		
		
		void ButtonDoClick(object sender, EventArgs e)
		{
			TSD.DrawingHandler drawingHandler = new TSD.DrawingHandler();
			
			TSD.UI.Picker picker = drawingHandler.GetPicker();
			
			TSG.Point point1 = null;
			TSG.Point point2 = null;
			TSG.Point point3 = null;
			TSD.ViewBase view = null;
			
			Shell shell = null;
			
			try
			{
				shell = new Shell(Convert.ToDouble(diameterTextBox.Text), Convert.ToDouble(thicknessTextBox.Text), chamferTopComboBox.SelectedItem.ToString(), chamferBotComboBox.SelectedItem.ToString(), Convert.ToDouble(angleTrimTextBox.Text), Convert.ToDouble(angleRotateTextBox.Text), Convert.ToDouble(angleSectorTextBox.Text), Convert.ToInt32(nPartTextBox.Text));
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			if (shell != null)
			{
				try
				{
					picker.PickThreePoints("1st poit", "2nd point", "3rd point", out point1, out point2, out point3, out view);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				
				
				double angleP2 = GetAngle(new TSG.Point((point2.X - point1.X), (point2.Y - point1.Y)));
				double angleP3 = GetAngle(new TSG.Point(((point3.X - point1.X)*Math.Cos(-angleP2) - (point3.Y - point1.Y)*Math.Sin(-angleP2)), ((point3.X - point1.X)*Math.Sin(-angleP2) + (point3.Y - point1.Y)*Math.Cos(-angleP2))));
				
				int kof = ( (angleP3 >= 0) && (angleP3 < Math.PI) ) ? -1 : 1;
				
				double lArc = (shell.diameter/2 - shell.thickness/2) * shell.angleSector;
				
				for (int i = 0; i < shell.arrLine.Length; i++)
				{
					TSG.Point p1 = new TSG.Point( (point1.X + (i*lArc/shell.nPart)*Math.Cos(angleP2)) , (point1.Y + (i*lArc/shell.nPart)*Math.Sin(angleP2)) );
					TSG.Point p2 = new TSG.Point( (point1.X + i*lArc/shell.nPart*Math.Cos(angleP2) + kof*shell.arrLine[i]*Math.Sin(angleP2) ) , (point1.Y + i*lArc/shell.nPart*Math.Sin(angleP2) - kof*shell.arrLine[i]*Math.Cos(angleP2)));;
					
					TSD.Text.TextAttributes txtAtributes = new TSD.Text.TextAttributes();
					txtAtributes.Angle = angleP2*180/Math.PI + 90;
					
					string dimText = (Math.Round(shell.arrLine[i]).ToString());
					TSD.Text dim = new TSD.Text(view, p1, dimText, txtAtributes);
					dim.Insert();
					
					TSD.Line line = new TSD.Line(view, p1, p2);
					line.Insert();

					
					
				}
				
				
				
				TSD.Line line2 = new TSD.Line(view, point1, new TSG.Point((point1.X + lArc*Math.Cos(angleP2)) , (point1.Y + lArc*Math.Sin(angleP2))));
				line2.Insert();
				
				
			}
		}
		
		double GetAngle(TSG.Point point)
		{
			double ang = 0;
			
			if ( point.Y == 0 && point.X > 0 ) return 0;
			if ( point.Y == 0 && point.X < 0 ) return Math.PI/2;
			if ( point.X >= 0 && point.Y > 0 ) return Math.Atan( point.Y / point.X );
			if ( point.X >= 0 && point.Y < 0 ) return Math.PI*2 - Math.Abs(Math.Atan(point.Y/point.X));
			if ( point.X < 0 && point.Y < 0 ) return Math.PI + Math.Abs(Math.Atan(point.Y/point.X));
			if ( point.X < 0 && point.Y < 0 ) return Math.PI - Math.Abs(Math.Atan(point.Y/point.X));

			return ang;
		}
	}
	
	
	
	public class Shell
	{
		public double diameter;
		public double thickness;
		public string chamferTop;
		public string chamferBot;
		public double angleTrim;
		public double angleRotate;
		public double angleSector;
		public int nPart;
		public List<double> lines;
		public double[] arrLine;
		
		public Shell(double diameter, double thickness, string chamferTop, string chamferBot, double angleTrim, double angleRotate, double angleSector, int nPart)
		{
			this.diameter = diameter;
			this.thickness = thickness;
			this.chamferTop = chamferTop;
			this.chamferBot = chamferBot;
			this.angleTrim = angleTrim * Math.PI/180;
			this.angleRotate = angleRotate * Math.PI/180;
			this.angleSector = angleSector * Math.PI/180;
			this.nPart = nPart;
			double a;
			double a_l;
			double l;
			lines = new List<double>();
			arrLine = new double[nPart+1];
			
			for (int i = 0; i < nPart+1; i++) 
			{
				a = this.angleRotate + i * (this.angleSector / nPart);
				a_l = Math.Atan( Math.Cos(a) * Math.Tan(this.angleTrim) );
				l = ( (this.diameter/2 - this.thickness/2) * Math.Tan(a_l) );
				if (a > 2*Math.PI)
				{
					a -= 2*Math.PI;
				}
				
				if ( (a >= 1.5*Math.PI && a <= 2*Math.PI) || (a >= 0 && a <= 0.5*Math.PI) )
				{
					if (chamferTop.Equals("Internal"))
					{
						l = l - (this.thickness/2)*Math.Abs(Math.Tan(a_l));
					}
					else
					{
						l = l + (this.thickness/2)*Math.Abs(Math.Tan(a_l));
					}
				}
				else
				{
					if (chamferBot.Equals("Internal"))
					{
						l = l + (this.thickness/2)*Math.Abs(Math.Tan(a_l));
					}
					else
					{
						l = l - (this.thickness/2)*Math.Abs(Math.Tan(a_l));
					}
				}
				
				this.arrLine[i] = l;
				this.lines.Add(l);
			}
			
			double lMin =  this.arrLine[0];
			
			foreach (double el in this.arrLine)
			{
				if (el < lMin)
				{
					lMin = el;
				}
			}
			
			for (int i = 0; i < this.arrLine.Length; i++)
			{
				this.arrLine[i] = this.arrLine[i] - lMin;
			}
		}
	}
}

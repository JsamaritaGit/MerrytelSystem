/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 10/21/2021
 * Time: 10:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MerrytelSystem
{

	public partial class UserControl1 : UserControl
	{
		private Color borderColor = Color.MediumSlateBlue;
		private int borderSize = 2;
		private bool underlinedStyle = true;
		private int borderRadius = 0;
		
		
		public UserControl1()
		{
			
			InitializeComponent();
			
		}
		
		public int BorderRadius
		{
			get{
				return borderRadius;
			}
			set{
				if(value>=0){
					borderRadius = value;
					this.Invalidate();
				}
				
			}
		}
		public string Texts
		{
			get{
				return textBox1.Text;
			}
			set{
				textBox1.Text = value;
			}
		}
 
		public override Color ForeColor {
			get {
				return base.ForeColor;
			}
			set {
				base.ForeColor = value;
				textBox1.ForeColor = value;
			}
		}
		public override Color BackColor
		{
			get{
				return base.BackColor;
			}
			set{
				base.BackColor = value;
				textBox1.BackColor = value;
			}
		}
		public override Font Font {
			get {
				return base.Font;
			}
			set {
				base.Font = value;
				textBox1.Font = value;
				if(this.DesignMode)
					UpdateControlHeight();
			}
		}
		
		public Color BorderColor
		{
			get{
				return borderColor;
			}
			set{
				borderColor = value;
				this.Invalidate();
			}
		}
		public int BorderSize
		{
			get{
				return borderSize;
			}
			set{
				borderSize = value;
				this.Invalidate();
			}
		}
		public bool UnderlinedStyle
		{
			get{
				return underlinedStyle;
			}
			set{
				underlinedStyle = value;
				this.Invalidate();
			}
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graph = e.Graphics;
			
			using (Pen penBorder = new Pen(BorderColor, BorderSize)) {
				penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
				
				if(underlinedStyle)
					graph.DrawLine(penBorder,0,this.Height-1, this.Width, this.Height -1);
				else
					graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
				
			}
		}
		
//		private GraphicsPath GetFigurePath(Rectangle rect, int Radius)
//		{
//			GraphicsPath path = new GraphicsPath();
//			float curveSize = Radius * 2f;
//			
//			path.StartFigure();
//			path.addArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
//			path.addArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
//			path.addArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, 0, 90);
//			path.addArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
//			path.CloseFigure();
//			return path;
//		}
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.DesignMode)
				UpdateControlHeight();
			
		}
		
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			UpdateControlHeight();
		}
		
		private void UpdateControlHeight()
		{
			//throw new NotImplementedException();
			if(textBox1.Multiline == false){
				int textHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
				textBox1.Multiline = true;
				textBox1.MinimumSize = new  Size(0,textHeight);
				textBox1.Multiline = false;
				
				//this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
				this.Height = textBox1.Height;
			}	   
		}
	}
}

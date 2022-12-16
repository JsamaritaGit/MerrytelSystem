/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 10/22/2021
 * Time: 3:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MerrytelSystem
{
	
	
	public partial class UserLabel : UserControl
	{
		
		private Color borderColor = Color.Aquamarine;
		private int borderSize = 2;
		private bool underlinedStyle = false;
		
		public UserLabel()
		{
			InitializeComponent();
			
		}
		
		public String Captions{
			set{
				label1.Text = value;
			}
			get{
				return label1.Text;
			}
		}
		
		public override Color ForeColor {
			get {
				return base.ForeColor;
			}
			set {
				base.ForeColor = value;
				label1.ForeColor = value;
			}
		}
		public override Color BackColor
		{
			get{
				return base.BackColor;
			}
			set{
				base.BackColor = value;
				label1.BackColor = value;
			}
		}
		public override Font Font {
			get {
				return base.Font;
			}
			set {
				base.Font = value;
				label1.Font = value;
				//if(this.DesignMode)
					//UpdateControlHeight();
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
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			//if (this.DesignMode)
				//UpdateControlHeight();
			
		}
		
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			//UpdateControlHeight();
		}
		
		

	}
}

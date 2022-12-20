/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 10/21/2021
 * Time: 5:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace MerrytelSystem
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		
		 
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
		private Form activeForm;
        public Point mouseLocation;
        public MainForm()
		{
			InitializeComponent();

			StartTimer();
				
		}
		
		private void OpenChildForm(Form childForm, object btnSender)
		{
			if(activeForm != null)
			{
				activeForm.Close();	
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.FormPanel.Controls.Add(childForm);
			this.FormPanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		
		void BtnEmployeeClick(object sender, EventArgs e)
		{		
			OpenChildForm(new frmEmployee(), sender);

			
		}
		void BtnProjectSitesClick(object sender, EventArgs e)
		{
			OpenChildForm(new frmMasterTracker(), sender);

		}
		void BtnMaterialsClick(object sender, EventArgs e)
		{
			//OpenChildForm(new frmMaterials(), sender);
			int left = this.DesktopLocation.X;	
			int top = this.DesktopLocation.Y;
			frmMaterials fm = new frmMaterials();
			fm.Location = new Point(left + 105, top + 50);
			fm.ShowDialog();
		}
		
		private void StartTimer()
		{
			Timer t = null;
		    t = new System.Windows.Forms.Timer();
		    t.Interval = 1000;
		    t.Tick += new EventHandler(Timer1Tick);
		    t.Enabled = true;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToShortTimeString();
		}
		
		public void ChangeColor(){
			btnEmployee.BackColor = Color.Transparent;
			btnMaterials.BackColor = Color.Transparent;
			btnTracker.BackColor = Color.Transparent;
		}
		void Button1Click(object sender, EventArgs e)
		{
			int left = this.DesktopLocation.X;	
			int top = this.DesktopLocation.Y;
			frmMaterialRequest fmr = new frmMaterialRequest();
			fmr.Location = new Point(left + 105, top + 50);
			fmr.ShowDialog();
		}
		void OSPMaterialToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmOSPMaterial frmOSPM = new frmOSPMaterial();
			frmOSPM.ShowDialog();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void CurveThis(Panel panel)
		{
			panel.BorderStyle = BorderStyle.None;
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 40, 40));
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmPO(), sender);
		}

		private void btnMaterials_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmMaterialRequest(), sender);
        }

        private void btnProjectSite_Click(object sender, EventArgs e)
        {
			OpenChildForm(new frmProjectSite(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }

        }
        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
    }
}

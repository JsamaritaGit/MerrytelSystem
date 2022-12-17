/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 10/21/2021
 * Time: 5:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MerrytelSystem
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnProjectSites;
		private System.Windows.Forms.Button btnEmployee;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMaterials;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelExit;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnProjectSites = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.panelExit = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMaterials);
            this.panel1.Controls.Add(this.btnProjectSites);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 724);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(0, 344);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 79);
            this.button3.TabIndex = 22;
            this.button3.Text = "SCO";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 79);
            this.button1.TabIndex = 21;
            this.button1.Text = "MR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.Transparent;
            this.btnMaterials.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaterials.BackgroundImage")));
            this.btnMaterials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterials.FlatAppearance.BorderSize = 0;
            this.btnMaterials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterials.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterials.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMaterials.Location = new System.Drawing.Point(0, 186);
            this.btnMaterials.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(93, 79);
            this.btnMaterials.TabIndex = 20;
            this.btnMaterials.Text = "Materials";
            this.btnMaterials.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaterials.UseVisualStyleBackColor = false;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnProjectSites
            // 
            this.btnProjectSites.BackColor = System.Drawing.Color.Transparent;
            this.btnProjectSites.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProjectSites.BackgroundImage")));
            this.btnProjectSites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProjectSites.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjectSites.FlatAppearance.BorderSize = 0;
            this.btnProjectSites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnProjectSites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectSites.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectSites.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnProjectSites.Location = new System.Drawing.Point(0, 107);
            this.btnProjectSites.Margin = new System.Windows.Forms.Padding(4);
            this.btnProjectSites.Name = "btnProjectSites";
            this.btnProjectSites.Size = new System.Drawing.Size(93, 79);
            this.btnProjectSites.TabIndex = 18;
            this.btnProjectSites.Text = "Sites";
            this.btnProjectSites.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProjectSites.UseVisualStyleBackColor = false;
            this.btnProjectSites.Click += new System.EventHandler(this.BtnProjectSitesClick);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployee.BackgroundImage")));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEmployee.Location = new System.Drawing.Point(0, 28);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(93, 79);
            this.btnEmployee.TabIndex = 19;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.BtnEmployeeClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 28);
            this.panel3.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.panelExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1115, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(248, 724);
            this.panel2.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Honeydew;
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTime.Location = new System.Drawing.Point(5, 689);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(243, 35);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "12:34";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.Transparent;
            this.panelExit.Controls.Add(this.button2);
            this.panelExit.Controls.Add(this.btnClose);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExit.Location = new System.Drawing.Point(5, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(243, 28);
            this.panelExit.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(167, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 28);
            this.button2.TabIndex = 9;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(205, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.SystemColors.Window;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(93, 0);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1022, 724);
            this.FormPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1364, 726);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1364, 726);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 1, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MerryTel";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelExit.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Panel FormPanel;
	}
}

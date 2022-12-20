/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 1/24/2022
 * Time: 7:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MerrytelSystem
{
	partial class formAdd
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textSiteName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textSiteID;
		private System.Windows.Forms.TextBox textNAP;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textLCP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textLines;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textStatus;
		private System.Windows.Forms.Panel panelExit;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ComboBox cmbBrgy;
		private System.Windows.Forms.ComboBox cmbMunicipality;
		private System.Windows.Forms.Panel panelActionButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label label1;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelActionButton = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.cmbBrgy = new System.Windows.Forms.ComboBox();
            this.cmbMunicipality = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textLines = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNAP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textLCP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSiteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSiteID = new System.Windows.Forms.TextBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelActionButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panelActionButton);
            this.panel1.Controls.Add(this.cmbBrgy);
            this.panel1.Controls.Add(this.cmbMunicipality);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textStatus);
            this.panel1.Controls.Add(this.textLines);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textNAP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textLCP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textSiteName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textSiteID);
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 372);
            this.panel1.TabIndex = 0;
            // 
            // panelActionButton
            // 
            this.panelActionButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelActionButton.Controls.Add(this.button2);
            this.panelActionButton.Controls.Add(this.buttonUpdate);
            this.panelActionButton.Controls.Add(this.buttonEdit);
            this.panelActionButton.Location = new System.Drawing.Point(663, 321);
            this.panelActionButton.Name = "panelActionButton";
            this.panelActionButton.Size = new System.Drawing.Size(155, 43);
            this.panelActionButton.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(11, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 43);
            this.button2.TabIndex = 19;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUpdate.Location = new System.Drawing.Point(59, 0);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(48, 43);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEdit.BackgroundImage")));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.Location = new System.Drawing.Point(107, 0);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(48, 43);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // cmbBrgy
            // 
            this.cmbBrgy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBrgy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBrgy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrgy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbBrgy.FormattingEnabled = true;
            this.cmbBrgy.ItemHeight = 18;
            this.cmbBrgy.Location = new System.Drawing.Point(284, 42);
            this.cmbBrgy.Name = "cmbBrgy";
            this.cmbBrgy.Size = new System.Drawing.Size(263, 26);
            this.cmbBrgy.TabIndex = 2;
            this.cmbBrgy.SelectedIndexChanged += new System.EventHandler(this.CmbBrgySelectedIndexChanged);
            // 
            // cmbMunicipality
            // 
            this.cmbMunicipality.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMunicipality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMunicipality.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipality.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMunicipality.FormattingEnabled = true;
            this.cmbMunicipality.ItemHeight = 18;
            this.cmbMunicipality.Location = new System.Drawing.Point(14, 42);
            this.cmbMunicipality.Name = "cmbMunicipality";
            this.cmbMunicipality.Size = new System.Drawing.Size(263, 26);
            this.cmbMunicipality.TabIndex = 1;
            this.cmbMunicipality.SelectedIndexChanged += new System.EventHandler(this.CmbMunicipalitySelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Status";
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textStatus.Location = new System.Drawing.Point(13, 209);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(805, 93);
            this.textStatus.TabIndex = 8;
            // 
            // textLines
            // 
            this.textLines.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLines.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLines.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textLines.Location = new System.Drawing.Point(457, 144);
            this.textLines.Name = "textLines";
            this.textLines.Size = new System.Drawing.Size(111, 26);
            this.textLines.TabIndex = 7;
            this.textLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(378, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 30);
            this.label8.TabIndex = 24;
            this.label8.Text = "Lines";
            // 
            // textNAP
            // 
            this.textNAP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textNAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNAP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNAP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNAP.Location = new System.Drawing.Point(267, 145);
            this.textNAP.Name = "textNAP";
            this.textNAP.Size = new System.Drawing.Size(81, 26);
            this.textNAP.TabIndex = 6;
            this.textNAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(186, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "NAP";
            this.label7.Click += new System.EventHandler(this.Label7Click);
            // 
            // textLCP
            // 
            this.textLCP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLCP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLCP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textLCP.Location = new System.Drawing.Point(74, 144);
            this.textLCP.Name = "textLCP";
            this.textLCP.Size = new System.Drawing.Size(77, 26);
            this.textLCP.TabIndex = 5;
            this.textLCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "LCP";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mucipality";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(283, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Barangay";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Site Name";
            // 
            // textSiteName
            // 
            this.textSiteName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSiteName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSiteName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSiteName.Location = new System.Drawing.Point(13, 106);
            this.textSiteName.Name = "textSiteName";
            this.textSiteName.Size = new System.Drawing.Size(805, 26);
            this.textSiteName.TabIndex = 4;
            this.textSiteName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(553, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Site ID";
            // 
            // textSiteID
            // 
            this.textSiteID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSiteID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSiteID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSiteID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSiteID.Location = new System.Drawing.Point(557, 42);
            this.textSiteID.Name = "textSiteID";
            this.textSiteID.Size = new System.Drawing.Size(261, 26);
            this.textSiteID.TabIndex = 3;
            this.textSiteID.Text = "-";
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.Transparent;
            this.panelExit.Location = new System.Drawing.Point(824, 1);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(26, 28);
            this.panelExit.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(811, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Site";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(838, 407);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelActionButton.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}

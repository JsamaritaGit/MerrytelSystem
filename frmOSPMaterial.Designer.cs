/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 2/1/2022
 * Time: 4:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MerrytelSystem
{
	partial class frmOSPMaterial
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelTable;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbUOM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxItemVariant;
		private System.Windows.Forms.TextBox textBoxItemCode;
		private System.Windows.Forms.Panel panelActionButton;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Panel panelExit;
		private System.Windows.Forms.Button btnClose;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOSPMaterial));
			this.panelTable = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelActionButton = new System.Windows.Forms.Panel();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxItemVariant = new System.Windows.Forms.TextBox();
			this.textBoxItemCode = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbUOM = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelExit = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panelActionButton.SuspendLayout();
			this.panelExit.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTable
			// 
			this.panelTable.Controls.Add(this.dataGridView1);
			this.panelTable.Location = new System.Drawing.Point(0, 260);
			this.panelTable.Name = "panelTable";
			this.panelTable.Size = new System.Drawing.Size(803, 329);
			this.panelTable.TabIndex = 12;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 34;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.GridColor = System.Drawing.Color.Teal;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.RowTemplate.Height = 32;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(803, 329);
			this.dataGridView1.TabIndex = 23;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel3.Controls.Add(this.panelActionButton);
			this.panel3.Controls.Add(this.textBoxItemVariant);
			this.panel3.Controls.Add(this.textBoxItemCode);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.cmbUOM);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(806, 256);
			this.panel3.TabIndex = 9;
			// 
			// panelActionButton
			// 
			this.panelActionButton.BackColor = System.Drawing.Color.Teal;
			this.panelActionButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelActionButton.Controls.Add(this.buttonAdd);
			this.panelActionButton.Controls.Add(this.buttonUpdate);
			this.panelActionButton.Controls.Add(this.buttonEdit);
			this.panelActionButton.Controls.Add(this.buttonDelete);
			this.panelActionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelActionButton.Location = new System.Drawing.Point(0, 177);
			this.panelActionButton.Name = "panelActionButton";
			this.panelActionButton.Padding = new System.Windows.Forms.Padding(2);
			this.panelActionButton.Size = new System.Drawing.Size(806, 79);
			this.panelActionButton.TabIndex = 13;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
			this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
			this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAdd.Location = new System.Drawing.Point(450, 2);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 73);
			this.buttonAdd.TabIndex = 17;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
			this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
			this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonUpdate.Enabled = false;
			this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
			this.buttonUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonUpdate.Location = new System.Drawing.Point(538, 2);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(88, 73);
			this.buttonUpdate.TabIndex = 16;
			this.buttonUpdate.Text = "Confirm";
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
			this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
			this.buttonEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdit.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonEdit.Location = new System.Drawing.Point(626, 2);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(88, 73);
			this.buttonEdit.TabIndex = 15;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonEdit.UseVisualStyleBackColor = false;
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
			this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
			this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
			this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonDelete.Location = new System.Drawing.Point(714, 2);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(88, 73);
			this.buttonDelete.TabIndex = 12;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// textBoxItemVariant
			// 
			this.textBoxItemVariant.Enabled = false;
			this.textBoxItemVariant.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxItemVariant.Location = new System.Drawing.Point(89, 123);
			this.textBoxItemVariant.Name = "textBoxItemVariant";
			this.textBoxItemVariant.Size = new System.Drawing.Size(567, 27);
			this.textBoxItemVariant.TabIndex = 9;
			// 
			// textBoxItemCode
			// 
			this.textBoxItemCode.Enabled = false;
			this.textBoxItemCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxItemCode.Location = new System.Drawing.Point(90, 52);
			this.textBoxItemCode.Name = "textBoxItemCode";
			this.textBoxItemCode.Size = new System.Drawing.Size(350, 27);
			this.textBoxItemCode.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.OrangeRed;
			this.label4.Location = new System.Drawing.Point(89, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(272, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Item Variant Description";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.OrangeRed;
			this.label2.Location = new System.Drawing.Point(556, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "UOM";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// cmbUOM
			// 
			this.cmbUOM.BackColor = System.Drawing.Color.Honeydew;
			this.cmbUOM.Enabled = false;
			this.cmbUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbUOM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbUOM.ForeColor = System.Drawing.SystemColors.Desktop;
			this.cmbUOM.FormattingEnabled = true;
			this.cmbUOM.Items.AddRange(new object[] {
			"PC",
			"MTR"});
			this.cmbUOM.Location = new System.Drawing.Point(556, 52);
			this.cmbUOM.Name = "cmbUOM";
			this.cmbUOM.Size = new System.Drawing.Size(100, 27);
			this.cmbUOM.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.OrangeRed;
			this.label1.Location = new System.Drawing.Point(90, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Item Code";
			// 
			// panelExit
			// 
			this.panelExit.BackColor = System.Drawing.Color.Transparent;
			this.panelExit.Controls.Add(this.btnClose);
			this.panelExit.Location = new System.Drawing.Point(766, 595);
			this.panelExit.Name = "panelExit";
			this.panelExit.Size = new System.Drawing.Size(26, 28);
			this.panelExit.TabIndex = 15;
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
			this.btnClose.Location = new System.Drawing.Point(0, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(26, 28);
			this.btnClose.TabIndex = 8;
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// frmOSPMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(804, 631);
			this.Controls.Add(this.panelExit);
			this.Controls.Add(this.panelTable);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(507, 78);
			this.MaximumSize = new System.Drawing.Size(804, 631);
			this.MinimumSize = new System.Drawing.Size(804, 631);
			this.Name = "frmOSPMaterial";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "OSP Material";
			this.Load += new System.EventHandler(this.FrmOSPMaterialLoad);
			this.panelTable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panelActionButton.ResumeLayout(false);
			this.panelExit.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

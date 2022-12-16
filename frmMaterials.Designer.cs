/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 11/19/2021
 * Time: 2:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MerrytelSystem
{
	partial class frmMaterials
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelTable;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbPosition;
		private System.Windows.Forms.Panel panelActionButton;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panelExit;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTitleWindow;
		private System.Windows.Forms.ComboBox cmbTeam;
		private System.Windows.Forms.ComboBox cmbSite;
		private System.Windows.Forms.ComboBox cmbItem;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label label3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterials));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelTable = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbPosition = new System.Windows.Forms.ComboBox();
			this.panelActionButton = new System.Windows.Forms.Panel();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panelExit = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.cmbItem = new System.Windows.Forms.ComboBox();
			this.cmbSite = new System.Windows.Forms.ComboBox();
			this.cmbTeam = new System.Windows.Forms.ComboBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTitleWindow = new System.Windows.Forms.Label();
			this.panelTable.SuspendLayout();
			this.panelActionButton.SuspendLayout();
			this.panelExit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTable
			// 
			this.panelTable.BackColor = System.Drawing.SystemColors.HighlightText;
			this.panelTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTable.Controls.Add(this.label8);
			this.panelTable.Controls.Add(this.cmbPosition);
			this.panelTable.Controls.Add(this.panelActionButton);
			this.panelTable.Controls.Add(this.textBoxSearch);
			this.panelTable.Controls.Add(this.label9);
			this.panelTable.Controls.Add(this.panelExit);
			this.panelTable.Controls.Add(this.dataGridView1);
			this.panelTable.Controls.Add(this.panel3);
			this.panelTable.Controls.Add(this.lblTitleWindow);
			this.panelTable.Location = new System.Drawing.Point(0, 0);
			this.panelTable.Name = "panelTable";
			this.panelTable.Size = new System.Drawing.Size(983, 431);
			this.panelTable.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label8.Location = new System.Drawing.Point(306, 401);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 23);
			this.label8.TabIndex = 31;
			this.label8.Text = "Filter";
			// 
			// cmbPosition
			// 
			this.cmbPosition.BackColor = System.Drawing.Color.DarkSlateGray;
			this.cmbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbPosition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPosition.ForeColor = System.Drawing.SystemColors.Menu;
			this.cmbPosition.FormattingEnabled = true;
			this.cmbPosition.ItemHeight = 21;
			this.cmbPosition.Location = new System.Drawing.Point(378, 396);
			this.cmbPosition.Name = "cmbPosition";
			this.cmbPosition.Size = new System.Drawing.Size(177, 29);
			this.cmbPosition.TabIndex = 30;
			// 
			// panelActionButton
			// 
			this.panelActionButton.BackColor = System.Drawing.SystemColors.MenuBar;
			this.panelActionButton.Controls.Add(this.buttonAdd);
			this.panelActionButton.Controls.Add(this.buttonUpdate);
			this.panelActionButton.Controls.Add(this.buttonEdit);
			this.panelActionButton.Controls.Add(this.buttonDelete);
			this.panelActionButton.Location = new System.Drawing.Point(634, 381);
			this.panelActionButton.Name = "panelActionButton";
			this.panelActionButton.Size = new System.Drawing.Size(342, 43);
			this.panelActionButton.TabIndex = 23;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.Silver;
			this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
			this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonAdd.Location = new System.Drawing.Point(7, 0);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
			this.buttonAdd.Size = new System.Drawing.Size(80, 43);
			this.buttonAdd.TabIndex = 17;
			this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.BackColor = System.Drawing.Color.Silver;
			this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
			this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonUpdate.Enabled = false;
			this.buttonUpdate.FlatAppearance.BorderSize = 0;
			this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonUpdate.Location = new System.Drawing.Point(87, 0);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(85, 43);
			this.buttonUpdate.TabIndex = 16;
			this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonUpdate.UseVisualStyleBackColor = false;
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.Color.Silver;
			this.buttonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEdit.BackgroundImage")));
			this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdit.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonEdit.Location = new System.Drawing.Point(172, 0);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(85, 43);
			this.buttonEdit.TabIndex = 15;
			this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonEdit.UseVisualStyleBackColor = false;
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.Silver;
			this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
			this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonDelete.Location = new System.Drawing.Point(257, 0);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(85, 43);
			this.buttonDelete.TabIndex = 12;
			this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.DarkSlateGray;
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.ForeColor = System.Drawing.SystemColors.Menu;
			this.textBoxSearch.Location = new System.Drawing.Point(87, 397);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(213, 27);
			this.textBoxSearch.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label9.Location = new System.Drawing.Point(6, 398);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(146, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "search";
			// 
			// panelExit
			// 
			this.panelExit.BackColor = System.Drawing.Color.Transparent;
			this.panelExit.Controls.Add(this.btnClose);
			this.panelExit.Location = new System.Drawing.Point(952, 3);
			this.panelExit.Name = "panelExit";
			this.panelExit.Size = new System.Drawing.Size(24, 24);
			this.panelExit.TabIndex = 14;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
			this.btnClose.Location = new System.Drawing.Point(0, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(24, 24);
			this.btnClose.TabIndex = 8;
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.ColumnHeadersHeight = 40;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(6, 34);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView1.RowTemplate.Height = 32;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(622, 356);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txtQuantity);
			this.panel3.Controls.Add(this.cmbItem);
			this.panel3.Controls.Add(this.cmbSite);
			this.panel3.Controls.Add(this.cmbTeam);
			this.panel3.Controls.Add(this.txtID);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(634, 34);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(342, 342);
			this.panel3.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.OrangeRed;
			this.label3.Location = new System.Drawing.Point(64, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 23);
			this.label3.TabIndex = 43;
			this.label3.Text = "Quantity";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtQuantity
			// 
			this.txtQuantity.BackColor = System.Drawing.Color.DarkSlateGray;
			this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantity.ForeColor = System.Drawing.SystemColors.Menu;
			this.txtQuantity.Location = new System.Drawing.Point(64, 286);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(225, 27);
			this.txtQuantity.TabIndex = 5;
			this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmbItem
			// 
			this.cmbItem.BackColor = System.Drawing.Color.DarkSlateGray;
			this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbItem.ForeColor = System.Drawing.SystemColors.Menu;
			this.cmbItem.FormattingEnabled = true;
			this.cmbItem.Location = new System.Drawing.Point(64, 208);
			this.cmbItem.Name = "cmbItem";
			this.cmbItem.Size = new System.Drawing.Size(225, 29);
			this.cmbItem.TabIndex = 4;
			// 
			// cmbSite
			// 
			this.cmbSite.BackColor = System.Drawing.Color.DarkSlateGray;
			this.cmbSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbSite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSite.ForeColor = System.Drawing.SystemColors.Menu;
			this.cmbSite.FormattingEnabled = true;
			this.cmbSite.Location = new System.Drawing.Point(64, 133);
			this.cmbSite.Name = "cmbSite";
			this.cmbSite.Size = new System.Drawing.Size(225, 29);
			this.cmbSite.TabIndex = 3;
			// 
			// cmbTeam
			// 
			this.cmbTeam.BackColor = System.Drawing.Color.DarkSlateGray;
			this.cmbTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbTeam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTeam.ForeColor = System.Drawing.SystemColors.Menu;
			this.cmbTeam.FormattingEnabled = true;
			this.cmbTeam.Location = new System.Drawing.Point(64, 68);
			this.cmbTeam.Name = "cmbTeam";
			this.cmbTeam.Size = new System.Drawing.Size(225, 29);
			this.cmbTeam.TabIndex = 2;
			// 
			// txtID
			// 
			this.txtID.BackColor = System.Drawing.Color.DarkSlateGray;
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.ForeColor = System.Drawing.SystemColors.Menu;
			this.txtID.Location = new System.Drawing.Point(5, 4);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(225, 27);
			this.txtID.TabIndex = 42;
			this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtID.Visible = false;
			this.txtID.TextChanged += new System.EventHandler(this.TxtIDTextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.OrangeRed;
			this.label2.Location = new System.Drawing.Point(64, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(225, 23);
			this.label2.TabIndex = 39;
			this.label2.Text = "Item";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.OrangeRed;
			this.label1.Location = new System.Drawing.Point(64, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(225, 23);
			this.label1.TabIndex = 35;
			this.label1.Text = "Site";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.OrangeRed;
			this.label5.Location = new System.Drawing.Point(64, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(225, 23);
			this.label5.TabIndex = 33;
			this.label5.Text = "Team";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTitleWindow
			// 
			this.lblTitleWindow.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleWindow.ForeColor = System.Drawing.Color.Black;
			this.lblTitleWindow.Image = ((System.Drawing.Image)(resources.GetObject("lblTitleWindow.Image")));
			this.lblTitleWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTitleWindow.Location = new System.Drawing.Point(6, 4);
			this.lblTitleWindow.Name = "lblTitleWindow";
			this.lblTitleWindow.Size = new System.Drawing.Size(970, 23);
			this.lblTitleWindow.TabIndex = 15;
			this.lblTitleWindow.Text = "MATERIAL TRACKER";
			this.lblTitleWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmMaterials
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(983, 431);
			this.Controls.Add(this.panelTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(105, 50);
			this.MaximumSize = new System.Drawing.Size(983, 431);
			this.MinimumSize = new System.Drawing.Size(983, 431);
			this.Name = "frmMaterials";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmMaterials";
			this.Load += new System.EventHandler(this.FrmMaterialsLoad);
			this.panelTable.ResumeLayout(false);
			this.panelTable.PerformLayout();
			this.panelActionButton.ResumeLayout(false);
			this.panelExit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

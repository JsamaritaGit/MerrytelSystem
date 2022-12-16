/*
 * Created by SharpDevelop.
 * User: Jonas
 * Date: 3/1/2022
 * Time: 12:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MerrytelSystem
{
	partial class frmEmployee
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
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelTable = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbPosition = new System.Windows.Forms.ComboBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.panelActionButton = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.txtMiddlename = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.lblTitleWindow = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panelTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelActionButton.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTable
			// 
			this.panelTable.BackColor = System.Drawing.Color.Silver;
			this.panelTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTable.Controls.Add(this.splitContainer1);
			this.panelTable.Controls.Add(this.lblTitleWindow);
			this.panelTable.Location = new System.Drawing.Point(0, 0);
			this.panelTable.Name = "panelTable";
			this.panelTable.Size = new System.Drawing.Size(1023, 723);
			this.panelTable.TabIndex = 13;
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Snow;
			this.splitContainer1.Location = new System.Drawing.Point(2, 45);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
			this.splitContainer1.Panel1.Controls.Add(this.label8);
			this.splitContainer1.Panel1.Controls.Add(this.cmbPosition);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxSearch);
			this.splitContainer1.Panel1.Controls.Add(this.label9);
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
			this.splitContainer1.Panel2.Controls.Add(this.txtPath);
			this.splitContainer1.Panel2.Controls.Add(this.txtID);
			this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
			this.splitContainer1.Panel2.Controls.Add(this.txtContact);
			this.splitContainer1.Panel2.Controls.Add(this.panelActionButton);
			this.splitContainer1.Panel2.Controls.Add(this.txtMiddlename);
			this.splitContainer1.Panel2.Controls.Add(this.txtAddress);
			this.splitContainer1.Panel2.Controls.Add(this.txtPosition);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
			this.splitContainer1.Panel2.Controls.Add(this.txtFirstname);
			this.splitContainer1.Panel2.Controls.Add(this.txtLastname);
			this.splitContainer1.Size = new System.Drawing.Size(1017, 677);
			this.splitContainer1.SplitterDistance = 620;
			this.splitContainer1.SplitterWidth = 2;
			this.splitContainer1.TabIndex = 83;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label8.Location = new System.Drawing.Point(379, 645);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 23);
			this.label8.TabIndex = 36;
			this.label8.Text = "Filter";
			// 
			// cmbPosition
			// 
			this.cmbPosition.BackColor = System.Drawing.Color.Snow;
			this.cmbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPosition.ForeColor = System.Drawing.SystemColors.Menu;
			this.cmbPosition.FormattingEnabled = true;
			this.cmbPosition.ItemHeight = 17;
			this.cmbPosition.Location = new System.Drawing.Point(452, 644);
			this.cmbPosition.Name = "cmbPosition";
			this.cmbPosition.Size = new System.Drawing.Size(139, 25);
			this.cmbPosition.TabIndex = 35;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.Snow;
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.ForeColor = System.Drawing.SystemColors.Menu;
			this.textBoxSearch.Location = new System.Drawing.Point(76, 644);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(281, 23);
			this.textBoxSearch.TabIndex = 33;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label9.Location = new System.Drawing.Point(12, 645);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(146, 23);
			this.label9.TabIndex = 34;
			this.label9.Text = "search";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView1.ColumnHeadersHeight = 40;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.Black;
			this.dataGridView1.Location = new System.Drawing.Point(12, 1);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.dataGridView1.RowTemplate.Height = 32;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(603, 634);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.VirtualMode = true;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1KeyDown);
			// 
			// txtPath
			// 
			this.txtPath.BackColor = System.Drawing.Color.DarkSlateGray;
			this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPath.ForeColor = System.Drawing.SystemColors.Menu;
			this.txtPath.Location = new System.Drawing.Point(8, 385);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(374, 27);
			this.txtPath.TabIndex = 90;
			this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPath.Visible = false;
			// 
			// txtID
			// 
			this.txtID.BackColor = System.Drawing.Color.DarkSlateGray;
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.ForeColor = System.Drawing.SystemColors.Menu;
			this.txtID.Location = new System.Drawing.Point(8, 418);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(208, 27);
			this.txtID.TabIndex = 89;
			this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtID.Visible = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.OrangeRed;
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
			this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(238, 335);
			this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
			this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(134, 27);
			this.dateTimePicker1.TabIndex = 88;
			this.dateTimePicker1.Value = new System.DateTime(2022, 2, 3, 0, 0, 0, 0);
			// 
			// txtContact
			// 
			this.txtContact.BackColor = System.Drawing.Color.MintCream;
			this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContact.ForeColor = System.Drawing.SystemColors.InfoText;
			this.txtContact.Location = new System.Drawing.Point(8, 335);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(207, 23);
			this.txtContact.TabIndex = 87;
			this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panelActionButton
			// 
			this.panelActionButton.BackColor = System.Drawing.SystemColors.MenuBar;
			this.panelActionButton.Controls.Add(this.button1);
			this.panelActionButton.Controls.Add(this.buttonAdd);
			this.panelActionButton.Controls.Add(this.buttonUpdate);
			this.panelActionButton.Controls.Add(this.buttonEdit);
			this.panelActionButton.Controls.Add(this.buttonDelete);
			this.panelActionButton.Location = new System.Drawing.Point(8, 624);
			this.panelActionButton.Name = "panelActionButton";
			this.panelActionButton.Size = new System.Drawing.Size(376, 43);
			this.panelActionButton.TabIndex = 86;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Silver;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Dock = System.Windows.Forms.DockStyle.Right;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Window;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(51, 0);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
			this.button1.Size = new System.Drawing.Size(65, 43);
			this.button1.TabIndex = 18;
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
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
			this.buttonAdd.Location = new System.Drawing.Point(116, 0);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
			this.buttonAdd.Size = new System.Drawing.Size(65, 43);
			this.buttonAdd.TabIndex = 17;
			this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAdd.UseVisualStyleBackColor = false;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
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
			this.buttonUpdate.Location = new System.Drawing.Point(181, 0);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(65, 43);
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
			this.buttonEdit.Location = new System.Drawing.Point(246, 0);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(65, 43);
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
			this.buttonDelete.Location = new System.Drawing.Point(311, 0);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(65, 43);
			this.buttonDelete.TabIndex = 12;
			this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// txtMiddlename
			// 
			this.txtMiddlename.BackColor = System.Drawing.Color.MintCream;
			this.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMiddlename.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMiddlename.ForeColor = System.Drawing.SystemColors.InfoText;
			this.txtMiddlename.Location = new System.Drawing.Point(7, 183);
			this.txtMiddlename.Name = "txtMiddlename";
			this.txtMiddlename.Size = new System.Drawing.Size(208, 23);
			this.txtMiddlename.TabIndex = 85;
			this.txtMiddlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.MintCream;
			this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.ForeColor = System.Drawing.SystemColors.InfoText;
			this.txtAddress.Location = new System.Drawing.Point(7, 261);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(373, 23);
			this.txtAddress.TabIndex = 84;
			this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPosition
			// 
			this.txtPosition.BackColor = System.Drawing.Color.MintCream;
			this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPosition.ForeColor = System.Drawing.SystemColors.InfoText;
			this.txtPosition.Location = new System.Drawing.Point(229, 183);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(150, 23);
			this.txtPosition.TabIndex = 83;
			this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(230, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.TabIndex = 82;
			this.pictureBox1.TabStop = false;
			// 
			// txtFirstname
			// 
			this.txtFirstname.BackColor = System.Drawing.Color.MintCream;
			this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFirstname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstname.ForeColor = System.Drawing.SystemColors.InfoText;
			this.txtFirstname.Location = new System.Drawing.Point(7, 121);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(208, 23);
			this.txtFirstname.TabIndex = 81;
			this.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtLastname
			// 
			this.txtLastname.BackColor = System.Drawing.Color.MintCream;
			this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastname.ForeColor = System.Drawing.SystemColors.InfoText;
			this.txtLastname.Location = new System.Drawing.Point(7, 49);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(208, 23);
			this.txtLastname.TabIndex = 80;
			this.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTitleWindow
			// 
			this.lblTitleWindow.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleWindow.ForeColor = System.Drawing.Color.Black;
			this.lblTitleWindow.Image = ((System.Drawing.Image)(resources.GetObject("lblTitleWindow.Image")));
			this.lblTitleWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTitleWindow.Location = new System.Drawing.Point(3, 10);
			this.lblTitleWindow.Name = "lblTitleWindow";
			this.lblTitleWindow.Size = new System.Drawing.Size(1015, 23);
			this.lblTitleWindow.TabIndex = 32;
			this.lblTitleWindow.Text = "EMPLOYEE RECORD";
			this.lblTitleWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// frmEmployee
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(1022, 724);
			this.Controls.Add(this.panelTable);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1022, 724);
			this.MinimumSize = new System.Drawing.Size(1022, 724);
			this.Name = "frmEmployee";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmEmployee";
			this.panelTable.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelActionButton.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.SplitContainer splitContainer1;
		public System.Windows.Forms.TextBox txtLastname;
		public System.Windows.Forms.TextBox txtFirstname;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.TextBox txtPosition;
		public System.Windows.Forms.TextBox txtContact;
		public System.Windows.Forms.TextBox txtAddress;
		public System.Windows.Forms.TextBox txtMiddlename;
		public System.Windows.Forms.DateTimePicker dateTimePicker1;
		public System.Windows.Forms.TextBox txtID;
		public System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label lblTitleWindow;
	}
}

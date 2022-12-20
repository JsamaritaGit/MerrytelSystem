/*
 * Created by SharpDevelop.
 * User: Merrytel
 * Date: 7/22/2022
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MerrytelSystem
{
	partial class frmMasterTracker
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterTracker));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTable = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMunicipality = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextStatus = new System.Windows.Forms.TextBox();
            this.TextLines = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAsBuilt = new System.Windows.Forms.CheckBox();
            this.checkBoxRedline = new System.Windows.Forms.CheckBox();
            this.checkBoxAFI = new System.Windows.Forms.CheckBox();
            this.checkBoxLLD = new System.Windows.Forms.CheckBox();
            this.checkBoxHLD = new System.Windows.Forms.CheckBox();
            this.TextAFISecured = new System.Windows.Forms.TextBox();
            this.TextAFIApplied = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.TextLLDSecured = new System.Windows.Forms.TextBox();
            this.TextLLDApplied = new System.Windows.Forms.TextBox();
            this.TextHLDSecured = new System.Windows.Forms.TextBox();
            this.TextHLDApplied = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.checkBoxHOA = new System.Windows.Forms.CheckBox();
            this.checkBoxNTP = new System.Windows.Forms.CheckBox();
            this.checkBoxBRGY = new System.Windows.Forms.CheckBox();
            this.checkBoxDPWH = new System.Windows.Forms.CheckBox();
            this.checkBoxLGU = new System.Windows.Forms.CheckBox();
            this.TextHOASecured = new System.Windows.Forms.TextBox();
            this.TextHOAApplied = new System.Windows.Forms.TextBox();
            this.TextNTPSecured = new System.Windows.Forms.TextBox();
            this.TextNTPApplied = new System.Windows.Forms.TextBox();
            this.TextBrgySecured = new System.Windows.Forms.TextBox();
            this.TextBrgyApplied = new System.Windows.Forms.TextBox();
            this.TextDPWHSecured = new System.Windows.Forms.TextBox();
            this.TextDPWHApplied = new System.Windows.Forms.TextBox();
            this.TextLGUSecured = new System.Windows.Forms.TextBox();
            this.TextLGUApllied = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActionButton = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.TextNAP = new System.Windows.Forms.TextBox();
            this.TextLCP = new System.Windows.Forms.TextBox();
            this.lblTitleWindow = new System.Windows.Forms.Label();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelActionButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            this.panelTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTable.Controls.Add(this.splitContainer1);
            this.panelTable.Controls.Add(this.lblTitleWindow);
            this.panelTable.Location = new System.Drawing.Point(0, 0);
            this.panelTable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1037, 723);
            this.panelTable.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Location = new System.Drawing.Point(2, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.cmbMunicipality);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.TextStatus);
            this.splitContainer1.Panel2.Controls.Add(this.TextLines);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.panelActionButton);
            this.splitContainer1.Panel2.Controls.Add(this.TextNAP);
            this.splitContainer1.Panel2.Controls.Add(this.TextLCP);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 677);
            this.splitContainer1.SplitterDistance = 629;
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
            // cmbMunicipality
            // 
            this.cmbMunicipality.BackColor = System.Drawing.Color.Snow;
            this.cmbMunicipality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMunicipality.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipality.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbMunicipality.FormattingEnabled = true;
            this.cmbMunicipality.ItemHeight = 17;
            this.cmbMunicipality.Location = new System.Drawing.Point(452, 644);
            this.cmbMunicipality.Name = "cmbMunicipality";
            this.cmbMunicipality.Size = new System.Drawing.Size(139, 25);
            this.cmbMunicipality.TabIndex = 35;
            this.cmbMunicipality.SelectedIndexChanged += new System.EventHandler(this.CmbMunicipalitySelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Snow;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(626, 634);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1KeyDown);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "Status";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 100;
            this.label7.Text = "Lines";
            this.label7.Click += new System.EventHandler(this.Label7Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 99;
            this.label6.Text = "NAP";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "LCP";
            // 
            // TextStatus
            // 
            this.TextStatus.BackColor = System.Drawing.Color.MintCream;
            this.TextStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStatus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextStatus.Location = new System.Drawing.Point(23, 563);
            this.TextStatus.Name = "TextStatus";
            this.TextStatus.Size = new System.Drawing.Size(342, 23);
            this.TextStatus.TabIndex = 94;
            this.TextStatus.TextChanged += new System.EventHandler(this.TextStatusTextChanged);
            // 
            // TextLines
            // 
            this.TextLines.BackColor = System.Drawing.Color.MintCream;
            this.TextLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLines.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLines.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextLines.Location = new System.Drawing.Point(269, 505);
            this.TextLines.Name = "TextLines";
            this.TextLines.Size = new System.Drawing.Size(96, 23);
            this.TextLines.TabIndex = 93;
            this.TextLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAsBuilt);
            this.groupBox2.Controls.Add(this.checkBoxRedline);
            this.groupBox2.Controls.Add(this.checkBoxAFI);
            this.groupBox2.Controls.Add(this.checkBoxLLD);
            this.groupBox2.Controls.Add(this.checkBoxHLD);
            this.groupBox2.Controls.Add(this.TextAFISecured);
            this.groupBox2.Controls.Add(this.TextAFIApplied);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.TextLLDSecured);
            this.groupBox2.Controls.Add(this.TextLLDApplied);
            this.groupBox2.Controls.Add(this.TextHLDSecured);
            this.groupBox2.Controls.Add(this.TextHLDApplied);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(8, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 217);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plan";
            // 
            // checkBoxAsBuilt
            // 
            this.checkBoxAsBuilt.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAsBuilt.Location = new System.Drawing.Point(181, 151);
            this.checkBoxAsBuilt.Name = "checkBoxAsBuilt";
            this.checkBoxAsBuilt.Size = new System.Drawing.Size(146, 24);
            this.checkBoxAsBuilt.TabIndex = 119;
            this.checkBoxAsBuilt.Text = "AS-BUILT";
            this.checkBoxAsBuilt.UseVisualStyleBackColor = true;
            // 
            // checkBoxRedline
            // 
            this.checkBoxRedline.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRedline.Location = new System.Drawing.Point(15, 151);
            this.checkBoxRedline.Name = "checkBoxRedline";
            this.checkBoxRedline.Size = new System.Drawing.Size(146, 24);
            this.checkBoxRedline.TabIndex = 118;
            this.checkBoxRedline.Text = "REDLINE/NAP LOC";
            this.checkBoxRedline.UseVisualStyleBackColor = true;
            // 
            // checkBoxAFI
            // 
            this.checkBoxAFI.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAFI.Location = new System.Drawing.Point(15, 121);
            this.checkBoxAFI.Name = "checkBoxAFI";
            this.checkBoxAFI.Size = new System.Drawing.Size(101, 24);
            this.checkBoxAFI.TabIndex = 117;
            this.checkBoxAFI.Text = "AFI";
            this.checkBoxAFI.UseVisualStyleBackColor = true;
            this.checkBoxAFI.CheckStateChanged += new System.EventHandler(this.AFICheckChanged);
            // 
            // checkBoxLLD
            // 
            this.checkBoxLLD.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLLD.Location = new System.Drawing.Point(15, 91);
            this.checkBoxLLD.Name = "checkBoxLLD";
            this.checkBoxLLD.Size = new System.Drawing.Size(101, 24);
            this.checkBoxLLD.TabIndex = 116;
            this.checkBoxLLD.Text = "LLD";
            this.checkBoxLLD.UseVisualStyleBackColor = true;
            this.checkBoxLLD.CheckStateChanged += new System.EventHandler(this.LLDCheckChanged);
            // 
            // checkBoxHLD
            // 
            this.checkBoxHLD.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHLD.Location = new System.Drawing.Point(15, 61);
            this.checkBoxHLD.Name = "checkBoxHLD";
            this.checkBoxHLD.Size = new System.Drawing.Size(101, 24);
            this.checkBoxHLD.TabIndex = 115;
            this.checkBoxHLD.Text = "HLD";
            this.checkBoxHLD.UseVisualStyleBackColor = true;
            this.checkBoxHLD.CheckStateChanged += new System.EventHandler(this.HLDCheckChanged);
            // 
            // TextAFISecured
            // 
            this.TextAFISecured.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextAFISecured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextAFISecured.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAFISecured.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextAFISecured.Location = new System.Drawing.Point(257, 121);
            this.TextAFISecured.Name = "TextAFISecured";
            this.TextAFISecured.Size = new System.Drawing.Size(100, 23);
            this.TextAFISecured.TabIndex = 105;
            this.TextAFISecured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextAFISecured.Visible = false;
            this.TextAFISecured.Click += new System.EventHandler(this.InputDate);
            // 
            // TextAFIApplied
            // 
            this.TextAFIApplied.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextAFIApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextAFIApplied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAFIApplied.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextAFIApplied.Location = new System.Drawing.Point(134, 121);
            this.TextAFIApplied.Name = "TextAFIApplied";
            this.TextAFIApplied.Size = new System.Drawing.Size(100, 23);
            this.TextAFIApplied.TabIndex = 104;
            this.TextAFIApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextAFIApplied.Visible = false;
            this.TextAFIApplied.Click += new System.EventHandler(this.InputDate);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtID.Location = new System.Drawing.Point(15, 181);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(208, 27);
            this.txtID.TabIndex = 89;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.TxtIDTextChanged);
            // 
            // TextLLDSecured
            // 
            this.TextLLDSecured.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextLLDSecured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLLDSecured.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLLDSecured.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextLLDSecured.Location = new System.Drawing.Point(257, 91);
            this.TextLLDSecured.Name = "TextLLDSecured";
            this.TextLLDSecured.Size = new System.Drawing.Size(100, 23);
            this.TextLLDSecured.TabIndex = 103;
            this.TextLLDSecured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextLLDSecured.Visible = false;
            this.TextLLDSecured.Click += new System.EventHandler(this.InputDate);
            // 
            // TextLLDApplied
            // 
            this.TextLLDApplied.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextLLDApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLLDApplied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLLDApplied.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextLLDApplied.Location = new System.Drawing.Point(134, 91);
            this.TextLLDApplied.Name = "TextLLDApplied";
            this.TextLLDApplied.Size = new System.Drawing.Size(100, 23);
            this.TextLLDApplied.TabIndex = 102;
            this.TextLLDApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextLLDApplied.Visible = false;
            this.TextLLDApplied.Click += new System.EventHandler(this.InputDate);
            // 
            // TextHLDSecured
            // 
            this.TextHLDSecured.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextHLDSecured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextHLDSecured.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHLDSecured.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextHLDSecured.Location = new System.Drawing.Point(257, 61);
            this.TextHLDSecured.Name = "TextHLDSecured";
            this.TextHLDSecured.Size = new System.Drawing.Size(100, 23);
            this.TextHLDSecured.TabIndex = 101;
            this.TextHLDSecured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextHLDSecured.Visible = false;
            this.TextHLDSecured.Click += new System.EventHandler(this.InputDate);
            // 
            // TextHLDApplied
            // 
            this.TextHLDApplied.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextHLDApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextHLDApplied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHLDApplied.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextHLDApplied.Location = new System.Drawing.Point(134, 61);
            this.TextHLDApplied.Name = "TextHLDApplied";
            this.TextHLDApplied.Size = new System.Drawing.Size(100, 23);
            this.TextHLDApplied.TabIndex = 100;
            this.TextHLDApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextHLDApplied.Visible = false;
            this.TextHLDApplied.Click += new System.EventHandler(this.InputDate);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(298, 187);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 99;
            this.button3.Text = "Save";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 98;
            this.label3.Text = "Date Secured";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 97;
            this.label4.Text = "Date Applied";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.checkBoxHOA);
            this.groupBox1.Controls.Add(this.checkBoxNTP);
            this.groupBox1.Controls.Add(this.checkBoxBRGY);
            this.groupBox1.Controls.Add(this.checkBoxDPWH);
            this.groupBox1.Controls.Add(this.checkBoxLGU);
            this.groupBox1.Controls.Add(this.TextHOASecured);
            this.groupBox1.Controls.Add(this.TextHOAApplied);
            this.groupBox1.Controls.Add(this.TextNTPSecured);
            this.groupBox1.Controls.Add(this.TextNTPApplied);
            this.groupBox1.Controls.Add(this.TextBrgySecured);
            this.groupBox1.Controls.Add(this.TextBrgyApplied);
            this.groupBox1.Controls.Add(this.TextDPWHSecured);
            this.groupBox1.Controls.Add(this.TextDPWHApplied);
            this.groupBox1.Controls.Add(this.TextLGUSecured);
            this.groupBox1.Controls.Add(this.TextLGUApllied);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 243);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permit";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowDrop = true;
            this.btnUpdate.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(296, 212);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 115;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
            // 
            // checkBoxHOA
            // 
            this.checkBoxHOA.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHOA.Location = new System.Drawing.Point(15, 181);
            this.checkBoxHOA.Name = "checkBoxHOA";
            this.checkBoxHOA.Size = new System.Drawing.Size(101, 24);
            this.checkBoxHOA.TabIndex = 114;
            this.checkBoxHOA.Text = "HOA";
            this.checkBoxHOA.UseVisualStyleBackColor = true;
            this.checkBoxHOA.CheckStateChanged += new System.EventHandler(this.HOACheckChanged);
            // 
            // checkBoxNTP
            // 
            this.checkBoxNTP.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNTP.Location = new System.Drawing.Point(15, 151);
            this.checkBoxNTP.Name = "checkBoxNTP";
            this.checkBoxNTP.Size = new System.Drawing.Size(101, 24);
            this.checkBoxNTP.TabIndex = 113;
            this.checkBoxNTP.Text = "NTP";
            this.checkBoxNTP.UseVisualStyleBackColor = true;
            this.checkBoxNTP.CheckStateChanged += new System.EventHandler(this.NTPCheckChanged);
            // 
            // checkBoxBRGY
            // 
            this.checkBoxBRGY.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBRGY.Location = new System.Drawing.Point(15, 121);
            this.checkBoxBRGY.Name = "checkBoxBRGY";
            this.checkBoxBRGY.Size = new System.Drawing.Size(101, 24);
            this.checkBoxBRGY.TabIndex = 112;
            this.checkBoxBRGY.Text = "Baranggay";
            this.checkBoxBRGY.UseVisualStyleBackColor = true;
            this.checkBoxBRGY.CheckStateChanged += new System.EventHandler(this.BrgyCheckChanged);
            // 
            // checkBoxDPWH
            // 
            this.checkBoxDPWH.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDPWH.Location = new System.Drawing.Point(15, 91);
            this.checkBoxDPWH.Name = "checkBoxDPWH";
            this.checkBoxDPWH.Size = new System.Drawing.Size(101, 24);
            this.checkBoxDPWH.TabIndex = 111;
            this.checkBoxDPWH.Text = "DPWH";
            this.checkBoxDPWH.UseVisualStyleBackColor = true;
            this.checkBoxDPWH.CheckStateChanged += new System.EventHandler(this.DPWHCheckChanged);
            // 
            // checkBoxLGU
            // 
            this.checkBoxLGU.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLGU.Location = new System.Drawing.Point(15, 61);
            this.checkBoxLGU.Name = "checkBoxLGU";
            this.checkBoxLGU.Size = new System.Drawing.Size(101, 24);
            this.checkBoxLGU.TabIndex = 110;
            this.checkBoxLGU.Text = "LGU";
            this.checkBoxLGU.UseVisualStyleBackColor = true;
            this.checkBoxLGU.CheckStateChanged += new System.EventHandler(this.LGUCheckChanged);
            // 
            // TextHOASecured
            // 
            this.TextHOASecured.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextHOASecured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextHOASecured.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHOASecured.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextHOASecured.Location = new System.Drawing.Point(257, 181);
            this.TextHOASecured.Name = "TextHOASecured";
            this.TextHOASecured.Size = new System.Drawing.Size(100, 23);
            this.TextHOASecured.TabIndex = 109;
            this.TextHOASecured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextHOASecured.Visible = false;
            this.TextHOASecured.Click += new System.EventHandler(this.InputDate);
            // 
            // TextHOAApplied
            // 
            this.TextHOAApplied.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextHOAApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextHOAApplied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHOAApplied.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextHOAApplied.Location = new System.Drawing.Point(134, 181);
            this.TextHOAApplied.Name = "TextHOAApplied";
            this.TextHOAApplied.Size = new System.Drawing.Size(100, 23);
            this.TextHOAApplied.TabIndex = 108;
            this.TextHOAApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextHOAApplied.Visible = false;
            this.TextHOAApplied.Click += new System.EventHandler(this.InputDate);
            // 
            // TextNTPSecured
            // 
            this.TextNTPSecured.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextNTPSecured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextNTPSecured.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNTPSecured.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextNTPSecured.Location = new System.Drawing.Point(257, 151);
            this.TextNTPSecured.Name = "TextNTPSecured";
            this.TextNTPSecured.Size = new System.Drawing.Size(100, 23);
            this.TextNTPSecured.TabIndex = 107;
            this.TextNTPSecured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextNTPSecured.Visible = false;
            this.TextNTPSecured.Click += new System.EventHandler(this.InputDate);
            // 
            // TextNTPApplied
            // 
            this.TextNTPApplied.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextNTPApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextNTPApplied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNTPApplied.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextNTPApplied.Location = new System.Drawing.Point(134, 151);
            this.TextNTPApplied.Name = "TextNTPApplied";
            this.TextNTPApplied.Size = new System.Drawing.Size(100, 23);
            this.TextNTPApplied.TabIndex = 106;
            this.TextNTPApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextNTPApplied.Visible = false;
            this.TextNTPApplied.Click += new System.EventHandler(this.InputDate);
            // 
            // TextBrgySecured
            // 
            this.TextBrgySecured.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBrgySecured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBrgySecured.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBrgySecured.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBrgySecured.Location = new System.Drawing.Point(257, 121);
            this.TextBrgySecured.Name = "TextBrgySecured";
            this.TextBrgySecured.Size = new System.Drawing.Size(100, 23);
            this.TextBrgySecured.TabIndex = 105;
            this.TextBrgySecured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBrgySecured.Visible = false;
            this.TextBrgySecured.Click += new System.EventHandler(this.InputDate);
            // 
            // TextBrgyApplied
            // 
            this.TextBrgyApplied.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBrgyApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBrgyApplied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBrgyApplied.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBrgyApplied.Location = new System.Drawing.Point(134, 121);
            this.TextBrgyApplied.Name = "TextBrgyApplied";
            this.TextBrgyApplied.Size = new System.Drawing.Size(100, 23);
            this.TextBrgyApplied.TabIndex = 104;
            this.TextBrgyApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBrgyApplied.Visible = false;
            this.TextBrgyApplied.Click += new System.EventHandler(this.InputDate);
            // 
            // TextDPWHSecured
            // 
            this.TextDPWHSecured.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextDPWHSecured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDPWHSecured.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDPWHSecured.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextDPWHSecured.Location = new System.Drawing.Point(257, 91);
            this.TextDPWHSecured.Name = "TextDPWHSecured";
            this.TextDPWHSecured.Size = new System.Drawing.Size(100, 23);
            this.TextDPWHSecured.TabIndex = 103;
            this.TextDPWHSecured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextDPWHSecured.Visible = false;
            this.TextDPWHSecured.Click += new System.EventHandler(this.InputDate);
            // 
            // TextDPWHApplied
            // 
            this.TextDPWHApplied.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextDPWHApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDPWHApplied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDPWHApplied.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextDPWHApplied.Location = new System.Drawing.Point(134, 91);
            this.TextDPWHApplied.Name = "TextDPWHApplied";
            this.TextDPWHApplied.Size = new System.Drawing.Size(100, 23);
            this.TextDPWHApplied.TabIndex = 102;
            this.TextDPWHApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextDPWHApplied.Visible = false;
            this.TextDPWHApplied.Click += new System.EventHandler(this.InputDate);
            // 
            // TextLGUSecured
            // 
            this.TextLGUSecured.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextLGUSecured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLGUSecured.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLGUSecured.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextLGUSecured.Location = new System.Drawing.Point(257, 61);
            this.TextLGUSecured.Name = "TextLGUSecured";
            this.TextLGUSecured.Size = new System.Drawing.Size(100, 23);
            this.TextLGUSecured.TabIndex = 101;
            this.TextLGUSecured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextLGUSecured.Visible = false;
            this.TextLGUSecured.Click += new System.EventHandler(this.InputDate);
            // 
            // TextLGUApllied
            // 
            this.TextLGUApllied.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextLGUApllied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLGUApllied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLGUApllied.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextLGUApllied.Location = new System.Drawing.Point(134, 61);
            this.TextLGUApllied.Name = "TextLGUApllied";
            this.TextLGUApllied.Size = new System.Drawing.Size(100, 23);
            this.TextLGUApllied.TabIndex = 100;
            this.TextLGUApllied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextLGUApllied.Visible = false;
            this.TextLGUApllied.Click += new System.EventHandler(this.InputDate);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 98;
            this.label2.Text = "Date Secured";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = "Date Applied";
            // 
            // panelActionButton
            // 
            this.panelActionButton.BackColor = System.Drawing.Color.SteelBlue;
            this.panelActionButton.Controls.Add(this.button1);
            this.panelActionButton.Controls.Add(this.buttonAdd);
            this.panelActionButton.Controls.Add(this.buttonUpdate);
            this.panelActionButton.Controls.Add(this.buttonEdit);
            this.panelActionButton.Controls.Add(this.buttonDelete);
            this.panelActionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionButton.Location = new System.Drawing.Point(0, 634);
            this.panelActionButton.Name = "panelActionButton";
            this.panelActionButton.Size = new System.Drawing.Size(401, 43);
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
            this.button1.Location = new System.Drawing.Point(76, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.button1.Size = new System.Drawing.Size(65, 43);
            this.button1.TabIndex = 18;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.buttonAdd.Location = new System.Drawing.Point(141, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.buttonAdd.Size = new System.Drawing.Size(65, 43);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.buttonUpdate.Location = new System.Drawing.Point(206, 0);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(65, 43);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
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
            this.buttonEdit.Location = new System.Drawing.Point(271, 0);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(65, 43);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.BtnUpdateClick);
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
            this.buttonDelete.Location = new System.Drawing.Point(336, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(65, 43);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // TextNAP
            // 
            this.TextNAP.BackColor = System.Drawing.Color.MintCream;
            this.TextNAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextNAP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNAP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextNAP.Location = new System.Drawing.Point(146, 505);
            this.TextNAP.Name = "TextNAP";
            this.TextNAP.Size = new System.Drawing.Size(96, 23);
            this.TextNAP.TabIndex = 81;
            this.TextNAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextLCP
            // 
            this.TextLCP.BackColor = System.Drawing.Color.MintCream;
            this.TextLCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLCP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLCP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextLCP.Location = new System.Drawing.Point(23, 505);
            this.TextLCP.Name = "TextLCP";
            this.TextLCP.Size = new System.Drawing.Size(96, 23);
            this.TextLCP.TabIndex = 80;
            this.TextLCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitleWindow
            // 
            this.lblTitleWindow.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleWindow.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleWindow.ForeColor = System.Drawing.Color.White;
            this.lblTitleWindow.Image = ((System.Drawing.Image)(resources.GetObject("lblTitleWindow.Image")));
            this.lblTitleWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleWindow.Location = new System.Drawing.Point(0, 0);
            this.lblTitleWindow.Name = "lblTitleWindow";
            this.lblTitleWindow.Size = new System.Drawing.Size(1037, 32);
            this.lblTitleWindow.TabIndex = 32;
            this.lblTitleWindow.Text = "MASTER TRACKER";
            this.lblTitleWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMasterTracker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1036, 722);
            this.Controls.Add(this.panelTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1036, 722);
            this.MinimumSize = new System.Drawing.Size(1036, 722);
            this.Name = "frmMasterTracker";
            this.ShowInTaskbar = false;
            this.Text = "frmMasterTracker";
            this.panelTable.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelActionButton.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.CheckBox checkBoxHLD;
		private System.Windows.Forms.CheckBox checkBoxLLD;
		private System.Windows.Forms.CheckBox checkBoxAFI;
		private System.Windows.Forms.CheckBox checkBoxRedline;
		private System.Windows.Forms.CheckBox checkBoxAsBuilt;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.CheckBox checkBoxDPWH;
		private System.Windows.Forms.CheckBox checkBoxBRGY;
		private System.Windows.Forms.CheckBox checkBoxNTP;
		private System.Windows.Forms.CheckBox checkBoxHOA;
		private System.Windows.Forms.CheckBox checkBoxLGU;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox TextLines;
		public System.Windows.Forms.TextBox TextStatus;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		public System.Windows.Forms.TextBox TextHLDApplied;
		public System.Windows.Forms.TextBox TextHLDSecured;
		public System.Windows.Forms.TextBox TextLLDApplied;
		public System.Windows.Forms.TextBox TextLLDSecured;
		public System.Windows.Forms.TextBox TextAFIApplied;
		public System.Windows.Forms.TextBox TextAFISecured;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.TextBox TextLGUApllied;
		public System.Windows.Forms.TextBox TextLGUSecured;
		public System.Windows.Forms.TextBox TextDPWHApplied;
		public System.Windows.Forms.TextBox TextDPWHSecured;
		public System.Windows.Forms.TextBox TextBrgyApplied;
		public System.Windows.Forms.TextBox TextBrgySecured;
		public System.Windows.Forms.TextBox TextNTPApplied;
		public System.Windows.Forms.TextBox TextNTPSecured;
		public System.Windows.Forms.TextBox TextHOAApplied;
		public System.Windows.Forms.TextBox TextHOASecured;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTitleWindow;
		public System.Windows.Forms.TextBox TextLCP;
		public System.Windows.Forms.TextBox TextNAP;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panelActionButton;
		public System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.ComboBox cmbMunicipality;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panelTable;
	}
}

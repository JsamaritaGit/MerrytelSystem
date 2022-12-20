/*
 * Created by SharpDevelop.
 * User: Jonas
 * Date: 3/1/2022
 * Time: 12:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using DataTable = System.Data.DataTable;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;


namespace MerrytelSystem
{
	/// <summary>
	/// Description of frmEmployee.
	/// </summary>
	public partial class frmEmployee : Form
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
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb");

        private Form parentForm;
        public frmEmployee()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Load_Data();
			load_cmb();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void Load_Data()
		{
			dataGridView1.DataSource = dataTableResult("SELECT ID, Lastname, Firstname, ContactNumber, Positions FROM EmployeeMasterFile");
			dataGridView1.Columns[0].Width = 40;
			dataGridView1.Columns[1].Width = 130;
			//dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridView1.Columns[2].Width = 130;
			dataGridView1.Columns[3].Width = 130;

					
		}
		public void load_set(DataGridViewRow row)
		{
			DataSet ds = new DataSet();
			
			string sql = "SELECT * FROM EmployeeMasterFile WHERE ID = '" + row.Cells[0].Value.ToString() + "'";
	        
	        OleDbDataAdapter sda = new OleDbDataAdapter(sql, con);
			con.Open();
	        sda.Fill(ds);
			con.Close();
	        txtLastname.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(1));
	        txtFirstname.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(2));
			txtMiddlename.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(3));
	        txtContact.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(5));
	        txtAddress.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(6));
			txtPosition.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(7));
			
			txtPath.Text =  Environment.CurrentDirectory + "/" + Convert.ToString(ds.Tables[0].Rows[0].Field<object>(8));
			txtID.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(0));
			
			try {
				pictureBox1.Image = Image.FromFile(txtPath.Text);
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			} catch (Exception ex) {
				String newline = System.Environment.NewLine;
				DialogResult dialogResult = MessageBox.Show(ex.Message + newline + newline + "PLEASE UPLOAD A NEW IMAGE..", "IMAGE FILE MISSING", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes) {
					uploadImage();
				} else {
		   			
				}
			}
			
			try {
				dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0].Field<object>(4));
				
			}catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
	        
		}
		public DataTable dataTableResult(string sql)
		{
			DataTable dataTableRes = new DataTable();
			try {

				OleDbDataAdapter dtAdapter = new OleDbDataAdapter(sql, con);
		        con.Open();
				dtAdapter.Fill(dataTableRes);
				con.Close();
	        	
			} catch (OleDbException ex) {
				MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
			} finally {
				con.Close();
			}
			return dataTableRes;
		}
		void load_cmb()
		{
			cmbPosition.DataSource = dataTableResult("SELECT DISTINCT Positions FROM EmployeeMasterFile");
			cmbPosition.DisplayMember = "Positions";
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) {
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				
				//load_text(row);
				load_set(row);
			}
		}
		void load_text(DataGridViewRow row)
		{
			txtLastname.Text = row.Cells[1].Value.ToString();
			//lblLastname.Text = txtLastname.Text;
			txtFirstname.Text = row.Cells[2].Value.ToString();
			//lblFirstname.Text = txtFirstname.Text;
			txtPosition.Text = row.Cells[4].Value.ToString();
			//lblPosition.Text = txtPosition.Text;
			txtContact.Text = row.Cells[3].Value.ToString();
			//lblContact.Text = txtContact.Text;
			txtAddress.Text = row.Cells[5].Value.ToString();
			//lblAddress.Text = txtAddress.Text;
			txtID.Text = row.Cells[0].Value.ToString();	
			
			txtPath.Text = Environment.CurrentDirectory + "/" + row.Cells[6].Value.ToString();
			
			try {
				pictureBox1.Image = Image.FromFile(txtPath.Text);
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			} catch (Exception ex) {
				String newline = System.Environment.NewLine;
                pictureBox1.Image = Image.FromFile("Image/default.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

			}
		    
		}
		void dataGridView1KeyDown(object sender, KeyEventArgs e)
		{                
			if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) {
				var index = e.KeyCode == Keys.Up ? -1 : e.KeyCode == Keys.Down ? 1 : 0;
				var rowIndex = dataGridView1.CurrentCell.RowIndex + index;
				int rows = dataGridView1.RowCount - 1;
		        
				if (rowIndex > -1 && rowIndex < rows) {
		        	
					var row = dataGridView1.Rows[rowIndex];

					if (row != null) {	
						//load_text(row);
						load_set(row);
					}
				} else {
		        	
				}
			}
		}

        void ButtonEditClick(object sender, EventArgs e)
		{
			buttonEdit.Enabled = !buttonEdit.Enabled;
			buttonEdit.BackColor = Color.Transparent;
			buttonAdd.Enabled = !buttonAdd.Enabled;
			buttonAdd.BackColor = Color.Transparent;
			buttonDelete.Enabled = !buttonDelete.Enabled;
			buttonDelete.BackColor = Color.Transparent;
			button1.Enabled = !button1.Enabled;
			button1.BackColor = Color.Transparent;
			
			buttonUpdate.Enabled = !buttonUpdate.Enabled;
			buttonUpdate.BackColor = Color.Silver;
			
		}
		
		public void enableLabel()
		{
			txtContact.Visible = !txtContact.Visible;
			txtFirstname.Visible = !txtFirstname.Visible;
			txtLastname.Visible = !txtLastname.Visible;
			txtPosition.Visible = !txtPosition.Visible;
			txtAddress.Visible = !txtAddress.Visible;
			//txtBirthdate.Visible = !txtBirthdate.Visible;
			txtMiddlename.Visible = !txtMiddlename.Visible;
			
			//lblContact.Visible = !lblContact.Visible;
			//lblFirstname.Visible = !lblFirstname.Visible;
			//lblLastname.Visible = !lblLastname.Visible;
			//lblPosition.Visible = !lblPosition.Visible;
			//lblAddress.Visible = !lblAddress.Visible;
			//lblBirthdate.Visible = !lblBirthdate.Visible;
			//lblMiddlename.Visible = !lblMiddlename.Visible;
		}
		public void uploadImage()
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {  
		        
				DialogResult dialogResult = MessageBox.Show("UPLOAD THIS IMAGE?", "UPLOAD", MessageBoxButtons.YesNo);
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				
				if (dialogResult == DialogResult.Yes) {
					using (OleDbCommand cmd = con.CreateCommand()) {
						cmd.CommandText = "UPDATE EmployeeMasterFile set ImagePath= @ImagePath WHERE ID = @PID";
	
						cmd.Parameters.AddWithValue("@ImagePath", saveTo());
						cmd.Parameters.AddWithValue("@ID", txtID.Text);
						cmd.Connection.Open();
						cmd.ExecuteNonQuery();
						cmd.Connection.Close();
					}		
					Load_Data();
				} else if (dialogResult == DialogResult.No) {
					//do something else
				}
			} 
		}
		void Button1Click(object sender, EventArgs e)
		{		
			uploadImage();
			
		}
		public static Image resizeImage(Image imgToResize, Size size)
		{
			return (Image)(new Bitmap(imgToResize, size));
		}
		public String saveTo()
		{
			String name = "Image/" + Path.GetRandomFileName() + ".JPEG";
			pictureBox1.Image = resizeImage(pictureBox1.Image, new Size(124, 124));
			pictureBox1.Image.Save(name);
			return name;

		}
		void Button2Click(object sender, EventArgs e)
		{
			
			_Application word = new Microsoft.Office.Interop.Word.Application();
			_Document doc = new Microsoft.Office.Interop.Word.Document();
			var wordpath = Environment.CurrentDirectory + @"\Templates\Doc2.dot";
			doc = word.Documents.Add(wordpath);
			doc.Activate();
			
			foreach (Microsoft.Office.Interop.Word.FormField field in doc.FormFields) {
				switch (field.Name) {
					case "FieldName":
						field.Range.Text = txtFirstname.Text + " " + txtLastname.Text;
						break;
					case "FieldIDno":
						field.Range.Text = txtID.Text;
						break;
					case "FieldPosition":
						field.Range.Text = txtPosition.Text;
						break;
					case "FieldPicture":
						field.Range.InlineShapes.AddPicture(@txtPath.Text);
						field.Range.Text = "";
						break;
					case "FieldAddress":
						field.Range.Text = txtAddress.Text;
						break;
					default:
						break;
				}
			}
//			var saveas = @"C:\Users\Jonas\Desktop\Doc5.docx";
			word.Visible = true;
//			doc.Close();
//			word.Quit();
			//System.Diagnostics.Process.Start(@"C:\Users\Jonas\Desktop\" + Path.GetRandomFileName()+".docx");
		}
		void Button3Click(object sender, EventArgs e)
		{
		
		}
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("DELETE THIS EMPLOYEE?", "WARNING", MessageBoxButtons.YesNo);
				
			if (dialogResult == DialogResult.Yes) {
				try {
					using (OleDbCommand cmd = con.CreateCommand()) {
						cmd.CommandText = "DELETE FROM EmployeeMasterFile WHERE ID = @PID";
						cmd.Parameters.AddWithValue("@ID", txtID.Text);
						cmd.Connection.Open();
						cmd.ExecuteNonQuery();
						cmd.Connection.Close();
					}
					MessageBox.Show("Data record deleted!", "DB Connection With App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Load_Data();
					clearText();
	
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}		
		}
		public void clearText()
		{
			txtLastname.Text = "";
			//lblLastname.Text = "";
			txtFirstname.Text = "";
			//lblFirstname.Text = "";
			txtPosition.Text = "";
			//lblPosition.Text = "";
			txtContact.Text = "";
			//lblContact.Text = "";
			txtAddress.Text = "";
			//lblAddress.Text = "";
			txtPath.Text = "";
			//txtBirthdate.Text = "";
			//lblBirthdate.Text = "";
			txtMiddlename.Text = "";
			//lblMiddlename.Text = "";
			pictureBox1.Image = null;
			
		}
		void ButtonAddClick(object sender, EventArgs e)
		{
			if (txtFirstname.Visible) {
				DialogResult dialogResult = MessageBox.Show("ADD NEW EMPLOYEE?", "ADD NEW", MessageBoxButtons.YesNo);
				
				if (dialogResult == DialogResult.Yes) {
					try {
						using (OleDbCommand cmd = con.CreateCommand()) {
							cmd.CommandText = "INSERT INTO EmployeeMasterFile Lastname = @Lastname, Firstname = @Firstname, Middlename = @Middlename, " +
							"Birthdate = @Birthdate, ContactNumber = @ContactNumber, Address = @Address, Positions = @Positions";
							cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
							cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
							cmd.Parameters.AddWithValue("@Middlename", txtMiddlename.Text);
							cmd.Parameters.AddWithValue("@Birthdate", dateTimePicker1.Value.ToShortDateString());
							cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text);
							cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
							cmd.Parameters.AddWithValue("@Positions", txtPosition.Text);
							cmd.Connection.Open();
							cmd.ExecuteNonQuery();
							cmd.Connection.Close();
						}
						MessageBox.Show("Added new Employee!", "DB Connection With App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Load_Data();
						clearText();
		
					} catch (Exception ex) {
						MessageBox.Show(ex.Message);
					} 
				}			
			} 
			else 
			{
				buttonEdit.Enabled = !buttonEdit.Enabled;
				buttonEdit.BackColor = Color.Transparent;
				buttonDelete.Enabled = !buttonDelete.Enabled;
				buttonDelete.BackColor = Color.Transparent;
				button1.Enabled = !button1.Enabled;
				button1.BackColor = Color.Transparent;
				
				enableLabel();
			}
			
			
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("UPDATE EMPLOYEE?", "UPDATE", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (OleDbCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE EmployeeMasterFile set Lastname = @Lastname, Firstname = @Firstname, Middlename = @Middlename, " +
                        "Birthdate = @Birthdate, ContactNumber = @ContactNumber, Address = @Address, Positions = @Positions WHERE ID = @ID";
						
						cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
                        cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                        cmd.Parameters.AddWithValue("@Middlename", txtMiddlename.Text);
                        cmd.Parameters.AddWithValue("@Birthdate", dateTimePicker1.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Positions", txtPosition.Text);
                        cmd.Parameters.AddWithValue("@ID", txtID.Text);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                    MessageBox.Show("Updated Employee!", "DB Connection With App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Load_Data();
                    clearText();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                buttonEdit.Enabled = !buttonEdit.Enabled;
                buttonEdit.BackColor = Color.Silver;
                buttonAdd.Enabled = !buttonAdd.Enabled;
                buttonAdd.BackColor = Color.Silver;
                buttonDelete.Enabled = !buttonDelete.Enabled;
                buttonDelete.BackColor = Color.Silver;
                button1.Enabled = !button1.Enabled;
                button1.BackColor = Color.Silver;

                buttonUpdate.Enabled = !buttonUpdate.Enabled;
                buttonUpdate.BackColor = Color.Transparent;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
			// do somthing
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}

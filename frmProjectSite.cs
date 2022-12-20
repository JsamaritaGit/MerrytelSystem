
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Runtime.InteropServices;


namespace MerrytelSystem
{

	public partial class frmProjectSite : Form
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
        
		String conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb";
		public frmProjectSite()
		{

			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
			load_cmb();
			Load_Data(); 
			CurveThisPanel(panelActionButton);
			disabledButton();
		}
		void disabledButton()
		{
			if(!buttonUpdate.Enabled)
			{
				buttonUpdate.BackColor = Color.Transparent;
			}
		}
		public void Load_Data()
		{
			dataGridView1.DataSource = dataTableResult("SELECT SPID, SiteID as [Site ID], SiteName as [Site Name], City.Region, City.Municipality, City.Barangay, LCP, NAP, Lines, Status FROM SiteProject, City WHERE City.CityID = SiteProject.CityID");
			dataGridView1.Columns[0].Width = 50;
			dataGridView1.Columns[1].Width = 150;
			dataGridView1.Columns[2].Width = 350;
					
        }
		void load_cmb()
		{
			cmbMunicipality.DataSource = dataTableResult("SELECT DISTINCT Municipality FROM City");
			cmbMunicipality.DisplayMember = "Municipality";
		}
		public DataTable dataTableResult(string sql)
		{
			DataTable dataTableRes = new DataTable();
			try
			{
				
				OleDbConnection con = new OleDbConnection(conString);
		        OleDbDataAdapter dtAdapter = new OleDbDataAdapter(sql, con);
		        
		        dtAdapter.Fill(dataTableRes);
		
	        	
			}
			catch (OleDbException ex)
			{
             	MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
            }
			finally
            {
               // con.Close();
            }
			return dataTableRes;
		}

		void Button1Click(object sender, EventArgs e)
		{

		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void CurveThisPanel(Panel panel)
		{
			panel.BorderStyle = BorderStyle.None;
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 5, 5));
		}
		void ButtonAddClick(object sender, EventArgs e)
		{
			formAdd frmAdd = new formAdd(dataGridView1);
			frmAdd.ShowDialog();	
		}
		void TextBoxSearchTextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = dataTableResult("SELECT SPID, SiteID as [Site ID], SiteName as [Site Name], City.Region, City.Municipality, City.Barangay, LCP, NAP, Lines, Status FROM SiteProject, City WHERE City.CityID = SiteProject.CityID AND SiteProject.SiteName LIKE '%" + textBoxSearch.Text + "%'");
		}
		void CmbMunicipalitySelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = dataTableResult("SELECT SPID, SiteID as [Site ID], SiteName as [Site Name], City.Region, City.Municipality, City.Barangay, LCP, NAP, Lines, Status FROM SiteProject, City WHERE City.CityID = SiteProject.CityID AND City.Municipality = '" + cmbMunicipality.Text + "'");
		}
		void ButtonEditClick(object sender, EventArgs e)
		{
			buttonEdit.Enabled = !buttonEdit.Enabled;
			buttonEdit.BackColor = Color.Transparent;
			buttonAdd.Enabled = !buttonAdd.Enabled;
			buttonAdd.BackColor = Color.Transparent;
			buttonDelete.Enabled = !buttonDelete.Enabled;
			buttonDelete.BackColor = Color.Transparent;
			
			buttonUpdate.Enabled = !buttonUpdate.Enabled;
			buttonUpdate.BackColor = Color.Silver;
		}
		void ButtonUpdateClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do you want to?", "Add Site", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				OleDbConnection con = new OleDbConnection(conString);
				using (OleDbCommand cmd = con.CreateCommand())
               {
                 cmd.CommandText = "UPDATE SiteProject set LCP= @LCP, NAP = @NAP, Lines = @Lines, Status = @Status WHERE SPID = @SPID";

                 cmd.Parameters.AddWithValue("@LCP", Convert.ToInt32(txtLCP.Text));
                 cmd.Parameters.AddWithValue("@NAP", Convert.ToInt32(txtNAP.Text));
                 cmd.Parameters.AddWithValue("@Lines", Convert.ToInt32(txtLines.Text));
                 cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                 cmd.Parameters.AddWithValue("@SPID", txtID.Text);
                 cmd.Connection.Open();
                 cmd.ExecuteNonQuery();
              }
				
				buttonEdit.Enabled = !buttonEdit.Enabled;
				buttonEdit.BackColor = Color.Silver;
				buttonAdd.Enabled = !buttonAdd.Enabled;
				buttonAdd.BackColor = Color.Silver;
				buttonDelete.Enabled = !buttonDelete.Enabled;
				buttonDelete.BackColor = Color.Silver;
				
				buttonUpdate.Enabled = !buttonUpdate.Enabled;
				buttonUpdate.BackColor = Color.Transparent;
				
				Load_Data();
            }
			else if (dialogResult == DialogResult.No)
			{
			    //do something else
			}
			
		}
		
		void dataGridView1KeyDown(object sender, KeyEventArgs e)
		{

        }
        void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{                
		    if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
		    {
		        var index = e.KeyCode == Keys.Up ? -1 : e.KeyCode == Keys.Down ? 1 : 0;
		        var rowIndex = dataGridView1.CurrentCell.RowIndex + index;
		        if (rowIndex > -1)
		        {	
		            var row = dataGridView1.Rows[rowIndex];
		            if (row != null)
		            {
		            	
		            	
		            }
		        }
		    }
		}
		
		
		void FrmProjectSiteLoad(object sender, EventArgs e)
		{
			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}

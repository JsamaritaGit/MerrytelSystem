/*
 * Created by SharpDevelop.
 * User: Merrytel
 * Date: 7/22/2022
 * Time: 3:19 PM
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
	/// Description of frmMasterTracker.
	/// </summary>
	public partial class frmMasterTracker : Form
	{
		String conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb";
		public frmMasterTracker()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			load_cmb();
			Load_Data(); 
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void Load_Data()
		{
			dataGridView1.DataSource = dataTableResult("SELECT SPID, SiteID as [Site ID], SiteName as [Site Name], City.Region, City.Municipality, City.Barangay, LCP, NAP, Lines, Status FROM SiteProject, City WHERE City.CityID = SiteProject.CityID");
			dataGridView1.Columns[0].Width = 30;
			dataGridView1.Columns[1].Width = 75;
			dataGridView1.Columns[2].Width = 300;
			dataGridView1.Columns[3].Width = 60;
			dataGridView1.Columns[4].Width = 75;
					
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
			catch (IndexOutOfRangeException ex)
			{
				MessageBox.Show(ex.Message.ToString(), "No Row Return");
			}
			finally
            {
               // con.Close();
            }
			return dataTableRes;
		}
		
		void CmbMunicipalitySelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = dataTableResult("SELECT SPID, SiteID as [Site ID], SiteName as [Site Name], City.Region, City.Municipality, City.Barangay, LCP, NAP, Lines, Status FROM SiteProject, City WHERE City.CityID = SiteProject.CityID AND City.Municipality = '" + cmbMunicipality.Text + "'");			
		}
		
		void TextStatusTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			
		}
		void dataGridView1KeyDown(object sender, KeyEventArgs e)
		{                
		    if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
		    {	// take note of this code
		        var index = e.KeyCode == Keys.Up ? -1 : e.KeyCode == Keys.Down ? 1 : 0;
		        var rowIndex = dataGridView1.CurrentCell.RowIndex + index;
		        int rows = dataGridView1.RowCount - 1;
		        
		        if (rowIndex > -1 && rowIndex < rows)
		        {
		        	
		            var row = dataGridView1.Rows[rowIndex];

		            if (row != null)
		            {
						TextLCP.Text = row.Cells[6].Value.ToString();
						TextNAP.Text = row.Cells[7].Value.ToString();
						TextLines.Text = row.Cells[8].Value.ToString();
						TextStatus.Text = row.Cells[9].Value.ToString();
						txtID.Text = row.Cells[0].Value.ToString();						
		            }
		        }
		        else
		        {
		        	
		        }
		    }
		}
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >=0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				TextLCP.Text = row.Cells[6].Value.ToString();
				TextNAP.Text = row.Cells[7].Value.ToString();
				TextLines.Text = row.Cells[8].Value.ToString();
				TextStatus.Text = row.Cells[9].Value.ToString();
				txtID.Text = row.Cells[0].Value.ToString();
			}
		}
		void LGUCheckChanged(object sender, EventArgs e)
		{
			TextLGUApllied.Visible = !TextLGUApllied.Visible;
			TextLGUSecured.Visible = !TextLGUSecured.Visible;
		}
		void InputDate(object sender, EventArgs e)
		{
			TextBox textbox = (TextBox)sender;
			textbox.Text = DateTime.Today.ToShortDateString();
		}
		void DPWHCheckChanged(object sender, EventArgs e)
		{
			TextDPWHApplied.Visible = !TextDPWHApplied.Visible;
			TextDPWHSecured.Visible = !TextDPWHSecured.Visible;	
		}
		void BrgyCheckChanged(object sender, EventArgs e)
		{
			TextBrgyApplied.Visible = !TextBrgyApplied.Visible;
			TextBrgySecured.Visible = !TextBrgySecured.Visible;
		}
		void NTPCheckChanged(object sender, EventArgs e)
		{
			TextNTPApplied.Visible = !TextNTPApplied.Visible;
			TextNTPSecured.Visible = !TextNTPSecured.Visible;
		}
		void HOACheckChanged(object sender, EventArgs e)
		{
			TextHOAApplied.Visible = !TextHOAApplied.Visible;
			TextHOASecured.Visible = !TextHOASecured.Visible;
		}
		void HLDCheckChanged(object sender, EventArgs e)
		{
			TextHLDApplied.Visible = !TextHLDApplied.Visible;
			TextHLDSecured.Visible = !TextHLDSecured.Visible;
		}
		void LLDCheckChanged(object sender ,EventArgs e)
		{
			TextLLDApplied.Visible = !TextLLDApplied.Visible;
			TextLLDSecured.Visible = !TextLLDSecured.Visible;
		}
		void AFICheckChanged(object sender, EventArgs e)
		{
			TextAFIApplied.Visible = !TextAFIApplied.Visible;
			TextAFISecured.Visible = !TextAFISecured.Visible;
		}
		void TxtIDTextChanged(object sender, EventArgs e)
		{
			UpdateObjectPermit();
			UpdateObjectPlan();
		}
		void UpdateObjectPlan()
		{
			DataTable dt  = dataTableResult("SELECT * FROM SitePlan WHERE SPID =" + txtID.Text + "");
			try
			{		
				checkBoxHLD.Checked = Convert.ToBoolean(dt.Rows[0]["HLD"]);
				TextHLDApplied.Text = dt.Rows[0]["HLDApplied"].ToString();
				TextHLDSecured.Text = dt.Rows[0]["HLDSecured"].ToString();
				checkBoxLLD.Checked = Convert.ToBoolean(dt.Rows[0]["LLD"]);
				TextLLDApplied.Text = dt.Rows[0]["LLDApplied"].ToString();
				TextLLDSecured.Text = dt.Rows[0]["LLDSecured"].ToString();
				checkBoxAFI.Checked = Convert.ToBoolean(dt.Rows[0]["AFI"]);
				TextAFIApplied.Text = dt.Rows[0]["AFIApplied"].ToString();
				TextAFISecured.Text = dt.Rows[0]["AFISecured"].ToString();
				checkBoxRedline.Checked = Convert.ToBoolean(dt.Rows[0]["Redline"]);
				checkBoxAsBuilt.Checked = Convert.ToBoolean(dt.Rows[0]["AsBuilt"]);
			}
			catch (IndexOutOfRangeException ex)
			{
				MessageBox.Show(ex.Message.ToString(), "No Row/s Return");
				InsertEmptyData1(Convert.ToInt32(txtID.Text));
				UpdateObjectPlan();
			}
		}
		void UpdateObjectPermit()
		{
			DataTable dt  = dataTableResult("SELECT * FROM SitePermit WHERE SPID =" + txtID.Text + "");
			try
			{
				checkBoxLGU.Checked = Convert.ToBoolean(dt.Rows[0]["LGU"]);
				TextLGUApllied.Text = dt.Rows[0]["LGUApplied"].ToString();
				TextLGUSecured.Text = dt.Rows[0]["LGUSecured"].ToString();
				checkBoxDPWH.Checked = Convert.ToBoolean(dt.Rows[0]["DPWH"]);
				TextDPWHApplied.Text = dt.Rows[0]["DPWHApplied"].ToString();
				TextDPWHSecured.Text = dt.Rows[0]["DPWHSecured"].ToString();
				checkBoxBRGY.Checked = Convert.ToBoolean(dt.Rows[0]["Baranggay"]);
				TextBrgyApplied.Text = dt.Rows[0]["BrgyApplied"].ToString();
				TextBrgySecured.Text = dt.Rows[0]["brgySecured"].ToString();
				checkBoxNTP.Checked = Convert.ToBoolean(dt.Rows[0]["NTP"]);
				TextNTPApplied.Text = dt.Rows[0]["NTPApplied"].ToString();
				TextNTPSecured.Text = dt.Rows[0]["NTPSecured"].ToString();
				checkBoxHOA.Checked = Convert.ToBoolean(dt.Rows[0]["HOA"]);
				TextHOAApplied.Text = dt.Rows[0]["HOAApplied"].ToString();
				TextHOASecured.Text = dt.Rows[0]["HOASecured"].ToString();
			}
			catch (IndexOutOfRangeException ex)
			{
				MessageBox.Show(ex.Message.ToString(), "No Row/s Return");
				InsertEmptyData(Convert.ToInt32(txtID.Text));
				UpdateObjectPermit();
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Insert_Data(Convert.ToInt32(txtID.Text), checkBoxLGU.Checked, TextLGUApllied.Text, TextLGUSecured.Text, checkBoxDPWH.Checked, TextDPWHApplied.Text, TextDPWHSecured.Text, checkBoxBRGY.Checked, TextBrgyApplied.Text, TextBrgySecured.Text, checkBoxNTP.Checked, TextNTPApplied.Text, TextNTPSecured.Text, checkBoxHOA.Checked, TextHOAApplied.Text, TextHOASecured.Text);
		}
		
		// NOT BEING USED FOR THE TIME BEING====================================================================================================================
		public void Insert_Data(int SPID, Boolean LGU, string lguapplied, string lgusecured, Boolean DPWH, string dpwhapplied, string dpwhsecured, Boolean Brgy, string brgyapplied, string brgysecured, Boolean NTP, string ntpapplied, string ntpsecured, Boolean HOA, string hoaapplied, string hoasecured)
        {
			DialogResult dialogResult = MessageBox.Show("UPDATE?" + lguapplied + LGU, "Apply Permit", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				string sqlInsert =  "INSERT INTO SitePermit (SPID, LGU, LGUApplied, LGUSecured, DPWH, DPWHApplied, DPWHSecured, Baranggay, BrgyApplied, BrgySecured, NTP, NTPApplied, NTPSecured, HOA, HOAApplied, HOASecured) VALUES ('" + SPID + "', '" + LGU + "', '" + lguapplied + "', '" + lgusecured + "', '" + DPWH + "', '" + dpwhapplied + "', '" + dpwhsecured + "', '" + Brgy + "', '" + brgyapplied + "', '" + brgysecured + "', '" + NTP + "', '" + ntpapplied + "', '" + ntpsecured + "', '" + HOA + "', '" + hoaapplied + "', '" + hoasecured + "')";
				dataTableResult(sqlInsert);
				
				//dataGridView.DataSource = dataTableResult("SELECT SPID, SiteID as [Site ID], SiteName as [Site Name], City.Region, City.Municipality, City.Barangay, LCP, NAP, Lines, Status FROM SiteProject, City WHERE City.CityID = SiteProject.CityID");
				//dataGridView.Columns[0].Width = 50;
				//dataGridView.Columns[1].Width = 150;
				//dataGridView.Columns[2].Width = 300;
				//this.Dispose();
            }
			else if (dialogResult == DialogResult.No)
			{
			    //do something else
			}
        }
		public void InsertEmptyData(int SPID)
        {
			DialogResult dialogResult = MessageBox.Show("No Record Found for this Site Permit, Please Update" ,  "UPDATE PERMIT", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				string sqlInsert =  "INSERT INTO SitePermit (SPID, LGU, DPWH, Baranggay, NTP, HOA) VALUES ('" + SPID + "', 'false', 'false', 'false', 'false', 'false')";
				dataTableResult(sqlInsert);
				
            }
			else if (dialogResult == DialogResult.No)
			{
			    //do something else
			}
        }
		public void InsertEmptyData1(int SPID)
        {
			DialogResult dialogResult = MessageBox.Show("No Record Found for this Site Plan, Please Update" ,  "UPDATE SITE PLAN", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				string sqlInsert =  "INSERT INTO SitePlan (SPID, HLD, LLD, AFI, Redline, AsBuilt) VALUES ('" + SPID + "', 'false', 'false', 'false', 'false', 'false')";
				dataTableResult(sqlInsert);

            }
			else if (dialogResult == DialogResult.No)
			{
			    //do something else
			}
        }
		void BtnUpdateClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Update the current Permit?", "Update Permit", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				OleDbConnection con = new OleDbConnection(conString);
				using (OleDbCommand cmd = con.CreateCommand())
               {
					
				 string sql = "UPDATE SitePermit SET LGU = @LGU, DPWH = @DPWH, Baranggay = @Baranggay, NTP = @NTP, HOA = @HOA";
				 //checkBoxLGU.Checked ? sql += ", LGUApplied = @LGUApplied, LGUSecured = @LGUSecured" : ;
				 
				 if(checkBoxLGU.Checked)
				 {
				 	sql += ", LGUApplied = @LGUApplied, LGUSecured = @LGUSecured";
				 }
				 if(checkBoxDPWH.Checked)
				 {
				 	sql += ", DPWHApplied = @DPWHApplied, DPWHSecured = @DPWHSecured";
				 }
				 if(checkBoxBRGY.Checked)
				 {	
					sql += ", BrgyApplied = @BrgyApplied, BrgySecured = @BrgySecured";	
				 }
				 if(checkBoxNTP.Checked)
				 {
					sql += ", NTPApplied = @NTPApplied, NTPSecured = @NTPSecured";	
				 }
				 if(checkBoxHOA.Checked)
				 {
				 	sql += ", HOAApplied = @HOAApplied, HOASecured = @HOASecured ";
				 }
				 
				 sql += " WHERE SPID = @SPID";
				 
				 cmd.CommandText = sql;          
                 cmd.Parameters.AddWithValue("@LGU", checkBoxLGU.Checked.ToString());
                 cmd.Parameters.AddWithValue("@DPWH", checkBoxDPWH.Checked.ToString());
                 cmd.Parameters.AddWithValue("@Baranggay", checkBoxBRGY.Checked.ToString());
                 cmd.Parameters.AddWithValue("@NTP", checkBoxNTP.Checked.ToString());
                 cmd.Parameters.AddWithValue("@HOA", checkBoxHOA.Checked.ToString());
                 
                 if(checkBoxLGU.Checked)
                 {
                 	cmd.Parameters.AddWithValue("@LGUApplied", TextLGUApllied.Text);
                	cmd.Parameters.AddWithValue("@LGUSecured", TextLGUSecured.Text);
                 }
                 if(checkBoxDPWH.Checked)
                 {
                 	cmd.Parameters.AddWithValue("@DPWHApplied", TextDPWHApplied.Text);
                	cmd.Parameters.AddWithValue("@DPWHSecured", TextDPWHSecured.Text);
                 }
                 if(checkBoxBRGY.Checked)
                 {
                 	cmd.Parameters.AddWithValue("@BrgyApplied", TextBrgyApplied.Text);
                	cmd.Parameters.AddWithValue("@BrgySecured", TextBrgySecured.Text);
                 }
                 if(checkBoxNTP.Checked)
                 {
                 	cmd.Parameters.AddWithValue("@NTPApplied", TextNTPApplied.Text);
                 	cmd.Parameters.AddWithValue("@NTPSecured", TextNTPSecured.Text);
                 }
                 if(checkBoxHOA.Checked)
                 {
                 	cmd.Parameters.AddWithValue("@HOAApplied", TextHOAApplied.Text);
                 	cmd.Parameters.AddWithValue("@HOASecured", TextHOASecured.Text);
                 }
				                  
                 cmd.Parameters.AddWithValue("@SPID", txtID.Text);

                 cmd.Connection.Open();
                 try {
                 	cmd.ExecuteNonQuery();
                 } catch (OleDbException ex) {
                 	MessageBox.Show(sql + ", \n\n\"" + ex.Message + "\"", "NOTE! Notify the Dev");
                 	//throw;
                 }  
              }
            }
			else if (dialogResult == DialogResult.No)
			{
			    //do something else
			}			
		}
		
		
		void Button3Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Update the current Status Plan?", "UPDATE PLAN", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				OleDbConnection con = new OleDbConnection(conString);
				using (OleDbCommand cmd = con.CreateCommand())
               {
					
				 string sql = "UPDATE SitePlan SET HLD = @HLD, LLD = @LLD, AFI = @AFI, Redline = @Redline, AsBuilt = @AsBuilt";
				 //checkBoxLGU.Checked ? sql += ", LGUApplied = @LGUApplied, LGUSecured = @LGUSecured" : ;
				 
				 if(checkBoxHLD.Checked)
				 {
				 	sql += ", HLDApplied = @HLDApplied, HLDSecured = @HLDSecured";
				 }
				 if(checkBoxLLD.Checked)
				 {
				 	sql += ", LLDApplied = @LLDApplied, LLDSecured = @LLDSecured";
				 }
				 if(checkBoxAFI.Checked)
				 {	
					sql += ", AFIApplied = @AFIApplied, AFISecured = @AFISecured";	
				 }

				 
				 sql += " WHERE SPID = @SPID";
				 
				 cmd.CommandText = sql;          
                 cmd.Parameters.AddWithValue("@HLD", checkBoxHLD.Checked.ToString());
                 cmd.Parameters.AddWithValue("@LLD", checkBoxLLD.Checked.ToString());
                 cmd.Parameters.AddWithValue("@AFI", checkBoxAFI.Checked.ToString());
                 cmd.Parameters.AddWithValue("@Redline", checkBoxRedline.Checked.ToString());
                 cmd.Parameters.AddWithValue("@AsBuilt", checkBoxAsBuilt.Checked.ToString());
                 
                 if(checkBoxHLD.Checked)
                 {
                 	cmd.Parameters.AddWithValue("@HLDApplied", TextHLDApplied.Text);
                	cmd.Parameters.AddWithValue("@HLDSecured", TextHLDSecured.Text);
                 }
                 if(checkBoxLLD.Checked)
                 {
                 	cmd.Parameters.AddWithValue("@LLDApplied", (TextLLDApplied.Text));
                	cmd.Parameters.AddWithValue("@LLDSecured", (TextLLDSecured.Text));
                 }
                 if(checkBoxAFI.Checked)
                 {
                 	cmd.Parameters.AddWithValue("@AFIApplied", TextAFIApplied.Text);
                	cmd.Parameters.AddWithValue("@AFISecured", TextAFISecured.Text);
                 }
				                  
                 cmd.Parameters.AddWithValue("@SPID", txtID.Text);

                 cmd.Connection.Open();
                 try {
                 	cmd.ExecuteNonQuery();
                 } catch (OleDbException ex) {
                 	MessageBox.Show(sql + ", \n\n\"" + ex.Message + "\"", "NOTE! Notify the Dev");
                 	//throw;
                 }  
              }
            }
			else if (dialogResult == DialogResult.No)
			{
			    //do something else
			}		
		}
	}
}

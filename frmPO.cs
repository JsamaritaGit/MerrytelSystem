/*
 * Created by SharpDevelop.
 * User: Jonas
 * Date: 3/5/2022
 * Time: 9:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using DataTable = System.Data.DataTable;

namespace MerrytelSystem
{
	/// <summary>
	/// Description of frmPO.
	/// </summary>
	public partial class frmPO : Form
	{
		String conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb";
		public frmPO()
		{

			InitializeComponent();
			Load_Data();
			load_cmb();

		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void ButtonAddClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("ADD NEW SCO?", "ADD NEW", MessageBoxButtons.YesNo);
				
			     if(dialogResult == DialogResult.Yes)
			     {
					try
		           {
						OleDbConnection con = new OleDbConnection(conString);
						using (OleDbCommand cmd = con.CreateCommand())
			            {
			                 cmd.CommandText = "INSERT INTO PONumber (SCOno, PODate, POLines, Municipality) VALUES (@SCOno, @PODate, @POLines, @Municipality)";
			                 cmd.Parameters.AddWithValue("@SCOno", txtSCOno.Text);
			                 cmd.Parameters.AddWithValue("@PODate", txtPODate.Text);
			                 cmd.Parameters.AddWithValue("@POLines", Convert.ToInt32(txtPOLines.Text));
			                 cmd.Parameters.AddWithValue("@Municipality", cmbMunicipality.Text);

			                 cmd.Connection.Open();
			                 cmd.ExecuteNonQuery();
			                 cmd.Connection.Close();
			            }
						MessageBox.Show("Added new SCO number!", "DB Connection With App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Load_Data();
						clearText();
		
		           }
		           catch (Exception ex)
		           {
		               MessageBox.Show(ex.Message);
		           }
		            
			     }		
		}
		public void Load_Data()
		{
			dataGridView1.DataSource = dataTableResult("SELECT * FROM POnumber");
		}
		public void clearText()
		{
			txtID.Text = "";
			txtSCOno.Text = "";
			txtPODate.Text = "";
			txtPOLines.Text = "";
		}
		public void load_cmb()
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
	}
}

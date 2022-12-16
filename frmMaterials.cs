/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 11/19/2021
 * Time: 2:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace MerrytelSystem
{
	/// <summary>
	/// Description of frmMaterials.
	/// </summary>
	public partial class frmMaterials : Form
	{
		String conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb";
		public frmMaterials()
		{

			InitializeComponent();
			Load_Data();
			load_ComboBox();
		}
		public void Load_Data()
        {

            using (OleDbConnection cn = new OleDbConnection(conString)) //use your connection string here
            {
                var bindingSource = new BindingSource();
                string sql = "";
 
                DataTable dataTableRes = new DataTable();
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, cn))
                {
                    try
                    {
                      	cn.Open();
						OleDbCommand cmd = new OleDbCommand("SELECT * FROM MaterialOut",cn);
						
						OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
						adapter.Fill(dataTableRes);
						dataGridView1.DataSource = dataTableRes;
						//dataGridView1.AutoResizeMode(1);

						cn.Close();
                    }
                    catch (OleDbException ex)
                    {
                       MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
                    }
                    finally
                    {
                        cn.Close();
                    }
                }

            }
        }

		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}


		void Button1Click(object sender, EventArgs e)
		{
	
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void ButtonAddClick(object sender, EventArgs e)
		{
			using (OleDbConnection cn = new OleDbConnection(conString)) //use your connection string here
            {
                var bindingSource = new BindingSource();
                string sql = "";
 
                DataTable dataTableRes = new DataTable();
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, cn))
                {
                    try
                    {
                    	OleDbCommand cmd = new OleDbCommand("INSERT INTO MaterialOut (DateOut, Team, Site, Item, Quantity) VALUES ( '"+ DateTime.Now.ToShortDateString() +"','" + cmbTeam.Text + "', '" + cmbSite.Text + "', '" + cmbItem.Text + "', '" + txtQuantity.Text + "')", cn);
						//OleDbCommand cmd = new OleDbCommand("INSERT INTO tblStudent(fname, mi, lname, ext, gendghjghjj) VALUES ('" + fname + "', '" + mi + "', '" + lname + "', '" + ext + "', '" + gender + "', '" + sec + "', '" + adv + "');", con);

						cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        Load_Data();
                    }
                    catch (OleDbException ex)
                    {
                       MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
			}
		}
		void FrmMaterialsLoad(object sender, EventArgs e)
		{
	
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		public void load_ComboBox()
		{
			cmbTeam.DataSource = dataTableResult("SELECT Firstname FROM EmployeeMasterFile WHERE Positions = 'FOREMAN'");
			cmbTeam.DisplayMember = "Firstname";
			
			cmbSite.DataSource = dataTableResult("SELECT Sitename FROM SiteProject");
			cmbSite.DisplayMember = "Sitename";
			cmbSite.AutoCompleteMode = AutoCompleteMode.Suggest;
			cmbSite.AutoCompleteSource = AutoCompleteSource.ListItems;
			
			cmbItem.DataSource = dataTableResult("SELECT ItemName FROM OSPItems");
			cmbItem.DisplayMember = "ItemName";
			cmbItem.AutoCompleteMode = AutoCompleteMode.Suggest;
			cmbItem.AutoCompleteSource = AutoCompleteSource.ListItems;
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
		void TxtIDTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}

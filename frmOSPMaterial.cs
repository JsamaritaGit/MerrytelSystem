/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 2/1/2022
 * Time: 4:30 AM
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
	/// Description of frmOSPMaterial.
	/// </summary>
	public partial class frmOSPMaterial : Form
	{
		string sql = "SELECT OSPMatID as [ID], ItemCode as [Item Code], ItemVariantDesc as [Item Description], UOM FROM OSPMaterials";
		
		String conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb";

		
		public frmOSPMaterial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Load_Data();
			Page_Load();
		}
		
		public void Load_Data()
        {
			DataTable dataTableRes = new DataTable();
		}
		public void Page_Load()
	    {
	        OleDbConnection con = new OleDbConnection(conString);
	        OleDbDataAdapter sda = new OleDbDataAdapter(sql, con);
	        DataTable dataTableRes = new DataTable();
	        sda.Fill(dataTableRes);
	
	        dataGridView1.DataSource = dataTableRes; 
	        dataGridView1.Columns[0].Width = 50;
			dataGridView1.Columns[1].Width = 146;
			dataGridView1.Columns[2].Width = 535;
			dataGridView1.Columns[3].Width = 73;

	    }
        
		public void Insert_Data(string ItemCode, string ItemVariant, string UOM)
        {
			DataTable dataTableRes = new DataTable();
			string sqlInsert =  "INSERT INTO OSPMaterials (ItemCode, ItemVariantDesc, UOM) VALUES ('" + ItemCode + "', '" + ItemVariant + "', '" + UOM + "')";
 
            using (OleDbConnection cn = new OleDbConnection(conString)) //use your connection string here
            {

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlInsert, cn))
                {
                	
                    try
                    {	
                    	cn.Open();
                    	
						adapter.Fill(dataTableRes);
						dataGridView1.DataSource = dataTableRes;

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
		void FrmOSPMaterialLoad(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			enabled();
		}

		void enabled()
		{
			textBoxItemCode.Enabled = !textBoxItemCode.Enabled;
			textBoxItemVariant.Enabled = !textBoxItemVariant.Enabled;
			cmbUOM.Enabled = !cmbUOM.Enabled;
			buttonUpdate.Enabled = !buttonUpdate.Enabled;
			buttonAdd.Enabled = !buttonAdd.Enabled;
		}
		void ButtonUpdateClick(object sender, EventArgs e)
		{
			Insert_Data(textBoxItemCode.Text, textBoxItemVariant.Text, cmbUOM.Text);
			Page_Load();
			
			textBoxItemCode.Clear();
			textBoxItemVariant.Clear();
			enabled();
			
			MessageBox.Show("New Item Added.");
			
			
			
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
		}

	}
}

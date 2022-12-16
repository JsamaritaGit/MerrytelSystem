/*
 * Created by SharpDevelop.
 * User: Merrytel
 * Date: 5/24/2022
 * Time: 12:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using System.Data.OleDb;

namespace MerrytelSystem
{
	/// <summary>
	/// Description of TestEmployeePanel.
	/// </summary>
	public partial class TestEmployeePanel : UserControl
	{
		//String conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb";
		public TestEmployeePanel()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//Load_Data();
			

		}
//				public void Load_Data()
//		{
//			dataGridView1.DataSource = dataTableResult("SELECT ID, Lastname, Firstname, ContactNumber, Positions FROM EmployeeMasterFile");
//			dataGridView1.Columns[0].Width = 50;
//			dataGridView1.Columns[1].Width = 150;
//			dataGridView1.Columns[2].Width = 150;
//			dataGridView1.Columns[3].Width = 150;
//
//					
//		}
//		public DataTable dataTableResult(string sql)
//		{
//			DataTable dataTableRes = new DataTable();
//			try {
//				
//				OleDbConnection con = new OleDbConnection(conString);
//				OleDbDataAdapter dtAdapter = new OleDbDataAdapter(sql, con);
//		        
//				dtAdapter.Fill(dataTableRes);
//		
//	        	
//			} catch (OleDbException ex) {
//				MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
//			} finally {
//				// con.Close();
//			}
//			return dataTableRes;
//		}
	}
}

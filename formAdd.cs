/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 1/24/2022
 * Time: 7:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Runtime.InteropServices;

namespace MerrytelSystem
{
	/// <summary>
	/// Description of formAdd.
	/// </summary>
	public partial class formAdd : Form
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
        
        
        private DataGridView dataGridView;
		string selectCity = "SELECT DISTINCT Municipality FROM City";
		String conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb";

		public formAdd(DataGridView dataGridView)
		{
			
			this.dataGridView = dataGridView;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			load_cmb();
			CurveThisPanel(panelActionButton);
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		void ButtonUpdateClick(object sender, EventArgs e)
		{
			Insert_Data(textSiteID.Text, textSiteName.Text, Convert.ToInt32(cmbBrgy.SelectedValue),Convert.ToInt32(textLCP.Text),Convert.ToInt32(textNAP.Text),Convert.ToInt32(textLines.Text),textStatus.Text);
		}
		void load_cmb()
		{
			OleDbConnection con = new OleDbConnection(conString);
	        OleDbDataAdapter dtAdapter = new OleDbDataAdapter(selectCity, con);
	        DataTable dataTableRes = new DataTable();
	        dtAdapter.Fill(dataTableRes);
	        
	        cmbMunicipality.DataSource = dataTableRes;
	        cmbMunicipality.DisplayMember = "Municipality";

	        //cmbBrgy.DataSource = dataTableRes;
	        //cmbBrgy.DisplayMember = "Barangay";
	        //cmbBrgy.ValueMember = "CityID";
		}
		
		public DataTable dataTableResult(string sql)
		{
			OleDbConnection con = new OleDbConnection(conString);
	        OleDbDataAdapter dtAdapter = new OleDbDataAdapter(sql, con);
	        DataTable dataTableRes = new DataTable();
	        dtAdapter.Fill(dataTableRes);
		
	        return dataTableRes;
		}
		void CmbMunicipalitySelectedIndexChanged(object sender, EventArgs e)
		{	
			cmbBrgy.DataSource = dataTableResult("SELECT Barangay, CityID FROM City WHERE Municipality = '" + cmbMunicipality.Text + "' ORDER BY Barangay");
			cmbBrgy.DisplayMember = "Barangay";
			cmbBrgy.ValueMember = "CityID";
		}
		
		void CurveThisPanel(Panel panel)
		{
			panel.BorderStyle = BorderStyle.None;
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 5, 5));
		}
		void Button2Click(object sender, EventArgs e)
		{
			textSiteID.Text = "-";
			textSiteName.Text = "";
			textLCP.Text = "";
			textNAP.Text = "";
			textLines.Text = "";
			textStatus.Text = "";
		}
		public void Insert_Data(string siteID, string siteName, int cityID, int lcp, int nap, int lines, string status)
        {
			DialogResult dialogResult = MessageBox.Show("Do you want to?", "Add Site", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				string sqlInsert =  "INSERT INTO SiteProject (SiteID, SiteName, CityID, LCP, NAP, Lines, Status) VALUES ('" + siteID + "', '" + siteName + "', '" + cityID + "', '" + lcp + "', '" + nap + "', '" + lines + "', '" + status+ "')";
				dataTableResult(sqlInsert);
				
				dataGridView.DataSource = dataTableResult("SELECT SPID, SiteID as [Site ID], SiteName as [Site Name], City.Region, City.Municipality, City.Barangay, LCP, NAP, Lines, Status FROM SiteProject, City WHERE City.CityID = SiteProject.CityID");
				dataGridView.Columns[0].Width = 50;
				dataGridView.Columns[1].Width = 150;
				dataGridView.Columns[2].Width = 300;
				this.Dispose();
            }
			else if (dialogResult == DialogResult.No)
			{
			    //do something else
			}
        }
		
		void CmbBrgySelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

	}
}

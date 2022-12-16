/*
 * Created by SharpDevelop.
 * User: Grace
 * Date: 2/1/2022
 * Time: 3:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace MerrytelSystem
{
	/// <summary>
	/// Description of frmMaterialRequest.
	/// </summary>
	public partial class frmMaterialRequest : Form
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
		
		string selectOSPM = "SELECT * FROM OSPMaterials";
		string selectMatReq = "SELECT DISTINCT ReferenceNo as [Reference no]FROM MaterialRequest GROUP BY ReferenceNo";
		string selectItem = "SELECT MaterialRequest.ID as [ID], MaterialRequest.ItemCode as [Item Code], OSPMaterials.ItemVariantDesc as [Item Description], OSPMaterials.UOM, MaterialRequest.Quantity FROM MaterialRequest INNER JOIN OSPMaterials ON MaterialRequest.ItemCode = OSPMaterials.ItemCode";
		String conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "/MerrytelDatabase1.mdb";
		
		
		
		public frmMaterialRequest()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			// TODO Delete Button
			
			InitializeComponent();
			
			this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 5, 5));
			
			CurveThis();
            load_cmb();
			
			Page_Load(selectMatReq, dataGridView1);
			this.Opacity = .90;
		}
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,Color.Black,Color.Gray,90F))
		    {
		        e.Graphics.FillRectangle(brush, this.ClientRectangle);
		    }
		}
		void CurveThis()
		{
   //         panelTable.BorderStyle = BorderStyle.None;
   //         panelTable.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTable.Width, panelTable.Height, 5, 5));
		
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			lblDescription.Text = cmbItemCode.SelectedValue.ToString();
			
		}	
		void load_cmb()
		{
			OleDbConnection con = new OleDbConnection(conString);
	        OleDbDataAdapter dtAdapter = new OleDbDataAdapter(selectOSPM, con);
	        DataTable dataTableRes = new DataTable();
	        dtAdapter.Fill(dataTableRes);
	        cmbItemCode.DataSource = dataTableRes;
	        cmbItemCode.DisplayMember = "ItemCode";
	        cmbItemCode.ValueMember = "ItemVariantDesc";
	        lblDescription.Text = cmbItemCode.SelectedValue.ToString();
	        
	        cmbSCOno.DataSource = dataTableResult("SELECT SCOno FROM PONumber");
	        cmbSCOno.DisplayMember = "SCOno";
		}
		void ButtonAddClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("ADD NEW EMPLOYEE?", "ADD NEW", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				if(ValidateTextBox())
				{
					Insert_Data(textBoxRefno.Text, cmbSCOno.Text , cmbItemCode.Text, textBoxTransactionno.Text, dateTimePicker1.Value.ToString() ,Convert.ToInt32(textBoxQuantity.Text), textBoxRemarks.Text);
					Page_Load(selectItem +  " WHERE ReferenceNo = '" + textBoxRefno.Text + "' ", dataGridView2);
					Page_Load(selectMatReq, dataGridView1);
					dataGridView2.Columns[0].Width = 50;
					dataGridView2.Columns[1].Width = 146;
					dataGridView2.Columns[2].Width = 443;
					dataGridView2.Columns[3].Width = 73;
					dataGridView2.Columns[4].Width = 90;
				}
			}
			else
			{
				
			}
		}
		
		public Boolean ValidateTextBox()
		{
			Boolean valid = true;
			if (textBoxRefno.Text == "")
			{
				MessageBox.Show("Reference no. is empty");
				textBoxRefno.Focus();
				valid = false;
			}
			else if (textBoxRemarks.Text == "")
			{
				MessageBox.Show("Please put remarks");
				textBoxRemarks.Focus();
				valid = false;
			}
			else if (textBoxQuantity.Text == "")
			{
				MessageBox.Show("Please put value of Quantity");
				textBoxQuantity.Focus();
				valid = false;
			}
			return valid;
			
		}
		public void Page_Load(string sql, DataGridView datagridview)
	    {
	        OleDbConnection con = new OleDbConnection(conString);
	        OleDbDataAdapter sda = new OleDbDataAdapter(sql, con);
	        DataTable dataTableRes = new DataTable();
	        sda.Fill(dataTableRes);
	 
	        datagridview.DataSource = dataTableRes;
	    }
		public void Insert_Data(string Referenceno, string POno, string ItemCode, string Transactionno, string DateReceive, int quantity, string remarks)
        {
			DataTable dataTableRes = new DataTable();
			string sqlInsert =  "INSERT INTO MaterialRequest (ReferenceNO, POno, ItemCode, Transactionno, DateReceive, Quantity, Remarks) VALUES ('" + Referenceno + "', '" + POno + "', '" + ItemCode + "', '" + Transactionno + "', '" + DateReceive + "', '" + quantity + "', '" + remarks+ "')";
 
            using (OleDbConnection cn = new OleDbConnection(conString)) //use your connection string here
            {

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlInsert, cn))
                {
                	
                    try
                    {	
                    	cn.Open();
                    	
						adapter.Fill(dataTableRes);
						dataGridView2.DataSource = dataTableRes;

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
		void TextBoxTransactionnoTextChanged(object sender, EventArgs e)
		{
	
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >=0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				textBoxRefno.Text = row.Cells[0].Value.ToString();
				
				Page_Load(selectItem +  " WHERE ReferenceNo = '" + textBoxRefno.Text + "' ", dataGridView2);
				dataGridView2.Columns[0].Width = 50;
				dataGridView2.Columns[1].Width = 146;
				dataGridView2.Columns[2].Width = 443;
				dataGridView2.Columns[3].Width = 73;
				dataGridView2.Columns[4].Width = 90;
				Load_textBox();
				
			}
		}
		public void Load_textBox()
	    {
			DataSet ds = new DataSet();
			string loadText = "SELECT * FROM MaterialRequest WHERE ReferenceNo = '" + textBoxRefno.Text + "'";
	        
			OleDbConnection con = new OleDbConnection(conString);
	        OleDbDataAdapter sda = new OleDbDataAdapter(loadText, con);
	
	        sda.Fill(ds);
	
	        cmbSCOno.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(2));
	        textBoxTransactionno.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(4));
	        textBoxRemarks.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(7));
	        dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0].Field<object>(5));
	    }
		public void Load_textBox2()
	    {
			try
			{
				DataSet ds = new DataSet();
			string loadText = "SELECT * FROM MaterialRequest WHERE ID = " +txtID.Text + "";
	        
			OleDbConnection con = new OleDbConnection(conString);
	        OleDbDataAdapter sda = new OleDbDataAdapter(loadText, con);
	
	        sda.Fill(ds);
	
	        cmbSCOno.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(2));
	        textBoxTransactionno.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(4));
	        textBoxRemarks.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<object>(7));
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
	        
	    }
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			//
			textBoxRefno.Enabled = !textBoxRefno.Enabled;
			textBoxRemarks.Enabled = !textBoxRemarks.Enabled;
			textBoxQuantity.Enabled = !textBoxQuantity.Enabled;
			textBoxTransactionno.Enabled = !textBoxTransactionno.Enabled;
			cmbItemCode.Enabled = !cmbItemCode.Enabled;
			cmbSCOno.Enabled = !cmbSCOno.Enabled;
			
			buttonAdd.Enabled = !buttonAdd.Enabled;
			buttonDelete.Enabled = !buttonDelete.Enabled;
			buttonEdit.Enabled = !buttonEdit.Enabled;
			button1.Enabled = !button1.Enabled;
			
			buttonAdd.BackColor = Color.Silver;
			buttonDelete.BackColor = Color.Transparent;
			buttonEdit.BackColor = Color.Transparent;
			button1.BackColor = Color.Transparent;
			
		}
		void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >=0)
			{
				DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
				cmbItemCode.Text = row.Cells[1].Value.ToString();
				textBoxQuantity.Text = row.Cells[4].Value.ToString();
				txtID.Text = row.Cells[0].Value.ToString();
				
				Load_textBox2();
				
				//MessageBox.Show(row.Cells[3].Value.ToString());
				
				//Page_Load("UPDATE MaterialRequest SET ReferenceNo = '"+ textBoxRefno.text +"', POno = '"+ textBoxPOno.Text +"', ItemCode = '"+ cmbItemCode.Text +"', Transactionno = '"+ textBoxTransactionno.Text +"', DateReceive = '"+ dateTimePicker1.Value +"', Quantity = '"+ textBoxQuantity.Text +"', Remarks = '"+ textBoxRemarks.Text +"' WHERE ReferenceNo = '"+ textbox +"'", dataGridView2);
			}
		}
		void TextBoxSearchTextChanged(object sender, EventArgs e)
		{
			Page_Load("SELECT DISTINCT ReferenceNo from MaterialRequest WHERE ReferenceNo LIKE '%" + textBoxSearch.Text + "%'", dataGridView1);
		}
		void ButtonEditClick(object sender, EventArgs e)
		{
			//
			buttonEdit.Enabled = !buttonEdit.Enabled;
			buttonUpdate.Enabled = !buttonUpdate.Enabled;
			button1.Enabled = !button1.Enabled;
			buttonDelete.Enabled = !buttonDelete.Enabled;
			
			buttonEdit.BackColor = Color.Transparent;
			buttonUpdate.BackColor = Color.Silver;
			button1.BackColor = Color.Transparent;
			buttonDelete.BackColor = Color.Transparent;
			
			cmbItemCode.Enabled = !cmbItemCode.Enabled;
			textBoxQuantity.Enabled = !textBoxQuantity.Enabled;
			textBoxRefno.Enabled = !textBoxRefno.Enabled;
			cmbSCOno.Enabled = !cmbSCOno.Enabled;
			textBoxTransactionno.Enabled = !textBoxTransactionno.Enabled;
			
			
		}
		void ButtonUpdateClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do you want to Update the Item?", "UPDATE ROW", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
			    //do something
			    //MessageBox.Show("UPDATE MaterialRequest SET ReferenceNo = '"+ textBoxRefno.Text +"', POno = '"+ textBoxPOno.Text +"', ItemCode = '"+ cmbItemCode.Text +"', Transactionno = '"+ textBoxTransactionno.Text +"', DateReceive = '"+ dateTimePicker1.Value.ToShortDateString() +"', Quantity = '"+ Convert.ToInt32(textBoxQuantity.Text) +"', Remarks = '"+ textBoxRemarks.Text +"' WHERE ID = '"+ txtID.Text +"'");
			    Page_Load("UPDATE MaterialRequest SET ReferenceNo = '"+ textBoxRefno.Text +"', POno = '"+ cmbSCOno.Text +"', ItemCode = '"+ cmbItemCode.Text +"', Transactionno = '"+ textBoxTransactionno.Text +"', DateReceive = '"+ dateTimePicker1.Value.ToShortDateString() +"', Quantity = '"+ Convert.ToInt32(textBoxQuantity.Text) +"', Remarks = '"+ textBoxRemarks.Text +"' WHERE ID = "+ txtID.Text +"", dataGridView2);
			    
			    buttonUpdate.Enabled = !buttonUpdate.Enabled;
			    buttonEdit.Enabled = !buttonEdit.Enabled;
			    buttonDelete.Enabled = !buttonDelete.Enabled;
			    button1.Enabled = !button1.Enabled;
			    
			    buttonUpdate.BackColor = Color.Transparent;
			    buttonEdit.BackColor = Color.Silver;
			    buttonDelete.BackColor = Color.Silver;
			    button1.BackColor = Color.Silver;
			    
			    cmbItemCode.Enabled = !cmbItemCode.Enabled;
			    textBoxQuantity.Enabled = !textBoxQuantity.Enabled;
			    cmbSCOno.Enabled = !cmbSCOno.Enabled;
			    textBoxTransactionno.Enabled = !textBoxTransactionno.Enabled;
			    textBoxRefno.Enabled = !textBoxRefno.Enabled;
			    
			}
			else if (dialogResult == DialogResult.No)
			{
			    //do something else
			}
			
		}
		void ButtonDeleteClick(object sender, EventArgs e)
		{
	
		}
		void BtnAddMaterialClick(object sender, EventArgs e)
		{
			frmOSPMaterial frmM = new frmOSPMaterial();
			frmM.Show();
		}
		void PanelTablePaint(object sender, PaintEventArgs e)
		{
	
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

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NovaNet.Utils;
using System.Data.Odbc;
using System.Net;
using System.IO;

namespace CAG_INWARD
{
    public partial class frmInward1 : Form
    {
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public frmInward1(OdbcConnection prmCon, Credentials prmCrd)
        {
            sqlCon = prmCon;
            crd = prmCrd;
            InitializeComponent();
            populateBatch();
        }
        private void populateBatch()
        {
            DataTable dt = new DataTable();
            string sqlstr = "select batch_code,batch_key from batch_master where status = '0'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlstr, sqlCon);
            odap.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                cmbBatch.DataSource = dt;
                cmbBatch.DisplayMember = "batch_code";
                cmbBatch.ValueMember = "batch_key";
                cmbBatch.SelectedIndex = 0;
                DataTable dt1 = new DataTable();
                dt1 = getBatchDetails();
                if (dt1.Rows.Count > 0)
                {
                    txtGroupNmae.Text = dt1.Rows[0][0].ToString();
                    cmbRecordtype.Text = dt1.Rows[0][1].ToString();
                    ShowEnteredData();
                }
            }
            else
            {
                cmbBatch.DataSource = null;
            }
        }

        private void deButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void getSection()
        {
            DataTable dt = new DataTable();
            string sqlStr = "select Section_id,section_name from tblsection_master order by section_id";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            cmbsection.DataSource = dt;
            cmbsection.DisplayMember = "section_name";
            cmbsection.ValueMember = "Section_id";
        }
        private void frmInward1_Load(object sender, EventArgs e)
        {
            dtpSendingDate.Text = DateTime.Now.ToString("ddMMyyyy");
            PopulateFinancialYears();
            getSection();
            ShowEnteredData();
        }
        private void PopulateFinancialYears()
        {
            int currentYear = DateTime.Now.Year;

            // Loop through the years from 1900 to current year + 1 for the next financial year
            for (int year = 1900; year <= currentYear + 1; year++)
            {
                string financialYear = $"{year}-{year + 1}";
                cmbFinancialyear.Items.Add(financialYear);
            }
        }
        private string recordcount()
        {
            string i = "0";
            DataTable dt = new DataTable();
            string sqlStr = "select Count(*) from tbl_inward_dtl where batch_key  = '"+cmbBatch.SelectedValue.ToString()+"'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                i = dt.Rows[0][0].ToString();
            }
                return i;
        }
        private void ShowEnteredData()
        {
            dgvMain.DataSource = null;
            DataTable dtRecord = new DataTable();
            string sqlStr = "select BRSNo,FileGpfNo,section,Year,Pensioner_name,Page_count from tbl_inward_dtl where batch_key = '"+cmbBatch.SelectedValue.ToString()+"' order by inward_id desc";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dtRecord);
            if(dtRecord.Rows.Count>0)
            {
                dgvMain.DataSource = null;
                dgvMain.DataSource = dtRecord;
            }
        }
        private void deButtonSave_Click(object sender, EventArgs e)
        {
            if(cmbFinancialyear.Text == "")
            {
                MessageBox.Show(this, "Please select Financial year", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbFinancialyear.Focus();
                return;
            }
            string Gpo_no = txtfileNo.Text + "/" + cmbFinancialyear.Text;
            string rackno = txtBundleNo.Text + "/" + txtRackNo.Text + "/" + txtShelfNo.Text;
            OdbcCommand sqlCmdPolicy = new OdbcCommand();
            OdbcCommand sqlRawdata = new OdbcCommand();
            try
            {
                string sqlStr = "insert into tbl_inward_dtl(sendingDate,groupName,BRSNo,Record_type,FileGPFNO,Section,year,page_count,pensioner_name,batch_key) values ('" + dtpSendingDate.Text + "','" + txtGroupNmae.Text + "','" + rackno + "','" + cmbRecordtype.Text + "','" + Gpo_no+ "','" + cmbsection.SelectedValue.ToString() + "','" + txtYear.Text + "','"+txtpage_count.Text.Trim()+"','"+txtPensioerName.Text.Trim()+"','"+cmbBatch.SelectedValue.ToString()+"')";
                sqlCmdPolicy.Connection = sqlCon;;
                sqlCmdPolicy.CommandText = sqlStr;

                int i = sqlCmdPolicy.ExecuteNonQuery();
                if (i > 0)
                {
                    string Rcount = recordcount();
                    MessageBox.Show(this, "Record saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult dlg = MessageBox.Show(this, "You Have entered :"+Rcount + " Records,Do you want to add more record to the selected Batch","",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    toolStripStatusLabel1.Text = "You Have Entered : " + Rcount + " Records";
                    if (Convert.ToInt32(Rcount) >=25)
                    {
                        MessageBox.Show(this, "You Have entered 25 Records,Create a separate Batch For further Entry", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        updateBatchStatus();
                        this.Close();
                    }
                    if(dlg == DialogResult.Yes)
                    {
                        clearFields();
                        ShowEnteredData();
                        txtBundleNo.Focus();
                    }
                    else
                    {
                        updateBatchStatus();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Error while Saving Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearFields()
        {
            txtBundleNo.Text = "";
            txtRackNo.Text = "";
            txtShelfNo.Text = "";
            txtfileNo.Text = "";
            cmbFinancialyear.Text = "";
            txtPensioerName.Text = "";
         
            cmbsection.Text = "";
            txtpage_count.Text = "";
            txtYear.Text = "";
            txtpage_count.Text = "";


        }
        private void updateBatchStatus()
        {
            OdbcCommand sqlCmdPolicy = new OdbcCommand();
            OdbcCommand sqlRawdata = new OdbcCommand();
            try
            {
                string sqlStr = "update batch_master set status = '1' where batch_key = '" + cmbBatch.SelectedValue.ToString() + "'";
                sqlCmdPolicy.Connection = sqlCon; ;
                sqlCmdPolicy.CommandText = sqlStr;
                sqlCmdPolicy.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = getBatchDetails();
            if(dt.Rows.Count>0)
            {
                txtGroupNmae.Text = dt.Rows[0][0].ToString();
                cmbRecordtype.Text = dt.Rows[0][1].ToString();
            }
            ShowEnteredData();
        }
        private DataTable getBatchDetails()
        {
            DataTable dt = new DataTable();
            string sqlStr = "select dept_name, category from batch_master where batch_key = '"+cmbBatch.SelectedValue.ToString()+"'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            return dt;
        }

        private void cmbBatch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = getBatchDetails();
            if (dt.Rows.Count > 0)
            {
                txtGroupNmae.Text = dt.Rows[0][0].ToString();
                cmbRecordtype.Text = dt.Rows[0][1].ToString();
            }
            ShowEnteredData();
        }

        private void cmbFinancialyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtYear.Text = cmbFinancialyear.Text;
        }

        private void mskBRS_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                        SendKeys.Send("{tab}");
            }
        }

        private void txtpage_count_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtpage_count.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtpage_count.Text = txtpage_count.Text.Remove(txtpage_count.Text.Length - 1);
            }
        }

        private void txtPensioerName_Leave(object sender, EventArgs e)
        {
            if (txtPensioerName.Text == "")
            {
                MessageBox.Show("Please enter Pensioners Name.");
                txtPensioerName.Focus();
                return;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtBundleNo_Leave(object sender, EventArgs e)
        {
            txtBundleNo.Text = txtBundleNo.Text.PadLeft(3, '0');
        }

        private void txtRackNo_Leave(object sender, EventArgs e)
        {
            txtRackNo.Text = txtRackNo.Text.PadLeft(2, '0');
        }

        private void txtShelfNo_Leave(object sender, EventArgs e)
        {
            txtShelfNo.Text = txtShelfNo.Text.PadLeft(2, '0');
        }
    }
}

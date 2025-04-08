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
    public partial class frmDigiDEPT : Form
    {
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        private string Mode = string.Empty;
        public frmDigiDEPT(OdbcConnection prmCon, Credentials prmCrd)
        {
            sqlCon = prmCon;
            crd = prmCrd;
            InitializeComponent();
            populateBatch();
        }
        private void populateBatch()
        {
            DataTable dt = new DataTable();
            string sqlstr = "select batch_code,batch_key from batch_master where status = '1'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlstr, sqlCon);
            odap.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                cmbBatch.DataSource = dt;
                cmbBatch.DisplayMember = "batch_code";
                cmbBatch.ValueMember = "batch_key";
                cmbBatch.SelectedIndex = 0;
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

        private void cmdShow_Click(object sender, EventArgs e)
        {
            if (cmbBatch.Text != "")
            {
                populateRecord();
                populateInwardDetails();
            }
        }
        public void populateInwardDetails()
        {
            DataTable dt = new DataTable();
            string sqlStr = "select batch_code,batch_key from batch_master where status = '2' and digi_recipt = 'YES'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
        }
        private void populateRecord()
        {
            DataTable dt = new DataTable();
            string sqlstr = "select department,subcat,state_name,filename,emp_name,desg,fileid,birth_date,joining_date,death_date,retirement_date,psa_name,section,pension_file_no,ppo_fppo,gpo_dgpo,mobile,hrms_id,spouce,created_by,created_dttm,BRSNo,page_count,Sending_date from metadata_entry where batch_key  = '" + cmbBatch.SelectedValue.ToString()+"'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlstr, sqlCon);
            odap.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                dgvMain.Columns.Clear();
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "SelectColumn";
                checkboxColumn.DataPropertyName = "IsSelected"; // Bind to 'IsSelected' property of MyData
                dgvMain.Columns.Add(checkboxColumn);
                dgvMain.DataSource = null;
                dgvMain.DataSource = dt;
                dgvMain.Columns[0].Width = 50;
                for(int i = 0;i<dgvMain.Rows.Count;i++)
                {
                    dgvMain.Rows[i].Selected = false;
                    dgvMain.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                dgvMain.DataSource = null;
            }
        }

        private void frmDigiDEPT_Load(object sender, EventArgs e)
        {
            cmbdigiRecpt.Items.Add("");
            cmbdigiRecpt.Items.Add("YES");
            cmbdigiRecpt.Items.Add("NO");
            cmbdigireturn.Items.Add("");
            cmbdigireturn.Items.Add("YES");
            cmbdigireturn.Items.Add("NO");
            cmbdigireturn.Enabled = false;
            dtpdigi_return.Enabled = false;
        }

        private void cmbdigiRecpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpdigi_recipt.Text = DateTime.Now.ToString("ddMMyyyy");
        }

        private void cmbdigireturn_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpdigi_return.Text = DateTime.Now.ToString("ddMMyyyy");
        }

        private void deButtonSave_Click(object sender, EventArgs e)
        {
            OdbcCommand sqlCmdPolicy = new OdbcCommand();
            OdbcCommand sqlCmdPolicy1 = new OdbcCommand();
            OdbcCommand sqlRawdata = new OdbcCommand();
            OdbcCommand sqlRawdata1 = new OdbcCommand();
            string sqlStr = string.Empty;
            string sql = string.Empty;
            try
            {
                if (ckhState.Checked == true)
                {
                    if (cmbdigireturn.Text == "")
                    {
                        MessageBox.Show(this, "Please Select YES/ NO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbdigireturn.Focus();
                        return;
                    }
                    sqlStr = "update metadata_entry set DIGI_CELL_RETRN = '" + cmbdigiRecpt.Text + "',DIGI_CELL_RETRN_DT = '" + dtpdigi_recipt.Text + "',DIGI_CELL_REMK = '" + txtdigiremark.Text + "' where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";
                    sql = "update Batch_master set digi_return = '" + cmbdigireturn.Text + "',digi_return_dt = '" + dtpdigi_return.Text + "',digi_rmk = '" + txtdigiremark.Text + "' where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";
               }
                else
                {
                    if (cmbdigiRecpt.Text == "")
                    {
                        MessageBox.Show(this, "Please Select YES/ NO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbdigiRecpt.Focus();
                        return;
                    }
                    sqlStr = "update metadata_entry set DIGI_CELL_RECPT = '" + cmbdigiRecpt.Text + "',DIGI_CELL_RECT_DT = '" + dtpdigi_recipt.Text + "',DIGI_CELL_REMK = '" + txtdigiremark.Text + "' where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";
                    sql = "update Batch_master set digi_recipt = '" + cmbdigiRecpt.Text + "',digi_recipt_dt = '" + dtpdigi_recipt.Text + "',digi_rmk = '" + txtdigiremark.Text + "' where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";
                }
                sqlCmdPolicy.Connection = sqlCon; ;
                sqlCmdPolicy.CommandText = sqlStr;
                sqlCmdPolicy.ExecuteNonQuery();

                
                sqlCmdPolicy1.Connection = sqlCon; ;
                sqlCmdPolicy1.CommandText = sql;
                sqlCmdPolicy1.ExecuteNonQuery();

                updateBatchStatus();
                populateBatch();
                MessageBox.Show(this, "Record Recived Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMain.Columns.Clear();
                dgvMain.DataSource = null;
                cmbdigiRecpt.Text = "";
                dtpdigi_recipt.Text = "";
                cmbdigireturn.Text = "";
                dtpdigi_return.Text = "";
                txtdigiremark.Text = "";
                ckhState.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateBatchStatus()
        {
            OdbcCommand sqlCmdPolicy = new OdbcCommand();
            OdbcCommand sqlRawdata = new OdbcCommand();
            try
            {
                string sqlStr = "update batch_master set status = '2' where batch_key = '" + cmbBatch.SelectedValue.ToString() + "'";
                sqlCmdPolicy.Connection = sqlCon; ;
                sqlCmdPolicy.CommandText = sqlStr;
                sqlCmdPolicy.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ckhState_CheckedChanged(object sender, EventArgs e)
        {
            if(ckhState.Checked == true)
            {
                Mode = "OUT";
                cmbdigireturn.Enabled = true;
                cmbdigiRecpt.Enabled = false;
                dgvMain.Columns.Clear();
                dgvMain.DataSource = null;
                populateBatchOutwardBAtches();
            }
            else
            {
                Mode = "IN";
                cmbdigireturn.Enabled = false;
                dtpdigi_return.Enabled = false;
                cmbdigiRecpt.Enabled = true;
                cmbBatch.DataSource = null;
                dgvMain.Columns.Clear();
                dgvMain.DataSource = null;
                populateBatch();
            }
        }

        public void populateBatchOutwardBAtches()
        {
            DataTable dt = new DataTable();
            string sqlStr = "select batch_code,batch_key from batch_master where status = '3' and digi_recipt = 'YES' and vendor_return = 'YES'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            cmbBatch.DataSource = null;

            if (dt.Rows.Count > 0)
            {
                cmbBatch.DataSource = null;
                cmbBatch.DataSource = dt;
                cmbBatch.DisplayMember = "batch_code";
                cmbBatch.ValueMember = "batch_key";
                cmbBatch.SelectedIndex = 0;
                dgvMain.Columns.Clear();
                dgvMain.DataSource = null;
                
            }
            else 
            {
                cmbBatch.DataSource = null;
            }
        }
    }
}

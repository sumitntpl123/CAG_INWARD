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
    public partial class frmInwardPA : Form
    {
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public frmInwardPA(OdbcConnection prmCon, Credentials prmCrd)
        {
            sqlCon = prmCon;
            crd = prmCrd;
            InitializeComponent();
            populateBatch();
        }
        private void populateBatch()
        {
            DataTable dt = new DataTable();
            string sqlstr = "select batch_code,batch_key from batch_master where status = '2' and vendor_return = 'YES' and digi_return = 'YES'";
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
            }
        }
        private void populateRecord()
        {
            DataTable dt = new DataTable();
            string sqlstr = "select department,subcat,state_name,filename,emp_name,desg,fileid,birth_date,joining_date,death_date,retirement_date,psa_name,section,pension_file_no,ppo_fppo,gpo_dgpo,mobile,hrms_id,spouce,created_by,created_dttm,BRSNo,page_count,Sending_date from metadata_entry where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";
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
                for (int i = 0; i < dgvMain.Rows.Count; i++)
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

        private void frmInwardPA_Load(object sender, EventArgs e)
        {
            cmbdigiRecpt.Items.Add("");
            cmbdigiRecpt.Items.Add("YES");
            cmbdigiRecpt.Items.Add("NO");

        }

        private void cmbdigiRecpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpdigi_recipt.Text = DateTime.Now.ToString("ddMMyyyy");
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
                    if (cmbdigiRecpt.Text == "")
                    {
                        MessageBox.Show(this, "Please Select YES/ NO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbdigiRecpt.Focus();
                        return;
                    }
                    sqlStr = "update metadata_entry set SEC_RETURN = '" + cmbdigiRecpt.Text + "',SEC_RETURN_DT = '" + dtpdigi_recipt.Text + "',SEC_REMK = '" + txtdigiremark.Text + "' where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";
                    sql = "update Batch_master set Sec_Recv = '" + cmbdigiRecpt.Text + "',Sec_recv_dt = '" + dtpdigi_recipt.Text + "',Sec_rmk = '" + txtdigiremark.Text + "' where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";

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
                txtdigiremark.Text = "";

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
                string sqlStr = "update batch_master set status = '3' where batch_key = '" + cmbBatch.SelectedValue.ToString() + "'";
                sqlCmdPolicy.Connection = sqlCon; ;
                sqlCmdPolicy.CommandText = sqlStr;
                sqlCmdPolicy.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

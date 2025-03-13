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
    public partial class frmNevaeh : Form
    {
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public frmNevaeh(OdbcConnection prmCon, Credentials prmCrd)
        {
            sqlCon = prmCon;
            crd = prmCrd;
            InitializeComponent();
            populateBatch();
        }
        private void populateBatch()
        {
            DataTable dt = new DataTable();
            string sqlstr = "select batch_code,batch_key from batch_master where status = '2'";
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

        private void frmNevaeh_Load(object sender, EventArgs e)
        {
            cmbdigiRecpt.Items.Add("YES");
            cmbdigiRecpt.Items.Add("NO");
            cmbdigireturn.Items.Add("YES");
            cmbdigireturn.Items.Add("NO");
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
            dgvMain.DataSource = null;
            DataTable dt = new DataTable();
            string sqlstr = "select sendingDate,groupName,BRSNo,Record_type,FileGPFNO,Section,year,pensioner_name,page_count from tbl_inward_dtl where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";
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

        private void cmbdigiRecpt_Leave(object sender, EventArgs e)
        {

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
            OdbcCommand sqlRawdata = new OdbcCommand();
            try
            {
                string sqlStr = "update tbl_inward_dtl set VEND_RECIPT = '"+cmbdigiRecpt.Text+"',VEND_RECPT_DT = '"+dtpdigi_recipt+"',VEND_RMK = '' where batch_key  = '"+cmbBatch.SelectedValue.ToString()+"'";
                sqlCmdPolicy.Connection = sqlCon; ;
                sqlCmdPolicy.CommandText = sqlStr;
                sqlCmdPolicy.ExecuteNonQuery();
                updateBatchStatus();
                populateBatch();
                MessageBox.Show(this, "Record Recived Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMain.DataSource = null;

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

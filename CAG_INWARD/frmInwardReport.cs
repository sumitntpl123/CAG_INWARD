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
    public partial class frmInwardReport : Form
    {
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public frmInwardReport(OdbcConnection prmCon, Credentials prmCrd)
        {
            sqlCon = prmCon;
            crd = prmCrd;
            InitializeComponent();
        }

        private void frmInwardReport_Load(object sender, EventArgs e)
        {

        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        { 
            DataTable dt = new DataTable();
            string sqlStr = "select batch_code,dept_name,category,created_by,Created_dttm,digi_recipt,digi_recipt_dt,vendor_recipt,vendor_recipt_dt,vendor_return,vendor_return_dt,digi_return,digi_return_dt,Sec_Recv,Sec_recv_dt from batch_master where created_dttm >='" + dtpStartDt.Value.ToString("yyyy-MM-dd") + "' and created_dttm <='" + dtpEndDate.Value.AddDays(1).ToString("yyyy-MM-dd") + "'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgvMain.DataSource = null;
                dgvMain.DataSource = dt;
                lblCount.Text = dt.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show(this, "No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}

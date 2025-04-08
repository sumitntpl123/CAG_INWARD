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
    public partial class Form1 : Form
    {
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public Form1(OdbcConnection prmCon, Credentials prmCrd)
        {
            sqlCon = prmCon;
            crd = prmCrd;
            InitializeComponent();
        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populate_User();
        }
        private void populate_User()
        {
            DataTable dt = new DataTable();
            string sqlStr = "select a.user_id from ac_user_role_map a,ac_role b where b.role_id in ('2','3','8') and a.role_id = b.role_id order by a.user_id";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            cmbUser.DataSource = dt;
            cmbUser.DisplayMember = "user_id";
            cmbUser.ValueMember = "user_id";
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlStr = "select sending_date,department,subcat,state_name,filename,emp_name,desg,fileid,birth_date,joining_date,death_date,retirement_date,psa_name,section,pension_file_no,ppo_fppo,gpo_dgpo,ppo_gpo_cpo,mobile,hrms_id,spouce from metadata_entry where created_by = '"+cmbUser.Text+ "' and created_dttm >='"+dtpStartDt.Value.ToString("yyyy-MM-dd") + "' and created_dttm <='" + dtpEndDate.Value.AddDays(1).ToString("yyyy-MM-dd")+"'"; 
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            if(dt.Rows.Count>0)
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

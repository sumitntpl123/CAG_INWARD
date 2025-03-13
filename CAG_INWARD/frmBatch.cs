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

    public partial class frmBatch : Form
    {

        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public static string dept;
        public frmBatch(OdbcConnection prmCon, Credentials prmCrd)
        {
            sqlCon = prmCon;
            crd = prmCrd;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBatch_Load(object sender, EventArgs e)
        {
            txtProject.Text = "CAG KOLKATA";
            txtProject.Enabled = false;
            txtCreateDate.Text = DateTime.Now.ToString("ddMMyyyy");
            populateDept();
            if (crd.role == "PensionAdmin")
            {
                deComboBox1.SelectedIndex = 0;
                deComboBox1.Enabled = false;
                deComboBox1_Leave(this, e);
            }
        }
        private void populateDeptCat()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string sql = "select cat_id, cat_name from tbl_category where dept_id IN (select dept_id from tbl_dept where dept_name = '" + deComboBox1.Text.Trim() + "')";

            OdbcDataAdapter odap = new OdbcDataAdapter(sql, sqlCon);
            odap.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                deComboBox2.DataSource = dt;
                deComboBox2.DisplayMember = "cat_name";
                deComboBox2.ValueMember = "cat_id";
            }
            else
            {
                deComboBox2.DataSource = null;
            }
            //else
            //{
            //    MessageBox.Show("Add one project first...");
            //}

        }
        public void populateDept()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string sql = "select dept_id, dept_name from tbl_dept order by dept_id";

            OdbcDataAdapter odap = new OdbcDataAdapter(sql, sqlCon);
            odap.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                deComboBox1.DataSource = dt;
                deComboBox1.DisplayMember = "dept_name";
                deComboBox1.ValueMember = "dept_id";

                //populateDeptCat();
            }
            //else
            //{
            //    MessageBox.Show("Add one project first...");
            //}
        }
        private void deButton1_Click(object sender, EventArgs e)
        {
            DateTime temp;
            //string isDate = dateTimePicker1.Text;
            string currDate = DateTime.Now.ToString("yyyy-MM-dd");

            if ((txtCreateDate.Text != "" || txtCreateDate.Text != null))
            {

                if (deComboBox1.Text != null || deComboBox1.Text != "")
                {
                    //P_CR_5
                    string depAnno = string.Empty;
                    if (deComboBox1.Text.ToLower() == "ge" || deComboBox1.Text.ToLower() == "admin")
                    {
                        depAnno = deComboBox1.Text.ToString().Substring(0, 2).ToUpper(); // GE or AD
                    }
                    else { depAnno = deComboBox1.Text.ToString().Substring(0, 1).ToUpper(); }//P or G 

                    string subCat = string.Empty;
                    if (deComboBox2.Text == "Pension Case File")
                    { subCat = "CF"; }
                    else if (deComboBox2.Text == "Pension Case Registers")
                    { subCat = "CR"; }
                    else if (deComboBox2.Text == "Pension Rule Files")
                    { subCat = "RR"; }
                    else if (deComboBox2.Text == "Ledger Cards")
                    { subCat = "LC"; }
                    else if (deComboBox2.Text == "Nomination")
                    { subCat = "NM"; }
                    else if (deComboBox2.Text == "Final Payment Case File")
                    { subCat = "FP"; }
                    string bundleCount = string.Empty;
                    if (subCat == "CR")
                    {
                        //deComboBox3.Enabled = true;
                        if (deComboBox3.Text != "")
                        {
                            bundleCount = depAnno + "_" + subCat + "_" + deComboBox3.Text + "_" + getBundleCount(deComboBox1.Text, deComboBox2.Text);
                        }
                        else
                        { return; }
                    }
                    else
                    {
                        if (deComboBox1.Text.ToLower() == "ge" || deComboBox1.Text.ToLower() == "admin")
                        {
                            bundleCount = depAnno + "_" + getBundleCount(deComboBox1.Text, deComboBox2.Text);
                        }
                        else
                        {
                            bundleCount = depAnno + "_" + subCat + "_" + getBundleCount(deComboBox1.Text, deComboBox2.Text);
                        }
                    }



                    string bundleCode = bundleCount;

                    textBox3.Text = bundleCode;
                    textBox4.Text = bundleCode;

                    button2.Enabled = true;

                }
            }
        }
        private string getBundleCount(string dep, string subCat)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string sql = "select Count(*) from batch_master where dept_name = '" + dep + "' and category = '" + subCat + "'";

            OdbcDataAdapter odap = new OdbcDataAdapter(sql, sqlCon);
            odap.Fill(dt);

            int count = Convert.ToInt32(dt.Rows[0][0].ToString());

            string getCount = Convert.ToString(count + 1);

            return getCount;
        }

        private void deComboBox1_Leave(object sender, EventArgs e)
        {
            if (deComboBox1.Text != "" || deComboBox1.Text != null || deComboBox1.Text != string.Empty || !string.IsNullOrEmpty(deComboBox1.Text))
            {
                if (deComboBox1.Text.ToLower() == "ge" || deComboBox1.Text.ToLower() == "admin")
                {
                    deComboBox2.Enabled = false;
                    deComboBox3.Enabled = false;
                }
                else
                {
                    deComboBox2.Enabled = true;
                }
                populateDeptCat();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdbcCommand sqlCmdPolicy = new OdbcCommand();
            OdbcCommand sqlRawdata = new OdbcCommand();
            string sqlstr = "insert into batch_master(dept_name,category,batch_code,batch_name,created_by,created_dttm) values('"+deComboBox1.Text+ "','" + deComboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + crd.created_by+"','"+crd.created_dttm+"')";
            sqlCmdPolicy.Connection = sqlCon;
            sqlCmdPolicy.CommandText = sqlstr;
            try
            {
                int i = sqlCmdPolicy.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show(this, "Batch Created Successfully!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Error While Creating Batch", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString() + "Contact Neaveh Technology", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
using Excel = Microsoft.Office.Interop.Excel;
namespace CAG_INWARD
{
    public partial class frmDownloadCSV : Form
    {
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public frmDownloadCSV(OdbcConnection prmCon, Credentials prmCrd)
        {
            sqlCon = prmCon;
            crd = prmCrd;
            InitializeComponent();
            populateBatch();
        }
        private void populateBatch()
        {
            DataTable dt = new DataTable();
            string sqlstr = "select batch_code,batch_key from batch_master where status = '3' and digi_recipt = 'YES' and vendor_recipt = 'YES'";
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
        private void cmdAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlStr = "select department,subcat,state_name,filename,emp_name,desg,fileid,birth_date,joining_date,death_date,retirement_date,psa_name,section,pension_file_no,ppo_fppo,gpo_dgpo,mobile,hrms_id,spouce,created_by,created_dttm,BRSNo,page_count,Sending_date from metadata_entry where batch_key = '" + cmbBatch.SelectedValue.ToString()+"' order by inward_id";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                dgvMain.DataSource = null;
                dgvMain.DataSource = dt;
                lblCount.Text = dt.Rows.Count.ToString();
            }
        }

        private void cmddownload_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.DoEvents();
            pgb.Style = ProgressBarStyle.Marquee;
            pgb.MarqueeAnimationSpeed = 30;
            excelExport();
            cmddownload.Enabled = false;
            MessageBox.Show(this, "CSV Generated Successfully...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void excelExport()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            if (!Directory.Exists(path + "\\Nevaeh\\"))
            {
                Directory.CreateDirectory(path + "\\Nevaeh\\");
            }
            tabTextFile(dgvMain, path + "\\Nevaeh\\" + cmbBatch.Text + ".csv");
        }
        private void tabTextFile(DataGridView dg, string filename)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dtSource = null;
            System.Data.DataTable dt = new System.Data.DataTable();
            DataRow dr;
            if (dg.DataSource != null)
            {
                if (dg.DataSource.GetType() == typeof(DataSet))
                {
                    DataSet dsSource = (DataSet)dg.DataSource;
                    if (dsSource.Tables.Count > 0)
                    {
                        string strTables = string.Empty;
                        foreach (System.Data.DataTable dt1 in dsSource.Tables)
                        {
                            strTables += TableToString(dt1);
                            //strTables += "\r\n\r\n";
                        }
                        if (strTables != string.Empty)
                            SaveDataGridData(strTables, filename);
                    }
                }
                else
                {
                    if (dg.DataSource.GetType() == typeof(System.Data.DataTable))
                        dtSource = (System.Data.DataTable)dg.DataSource;
                    if (dtSource != null)

                        SaveDataGridData(TableToString(dtSource), filename);
                }
            }
        }
        private void SaveDataGridData(string strData, string strFileName)
        {
            FileStream fs;
            TextWriter tw = null;
            try
            {
                if (File.Exists(strFileName))
                {
                    fs = new FileStream(strFileName, FileMode.Open);
                }
                else
                {
                    fs = new FileStream(strFileName, FileMode.Create);
                }
                tw = new StreamWriter(fs);
                tw.Write(strData);
            }
            finally
            {
                if (tw != null)
                {
                    tw.Flush();
                    tw.Close();
                }
            }
        }

        private string TableToString(System.Data.DataTable dt)
        {
            string strData = string.Empty;
            string sep = string.Empty;
            if (dt.Rows.Count > 0)
            {
                foreach (DataColumn c in dt.Columns)
                {
                    if (c.DataType != typeof(System.Guid) &&
                    c.DataType != typeof(System.Byte[]))
                    {
                        strData += sep + c.ColumnName;
                        sep = ",";
                    }
                }
                strData += "\r\n";
                foreach (DataRow r in dt.Rows)
                {
                    sep = string.Empty;
                    foreach (DataColumn c in dt.Columns)
                    {
                        if (c.DataType != typeof(System.Guid) &&
                        c.DataType != typeof(System.Byte[]))
                        {
                            if (!Convert.IsDBNull(r[c.ColumnName]))

                                strData += sep +
                                '"' + r[c.ColumnName].ToString().Replace("\n", "").Replace(",", "-").Replace("\r", "") + '"';

                            else

                                strData += sep + "";
                            sep = ",";

                        }
                    }
                    strData += "\r\n";

                }
            }
            else
            {
                //strData += "\r\n---> Table was empty!";
                foreach (DataColumn c in dt.Columns)
                {
                    if (c.DataType != typeof(System.Guid) &&
                    c.DataType != typeof(System.Byte[]))
                    {
                        strData += sep + c.ColumnName;
                        sep = ",";
                    }
                }
                strData += "\r\n";
            }
            return strData;
        }


    }
}

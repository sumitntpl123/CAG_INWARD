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
    public partial class frmInwardNew : Form
    {
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public string Mode = "Add";
        public frmInwardNew(OdbcConnection prmCon, Credentials prmCrd)
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
                    //ShowEnteredData();
                }
            }
            else
            {
                cmbBatch.DataSource = null;
            }
        }
        private DataTable getBatchDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                string sqlStr = "select dept_name, category from batch_master where batch_key = '" + cmbBatch.SelectedValue.ToString() + "'";
                OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
                odap.Fill(dt);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(this,"Create a Batch First..","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return dt;
        }
        private void deButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInwardNew_Load(object sender, EventArgs e)
        {
            txtsendingDate.Text = DateTime.Now.ToString("ddMMyyyy");
            txtPPO.Focus();
        }

        private void txtPPO_Leave(object sender, EventArgs e)
        {
            if (txtPPO.Text.Trim().Length > 0)
            {
                PopulateRecordFromMaster(txtPPO.Text.Trim());
            }
        }

        private void PopulateRecordFromMaster(string ppoNo)
        {
            DataTable dt = new DataTable();
            string sqlStr = "select * from tbl_master_data where ppo_fppo_no = '"+ppoNo+"'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            if(dt.Rows.Count>0)
            {
                txtEmpName.Text = dt.Rows[0][1].ToString();
                txtDesignation.Text = dt.Rows[0][2].ToString();
                txtFileID.Text = dt.Rows[0][3].ToString();
                string dob = dt.Rows[0][4].ToString();
                if (dob != "")
                {
                    string[] resultArray1 = dob.Split('/');
                    txtdobD.Text = resultArray1[0].ToString().Trim();
                    txtdobM.Text = resultArray1[1].ToString().Trim();
                    txtdobY.Text = resultArray1[2].ToString().Trim();
                }
                string doj = dt.Rows[0][5].ToString();
                if (doj != "")
                {
                    string[] resultArray2 = doj.Split('/');
                    txtdojD.Text = resultArray2[0].ToString().Trim();
                    txtdojM.Text = resultArray2[1].ToString().Trim();
                    txtdojY.Text = resultArray2[2].ToString().Trim();
                }
                string dor = dt.Rows[0][6].ToString();
                if (dor != "")
                {
                    string[] resultArray3 = dor.Split('/');
                    txtdorD.Text = resultArray3[0].ToString().Trim();
                    txtdorM.Text = resultArray3[1].ToString().Trim();
                    txtdorY.Text = resultArray3[2].ToString().Trim();
                }
                string dod = dt.Rows[0][7].ToString();
                if (dod != "")
                {
                    string[] resultArray4 = dod.Split('/');
                    txtdodD.Text = resultArray4[0].ToString().Trim();
                    txtdodM.Text = resultArray4[1].ToString().Trim();
                    txtdodY.Text = resultArray4[2].ToString().Trim();
                }
                txtPSA.Text = dt.Rows[0][8].ToString();
                txtSection.Text = dt.Rows[0][9].ToString();
                txtPensionCaseNo.Text = dt.Rows[0][10].ToString();
                txtPPO.Text = dt.Rows[0][11].ToString();
                txtGPO.Text = dt.Rows[0][12].ToString();
                txtMobile.Text = dt.Rows[0][13].ToString();
                txtHRMS.Text = dt.Rows[0][14].ToString();
                txtSpouse.Text = dt.Rows[0][15].ToString();
                DisableREcord();
                txtBundleNo.Focus();
            }
            else
            {
                MessageBox.Show(this, "No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dlg = MessageBox.Show(this, "Do You Want to Search By File ID", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlg == DialogResult.Yes)
                {
                    txtPPO.Text = "";
                    txtFileID.Focus();
                }
            }
        }
        private void DisableREcord()
        {
            grpmain.Enabled = false;
        }

        private void txtFileID_Leave(object sender, EventArgs e)
        {
            if (txtFileID.Text.Trim().Length > 0)
            {
                PopulateRecordFromMasterwithFile(txtFileID.Text.Trim());
            }
        }
        private void PopulateRecordFromMasterwithFile(string fileID)
        {
            DataTable dt = new DataTable();
            string sqlStr = "select * from tbl_master_data where fileid = '" + fileID + "'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtEmpName.Text = dt.Rows[0][1].ToString();
                txtDesignation.Text = dt.Rows[0][2].ToString();
                txtFileID.Text = dt.Rows[0][3].ToString();
                string dob = dt.Rows[0][4].ToString();
                if (dob != "")
                {
                    string[] resultArray1 = dob.Split('/');
                    txtdobD.Text = resultArray1[0].ToString().Trim();
                    txtdobM.Text = resultArray1[1].ToString().Trim();
                    txtdobY.Text = resultArray1[2].ToString().Trim();
                }
                string doj = dt.Rows[0][5].ToString();
                if (doj != "")
                {
                    string[] resultArray2 = doj.Split('/');
                    txtdojD.Text = resultArray2[0].ToString().Trim();
                    txtdojM.Text = resultArray2[1].ToString().Trim();
                    txtdojY.Text = resultArray2[2].ToString().Trim();
                }
                string dor = dt.Rows[0][6].ToString();
                if (dor != "")
                {
                    string[] resultArray3 = dor.Split('/');
                    txtdorD.Text = resultArray3[0].ToString().Trim();
                    txtdorM.Text = resultArray3[1].ToString().Trim();
                    txtdorY.Text = resultArray3[2].ToString().Trim();
                }
                string dod = dt.Rows[0][7].ToString();
                if (dod != "")
                {
                    string[] resultArray4 = dod.Split('/');
                    txtdodD.Text = resultArray4[0].ToString().Trim();
                    txtdodM.Text = resultArray4[1].ToString().Trim();
                    txtdodY.Text = resultArray4[2].ToString().Trim();
                }
                txtPSA.Text = dt.Rows[0][8].ToString();
                txtSection.Text = dt.Rows[0][9].ToString();
                txtPensionCaseNo.Text = dt.Rows[0][10].ToString();
                txtPPO.Text = dt.Rows[0][11].ToString();
                txtGPO.Text = dt.Rows[0][12].ToString();
                txtMobile.Text = dt.Rows[0][13].ToString();
                txtHRMS.Text = dt.Rows[0][14].ToString();
                txtSpouse.Text = dt.Rows[0][15].ToString();
                DisableREcord();
                txtBundleNo.Focus();
            }
            else
            {
                MessageBox.Show(this, "No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBundleNo_Leave(object sender, EventArgs e)
        {
            txtBundleNo.Text = txtBundleNo.Text.PadLeft(3, '0');
        }

        private void txtRackNo_Leave(object sender, EventArgs e)
        {
            txtRackNo.Text = txtRackNo.Text.PadLeft(3, '0');
        }

        private void txtShelfNo_Leave(object sender, EventArgs e)
        {
            txtShelfNo.Text = txtShelfNo.Text.PadLeft(3, '0');
        }

        private void txtpage_count_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtpage_count.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtpage_count.Text = txtpage_count.Text.Remove(txtpage_count.Text.Length - 1);
            }
        }

        private void deButtonSave_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            if (txtFileID.Text.Trim().Length > 0)
            {
                fileName = txtFileID.Text.Trim();
            }
            if (txtPensionCaseNo.Text.Trim().Length >0)
            {
                fileName = txtPensionCaseNo.Text.Trim();
            }
            if(txtBundleNo.Text.Trim() == "")
            {
                MessageBox.Show(this, "Please Enter Bundle No", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBundleNo.Focus();
                return;
            }
            if (txtRackNo.Text.Trim() == "")
            {
                MessageBox.Show(this, "Please Enter Rack No", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRackNo.Focus();
                return;
            }
            if (txtShelfNo.Text.Trim() == "")
            {
                MessageBox.Show(this, "Please Enter Shelf No", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtShelfNo.Focus();
                return;
            }
            if (txtpage_count.Text.Trim() == "")
            {
                MessageBox.Show(this, "Please Enter Page Count", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpage_count.Focus();
                return;
            }
            string rackno = txtBundleNo.Text + "/" + txtRackNo.Text + "/" + txtShelfNo.Text;
            OdbcCommand sqlCmdPolicy = new OdbcCommand();
            OdbcCommand sqlRawdata = new OdbcCommand();
            string bDate = string.Empty;
            string joinDate = string.Empty;
            string rDate = string.Empty;
            string dDate = string.Empty;
            try
            {
                if (txtdobD.Text != "" && txtdobM.Text != "" && txtdobY.Text != "")
                {
                    bDate = txtdobD.Text + "-" + txtdobM.Text + "-" + txtdobY.Text;
                }
                else
                {
                    bDate = "";
                }

                if (txtdojD.Text != "" && txtdojM.Text != "" && txtdojY.Text != "")
                {
                    joinDate = txtdojD.Text + "-" + txtdojM.Text + "-" + txtdojY.Text;
                }
                else
                {
                    joinDate = "";
                }

                if (txtdorD.Text != "" && txtdorM.Text != "" && txtdorY.Text != "")
                {
                    rDate = txtdorD.Text + "-" + txtdorM.Text + "-" + txtdorY.Text;
                }
                else
                {
                    rDate = "";
                }
                if (txtdodD.Text != "" && txtdodM.Text != "" && txtdodY.Text != "")
                {
                    dDate = txtdodD.Text + "-" + txtdodM.Text + "-" + txtdodY.Text;
                }
                else
                {
                    dDate = "";
                }
                if (Mode == "Update")
                {
                    string sql = "update metadata_entry set BRSNO = '" + rackno + "',page_count = '" + txtpage_count.Text.Trim() + "' where ppo_fppo = '"+txtPPO.Text+"'";
                    sqlCmdPolicy.Connection = sqlCon; ;
                    sqlCmdPolicy.CommandText = sql;

                    int j = sqlCmdPolicy.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show(this, "Record Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        ShowEnteredData();
                        txtPPO.Focus();
                        Mode = "Add";
                        return;
                    }
                }
                string sqlStr = "insert into metadata_entry(proj_code,batch_key,department,subcat,state_name,filename,emp_name,desg,fileid,birth_date,joining_date,death_date,retirement_date,psa_name,section,pension_file_no,ppo_fppo,gpo_dgpo,mobile,hrms_id,spouce,created_by,created_dttm,BRSNo,page_count,Sending_date) values ('1','" + cmbBatch.SelectedValue.ToString() + "','" + txtGroupNmae.Text.ToString() + "','" + cmbRecordtype.Text.ToString().Replace("'", " ") + "','WEST BENGAL','" + fileName.ToString().Replace("'", " ") + "','" + txtEmpName.Text.ToString().Replace("'", " ") + "','" + txtDesignation.Text.Trim().ToString().Replace("'", " ") + "','" + txtFileID.Text.Trim().ToString().Replace("'", " ") + "','" + bDate + "','"+joinDate+"','"+dDate+"','"+rDate+"','"+txtPSA.Text.ToString().Replace("'"," ")+"','"+txtSection.Text.ToString().Replace("'", " ") + "','"+txtPensionCaseNo.Text.ToString().Replace("'", " ") + "','"+txtPPO.Text.ToString().Replace("'", " ") + "','"+txtGPO.Text.ToString().Replace("'", " ") + "','"+txtMobile.Text.ToString().Replace("'", " ") + "','"+txtHRMS.Text.ToString().Replace("'", " ") + "','"+txtSpouse.Text.ToString().Replace("'", " ") + "','"+crd.created_by+"','"+crd.created_dttm+"','"+ rackno + "','"+txtpage_count.Text+"','"+txtsendingDate.DateBritish+"')";
                sqlCmdPolicy.Connection = sqlCon; ;
                sqlCmdPolicy.CommandText = sqlStr;

                int i = sqlCmdPolicy.ExecuteNonQuery();
                if (i > 0)
                {
                    string Rcount = recordcount();
                    MessageBox.Show(this, "Record saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCount.Text = Rcount.ToString();
                    DialogResult dlg = MessageBox.Show(this, "You Have entered :" + Rcount + " Records,Do you want to add more record ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Convert.ToInt32(Rcount) >= 25)
                    {
                        MessageBox.Show(this, "You Have entered 25 Records,Create a separate Batch For further Entry", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        updateBatchStatus();
                        this.Close();
                    }
                    if (dlg == DialogResult.Yes)
                    {
                        clearFields();
                        ShowEnteredData();
                        txtPPO.Focus();
                    }
                    else
                    {
                        ShowEnteredData();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Error while Saving Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearFields()
        {
            grpmain.Enabled = true;
            txtBundleNo.Text = "";
            txtRackNo.Text = "";
            txtShelfNo.Text = "";
            txtFileID.Text = "";
            txtEmpName.Text = "";
            txtSection.Text = "";
            txtpage_count.Text = "";
            txtDesignation.Text = "";
            txtdobD.Text = "";
            txtdobM.Text = "";
            txtdobY.Text = "";
            txtdojD.Text = "";
            txtdojM.Text = "";
            txtdojY.Text = "";
            txtdorD.Text = "";
            txtdorM.Text = "";
            txtdorY.Text = "";
            txtdodD.Text = "";
            txtdodM.Text = "";
            txtdodY.Text = "";
            txtPSA.Text = "";
            txtPensionCaseNo.Text = "";
            txtPPO.Text = "";
            txtGPO.Text = "";
            txtMobile.Text = "";
            txtHRMS.Text = "";
            txtSpouse.Text = "";

        }
        private void ShowEnteredData()
        {
            dgvMain.DataSource = null;
            DataTable dtRecord = new DataTable();
            string sqlStr = "select department,subcat,state_name,filename,emp_name,desg,fileid,birth_date,joining_date,death_date,retirement_date,psa_name,section,pension_file_no,ppo_fppo,gpo_dgpo,mobile,hrms_id,spouce,created_by,created_dttm,BRSNo,page_count,Sending_date from metadata_entry where batch_key = '" + cmbBatch.SelectedValue.ToString() + "' order by inward_id desc";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dtRecord);
            if (dtRecord.Rows.Count > 0)
            {
                dgvMain.DataSource = null;
                dgvMain.DataSource = dtRecord;
            }
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
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string recordcount()
        {
            string i = "0";
            DataTable dt = new DataTable();
            string sqlStr = "select Count(*) from metadata_entry where batch_key  = '" + cmbBatch.SelectedValue.ToString() + "'";
            OdbcDataAdapter odap = new OdbcDataAdapter(sqlStr, sqlCon);
            odap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                i = dt.Rows[0][0].ToString();
            }
            return i;
        }

        private void cmdFinishBatch_Click(object sender, EventArgs e)
        {
            updateBatchStatus();
            this.Close();
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

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtPPO_Leave_1(object sender, EventArgs e)
        {
            if (txtPPO.Text.Trim().Length > 0)
            {
                PopulateRecordFromMaster(txtPPO.Text.Trim());
            }
        }

        private void txtFileID_Leave_1(object sender, EventArgs e)
        {
            if (txtFileID.Text.Trim().Length > 0)
            {
                PopulateRecordFromMasterwithFile(txtFileID.Text.Trim());
            }
        }

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            Mode = "Update";
            string ppo_no = dgvMain.CurrentRow.Cells[14].Value.ToString();
            txtPPO.Text = ppo_no;
            txtPPO_Leave_1(this, e);//BRSNo
            string bsrNO = dgvMain.CurrentRow.Cells[21].Value.ToString();
            if (bsrNO != "")
            {
                string[] resultArray3 = bsrNO.Split('/');
                txtBundleNo.Text = resultArray3[0].ToString().Trim();
                txtRackNo.Text = resultArray3[1].ToString().Trim();
                txtShelfNo.Text = resultArray3[2].ToString().Trim();
            }
            txtpage_count.Text = dgvMain.CurrentRow.Cells[22].Value.ToString();

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using NovaNet.Utils;
using System.Data.Odbc;
using System.Reflection;
using System.Data.OleDb;
using System.Globalization;
using NovaNet;


namespace CAG_INWARD
{
    public partial class mdiMain : Form
    {
        private int childFormNumber = 0;
        OdbcConnection sqlCon = null;
        public Credentials crd;
        static int colorMode;
        dbCon dbcon;
        NovaNet.Utils.GetProfile pData;
        NovaNet.Utils.ChangePassword pCPwd;
        NovaNet.Utils.Profile p;
        public static NovaNet.Utils.IntrRBAC rbc;
        private short logincounter;
        public static string name;
        public mdiMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void inwardEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmInward1 inward = new frmInward1(sqlCon, crd);
            //inward.ShowDialog(this);
            frmInwardNew inward = new frmInwardNew(sqlCon, crd);
            inward.ShowDialog(this);
        }

        private void createBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatch batch = new frmBatch(sqlCon,crd);
            batch.ShowDialog(this);
        }

        private void digitisationDeptEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDigiDEPT digi = new frmDigiDEPT(sqlCon, crd);
            digi.ShowDialog(this);
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmNewUser user = new frmNewUser();
            //user.ShowDialog(this);
            AddNewUser nwUsr = new AddNewUser(getnwusrData, sqlCon);
            nwUsr.ShowDialog(this);
        }
        void getnwusrData(ref NovaNet.Utils.Profile prmp)
        {
            p = prmp;
            if (rbc.addUser(p.UserId, p.UserName, p.Role_des, p.Password) == false)
            {
                AddNewUser nwUsr = new AddNewUser(getnwusrData, sqlCon);
                nwUsr.ShowDialog(this);
            }
        }
        private void mdiMain_Load(object sender, EventArgs e)
        {
            dbcon = new NovaNet.Utils.dbCon();
            //try
            //{
            string dllPaths = string.Empty;
            dbcon = new NovaNet.Utils.dbCon();
            sqlCon = dbcon.Connect();



            if (sqlCon.State == ConnectionState.Open)
            {
                rbc = new NovaNet.Utils.RBAC(sqlCon, dbcon, pData, pCPwd);
                ////string test = sqlCon.Database;
                GetChallenge gc = new GetChallenge(getData);




                gc.ShowDialog(this);

                crd = rbc.getCredentials(p);

                name = crd.userName;
                if(crd.role == "Nevaeh")
                {
                    downloadCSVToolStripMenuItem.Visible = true;
                }
                if(crd.role == "Admin")
                {
                    createUserToolStripMenuItem.Visible = true;
                }
                
                if(crd.role == "RecordRoom")
                {
                    digitisationDeptEntryToolStripMenuItem.Visible = false;
                    nevaehInwardOutwardToolStripMenuItem.Visible = false;
                    inventoryReceiptToolStripMenuItem.Visible = true;
                }
                if (crd.role == "Digitisation")
                {
                    inwardEntryToolStripMenuItem.Visible = false;
                    nevaehInwardOutwardToolStripMenuItem.Visible = false;
                    createBatchToolStripMenuItem.Visible = false;
                    digitisationDeptEntryToolStripMenuItem.Visible = true;
                }
                if (crd.role == "Nevaeh")
                {
                    inwardEntryToolStripMenuItem.Visible = false;
                    digitisationDeptEntryToolStripMenuItem.Visible = false;
                    createBatchToolStripMenuItem.Visible = false;
                }
                if (crd.role == "PensionAdmin")
                {
                    digitisationDeptEntryToolStripMenuItem.Visible = false;
                    nevaehInwardOutwardToolStripMenuItem.Visible = false;
                    inventoryReceiptToolStripMenuItem.Visible = true;
                }
                if (crd.role == "GPFAdmin")
                {
                    digitisationDeptEntryToolStripMenuItem.Visible = false;
                    nevaehInwardOutwardToolStripMenuItem.Visible = false;
                }
            }
        }
        void getData(ref NovaNet.Utils.Profile prmp)
        {
            int i;
            p = prmp;
            for (i = 1; i <= 2; i++)
            {
                if (rbc.authenticate(p.UserId, p.Password) == false)
                {
                    if (logincounter == 2)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        logincounter++;
                        GetChallenge ogc = new GetChallenge(getData);
                        AssemblyName assemName = Assembly.GetExecutingAssembly().GetName();
                        
                        ogc.ShowDialog(this);
                    }
                }
                else
                {
                    if (rbc.CheckUserIsLogged(p.UserId))
                    {

                        p = rbc.getProfile();
                        crd = rbc.getCredentials(p);
                    }
                    else
                    {
                        p.UserId = null;
                        p.UserName = null;
                        GetChallenge ogc = new GetChallenge(getData);
                        AssemblyName assemName = Assembly.GetExecutingAssembly().GetName();
                        ogc.ShowDialog(this);
                    }
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdiMain main = new mdiMain();
            main.Show();
        }

        private void nevaehInwardOutwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNevaeh nevaeh = new frmNevaeh(sqlCon, crd);
            nevaeh.ShowDialog();
        }

        private void downloadCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDownloadCSV down = new frmDownloadCSV(sqlCon, crd);
            down.ShowDialog(this);
        }

        private void inwardReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInwardReport report = new frmInwardReport(sqlCon, crd);
            report.ShowDialog(this);
        }

        private void inventoryReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInwardPA pa = new frmInwardPA(sqlCon, crd);
            pa.ShowDialog(this);
        }

        private void entryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(sqlCon, crd);
            frm.ShowDialog(this);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PwdChange pwdCh = new PwdChange(ref p, getCPwd);
            pwdCh.ShowDialog(this);
        }
        void getCPwd(ref NovaNet.Utils.Profile prmpwd)
        {
            p = prmpwd;
            rbc.changePassword(p.UserId, p.UserName, p.Password);
        }
    }
}

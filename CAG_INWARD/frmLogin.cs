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
    public partial class frmLogin : Form
    {
        NovaNet.Utils.dbCon dbcon;
        OdbcConnection sqlCon = null;
        Credentials crd = new Credentials();
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(OdbcConnection prmCon)
        {
            InitializeComponent();
            dbcon = new NovaNet.Utils.dbCon();
            sqlCon = prmCon;
        }

        private void deButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deButtonSave_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

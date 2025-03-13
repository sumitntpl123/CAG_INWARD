
namespace CAG_INWARD
{
    partial class frmInward1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInward1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBatch = new nControls.deComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deButtonCancel = new nControls.deButton();
            this.deButtonSave = new nControls.deButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFinancialyear = new nControls.deComboBox();
            this.cmbsection = new nControls.deComboBox();
            this.deLabel3 = new nControls.deLabel();
            this.cmbRecordtype = new nControls.deTextBox();
            this.mskBRS = new System.Windows.Forms.MaskedTextBox();
            this.deLabel10 = new nControls.deLabel();
            this.txtpage_count = new nControls.deTextBox();
            this.deLabel9 = new nControls.deLabel();
            this.txtPensioerName = new nControls.deTextBox();
            this.deLabel8 = new nControls.deLabel();
            this.txtYear = new nControls.deTextBox();
            this.deLabel7 = new nControls.deLabel();
            this.deLabel6 = new nControls.deLabel();
            this.txtfileNo = new nControls.deTextBox();
            this.deLabel5 = new nControls.deLabel();
            this.deLabel4 = new nControls.deLabel();
            this.deLabel2 = new nControls.deLabel();
            this.deLabel1 = new nControls.deLabel();
            this.txtGroupNmae = new nControls.deTextBox();
            this.dtpSendingDate = new nControls.deDateBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBatch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 36);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Batch";
            // 
            // cmbBatch
            // 
            this.cmbBatch.BackColor = System.Drawing.Color.White;
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.ForeColor = System.Drawing.Color.Black;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(188, 9);
            this.cmbBatch.Mandatory = false;
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(309, 21);
            this.cmbBatch.TabIndex = 21;
            this.cmbBatch.SelectedIndexChanged += new System.EventHandler(this.cmbBatch_SelectedIndexChanged);
            this.cmbBatch.Click += new System.EventHandler(this.cmbBatch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deButtonCancel);
            this.groupBox2.Controls.Add(this.deButtonSave);
            this.groupBox2.Location = new System.Drawing.Point(10, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 60);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            // 
            // deButtonCancel
            // 
            this.deButtonCancel.BackColor = System.Drawing.Color.White;
            this.deButtonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deButtonCancel.BackgroundImage")));
            this.deButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deButtonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.deButtonCancel.Location = new System.Drawing.Point(412, 15);
            this.deButtonCancel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deButtonCancel.Name = "deButtonCancel";
            this.deButtonCancel.Size = new System.Drawing.Size(87, 35);
            this.deButtonCancel.TabIndex = 86;
            this.deButtonCancel.Text = "A&bort";
            this.deButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deButtonCancel.UseCompatibleTextRendering = true;
            this.deButtonCancel.UseVisualStyleBackColor = false;
            this.deButtonCancel.Click += new System.EventHandler(this.deButtonCancel_Click);
            // 
            // deButtonSave
            // 
            this.deButtonSave.BackColor = System.Drawing.Color.White;
            this.deButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deButtonSave.BackgroundImage")));
            this.deButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deButtonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deButtonSave.ForeColor = System.Drawing.Color.Black;
            this.deButtonSave.Location = new System.Drawing.Point(299, 15);
            this.deButtonSave.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deButtonSave.Name = "deButtonSave";
            this.deButtonSave.Size = new System.Drawing.Size(90, 35);
            this.deButtonSave.TabIndex = 6;
            this.deButtonSave.Text = "&Save";
            this.deButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deButtonSave.UseCompatibleTextRendering = true;
            this.deButtonSave.UseVisualStyleBackColor = false;
            this.deButtonSave.Click += new System.EventHandler(this.deButtonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.cmbFinancialyear);
            this.groupBox1.Controls.Add(this.cmbsection);
            this.groupBox1.Controls.Add(this.deLabel3);
            this.groupBox1.Controls.Add(this.cmbRecordtype);
            this.groupBox1.Controls.Add(this.mskBRS);
            this.groupBox1.Controls.Add(this.deLabel10);
            this.groupBox1.Controls.Add(this.txtpage_count);
            this.groupBox1.Controls.Add(this.deLabel9);
            this.groupBox1.Controls.Add(this.txtPensioerName);
            this.groupBox1.Controls.Add(this.deLabel8);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.deLabel7);
            this.groupBox1.Controls.Add(this.deLabel6);
            this.groupBox1.Controls.Add(this.txtfileNo);
            this.groupBox1.Controls.Add(this.deLabel5);
            this.groupBox1.Controls.Add(this.deLabel4);
            this.groupBox1.Controls.Add(this.deLabel2);
            this.groupBox1.Controls.Add(this.deLabel1);
            this.groupBox1.Controls.Add(this.txtGroupNmae);
            this.groupBox1.Controls.Add(this.dtpSendingDate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 304);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Entry Form";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbFinancialyear
            // 
            this.cmbFinancialyear.BackColor = System.Drawing.Color.White;
            this.cmbFinancialyear.ForeColor = System.Drawing.Color.Black;
            this.cmbFinancialyear.FormattingEnabled = true;
            this.cmbFinancialyear.Location = new System.Drawing.Point(337, 146);
            this.cmbFinancialyear.Mandatory = true;
            this.cmbFinancialyear.Name = "cmbFinancialyear";
            this.cmbFinancialyear.Size = new System.Drawing.Size(155, 21);
            this.cmbFinancialyear.TabIndex = 2;
            this.cmbFinancialyear.SelectedIndexChanged += new System.EventHandler(this.cmbFinancialyear_SelectedIndexChanged);
            // 
            // cmbsection
            // 
            this.cmbsection.BackColor = System.Drawing.Color.White;
            this.cmbsection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsection.ForeColor = System.Drawing.Color.Black;
            this.cmbsection.FormattingEnabled = true;
            this.cmbsection.Location = new System.Drawing.Point(183, 174);
            this.cmbsection.Mandatory = true;
            this.cmbsection.Name = "cmbsection";
            this.cmbsection.Size = new System.Drawing.Size(309, 21);
            this.cmbsection.TabIndex = 3;
            // 
            // deLabel3
            // 
            this.deLabel3.AutoSize = true;
            this.deLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel3.ForeColor = System.Drawing.Color.Black;
            this.deLabel3.Location = new System.Drawing.Point(319, 148);
            this.deLabel3.Name = "deLabel3";
            this.deLabel3.Size = new System.Drawing.Size(12, 15);
            this.deLabel3.TabIndex = 22;
            this.deLabel3.Text = "/";
            // 
            // cmbRecordtype
            // 
            this.cmbRecordtype.BackColor = System.Drawing.Color.White;
            this.cmbRecordtype.Enabled = false;
            this.cmbRecordtype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecordtype.ForeColor = System.Drawing.Color.Black;
            this.cmbRecordtype.Location = new System.Drawing.Point(183, 116);
            this.cmbRecordtype.Mandatory = true;
            this.cmbRecordtype.Name = "cmbRecordtype";
            this.cmbRecordtype.Size = new System.Drawing.Size(309, 23);
            this.cmbRecordtype.TabIndex = 21;
            // 
            // mskBRS
            // 
            this.mskBRS.BeepOnError = true;
            this.mskBRS.Location = new System.Drawing.Point(183, 88);
            this.mskBRS.Mask = "000/00/00";
            this.mskBRS.Name = "mskBRS";
            this.mskBRS.Size = new System.Drawing.Size(181, 20);
            this.mskBRS.TabIndex = 0;
            this.mskBRS.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mskBRS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskBRS_KeyUp);
            // 
            // deLabel10
            // 
            this.deLabel10.AutoSize = true;
            this.deLabel10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel10.ForeColor = System.Drawing.Color.Black;
            this.deLabel10.Location = new System.Drawing.Point(25, 261);
            this.deLabel10.Name = "deLabel10";
            this.deLabel10.Size = new System.Drawing.Size(93, 15);
            this.deLabel10.TabIndex = 19;
            this.deLabel10.Text = "Count of pages:";
            // 
            // txtpage_count
            // 
            this.txtpage_count.BackColor = System.Drawing.Color.White;
            this.txtpage_count.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpage_count.ForeColor = System.Drawing.Color.Black;
            this.txtpage_count.Location = new System.Drawing.Point(183, 261);
            this.txtpage_count.Mandatory = true;
            this.txtpage_count.Name = "txtpage_count";
            this.txtpage_count.Size = new System.Drawing.Size(309, 23);
            this.txtpage_count.TabIndex = 5;
            this.txtpage_count.TextChanged += new System.EventHandler(this.txtpage_count_TextChanged);
            // 
            // deLabel9
            // 
            this.deLabel9.AutoSize = true;
            this.deLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel9.ForeColor = System.Drawing.Color.Black;
            this.deLabel9.Location = new System.Drawing.Point(25, 234);
            this.deLabel9.Name = "deLabel9";
            this.deLabel9.Size = new System.Drawing.Size(141, 15);
            this.deLabel9.TabIndex = 17;
            this.deLabel9.Text = "Name of the pensioner :";
            // 
            // txtPensioerName
            // 
            this.txtPensioerName.BackColor = System.Drawing.Color.White;
            this.txtPensioerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensioerName.ForeColor = System.Drawing.Color.Black;
            this.txtPensioerName.Location = new System.Drawing.Point(183, 234);
            this.txtPensioerName.Mandatory = true;
            this.txtPensioerName.Name = "txtPensioerName";
            this.txtPensioerName.Size = new System.Drawing.Size(309, 23);
            this.txtPensioerName.TabIndex = 4;
            this.txtPensioerName.Leave += new System.EventHandler(this.txtPensioerName_Leave);
            // 
            // deLabel8
            // 
            this.deLabel8.AutoSize = true;
            this.deLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel8.ForeColor = System.Drawing.Color.Black;
            this.deLabel8.Location = new System.Drawing.Point(25, 202);
            this.deLabel8.Name = "deLabel8";
            this.deLabel8.Size = new System.Drawing.Size(42, 15);
            this.deLabel8.TabIndex = 15;
            this.deLabel8.Text = "YEAR :";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Enabled = false;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.Location = new System.Drawing.Point(183, 202);
            this.txtYear.Mandatory = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(309, 23);
            this.txtYear.TabIndex = 14;
            // 
            // deLabel7
            // 
            this.deLabel7.AutoSize = true;
            this.deLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel7.ForeColor = System.Drawing.Color.Black;
            this.deLabel7.Location = new System.Drawing.Point(25, 171);
            this.deLabel7.Name = "deLabel7";
            this.deLabel7.Size = new System.Drawing.Size(62, 15);
            this.deLabel7.TabIndex = 13;
            this.deLabel7.Text = "SECTION :";
            // 
            // deLabel6
            // 
            this.deLabel6.AutoSize = true;
            this.deLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel6.ForeColor = System.Drawing.Color.Black;
            this.deLabel6.Location = new System.Drawing.Point(24, 145);
            this.deLabel6.Name = "deLabel6";
            this.deLabel6.Size = new System.Drawing.Size(91, 15);
            this.deLabel6.TabIndex = 11;
            this.deLabel6.Text = "FILE / GPF/NO :";
            // 
            // txtfileNo
            // 
            this.txtfileNo.BackColor = System.Drawing.Color.White;
            this.txtfileNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfileNo.ForeColor = System.Drawing.Color.Black;
            this.txtfileNo.Location = new System.Drawing.Point(183, 145);
            this.txtfileNo.Mandatory = true;
            this.txtfileNo.Name = "txtfileNo";
            this.txtfileNo.Size = new System.Drawing.Size(130, 23);
            this.txtfileNo.TabIndex = 1;
            // 
            // deLabel5
            // 
            this.deLabel5.AutoSize = true;
            this.deLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel5.ForeColor = System.Drawing.Color.Black;
            this.deLabel5.Location = new System.Drawing.Point(24, 116);
            this.deLabel5.Name = "deLabel5";
            this.deLabel5.Size = new System.Drawing.Size(90, 15);
            this.deLabel5.TabIndex = 8;
            this.deLabel5.Text = "RECORD TYPE :";
            // 
            // deLabel4
            // 
            this.deLabel4.AutoSize = true;
            this.deLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel4.ForeColor = System.Drawing.Color.Black;
            this.deLabel4.Location = new System.Drawing.Point(25, 89);
            this.deLabel4.Name = "deLabel4";
            this.deLabel4.Size = new System.Drawing.Size(57, 15);
            this.deLabel4.TabIndex = 7;
            this.deLabel4.Text = "BRS NO :";
            // 
            // deLabel2
            // 
            this.deLabel2.AutoSize = true;
            this.deLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel2.ForeColor = System.Drawing.Color.Black;
            this.deLabel2.Location = new System.Drawing.Point(24, 59);
            this.deLabel2.Name = "deLabel2";
            this.deLabel2.Size = new System.Drawing.Size(92, 15);
            this.deLabel2.TabIndex = 4;
            this.deLabel2.Text = "GROUP NAME :";
            // 
            // deLabel1
            // 
            this.deLabel1.AutoSize = true;
            this.deLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel1.ForeColor = System.Drawing.Color.Black;
            this.deLabel1.Location = new System.Drawing.Point(24, 31);
            this.deLabel1.Name = "deLabel1";
            this.deLabel1.Size = new System.Drawing.Size(98, 15);
            this.deLabel1.TabIndex = 3;
            this.deLabel1.Text = "SENDING DATE :";
            // 
            // txtGroupNmae
            // 
            this.txtGroupNmae.BackColor = System.Drawing.Color.White;
            this.txtGroupNmae.Enabled = false;
            this.txtGroupNmae.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupNmae.ForeColor = System.Drawing.Color.Black;
            this.txtGroupNmae.Location = new System.Drawing.Point(183, 59);
            this.txtGroupNmae.Mandatory = true;
            this.txtGroupNmae.Name = "txtGroupNmae";
            this.txtGroupNmae.Size = new System.Drawing.Size(309, 23);
            this.txtGroupNmae.TabIndex = 1;
            // 
            // dtpSendingDate
            // 
            this.dtpSendingDate.Enabled = false;
            this.dtpSendingDate.Location = new System.Drawing.Point(183, 31);
            this.dtpSendingDate.Mandatory = true;
            this.dtpSendingDate.Name = "dtpSendingDate";
            this.dtpSendingDate.Size = new System.Drawing.Size(309, 20);
            this.dtpSendingDate.TabIndex = 0;
            this.dtpSendingDate.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMain);
            this.groupBox4.Location = new System.Drawing.Point(556, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(699, 401);
            this.groupBox4.TabIndex = 91;
            this.groupBox4.TabStop = false;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 16);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(693, 382);
            this.dgvMain.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1267, 22);
            this.statusStrip1.TabIndex = 92;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // frmInward1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 439);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInward1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInward1";
            this.Load += new System.EventHandler(this.frmInward1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private nControls.deComboBox cmbBatch;
        private System.Windows.Forms.GroupBox groupBox2;
        private nControls.deButton deButtonCancel;
        private nControls.deButton deButtonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private nControls.deLabel deLabel8;
        private nControls.deTextBox txtYear;
        private nControls.deLabel deLabel7;
        private nControls.deLabel deLabel6;
        private nControls.deTextBox txtfileNo;
        private nControls.deLabel deLabel5;
        private nControls.deLabel deLabel4;
        private nControls.deLabel deLabel2;
        private nControls.deLabel deLabel1;
        private nControls.deTextBox txtGroupNmae;
        private nControls.deDateBox dtpSendingDate;
        private System.Windows.Forms.MaskedTextBox mskBRS;
        private nControls.deLabel deLabel10;
        private nControls.deTextBox txtpage_count;
        private nControls.deLabel deLabel9;
        private nControls.deTextBox txtPensioerName;
        private nControls.deTextBox cmbRecordtype;
        private nControls.deLabel deLabel3;
        private nControls.deComboBox cmbsection;
        private nControls.deComboBox cmbFinancialyear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
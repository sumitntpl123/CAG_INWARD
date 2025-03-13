
namespace CAG_INWARD
{
    partial class frmNevaeh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNevaeh));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdShow = new System.Windows.Forms.Button();
            this.cmbBatch = new nControls.deComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deButtonCancel = new nControls.deButton();
            this.deButtonSave = new nControls.deButton();
            this.deLabel20 = new nControls.deLabel();
            this.txtdigiremark = new nControls.deDateBox();
            this.deLabel18 = new nControls.deLabel();
            this.deLabel19 = new nControls.deLabel();
            this.dtpdigi_return = new nControls.deDateBox();
            this.cmbdigireturn = new nControls.deComboBox();
            this.deLabel17 = new nControls.deLabel();
            this.deLabel16 = new nControls.deLabel();
            this.deLabel15 = new nControls.deLabel();
            this.dtpdigi_recipt = new nControls.deDateBox();
            this.cmbdigiRecpt = new nControls.deComboBox();
            this.deLabel14 = new nControls.deLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdShow);
            this.groupBox3.Controls.Add(this.cmbBatch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1008, 36);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Batch";
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(513, 10);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(101, 23);
            this.cmdShow.TabIndex = 23;
            this.cmdShow.Text = "&Show Details";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
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
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.dgvMain);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 351);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Entry Form";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 16);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(1004, 332);
            this.dgvMain.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deButtonCancel);
            this.groupBox2.Controls.Add(this.deButtonSave);
            this.groupBox2.Controls.Add(this.deLabel20);
            this.groupBox2.Controls.Add(this.txtdigiremark);
            this.groupBox2.Controls.Add(this.deLabel18);
            this.groupBox2.Controls.Add(this.deLabel19);
            this.groupBox2.Controls.Add(this.dtpdigi_return);
            this.groupBox2.Controls.Add(this.cmbdigireturn);
            this.groupBox2.Controls.Add(this.deLabel17);
            this.groupBox2.Controls.Add(this.deLabel16);
            this.groupBox2.Controls.Add(this.deLabel15);
            this.groupBox2.Controls.Add(this.dtpdigi_recipt);
            this.groupBox2.Controls.Add(this.cmbdigiRecpt);
            this.groupBox2.Controls.Add(this.deLabel14);
            this.groupBox2.Location = new System.Drawing.Point(1027, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 386);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DigitiZation";
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
            this.deButtonCancel.Location = new System.Drawing.Point(212, 313);
            this.deButtonCancel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deButtonCancel.Name = "deButtonCancel";
            this.deButtonCancel.Size = new System.Drawing.Size(87, 35);
            this.deButtonCancel.TabIndex = 88;
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
            this.deButtonSave.Location = new System.Drawing.Point(114, 313);
            this.deButtonSave.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deButtonSave.Name = "deButtonSave";
            this.deButtonSave.Size = new System.Drawing.Size(90, 35);
            this.deButtonSave.TabIndex = 87;
            this.deButtonSave.Text = "&Save";
            this.deButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deButtonSave.UseCompatibleTextRendering = true;
            this.deButtonSave.UseVisualStyleBackColor = false;
            this.deButtonSave.Click += new System.EventHandler(this.deButtonSave_Click);
            // 
            // deLabel20
            // 
            this.deLabel20.AutoSize = true;
            this.deLabel20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel20.ForeColor = System.Drawing.Color.Black;
            this.deLabel20.Location = new System.Drawing.Point(19, 179);
            this.deLabel20.Name = "deLabel20";
            this.deLabel20.Size = new System.Drawing.Size(151, 15);
            this.deLabel20.TabIndex = 30;
            this.deLabel20.Text = "NEVAEH REMARK (if any) :";
            // 
            // txtdigiremark
            // 
            this.txtdigiremark.Location = new System.Drawing.Point(128, 203);
            this.txtdigiremark.Mandatory = true;
            this.txtdigiremark.Multiline = true;
            this.txtdigiremark.Name = "txtdigiremark";
            this.txtdigiremark.Size = new System.Drawing.Size(171, 86);
            this.txtdigiremark.TabIndex = 29;
            // 
            // deLabel18
            // 
            this.deLabel18.AutoSize = true;
            this.deLabel18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel18.ForeColor = System.Drawing.Color.Black;
            this.deLabel18.Location = new System.Drawing.Point(19, 125);
            this.deLabel18.Name = "deLabel18";
            this.deLabel18.Size = new System.Drawing.Size(140, 15);
            this.deLabel18.TabIndex = 28;
            this.deLabel18.Text = "NEVAEH RETURN DATE :";
            // 
            // deLabel19
            // 
            this.deLabel19.AutoSize = true;
            this.deLabel19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel19.ForeColor = System.Drawing.Color.Black;
            this.deLabel19.Location = new System.Drawing.Point(137, 143);
            this.deLabel19.Name = "deLabel19";
            this.deLabel19.Size = new System.Drawing.Size(162, 13);
            this.deLabel19.TabIndex = 27;
            this.deLabel19.Text = "(Format Should me ddmmyyyy)";
            // 
            // dtpdigi_return
            // 
            this.dtpdigi_return.Enabled = false;
            this.dtpdigi_return.Location = new System.Drawing.Point(185, 120);
            this.dtpdigi_return.Mandatory = true;
            this.dtpdigi_return.Name = "dtpdigi_return";
            this.dtpdigi_return.Size = new System.Drawing.Size(114, 20);
            this.dtpdigi_return.TabIndex = 26;
            // 
            // cmbdigireturn
            // 
            this.cmbdigireturn.BackColor = System.Drawing.Color.White;
            this.cmbdigireturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdigireturn.ForeColor = System.Drawing.Color.Black;
            this.cmbdigireturn.FormattingEnabled = true;
            this.cmbdigireturn.Location = new System.Drawing.Point(185, 94);
            this.cmbdigireturn.Mandatory = false;
            this.cmbdigireturn.Name = "cmbdigireturn";
            this.cmbdigireturn.Size = new System.Drawing.Size(73, 21);
            this.cmbdigireturn.TabIndex = 25;
            this.cmbdigireturn.SelectedIndexChanged += new System.EventHandler(this.cmbdigireturn_SelectedIndexChanged);
            // 
            // deLabel17
            // 
            this.deLabel17.AutoSize = true;
            this.deLabel17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel17.ForeColor = System.Drawing.Color.Black;
            this.deLabel17.Location = new System.Drawing.Point(19, 94);
            this.deLabel17.Name = "deLabel17";
            this.deLabel17.Size = new System.Drawing.Size(108, 15);
            this.deLabel17.TabIndex = 24;
            this.deLabel17.Text = "NEVAEH RETURN :";
            // 
            // deLabel16
            // 
            this.deLabel16.AutoSize = true;
            this.deLabel16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel16.ForeColor = System.Drawing.Color.Black;
            this.deLabel16.Location = new System.Drawing.Point(19, 55);
            this.deLabel16.Name = "deLabel16";
            this.deLabel16.Size = new System.Drawing.Size(132, 15);
            this.deLabel16.TabIndex = 23;
            this.deLabel16.Text = "NEVAEH RECIPT DATE :";
            // 
            // deLabel15
            // 
            this.deLabel15.AutoSize = true;
            this.deLabel15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel15.ForeColor = System.Drawing.Color.Black;
            this.deLabel15.Location = new System.Drawing.Point(137, 73);
            this.deLabel15.Name = "deLabel15";
            this.deLabel15.Size = new System.Drawing.Size(162, 13);
            this.deLabel15.TabIndex = 22;
            this.deLabel15.Text = "(Format Should me ddmmyyyy)";
            // 
            // dtpdigi_recipt
            // 
            this.dtpdigi_recipt.Enabled = false;
            this.dtpdigi_recipt.Location = new System.Drawing.Point(185, 50);
            this.dtpdigi_recipt.Mandatory = true;
            this.dtpdigi_recipt.Name = "dtpdigi_recipt";
            this.dtpdigi_recipt.Size = new System.Drawing.Size(114, 20);
            this.dtpdigi_recipt.TabIndex = 21;
            // 
            // cmbdigiRecpt
            // 
            this.cmbdigiRecpt.BackColor = System.Drawing.Color.White;
            this.cmbdigiRecpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdigiRecpt.ForeColor = System.Drawing.Color.Black;
            this.cmbdigiRecpt.FormattingEnabled = true;
            this.cmbdigiRecpt.Location = new System.Drawing.Point(185, 26);
            this.cmbdigiRecpt.Mandatory = false;
            this.cmbdigiRecpt.Name = "cmbdigiRecpt";
            this.cmbdigiRecpt.Size = new System.Drawing.Size(73, 21);
            this.cmbdigiRecpt.TabIndex = 11;
            this.cmbdigiRecpt.SelectedIndexChanged += new System.EventHandler(this.cmbdigiRecpt_SelectedIndexChanged);
            this.cmbdigiRecpt.Leave += new System.EventHandler(this.cmbdigiRecpt_Leave);
            // 
            // deLabel14
            // 
            this.deLabel14.AutoSize = true;
            this.deLabel14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel14.ForeColor = System.Drawing.Color.Black;
            this.deLabel14.Location = new System.Drawing.Point(19, 26);
            this.deLabel14.Name = "deLabel14";
            this.deLabel14.Size = new System.Drawing.Size(100, 15);
            this.deLabel14.TabIndex = 10;
            this.deLabel14.Text = "NEVAEH RECIPT :";
            // 
            // frmNevaeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1351, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNevaeh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNevaeh";
            this.Load += new System.EventHandler(this.frmNevaeh_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private nControls.deComboBox cmbBatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private nControls.deButton deButtonCancel;
        private nControls.deButton deButtonSave;
        private nControls.deLabel deLabel20;
        private nControls.deDateBox txtdigiremark;
        private nControls.deLabel deLabel18;
        private nControls.deLabel deLabel19;
        private nControls.deDateBox dtpdigi_return;
        private nControls.deComboBox cmbdigireturn;
        private nControls.deLabel deLabel17;
        private nControls.deLabel deLabel16;
        private nControls.deLabel deLabel15;
        private nControls.deDateBox dtpdigi_recipt;
        private nControls.deComboBox cmbdigiRecpt;
        private nControls.deLabel deLabel14;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.DataGridView dgvMain;
    }
}
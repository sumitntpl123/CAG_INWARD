
namespace CAG_INWARD
{
    partial class frmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboRole = new System.Windows.Forms.ComboBox();
            this.lbRoledes = new System.Windows.Forms.Label();
            this.lbUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtConPwd = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserPwd = new System.Windows.Forms.Label();
            this.deButtonCancel = new nControls.deButton();
            this.deButtonSave = new nControls.deButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboRole);
            this.groupBox1.Controls.Add(this.lbRoledes);
            this.groupBox1.Controls.Add(this.lbUserId);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.txtConPwd);
            this.groupBox1.Controls.Add(this.lbUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.lbUserPwd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmboRole
            // 
            this.cmboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboRole.FormattingEnabled = true;
            this.cmboRole.Location = new System.Drawing.Point(147, 82);
            this.cmboRole.Name = "cmboRole";
            this.cmboRole.Size = new System.Drawing.Size(135, 21);
            this.cmboRole.TabIndex = 3;
            // 
            // lbRoledes
            // 
            this.lbRoledes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoledes.Location = new System.Drawing.Point(24, 83);
            this.lbRoledes.Name = "lbRoledes";
            this.lbRoledes.Size = new System.Drawing.Size(114, 18);
            this.lbRoledes.TabIndex = 8;
            this.lbRoledes.Text = "Role Description:";
            // 
            // lbUserId
            // 
            this.lbUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUserId.Location = new System.Drawing.Point(24, 16);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(73, 20);
            this.lbUserId.TabIndex = 0;
            this.lbUserId.Text = "User ID:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(147, 16);
            this.txtUserId.MaxLength = 30;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(135, 20);
            this.txtUserId.TabIndex = 0;
            // 
            // txtConPwd
            // 
            this.txtConPwd.Location = new System.Drawing.Point(147, 150);
            this.txtConPwd.MaxLength = 50;
            this.txtConPwd.Name = "txtConPwd";
            this.txtConPwd.PasswordChar = '*';
            this.txtConPwd.Size = new System.Drawing.Size(135, 20);
            this.txtConPwd.TabIndex = 5;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUserName.Location = new System.Drawing.Point(24, 51);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(91, 17);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 116);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(147, 50);
            this.txtUserName.MaxLength = 100;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(212, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lbUserPwd
            // 
            this.lbUserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserPwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUserPwd.Location = new System.Drawing.Point(24, 116);
            this.lbUserPwd.Name = "lbUserPwd";
            this.lbUserPwd.Size = new System.Drawing.Size(91, 20);
            this.lbUserPwd.TabIndex = 2;
            this.lbUserPwd.Text = "Password:";
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
            this.deButtonCancel.Location = new System.Drawing.Point(296, 201);
            this.deButtonCancel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deButtonCancel.Name = "deButtonCancel";
            this.deButtonCancel.Size = new System.Drawing.Size(87, 35);
            this.deButtonCancel.TabIndex = 90;
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
            this.deButtonSave.Location = new System.Drawing.Point(198, 201);
            this.deButtonSave.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deButtonSave.Name = "deButtonSave";
            this.deButtonSave.Size = new System.Drawing.Size(90, 35);
            this.deButtonSave.TabIndex = 89;
            this.deButtonSave.Text = "&Save";
            this.deButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deButtonSave.UseCompatibleTextRendering = true;
            this.deButtonSave.UseVisualStyleBackColor = false;
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(401, 248);
            this.Controls.Add(this.deButtonCancel);
            this.Controls.Add(this.deButtonSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmboRole;
        private System.Windows.Forms.Label lbRoledes;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtConPwd;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserPwd;
        private nControls.deButton deButtonCancel;
        private nControls.deButton deButtonSave;
    }
}

namespace CAG_INWARD
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deButtonCancel = new nControls.deButton();
            this.deButtonSave = new nControls.deButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deButtonCancel);
            this.groupBox1.Controls.Add(this.deButtonSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '@';
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
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
            this.deButtonCancel.Location = new System.Drawing.Point(266, 110);
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
            this.deButtonSave.Location = new System.Drawing.Point(168, 110);
            this.deButtonSave.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deButtonSave.Name = "deButtonSave";
            this.deButtonSave.Size = new System.Drawing.Size(90, 35);
            this.deButtonSave.TabIndex = 89;
            this.deButtonSave.Text = "&Login";
            this.deButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deButtonSave.UseCompatibleTextRendering = true;
            this.deButtonSave.UseVisualStyleBackColor = false;
            this.deButtonSave.Click += new System.EventHandler(this.deButtonSave_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(388, 180);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private nControls.deButton deButtonCancel;
        private nControls.deButton deButtonSave;
    }
}
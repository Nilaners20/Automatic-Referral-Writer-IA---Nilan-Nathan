namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    partial class HomePage
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
            this.btnRecordSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewReferral = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecordSearch
            // 
            this.btnRecordSearch.BackColor = System.Drawing.Color.Crimson;
            this.btnRecordSearch.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecordSearch.Location = new System.Drawing.Point(87, 189);
            this.btnRecordSearch.Name = "btnRecordSearch";
            this.btnRecordSearch.Size = new System.Drawing.Size(209, 83);
            this.btnRecordSearch.TabIndex = 0;
            this.btnRecordSearch.Text = "Student Record Search";
            this.btnRecordSearch.UseVisualStyleBackColor = false;
            this.btnRecordSearch.Click += new System.EventHandler(this.btnRecordSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 124);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!";
            // 
            // btnNewReferral
            // 
            this.btnNewReferral.BackColor = System.Drawing.Color.Crimson;
            this.btnNewReferral.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReferral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewReferral.Location = new System.Drawing.Point(455, 189);
            this.btnNewReferral.Name = "btnNewReferral";
            this.btnNewReferral.Size = new System.Drawing.Size(209, 83);
            this.btnNewReferral.TabIndex = 3;
            this.btnNewReferral.Text = "New Referral";
            this.btnNewReferral.UseVisualStyleBackColor = false;
            this.btnNewReferral.Click += new System.EventHandler(this.btnNewReferral_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(592, 406);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 32);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT ";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNewReferral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecordSearch);
            this.Name = "HomePage";
            this.Text = "Hello User.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewReferral;
        private System.Windows.Forms.Button btnLogout;
    }
}


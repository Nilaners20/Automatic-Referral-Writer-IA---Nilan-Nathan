namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    partial class StudentViewerPage
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnStudentRepBacktoHome = new System.Windows.Forms.Button();
            this.lblNoStuFound = new System.Windows.Forms.Label();
            this.txtRepView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentName.Location = new System.Drawing.Point(150, 9);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(477, 83);
            this.lblStudentName.TabIndex = 5;
            this.lblStudentName.Text = "Student Name";
            // 
            // btnStudentRepBacktoHome
            // 
            this.btnStudentRepBacktoHome.BackColor = System.Drawing.Color.Crimson;
            this.btnStudentRepBacktoHome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentRepBacktoHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentRepBacktoHome.Location = new System.Drawing.Point(643, 402);
            this.btnStudentRepBacktoHome.Name = "btnStudentRepBacktoHome";
            this.btnStudentRepBacktoHome.Size = new System.Drawing.Size(145, 36);
            this.btnStudentRepBacktoHome.TabIndex = 13;
            this.btnStudentRepBacktoHome.Text = "Back To Home";
            this.btnStudentRepBacktoHome.UseVisualStyleBackColor = false;
            this.btnStudentRepBacktoHome.Click += new System.EventHandler(this.btnStudentRepBacktoHome_Click);
            // 
            // lblNoStuFound
            // 
            this.lblNoStuFound.AutoSize = true;
            this.lblNoStuFound.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoStuFound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNoStuFound.Location = new System.Drawing.Point(220, 402);
            this.lblNoStuFound.Name = "lblNoStuFound";
            this.lblNoStuFound.Size = new System.Drawing.Size(342, 22);
            this.lblNoStuFound.TabIndex = 20;
            this.lblNoStuFound.Text = "NO STUDENT FOUND WITH THAT NAME";
            this.lblNoStuFound.Visible = false;
            this.lblNoStuFound.Click += new System.EventHandler(this.lblNoStuFound_Click);
            // 
            // txtRepView
            // 
            this.txtRepView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepView.Location = new System.Drawing.Point(68, 95);
            this.txtRepView.Name = "txtRepView";
            this.txtRepView.Size = new System.Drawing.Size(645, 260);
            this.txtRepView.TabIndex = 21;
            this.txtRepView.Text = "Press any key to see your report";
            this.txtRepView.TextChanged += new System.EventHandler(this.txtRepView_TextChanged);
            // 
            // StudentViewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRepView);
            this.Controls.Add(this.lblNoStuFound);
            this.Controls.Add(this.btnStudentRepBacktoHome);
            this.Controls.Add(this.lblStudentName);
            this.Name = "StudentViewerPage";
            this.Text = "StudentViewerPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnStudentRepBacktoHome;
        private System.Windows.Forms.Label lblNoStuFound;
        private System.Windows.Forms.RichTextBox txtRepView;
    }
}
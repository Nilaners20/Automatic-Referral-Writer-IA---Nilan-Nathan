namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    partial class StudentLookupPage
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
            this.lblFindStudent = new System.Windows.Forms.Label();
            this.btnStudentLookBacktoHome = new System.Windows.Forms.Button();
            this.boxFindStudent = new System.Windows.Forms.TextBox();
            this.btnFoundStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFindStudent
            // 
            this.lblFindStudent.AutoSize = true;
            this.lblFindStudent.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFindStudent.Location = new System.Drawing.Point(147, 9);
            this.lblFindStudent.Name = "lblFindStudent";
            this.lblFindStudent.Size = new System.Drawing.Size(479, 83);
            this.lblFindStudent.TabIndex = 4;
            this.lblFindStudent.Text = "Find a Student";
            // 
            // btnStudentLookBacktoHome
            // 
            this.btnStudentLookBacktoHome.BackColor = System.Drawing.Color.Crimson;
            this.btnStudentLookBacktoHome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLookBacktoHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentLookBacktoHome.Location = new System.Drawing.Point(641, 393);
            this.btnStudentLookBacktoHome.Name = "btnStudentLookBacktoHome";
            this.btnStudentLookBacktoHome.Size = new System.Drawing.Size(147, 45);
            this.btnStudentLookBacktoHome.TabIndex = 12;
            this.btnStudentLookBacktoHome.Text = "Back To Home";
            this.btnStudentLookBacktoHome.UseVisualStyleBackColor = false;
            this.btnStudentLookBacktoHome.Click += new System.EventHandler(this.btnStudentLookBacktoHome_Click);
            // 
            // boxFindStudent
            // 
            this.boxFindStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFindStudent.Location = new System.Drawing.Point(161, 174);
            this.boxFindStudent.Name = "boxFindStudent";
            this.boxFindStudent.Size = new System.Drawing.Size(465, 26);
            this.boxFindStudent.TabIndex = 13;
            // 
            // btnFoundStudent
            // 
            this.btnFoundStudent.BackColor = System.Drawing.Color.Crimson;
            this.btnFoundStudent.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoundStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFoundStudent.Location = new System.Drawing.Point(161, 229);
            this.btnFoundStudent.Name = "btnFoundStudent";
            this.btnFoundStudent.Size = new System.Drawing.Size(465, 45);
            this.btnFoundStudent.TabIndex = 14;
            this.btnFoundStudent.Text = "Student Name";
            this.btnFoundStudent.UseVisualStyleBackColor = false;
            // 
            // StudentLookupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFoundStudent);
            this.Controls.Add(this.boxFindStudent);
            this.Controls.Add(this.btnStudentLookBacktoHome);
            this.Controls.Add(this.lblFindStudent);
            this.Name = "StudentLookupPage";
            this.Text = "StudentLookupPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindStudent;
        private System.Windows.Forms.Button btnStudentLookBacktoHome;
        private System.Windows.Forms.TextBox boxFindStudent;
        private System.Windows.Forms.Button btnFoundStudent;
    }
}
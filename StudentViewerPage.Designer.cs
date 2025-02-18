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
            this.tblStudentReport = new System.Windows.Forms.TableLayoutPanel();
            this.lblIntervention = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRefCount = new System.Windows.Forms.Label();
            this.btnStudentRepBacktoHome = new System.Windows.Forms.Button();
            this.lblNoStuFound = new System.Windows.Forms.Label();
            this.tblStudentReport.SuspendLayout();
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
            // tblStudentReport
            // 
            this.tblStudentReport.BackColor = System.Drawing.Color.DimGray;
            this.tblStudentReport.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tblStudentReport.ColumnCount = 4;
            this.tblStudentReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.84685F));
            this.tblStudentReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.15315F));
            this.tblStudentReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tblStudentReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblStudentReport.Controls.Add(this.lblIntervention, 3, 0);
            this.tblStudentReport.Controls.Add(this.lblReason, 2, 0);
            this.tblStudentReport.Controls.Add(this.lblDate, 1, 0);
            this.tblStudentReport.Controls.Add(this.lblRefCount, 0, 0);
            this.tblStudentReport.Location = new System.Drawing.Point(63, 107);
            this.tblStudentReport.Name = "tblStudentReport";
            this.tblStudentReport.RowCount = 2;
            this.tblStudentReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tblStudentReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.87096F));
            this.tblStudentReport.Size = new System.Drawing.Size(668, 186);
            this.tblStudentReport.TabIndex = 6;
            this.tblStudentReport.Paint += new System.Windows.Forms.PaintEventHandler(this.tblStudentReport_Paint);
            // 
            // lblIntervention
            // 
            this.lblIntervention.AutoSize = true;
            this.lblIntervention.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIntervention.Location = new System.Drawing.Point(508, 2);
            this.lblIntervention.Name = "lblIntervention";
            this.lblIntervention.Size = new System.Drawing.Size(117, 22);
            this.lblIntervention.TabIndex = 3;
            this.lblIntervention.Text = "Intervention?";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReason.Location = new System.Drawing.Point(329, 2);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(68, 22);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Reason";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(157, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 22);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblRefCount
            // 
            this.lblRefCount.AutoSize = true;
            this.lblRefCount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRefCount.Location = new System.Drawing.Point(5, 2);
            this.lblRefCount.Name = "lblRefCount";
            this.lblRefCount.Size = new System.Drawing.Size(127, 22);
            this.lblRefCount.TabIndex = 0;
            this.lblRefCount.Text = "Referral Count";
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
            this.lblNoStuFound.Location = new System.Drawing.Point(220, 328);
            this.lblNoStuFound.Name = "lblNoStuFound";
            this.lblNoStuFound.Size = new System.Drawing.Size(342, 22);
            this.lblNoStuFound.TabIndex = 20;
            this.lblNoStuFound.Text = "NO STUDENT FOUND WITH THAT NAME";
            this.lblNoStuFound.Visible = false;
            this.lblNoStuFound.Click += new System.EventHandler(this.lblNoStuFound_Click);
            // 
            // StudentViewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNoStuFound);
            this.Controls.Add(this.btnStudentRepBacktoHome);
            this.Controls.Add(this.tblStudentReport);
            this.Controls.Add(this.lblStudentName);
            this.Name = "StudentViewerPage";
            this.Text = "StudentViewerPage";
            this.tblStudentReport.ResumeLayout(false);
            this.tblStudentReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TableLayoutPanel tblStudentReport;
        private System.Windows.Forms.Button btnStudentRepBacktoHome;
        private System.Windows.Forms.Label lblIntervention;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRefCount;
        private System.Windows.Forms.Label lblNoStuFound;
    }
}
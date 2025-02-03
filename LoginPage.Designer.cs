namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterEmpCode = new System.Windows.Forms.Label();
            this.boxEnterEmpCode = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblWrongCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 83);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Login Here";
            // 
            // txtEnterEmpCode
            // 
            this.txtEnterEmpCode.AutoSize = true;
            this.txtEnterEmpCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterEmpCode.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEnterEmpCode.Location = new System.Drawing.Point(196, 247);
            this.txtEnterEmpCode.Name = "txtEnterEmpCode";
            this.txtEnterEmpCode.Size = new System.Drawing.Size(141, 22);
            this.txtEnterEmpCode.TabIndex = 8;
            this.txtEnterEmpCode.Text = "Employee Code:";
            // 
            // boxEnterEmpCode
            // 
            this.boxEnterEmpCode.Location = new System.Drawing.Point(343, 250);
            this.boxEnterEmpCode.Name = "boxEnterEmpCode";
            this.boxEnterEmpCode.Size = new System.Drawing.Size(215, 20);
            this.boxEnterEmpCode.TabIndex = 9;
            this.boxEnterEmpCode.TextChanged += new System.EventHandler(this.boxEnterEmpCode_TextChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Crimson;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignIn.Location = new System.Drawing.Point(330, 338);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(121, 45);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblWrongCode
            // 
            this.lblWrongCode.AutoSize = true;
            this.lblWrongCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongCode.ForeColor = System.Drawing.Color.Snow;
            this.lblWrongCode.Location = new System.Drawing.Point(326, 286);
            this.lblWrongCode.Name = "lblWrongCode";
            this.lblWrongCode.Size = new System.Drawing.Size(163, 19);
            this.lblWrongCode.TabIndex = 12;
            this.lblWrongCode.Text = "Incorrect Code Entered";
            this.lblWrongCode.Visible = false;
            this.lblWrongCode.Click += new System.EventHandler(this.lblWrongCode_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWrongCode);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.boxEnterEmpCode);
            this.Controls.Add(this.txtEnterEmpCode);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtEnterEmpCode;
        private System.Windows.Forms.TextBox boxEnterEmpCode;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblWrongCode;
    }
}
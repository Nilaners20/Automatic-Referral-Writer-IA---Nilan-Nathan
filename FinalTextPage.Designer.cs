namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    partial class FinalTextPage
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
            this.lblFinalText = new System.Windows.Forms.Label();
            this.txtFinalText = new System.Windows.Forms.RichTextBox();
            this.btnFinalTextBackToHome = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.lblRefCopied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinalText
            // 
            this.lblFinalText.AutoSize = true;
            this.lblFinalText.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinalText.Location = new System.Drawing.Point(246, 9);
            this.lblFinalText.Name = "lblFinalText";
            this.lblFinalText.Size = new System.Drawing.Size(345, 83);
            this.lblFinalText.TabIndex = 7;
            this.lblFinalText.Text = "Final Text!";
            // 
            // txtFinalText
            // 
            this.txtFinalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalText.Location = new System.Drawing.Point(98, 95);
            this.txtFinalText.Name = "txtFinalText";
            this.txtFinalText.Size = new System.Drawing.Size(650, 295);
            this.txtFinalText.TabIndex = 8;
            this.txtFinalText.Text = "Press any key to see your referral text.";
            this.txtFinalText.TextChanged += new System.EventHandler(this.txtFinalText_TextChanged);
            // 
            // btnFinalTextBackToHome
            // 
            this.btnFinalTextBackToHome.BackColor = System.Drawing.Color.Crimson;
            this.btnFinalTextBackToHome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTextBackToHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalTextBackToHome.Location = new System.Drawing.Point(603, 402);
            this.btnFinalTextBackToHome.Name = "btnFinalTextBackToHome";
            this.btnFinalTextBackToHome.Size = new System.Drawing.Size(145, 36);
            this.btnFinalTextBackToHome.TabIndex = 17;
            this.btnFinalTextBackToHome.Text = "Back To Home";
            this.btnFinalTextBackToHome.UseVisualStyleBackColor = false;
            this.btnFinalTextBackToHome.Click += new System.EventHandler(this.btnFinalTextBackToHome_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.BackColor = System.Drawing.Color.Crimson;
            this.btnCopyToClipboard.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToClipboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(98, 402);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(191, 36);
            this.btnCopyToClipboard.TabIndex = 18;
            this.btnCopyToClipboard.Text = "Copy Text to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = false;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // lblRefCopied
            // 
            this.lblRefCopied.AutoSize = true;
            this.lblRefCopied.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefCopied.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRefCopied.Location = new System.Drawing.Point(308, 409);
            this.lblRefCopied.Name = "lblRefCopied";
            this.lblRefCopied.Size = new System.Drawing.Size(246, 22);
            this.lblRefCopied.TabIndex = 20;
            this.lblRefCopied.Text = "REFERRAL HAS BEEN COPIED";
            this.lblRefCopied.Visible = false;
            this.lblRefCopied.Click += new System.EventHandler(this.lblRefCreated_Click);
            // 
            // FinalTextPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRefCopied);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.btnFinalTextBackToHome);
            this.Controls.Add(this.txtFinalText);
            this.Controls.Add(this.lblFinalText);
            this.Name = "FinalTextPage";
            this.Text = "FinalTextPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinalText;
        private System.Windows.Forms.RichTextBox txtFinalText;
        private System.Windows.Forms.Button btnFinalTextBackToHome;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Label lblRefCopied;
    }
}
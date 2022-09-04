namespace Activity15
{
    partial class YourResults
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
            this.YourLuckyNumIs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(165, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Lucky  Numer is:";
            // 
            // YourLuckyNumIs
            // 
            this.YourLuckyNumIs.AutoSize = true;
            this.YourLuckyNumIs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.YourLuckyNumIs.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YourLuckyNumIs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YourLuckyNumIs.Location = new System.Drawing.Point(299, 226);
            this.YourLuckyNumIs.Name = "YourLuckyNumIs";
            this.YourLuckyNumIs.Size = new System.Drawing.Size(0, 215);
            this.YourLuckyNumIs.TabIndex = 1;
            // 
            // YourResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(763, 602);
            this.Controls.Add(this.YourLuckyNumIs);
            this.Controls.Add(this.label1);
            this.Name = "YourResults";
            this.Text = "YourResults";
            this.Load += new System.EventHandler(this.YourResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label YourLuckyNumIs;
    }
}
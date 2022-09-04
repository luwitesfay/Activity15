namespace Activity15
{
    partial class LuckyNumbers
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthYearCB = new System.Windows.Forms.ComboBox();
            this.birthMonthCB = new System.Windows.Forms.ComboBox();
            this.birthDayCB = new System.Windows.Forms.ComboBox();
            this.favoriteColorCB = new System.Windows.Forms.ComboBox();
            this.LuckyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your birth year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 3;
            // 
            // birthYearCB
            // 
            this.birthYearCB.FormattingEnabled = true;
            this.birthYearCB.Items.AddRange(new object[] {
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900"});
            this.birthYearCB.Location = new System.Drawing.Point(464, 107);
            this.birthYearCB.Name = "birthYearCB";
            this.birthYearCB.Size = new System.Drawing.Size(242, 40);
            this.birthYearCB.TabIndex = 4;
            this.birthYearCB.SelectedIndexChanged += new System.EventHandler(this.birthYearCB_SelectedIndexChanged);
            // 
            // birthMonthCB
            // 
            this.birthMonthCB.FormattingEnabled = true;
            this.birthMonthCB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.birthMonthCB.Location = new System.Drawing.Point(464, 173);
            this.birthMonthCB.Name = "birthMonthCB";
            this.birthMonthCB.Size = new System.Drawing.Size(242, 40);
            this.birthMonthCB.TabIndex = 5;
            this.birthMonthCB.SelectedIndexChanged += new System.EventHandler(this.birthMonthCB_SelectedIndexChanged);
            // 
            // birthDayCB
            // 
            this.birthDayCB.FormattingEnabled = true;
            this.birthDayCB.Location = new System.Drawing.Point(464, 241);
            this.birthDayCB.Name = "birthDayCB";
            this.birthDayCB.Size = new System.Drawing.Size(242, 40);
            this.birthDayCB.TabIndex = 6;
            // 
            // favoriteColorCB
            // 
            this.favoriteColorCB.FormattingEnabled = true;
            this.favoriteColorCB.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Pink",
            "Silver",
            "Gold",
            "Brown",
            "Black",
            "White"});
            this.favoriteColorCB.Location = new System.Drawing.Point(464, 311);
            this.favoriteColorCB.Name = "favoriteColorCB";
            this.favoriteColorCB.Size = new System.Drawing.Size(242, 40);
            this.favoriteColorCB.TabIndex = 7;
            // 
            // LuckyButton
            // 
            this.LuckyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LuckyButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LuckyButton.Location = new System.Drawing.Point(93, 403);
            this.LuckyButton.Name = "LuckyButton";
            this.LuckyButton.Size = new System.Drawing.Size(613, 112);
            this.LuckyButton.TabIndex = 8;
            this.LuckyButton.Text = "Get Your Lucky Number";
            this.LuckyButton.UseVisualStyleBackColor = false;
            this.LuckyButton.Click += new System.EventHandler(this.LuckyButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(93, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter your favourite color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(93, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter your birth day:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(93, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "Enter your birth month:";
            // 
            // LuckyNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(771, 590);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LuckyButton);
            this.Controls.Add(this.favoriteColorCB);
            this.Controls.Add(this.birthDayCB);
            this.Controls.Add(this.birthMonthCB);
            this.Controls.Add(this.birthYearCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LuckyNumbers";
            this.Text = "LuckyNumbers";
            this.Load += new System.EventHandler(this.LuckyNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox birthYearCB;
        private ComboBox birthMonthCB;
        private ComboBox birthDayCB;
        private ComboBox favoriteColorCB;
        private Button LuckyButton;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
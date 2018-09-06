namespace LReeseEx1d1
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUSDollar = new System.Windows.Forms.TextBox();
            this.txtBhutUS = new System.Windows.Forms.TextBox();
            this.txtCostaUS = new System.Windows.Forms.TextBox();
            this.txtEuroUS = new System.Windows.Forms.TextBox();
            this.txtAustUS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBhutRate = new System.Windows.Forms.TextBox();
            this.txtCostaRate = new System.Windows.Forms.TextBox();
            this.txtEuroRate = new System.Windows.Forms.TextBox();
            this.txtAustRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBhutAmount = new System.Windows.Forms.TextBox();
            this.txtCostaAmount = new System.Windows.Forms.TextBox();
            this.txtEuroAmount = new System.Windows.Forms.TextBox();
            this.txtAustAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(314, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 23);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(199, 207);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 23);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(556, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "$US:";
            // 
            // txtUSDollar
            // 
            this.txtUSDollar.Location = new System.Drawing.Point(580, 181);
            this.txtUSDollar.Name = "txtUSDollar";
            this.txtUSDollar.ReadOnly = true;
            this.txtUSDollar.Size = new System.Drawing.Size(106, 20);
            this.txtUSDollar.TabIndex = 52;
            this.txtUSDollar.TabStop = false;
            this.txtUSDollar.Text = "0.00";
            this.txtUSDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDollar.TextChanged += new System.EventHandler(this.txtUSDollar_TextChanged);
            // 
            // txtBhutUS
            // 
            this.txtBhutUS.Location = new System.Drawing.Point(199, 181);
            this.txtBhutUS.Name = "txtBhutUS";
            this.txtBhutUS.ReadOnly = true;
            this.txtBhutUS.Size = new System.Drawing.Size(109, 20);
            this.txtBhutUS.TabIndex = 47;
            this.txtBhutUS.TabStop = false;
            this.txtBhutUS.Text = "0.00";
            this.txtBhutUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBhutUS.TextChanged += new System.EventHandler(this.USTextChanged);
            // 
            // txtCostaUS
            // 
            this.txtCostaUS.Location = new System.Drawing.Point(314, 181);
            this.txtCostaUS.Name = "txtCostaUS";
            this.txtCostaUS.ReadOnly = true;
            this.txtCostaUS.Size = new System.Drawing.Size(106, 20);
            this.txtCostaUS.TabIndex = 48;
            this.txtCostaUS.TabStop = false;
            this.txtCostaUS.Text = "0.00";
            this.txtCostaUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostaUS.TextChanged += new System.EventHandler(this.USTextChanged);
            // 
            // txtEuroUS
            // 
            this.txtEuroUS.Location = new System.Drawing.Point(424, 181);
            this.txtEuroUS.Name = "txtEuroUS";
            this.txtEuroUS.ReadOnly = true;
            this.txtEuroUS.Size = new System.Drawing.Size(106, 20);
            this.txtEuroUS.TabIndex = 49;
            this.txtEuroUS.TabStop = false;
            this.txtEuroUS.Text = "0.00";
            this.txtEuroUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuroUS.TextChanged += new System.EventHandler(this.USTextChanged);
            // 
            // txtAustUS
            // 
            this.txtAustUS.Location = new System.Drawing.Point(89, 181);
            this.txtAustUS.Name = "txtAustUS";
            this.txtAustUS.ReadOnly = true;
            this.txtAustUS.Size = new System.Drawing.Size(104, 20);
            this.txtAustUS.TabIndex = 46;
            this.txtAustUS.TabStop = false;
            this.txtAustUS.Text = "0.00";
            this.txtAustUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAustUS.TextChanged += new System.EventHandler(this.USTextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Rate:";
            // 
            // txtBhutRate
            // 
            this.txtBhutRate.Location = new System.Drawing.Point(199, 155);
            this.txtBhutRate.Name = "txtBhutRate";
            this.txtBhutRate.Size = new System.Drawing.Size(109, 20);
            this.txtBhutRate.TabIndex = 35;
            this.txtBhutRate.Text = "0.0139831";
            this.txtBhutRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBhutRate.TextChanged += new System.EventHandler(this.BhutTextChanged);
            // 
            // txtCostaRate
            // 
            this.txtCostaRate.Location = new System.Drawing.Point(314, 155);
            this.txtCostaRate.Name = "txtCostaRate";
            this.txtCostaRate.Size = new System.Drawing.Size(106, 20);
            this.txtCostaRate.TabIndex = 36;
            this.txtCostaRate.Text = "0.00176040";
            this.txtCostaRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostaRate.TextChanged += new System.EventHandler(this.CostaTextChanged);
            // 
            // txtEuroRate
            // 
            this.txtEuroRate.Location = new System.Drawing.Point(424, 155);
            this.txtEuroRate.Name = "txtEuroRate";
            this.txtEuroRate.Size = new System.Drawing.Size(106, 20);
            this.txtEuroRate.TabIndex = 38;
            this.txtEuroRate.Text = "1.16235";
            this.txtEuroRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuroRate.TextChanged += new System.EventHandler(this.EuroTextChanged);
            // 
            // txtAustRate
            // 
            this.txtAustRate.Location = new System.Drawing.Point(89, 155);
            this.txtAustRate.Name = "txtAustRate";
            this.txtAustRate.Size = new System.Drawing.Size(104, 20);
            this.txtAustRate.TabIndex = 33;
            this.txtAustRate.Text = "0.717976";
            this.txtAustRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAustRate.TextChanged += new System.EventHandler(this.AustTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Amount:";
            // 
            // txtBhutAmount
            // 
            this.txtBhutAmount.Location = new System.Drawing.Point(199, 129);
            this.txtBhutAmount.Name = "txtBhutAmount";
            this.txtBhutAmount.Size = new System.Drawing.Size(109, 20);
            this.txtBhutAmount.TabIndex = 26;
            this.txtBhutAmount.Text = "0.00";
            this.txtBhutAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBhutAmount.TextChanged += new System.EventHandler(this.BhutTextChanged);
            // 
            // txtCostaAmount
            // 
            this.txtCostaAmount.Location = new System.Drawing.Point(314, 129);
            this.txtCostaAmount.Name = "txtCostaAmount";
            this.txtCostaAmount.Size = new System.Drawing.Size(106, 20);
            this.txtCostaAmount.TabIndex = 28;
            this.txtCostaAmount.Text = "0.00";
            this.txtCostaAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostaAmount.TextChanged += new System.EventHandler(this.CostaTextChanged);
            // 
            // txtEuroAmount
            // 
            this.txtEuroAmount.Location = new System.Drawing.Point(424, 129);
            this.txtEuroAmount.Name = "txtEuroAmount";
            this.txtEuroAmount.Size = new System.Drawing.Size(106, 20);
            this.txtEuroAmount.TabIndex = 29;
            this.txtEuroAmount.Text = "0.00";
            this.txtEuroAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuroAmount.TextChanged += new System.EventHandler(this.EuroTextChanged);
            // 
            // txtAustAmount
            // 
            this.txtAustAmount.Location = new System.Drawing.Point(89, 129);
            this.txtAustAmount.Name = "txtAustAmount";
            this.txtAustAmount.Size = new System.Drawing.Size(104, 20);
            this.txtAustAmount.TabIndex = 25;
            this.txtAustAmount.Text = "0.00";
            this.txtAustAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAustAmount.TextChanged += new System.EventHandler(this.AustTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "US Dollar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Costa Rican Colon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Bhutaneese Nguitrum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Australian Dollars";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = global::LReeseEx1d1.Properties.Resources.United_States_Flag_icon;
            this.pictureBox5.Location = new System.Drawing.Point(580, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 98);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::LReeseEx1d1.Properties.Resources.European_Union_Flag_icon;
            this.pictureBox4.Location = new System.Drawing.Point(426, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 98);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::LReeseEx1d1.Properties.Resources.Costa_Rica_Flag_icon;
            this.pictureBox3.Location = new System.Drawing.Point(314, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::LReeseEx1d1.Properties.Resources.Bhutan_Flag_icon;
            this.pictureBox2.Location = new System.Drawing.Point(199, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::LReeseEx1d1.Properties.Resources.Australia_Flag_icon;
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(743, 339);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUSDollar);
            this.Controls.Add(this.txtBhutUS);
            this.Controls.Add(this.txtCostaUS);
            this.Controls.Add(this.txtEuroUS);
            this.Controls.Add(this.txtAustUS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBhutRate);
            this.Controls.Add(this.txtCostaRate);
            this.Controls.Add(this.txtEuroRate);
            this.Controls.Add(this.txtAustRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBhutAmount);
            this.Controls.Add(this.txtCostaAmount);
            this.Controls.Add(this.txtEuroAmount);
            this.Controls.Add(this.txtAustAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUSDollar;
        private System.Windows.Forms.TextBox txtBhutUS;
        private System.Windows.Forms.TextBox txtCostaUS;
        private System.Windows.Forms.TextBox txtEuroUS;
        private System.Windows.Forms.TextBox txtAustUS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBhutRate;
        private System.Windows.Forms.TextBox txtCostaRate;
        private System.Windows.Forms.TextBox txtEuroRate;
        private System.Windows.Forms.TextBox txtAustRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBhutAmount;
        private System.Windows.Forms.TextBox txtCostaAmount;
        private System.Windows.Forms.TextBox txtEuroAmount;
        private System.Windows.Forms.TextBox txtAustAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


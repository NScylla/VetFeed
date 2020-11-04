namespace VetFeed
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
            this.lblKediİsim = new System.Windows.Forms.Label();
            this.txtBoxCatBreed = new System.Windows.Forms.TextBox();
            this.txtBoxCatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn1Clr = new System.Windows.Forms.Button();
            this.btn1Next = new System.Windows.Forms.Button();
            this.nmrcAge = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKediİsim
            // 
            this.lblKediİsim.AutoSize = true;
            this.lblKediİsim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKediİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKediİsim.Location = new System.Drawing.Point(150, 54);
            this.lblKediİsim.Name = "lblKediİsim";
            this.lblKediİsim.Size = new System.Drawing.Size(84, 25);
            this.lblKediİsim.TabIndex = 0;
            this.lblKediİsim.Text = "Kedinin;";
            // 
            // txtBoxCatBreed
            // 
            this.txtBoxCatBreed.Location = new System.Drawing.Point(294, 191);
            this.txtBoxCatBreed.Name = "txtBoxCatBreed";
            this.txtBoxCatBreed.Size = new System.Drawing.Size(163, 22);
            this.txtBoxCatBreed.TabIndex = 2;
            this.txtBoxCatBreed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCatName_KeyPress);
            this.txtBoxCatBreed.Leave += new System.EventHandler(this.txtBoxCatName_Leave);
            // 
            // txtBoxCatName
            // 
            this.txtBoxCatName.Location = new System.Drawing.Point(294, 127);
            this.txtBoxCatName.Name = "txtBoxCatName";
            this.txtBoxCatName.Size = new System.Drawing.Size(163, 22);
            this.txtBoxCatName.TabIndex = 1;
            this.txtBoxCatName.Enter += new System.EventHandler(this.txtBoxCatName_Enter);
            this.txtBoxCatName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCatName_KeyPress);
            this.txtBoxCatName.Leave += new System.EventHandler(this.txtBoxCatName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cinsi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yaşı:";
            // 
            // cmbBoxColor
            // 
            this.cmbBoxColor.FormattingEnabled = true;
            this.cmbBoxColor.Items.AddRange(new object[] {
            "Siyah ",
            "Beyaz",
            "Sarı",
            "Karışık"});
            this.cmbBoxColor.Location = new System.Drawing.Point(294, 319);
            this.cmbBoxColor.Name = "cmbBoxColor";
            this.cmbBoxColor.Size = new System.Drawing.Size(163, 24);
            this.cmbBoxColor.TabIndex = 4;
            this.cmbBoxColor.Text = "Lütfen Seçim Yapınız...";
            this.cmbBoxColor.SelectedIndexChanged += new System.EventHandler(this.cmbBoxColor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rengi:";
            // 
            // btn1Clr
            // 
            this.btn1Clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Clr.Location = new System.Drawing.Point(83, 390);
            this.btn1Clr.Name = "btn1Clr";
            this.btn1Clr.Size = new System.Drawing.Size(205, 33);
            this.btn1Clr.TabIndex = 6;
            this.btn1Clr.Text = "Ekranı Temizle";
            this.btn1Clr.UseVisualStyleBackColor = true;
            this.btn1Clr.Click += new System.EventHandler(this.btn1Clr_Click);
            // 
            // btn1Next
            // 
            this.btn1Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Next.Location = new System.Drawing.Point(366, 390);
            this.btn1Next.Name = "btn1Next";
            this.btn1Next.Size = new System.Drawing.Size(205, 33);
            this.btn1Next.TabIndex = 5;
            this.btn1Next.Text = "İleri";
            this.btn1Next.UseVisualStyleBackColor = true;
            this.btn1Next.Click += new System.EventHandler(this.btn1Next_Click);
            // 
            // nmrcAge
            // 
            this.nmrcAge.Location = new System.Drawing.Point(294, 255);
            this.nmrcAge.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmrcAge.Name = "nmrcAge";
            this.nmrcAge.Size = new System.Drawing.Size(163, 22);
            this.nmrcAge.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VetFeed.Properties.Resources._20621;
            this.pictureBox1.Location = new System.Drawing.Point(294, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 482);
            this.Controls.Add(this.nmrcAge);
            this.Controls.Add(this.btn1Next);
            this.Controls.Add(this.btn1Clr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoxColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCatName);
            this.Controls.Add(this.txtBoxCatBreed);
            this.Controls.Add(this.lblKediİsim);
            this.Name = "Form1";
            this.Text = "Kedi Bilgileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKediİsim;
        private System.Windows.Forms.TextBox txtBoxCatBreed;
        private System.Windows.Forms.TextBox txtBoxCatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1Clr;
        private System.Windows.Forms.Button btn1Next;
        private System.Windows.Forms.NumericUpDown nmrcAge;
    }
}


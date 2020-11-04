namespace VetFeed
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxFood = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxDiet = new System.Windows.Forms.ComboBox();
            this.btn3Next = new System.Windows.Forms.Button();
            this.btn3Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Yemek Türü:";
            // 
            // cmbBoxFood
            // 
            this.cmbBoxFood.FormattingEnabled = true;
            this.cmbBoxFood.Items.AddRange(new object[] {
            "Kuru Mama",
            "Yaş Mama"});
            this.cmbBoxFood.Location = new System.Drawing.Point(285, 99);
            this.cmbBoxFood.Name = "cmbBoxFood";
            this.cmbBoxFood.Size = new System.Drawing.Size(222, 24);
            this.cmbBoxFood.TabIndex = 1;
            this.cmbBoxFood.Text = "Lütfen Seçim Yapınız...";
            this.cmbBoxFood.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFood_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Diyet Türü:";
            // 
            // cmbBoxDiet
            // 
            this.cmbBoxDiet.FormattingEnabled = true;
            this.cmbBoxDiet.Items.AddRange(new object[] {
            "Yavru Kedi",
            "Tahılsız",
            "Zayıflama Amaçlı",
            "Kısırlaştırılmış"});
            this.cmbBoxDiet.Location = new System.Drawing.Point(285, 198);
            this.cmbBoxDiet.Name = "cmbBoxDiet";
            this.cmbBoxDiet.Size = new System.Drawing.Size(222, 24);
            this.cmbBoxDiet.TabIndex = 2;
            this.cmbBoxDiet.Text = "Lütfen Seçim Yapınız...";
            this.cmbBoxDiet.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDiet_SelectedIndexChanged);
            // 
            // btn3Next
            // 
            this.btn3Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Next.Location = new System.Drawing.Point(357, 284);
            this.btn3Next.Name = "btn3Next";
            this.btn3Next.Size = new System.Drawing.Size(194, 34);
            this.btn3Next.TabIndex = 3;
            this.btn3Next.Text = "İleri";
            this.btn3Next.UseVisualStyleBackColor = true;
            this.btn3Next.Click += new System.EventHandler(this.btn3Next_Click);
            // 
            // btn3Back
            // 
            this.btn3Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Back.Location = new System.Drawing.Point(109, 284);
            this.btn3Back.Name = "btn3Back";
            this.btn3Back.Size = new System.Drawing.Size(194, 34);
            this.btn3Back.TabIndex = 4;
            this.btn3Back.Text = "Geri";
            this.btn3Back.UseVisualStyleBackColor = true;
            this.btn3Back.Click += new System.EventHandler(this.btn3Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 406);
            this.Controls.Add(this.btn3Back);
            this.Controls.Add(this.btn3Next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxDiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoxFood);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxDiet;
        private System.Windows.Forms.Button btn3Next;
        private System.Windows.Forms.Button btn3Back;
    }
}
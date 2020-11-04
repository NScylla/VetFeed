namespace VetFeed
{
    partial class Form2
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
            this.btn2Next = new System.Windows.Forms.Button();
            this.btn2Clr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOwnersName = new System.Windows.Forms.TextBox();
            this.txtBoxOwnersSurname = new System.Windows.Forms.TextBox();
            this.lblKediİsim = new System.Windows.Forms.Label();
            this.btn2Back = new System.Windows.Forms.Button();
            this.dTpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn2Next
            // 
            this.btn2Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Next.Location = new System.Drawing.Point(443, 400);
            this.btn2Next.Name = "btn2Next";
            this.btn2Next.Size = new System.Drawing.Size(205, 33);
            this.btn2Next.TabIndex = 5;
            this.btn2Next.Text = "İleri";
            this.btn2Next.UseVisualStyleBackColor = true;
            this.btn2Next.Click += new System.EventHandler(this.btn2Next_Click);
            // 
            // btn2Clr
            // 
            this.btn2Clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Clr.Location = new System.Drawing.Point(25, 400);
            this.btn2Clr.Name = "btn2Clr";
            this.btn2Clr.Size = new System.Drawing.Size(205, 33);
            this.btn2Clr.TabIndex = 7;
            this.btn2Clr.Text = "Ekranı Temizle";
            this.btn2Clr.UseVisualStyleBackColor = true;
            this.btn2Clr.Click += new System.EventHandler(this.btn2Clr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Yaşadığı Şehir:";
            // 
            // cmbBoxCity
            // 
            this.cmbBoxCity.FormattingEnabled = true;
            this.cmbBoxCity.Items.AddRange(new object[] {
            "Seçim Yapınız...",
            "Foreign",
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            " Isparta",
            "İçel_Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K_maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbBoxCity.Location = new System.Drawing.Point(329, 336);
            this.cmbBoxCity.Name = "cmbBoxCity";
            this.cmbBoxCity.Size = new System.Drawing.Size(175, 24);
            this.cmbBoxCity.TabIndex = 4;
            this.cmbBoxCity.Text = "Lütfen Seçim Yapınız...";
            this.cmbBoxCity.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adı:";
            // 
            // txtBoxOwnersName
            // 
            this.txtBoxOwnersName.Location = new System.Drawing.Point(329, 144);
            this.txtBoxOwnersName.Name = "txtBoxOwnersName";
            this.txtBoxOwnersName.Size = new System.Drawing.Size(175, 22);
            this.txtBoxOwnersName.TabIndex = 1;
            this.txtBoxOwnersName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxOwnersName_KeyPress);
            this.txtBoxOwnersName.Leave += new System.EventHandler(this.txtBoxOwnersName_Leave);
            // 
            // txtBoxOwnersSurname
            // 
            this.txtBoxOwnersSurname.Location = new System.Drawing.Point(329, 208);
            this.txtBoxOwnersSurname.Name = "txtBoxOwnersSurname";
            this.txtBoxOwnersSurname.Size = new System.Drawing.Size(175, 22);
            this.txtBoxOwnersSurname.TabIndex = 2;
            this.txtBoxOwnersSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxOwnersName_KeyPress);
            this.txtBoxOwnersSurname.Leave += new System.EventHandler(this.txtBoxOwnersName_Leave);
            // 
            // lblKediİsim
            // 
            this.lblKediİsim.AutoSize = true;
            this.lblKediİsim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKediİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKediİsim.Location = new System.Drawing.Point(151, 71);
            this.lblKediİsim.Name = "lblKediİsim";
            this.lblKediİsim.Size = new System.Drawing.Size(170, 25);
            this.lblKediİsim.TabIndex = 12;
            this.lblKediİsim.Text = "Kedinin Sahibinin;";
            // 
            // btn2Back
            // 
            this.btn2Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Back.Location = new System.Drawing.Point(236, 400);
            this.btn2Back.Name = "btn2Back";
            this.btn2Back.Size = new System.Drawing.Size(205, 33);
            this.btn2Back.TabIndex = 6;
            this.btn2Back.Text = "Geri";
            this.btn2Back.UseVisualStyleBackColor = true;
            this.btn2Back.Click += new System.EventHandler(this.btn2Back_Click);
            // 
            // dTpBirthDate
            // 
            this.dTpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTpBirthDate.Location = new System.Drawing.Point(329, 269);
            this.dTpBirthDate.MaxDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dTpBirthDate.MinDate = new System.DateTime(1919, 1, 1, 0, 0, 0, 0);
            this.dTpBirthDate.Name = "dTpBirthDate";
            this.dTpBirthDate.Size = new System.Drawing.Size(175, 22);
            this.dTpBirthDate.TabIndex = 3;
            this.dTpBirthDate.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dTpBirthDate.TabStopChanged += new System.EventHandler(this.dTpBirthDate_TabStopChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 482);
            this.Controls.Add(this.dTpBirthDate);
            this.Controls.Add(this.btn2Back);
            this.Controls.Add(this.btn2Next);
            this.Controls.Add(this.btn2Clr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoxCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxOwnersName);
            this.Controls.Add(this.txtBoxOwnersSurname);
            this.Controls.Add(this.lblKediİsim);
            this.Name = "Form2";
            this.Text = "Kişi Bilgileri";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2Next;
        private System.Windows.Forms.Button btn2Clr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOwnersName;
        private System.Windows.Forms.TextBox txtBoxOwnersSurname;
        private System.Windows.Forms.Label lblKediİsim;
        private System.Windows.Forms.Button btn2Back;
        private System.Windows.Forms.DateTimePicker dTpBirthDate;
    }
}
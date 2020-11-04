namespace VetFeed
{
    partial class Form4
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
            this.lnkFood = new System.Windows.Forms.LinkLabel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDText = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.labelSahip = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkFood
            // 
            this.lnkFood.AutoSize = true;
            this.lnkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFood.Location = new System.Drawing.Point(68, 181);
            this.lnkFood.Name = "lnkFood";
            this.lnkFood.Size = new System.Drawing.Size(108, 25);
            this.lnkFood.TabIndex = 1;
            this.lnkFood.TabStop = true;
            this.lnkFood.Text = "Sipariş Ver";
            this.lnkFood.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFood_LinkClicked);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(71, 92);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(64, 25);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "label3";
            // 
            // lblIDText
            // 
            this.lblIDText.AutoSize = true;
            this.lblIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDText.Location = new System.Drawing.Point(141, 92);
            this.lblIDText.Name = "lblIDText";
            this.lblIDText.Size = new System.Drawing.Size(315, 25);
            this.lblIDText.TabIndex = 3;
            this.lblIDText.Text = "No.lu Kullanıcı Kodunuz Atanmıştır.";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(68, 136);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(739, 25);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Size özel oluşturulan ID ile indirimli siparişinizi aşağıdaki linke tıklayarak ve" +
    "rebilirsiniz.";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(170, 53);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(206, 25);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "isimli kedi sahibi Sayın";
            // 
            // labelSahip
            // 
            this.labelSahip.AutoSize = true;
            this.labelSahip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSahip.Location = new System.Drawing.Point(382, 53);
            this.labelSahip.Name = "labelSahip";
            this.labelSahip.Size = new System.Drawing.Size(64, 25);
            this.labelSahip.TabIndex = 7;
            this.labelSahip.Text = "label2";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.Location = new System.Drawing.Point(71, 53);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(64, 25);
            this.lblCatName.TabIndex = 9;
            this.lblCatName.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 249);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.labelSahip);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblIDText);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lnkFood);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkFood;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDText;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label labelSahip;
        private System.Windows.Forms.Label lblCatName;
    }
}
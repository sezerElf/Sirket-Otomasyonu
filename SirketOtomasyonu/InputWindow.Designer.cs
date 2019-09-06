namespace SirketOtomasyonu
{
    partial class InputWindow
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
            this.nameTb = new System.Windows.Forms.TextBox();
            this.lastnameTb = new System.Windows.Forms.TextBox();
            this.ageTb = new System.Windows.Forms.TextBox();
            this.genderCb = new System.Windows.Forms.ComboBox();
            this.noTb = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.genderlb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(12, 97);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 0;
            // 
            // lastnameTb
            // 
            this.lastnameTb.Location = new System.Drawing.Point(127, 97);
            this.lastnameTb.Name = "lastnameTb";
            this.lastnameTb.Size = new System.Drawing.Size(100, 20);
            this.lastnameTb.TabIndex = 1;
            // 
            // ageTb
            // 
            this.ageTb.Location = new System.Drawing.Point(242, 97);
            this.ageTb.Name = "ageTb";
            this.ageTb.Size = new System.Drawing.Size(40, 20);
            this.ageTb.TabIndex = 2;
            // 
            // genderCb
            // 
            this.genderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCb.FormattingEnabled = true;
            this.genderCb.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Diğer"});
            this.genderCb.Location = new System.Drawing.Point(297, 97);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(121, 21);
            this.genderCb.TabIndex = 3;
            // 
            // noTb
            // 
            this.noTb.Location = new System.Drawing.Point(433, 97);
            this.noTb.Name = "noTb";
            this.noTb.Size = new System.Drawing.Size(100, 20);
            this.noTb.TabIndex = 4;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(12, 81);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(25, 13);
            this.namelbl.TabIndex = 5;
            this.namelbl.Text = "İsim";
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Location = new System.Drawing.Point(126, 81);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(42, 13);
            this.lastNamelbl.TabIndex = 6;
            this.lastNamelbl.Text = "Soyisim";
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Location = new System.Drawing.Point(243, 81);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(25, 13);
            this.agelbl.TabIndex = 7;
            this.agelbl.Text = "Yaş";
            // 
            // genderlb
            // 
            this.genderlb.AutoSize = true;
            this.genderlb.Location = new System.Drawing.Point(295, 81);
            this.genderlb.Name = "genderlb";
            this.genderlb.Size = new System.Drawing.Size(43, 13);
            this.genderlb.TabIndex = 8;
            this.genderlb.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "no";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(220, 149);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Ekle";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // InputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 230);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genderlb);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.lastNamelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.noTb);
            this.Controls.Add(this.genderCb);
            this.Controls.Add(this.ageTb);
            this.Controls.Add(this.lastnameTb);
            this.Controls.Add(this.nameTb);
            this.Name = "InputWindow";
            this.Text = "InputWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox lastnameTb;
        private System.Windows.Forms.TextBox ageTb;
        private System.Windows.Forms.ComboBox genderCb;
        private System.Windows.Forms.TextBox noTb;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label lastNamelbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Label genderlb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
    }
}
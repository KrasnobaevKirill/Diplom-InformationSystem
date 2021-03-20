namespace Kurs
{
    partial class AddPoverkaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPoverkaForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomerprot_ = new System.Windows.Forms.TextBox();
            this.organ_ = new System.Windows.Forms.ComboBox();
            this.nomerprib_ = new System.Windows.Forms.ComboBox();
            this.date_ = new System.Windows.Forms.DateTimePicker();
            this.res_ = new System.Windows.Forms.ComboBox();
            this.fio_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер протокола";
            // 
            // nomerprot_
            // 
            this.nomerprot_.Location = new System.Drawing.Point(126, 12);
            this.nomerprot_.Name = "nomerprot_";
            this.nomerprot_.Size = new System.Drawing.Size(174, 20);
            this.nomerprot_.TabIndex = 2;
            // 
            // organ_
            // 
            this.organ_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organ_.FormattingEnabled = true;
            this.organ_.Location = new System.Drawing.Point(126, 39);
            this.organ_.Name = "organ_";
            this.organ_.Size = new System.Drawing.Size(174, 21);
            this.organ_.TabIndex = 3;
            // 
            // nomerprib_
            // 
            this.nomerprib_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomerprib_.FormattingEnabled = true;
            this.nomerprib_.Location = new System.Drawing.Point(126, 67);
            this.nomerprib_.Name = "nomerprib_";
            this.nomerprib_.Size = new System.Drawing.Size(174, 21);
            this.nomerprib_.TabIndex = 4;
            // 
            // date_
            // 
            this.date_.Location = new System.Drawing.Point(126, 95);
            this.date_.Name = "date_";
            this.date_.Size = new System.Drawing.Size(174, 20);
            this.date_.TabIndex = 5;
            // 
            // res_
            // 
            this.res_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res_.FormattingEnabled = true;
            this.res_.Items.AddRange(new object[] {
            "Годен",
            "Не годен"});
            this.res_.Location = new System.Drawing.Point(126, 147);
            this.res_.Name = "res_";
            this.res_.Size = new System.Drawing.Size(174, 21);
            this.res_.TabIndex = 6;
            // 
            // fio_
            // 
            this.fio_.Location = new System.Drawing.Point(126, 121);
            this.fio_.Name = "fio_";
            this.fio_.Size = new System.Drawing.Size(174, 20);
            this.fio_.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Организация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер прибора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ФИО поверяющего";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Результат";
            // 
            // AddPoverkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fio_);
            this.Controls.Add(this.res_);
            this.Controls.Add(this.date_);
            this.Controls.Add(this.nomerprib_);
            this.Controls.Add(this.organ_);
            this.Controls.Add(this.nomerprot_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPoverkaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddPoverkaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomerprot_;
        private System.Windows.Forms.ComboBox organ_;
        private System.Windows.Forms.ComboBox nomerprib_;
        private System.Windows.Forms.DateTimePicker date_;
        private System.Windows.Forms.ComboBox res_;
        private System.Windows.Forms.TextBox fio_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
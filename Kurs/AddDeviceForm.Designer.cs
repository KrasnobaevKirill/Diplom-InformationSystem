namespace Kurs
{
    partial class AddDeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeviceForm));
            this.button1 = new System.Windows.Forms.Button();
            this.zavnomer_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sost_ = new System.Windows.Forms.ComboBox();
            this.mesto_ = new System.Windows.Forms.ComboBox();
            this.kodsotr_ = new System.Windows.Forms.ComboBox();
            this.marka_ = new System.Windows.Forms.ComboBox();
            this.datevyp_ = new System.Windows.Forms.DateTimePicker();
            this.datevvoda_ = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zavnomer_
            // 
            this.zavnomer_.Location = new System.Drawing.Point(172, 6);
            this.zavnomer_.Name = "zavnomer_";
            this.zavnomer_.Size = new System.Drawing.Size(168, 20);
            this.zavnomer_.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заводской номер (6 знаков)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Марка прибора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Код сотрудника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Место установки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата выпуска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата ввода в эксплуатацию";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Состояние";
            // 
            // sost_
            // 
            this.sost_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sost_.FormattingEnabled = true;
            this.sost_.Items.AddRange(new object[] {
            "Эксплуатируется",
            "Ремонтируется",
            "Списан"});
            this.sost_.Location = new System.Drawing.Point(172, 208);
            this.sost_.Name = "sost_";
            this.sost_.Size = new System.Drawing.Size(168, 21);
            this.sost_.TabIndex = 15;
            // 
            // mesto_
            // 
            this.mesto_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesto_.FormattingEnabled = true;
            this.mesto_.Location = new System.Drawing.Point(172, 108);
            this.mesto_.Name = "mesto_";
            this.mesto_.Size = new System.Drawing.Size(168, 21);
            this.mesto_.TabIndex = 16;
            // 
            // kodsotr_
            // 
            this.kodsotr_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodsotr_.FormattingEnabled = true;
            this.kodsotr_.Location = new System.Drawing.Point(172, 74);
            this.kodsotr_.Name = "kodsotr_";
            this.kodsotr_.Size = new System.Drawing.Size(168, 21);
            this.kodsotr_.TabIndex = 17;
            // 
            // marka_
            // 
            this.marka_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marka_.FormattingEnabled = true;
            this.marka_.Location = new System.Drawing.Point(172, 38);
            this.marka_.Name = "marka_";
            this.marka_.Size = new System.Drawing.Size(168, 21);
            this.marka_.TabIndex = 18;
            // 
            // datevyp_
            // 
            this.datevyp_.Location = new System.Drawing.Point(172, 142);
            this.datevyp_.Name = "datevyp_";
            this.datevyp_.Size = new System.Drawing.Size(168, 20);
            this.datevyp_.TabIndex = 19;
            // 
            // datevvoda_
            // 
            this.datevvoda_.Location = new System.Drawing.Point(172, 174);
            this.datevvoda_.Name = "datevvoda_";
            this.datevvoda_.Size = new System.Drawing.Size(168, 20);
            this.datevvoda_.TabIndex = 20;
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 342);
            this.Controls.Add(this.datevvoda_);
            this.Controls.Add(this.datevyp_);
            this.Controls.Add(this.marka_);
            this.Controls.Add(this.kodsotr_);
            this.Controls.Add(this.mesto_);
            this.Controls.Add(this.sost_);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zavnomer_);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление прибора";
            this.Load += new System.EventHandler(this.AddDeviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox zavnomer_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sost_;
        private System.Windows.Forms.ComboBox mesto_;
        private System.Windows.Forms.ComboBox kodsotr_;
        private System.Windows.Forms.ComboBox marka_;
        private System.Windows.Forms.DateTimePicker datevyp_;
        private System.Windows.Forms.DateTimePicker datevvoda_;
    }
}
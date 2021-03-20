namespace Kurs
{
    partial class AddMarkaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMarkaForm));
            this.button1 = new System.Windows.Forms.Button();
            this.marka_ = new System.Windows.Forms.TextBox();
            this.type_ = new System.Windows.Forms.TextBox();
            this.proizv_ = new System.Windows.Forms.TextBox();
            this.period_ = new System.Windows.Forms.TextBox();
            this.srok_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marka_
            // 
            this.marka_.Location = new System.Drawing.Point(175, 12);
            this.marka_.Name = "marka_";
            this.marka_.Size = new System.Drawing.Size(100, 20);
            this.marka_.TabIndex = 1;
            // 
            // type_
            // 
            this.type_.Location = new System.Drawing.Point(175, 39);
            this.type_.Name = "type_";
            this.type_.Size = new System.Drawing.Size(100, 20);
            this.type_.TabIndex = 2;
            // 
            // proizv_
            // 
            this.proizv_.Location = new System.Drawing.Point(175, 67);
            this.proizv_.Name = "proizv_";
            this.proizv_.Size = new System.Drawing.Size(100, 20);
            this.proizv_.TabIndex = 3;
            // 
            // period_
            // 
            this.period_.Location = new System.Drawing.Point(175, 93);
            this.period_.Name = "period_";
            this.period_.Size = new System.Drawing.Size(100, 20);
            this.period_.TabIndex = 4;
            // 
            // srok_
            // 
            this.srok_.Location = new System.Drawing.Point(175, 120);
            this.srok_.Name = "srok_";
            this.srok_.Size = new System.Drawing.Size(100, 20);
            this.srok_.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Периодичность поверки (мес.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Срок эксплуатации (мес.)";
            // 
            // AddMarkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 274);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srok_);
            this.Controls.Add(this.period_);
            this.Controls.Add(this.proizv_);
            this.Controls.Add(this.type_);
            this.Controls.Add(this.marka_);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMarkaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление марки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox marka_;
        private System.Windows.Forms.TextBox type_;
        private System.Windows.Forms.TextBox proizv_;
        private System.Windows.Forms.TextBox period_;
        private System.Windows.Forms.TextBox srok_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
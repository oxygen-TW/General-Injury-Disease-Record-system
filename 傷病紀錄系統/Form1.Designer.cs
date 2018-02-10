namespace 傷病紀錄系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Patient_Name = new System.Windows.Forms.TextBox();
            this.b_Submit = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Patient_Symptom = new System.Windows.Forms.TextBox();
            this.Treatment = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PatientSpecialNeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // Patient_Name
            // 
            this.Patient_Name.Location = new System.Drawing.Point(12, 24);
            this.Patient_Name.Name = "Patient_Name";
            this.Patient_Name.Size = new System.Drawing.Size(100, 22);
            this.Patient_Name.TabIndex = 1;
            // 
            // b_Submit
            // 
            this.b_Submit.Location = new System.Drawing.Point(486, 95);
            this.b_Submit.Name = "b_Submit";
            this.b_Submit.Size = new System.Drawing.Size(75, 23);
            this.b_Submit.TabIndex = 2;
            this.b_Submit.Text = "Submit";
            this.b_Submit.UseVisualStyleBackColor = true;
            this.b_Submit.Click += new System.EventHandler(this.B_Submit_Click);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(12, 64);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 22);
            this.Age.TabIndex = 3;
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.Sex.Location = new System.Drawing.Point(135, 26);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(116, 20);
            this.Sex.TabIndex = 4;
            // 
            // Patient_Symptom
            // 
            this.Patient_Symptom.Location = new System.Drawing.Point(266, 24);
            this.Patient_Symptom.Multiline = true;
            this.Patient_Symptom.Name = "Patient_Symptom";
            this.Patient_Symptom.Size = new System.Drawing.Size(141, 65);
            this.Patient_Symptom.TabIndex = 5;
            // 
            // Treatment
            // 
            this.Treatment.Location = new System.Drawing.Point(420, 24);
            this.Treatment.Multiline = true;
            this.Treatment.Name = "Treatment";
            this.Treatment.Size = new System.Drawing.Size(141, 65);
            this.Treatment.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 12);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Symptoms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Treatment";
            // 
            // PatientSpecialNeed
            // 
            this.PatientSpecialNeed.Location = new System.Drawing.Point(135, 64);
            this.PatientSpecialNeed.Name = "PatientSpecialNeed";
            this.PatientSpecialNeed.Size = new System.Drawing.Size(116, 22);
            this.PatientSpecialNeed.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "Special Need";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 387);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PatientSpecialNeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Treatment);
            this.Controls.Add(this.Patient_Symptom);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.b_Submit);
            this.Controls.Add(this.Patient_Name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Patient_Name;
        private System.Windows.Forms.Button b_Submit;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.TextBox Patient_Symptom;
        private System.Windows.Forms.TextBox Treatment;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatientSpecialNeed;
        private System.Windows.Forms.Label label6;
    }
}


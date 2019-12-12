namespace Assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            lblMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            lblMin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            lblAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(467, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(593, 40);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách các số :";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(375, 167);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(129, 17);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "Danh sách các số :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá trị lớn nhất :";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new System.Drawing.Point(375, 233);
            lblMax.Name = "lblMax";
            lblMax.Size = new System.Drawing.Size(129, 17);
            lblMax.TabIndex = 3;
            lblMax.Text = "Danh sách các số :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá trị nhỏ nhất :";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new System.Drawing.Point(375, 304);
            lblMin.Name = "lblMin";
            lblMin.Size = new System.Drawing.Size(129, 17);
            lblMin.TabIndex = 3;
            lblMin.Text = "Danh sách các số :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giá trị trung bình :";
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Location = new System.Drawing.Point(375, 373);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new System.Drawing.Size(129, 17);
            lblAvg.TabIndex = 3;
            lblAvg.Text = "Danh sách các số :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái :";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(375, 103);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(129, 17);
            this.lblReport.TabIndex = 3;
            this.lblReport.Text = "Danh sách các số :";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(228, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(194, 22);
            this.txtInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(lblAvg);
            this.Controls.Add(lblMin);
            this.Controls.Add(lblMax);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label label3;
        public static System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label5;
        public static System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label7;
        public static System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.TextBox txtInput;
    }
}


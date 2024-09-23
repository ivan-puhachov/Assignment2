namespace assignment2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.lblClassA = new System.Windows.Forms.Label();
            this.lblClassB = new System.Windows.Forms.Label();
            this.lblClassC = new System.Windows.Forms.Label();
            this.lblRevenueA = new System.Windows.Forms.Label();
            this.lblRevenueB = new System.Windows.Forms.Label();
            this.lblRevenueC = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtRevenueA = new System.Windows.Forms.TextBox();
            this.txtRevenueB = new System.Windows.Forms.TextBox();
            this.txtRevenueC = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClassA
            // 
            this.txtClassA.BackColor = System.Drawing.SystemColors.Window;
            this.txtClassA.Location = new System.Drawing.Point(177, 51);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(100, 20);
            this.txtClassA.TabIndex = 0;
            this.txtClassA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(177, 77);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(100, 20);
            this.txtClassB.TabIndex = 1;
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(177, 103);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(100, 20);
            this.txtClassC.TabIndex = 2;
            // 
            // lblClassA
            // 
            this.lblClassA.AutoSize = true;
            this.lblClassA.Location = new System.Drawing.Point(68, 58);
            this.lblClassA.Name = "lblClassA";
            this.lblClassA.Size = new System.Drawing.Size(45, 13);
            this.lblClassA.TabIndex = 3;
            this.lblClassA.Text = "Class A:";
            // 
            // lblClassB
            // 
            this.lblClassB.AutoSize = true;
            this.lblClassB.Location = new System.Drawing.Point(68, 84);
            this.lblClassB.Name = "lblClassB";
            this.lblClassB.Size = new System.Drawing.Size(45, 13);
            this.lblClassB.TabIndex = 4;
            this.lblClassB.Text = "Class B:";
            // 
            // lblClassC
            // 
            this.lblClassC.AutoSize = true;
            this.lblClassC.Location = new System.Drawing.Point(68, 110);
            this.lblClassC.Name = "lblClassC";
            this.lblClassC.Size = new System.Drawing.Size(45, 13);
            this.lblClassC.TabIndex = 5;
            this.lblClassC.Text = "Class C:";
            // 
            // lblRevenueA
            // 
            this.lblRevenueA.AutoSize = true;
            this.lblRevenueA.Location = new System.Drawing.Point(23, 58);
            this.lblRevenueA.Name = "lblRevenueA";
            this.lblRevenueA.Size = new System.Drawing.Size(45, 13);
            this.lblRevenueA.TabIndex = 6;
            this.lblRevenueA.Text = "Class A:";
            // 
            // lblRevenueB
            // 
            this.lblRevenueB.AutoSize = true;
            this.lblRevenueB.Location = new System.Drawing.Point(23, 85);
            this.lblRevenueB.Name = "lblRevenueB";
            this.lblRevenueB.Size = new System.Drawing.Size(45, 13);
            this.lblRevenueB.TabIndex = 7;
            this.lblRevenueB.Text = "Class B:";
            // 
            // lblRevenueC
            // 
            this.lblRevenueC.AutoSize = true;
            this.lblRevenueC.Location = new System.Drawing.Point(23, 110);
            this.lblRevenueC.Name = "lblRevenueC";
            this.lblRevenueC.Size = new System.Drawing.Size(45, 13);
            this.lblRevenueC.TabIndex = 8;
            this.lblRevenueC.Text = "Class C:";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Location = new System.Drawing.Point(23, 136);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(34, 13);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "Total:";
            this.lblTotalRevenue.Click += new System.EventHandler(this.lblTotalRevenue_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(227, 219);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(60, 39);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Revenue";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 39);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(359, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 39);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtRevenueA
            // 
            this.txtRevenueA.Location = new System.Drawing.Point(98, 51);
            this.txtRevenueA.Name = "txtRevenueA";
            this.txtRevenueA.Size = new System.Drawing.Size(100, 20);
            this.txtRevenueA.TabIndex = 13;
            // 
            // txtRevenueB
            // 
            this.txtRevenueB.Location = new System.Drawing.Point(98, 77);
            this.txtRevenueB.Name = "txtRevenueB";
            this.txtRevenueB.Size = new System.Drawing.Size(100, 20);
            this.txtRevenueB.TabIndex = 14;
            // 
            // txtRevenueC
            // 
            this.txtRevenueC.Location = new System.Drawing.Point(98, 103);
            this.txtRevenueC.Name = "txtRevenueC";
            this.txtRevenueC.Size = new System.Drawing.Size(100, 20);
            this.txtRevenueC.TabIndex = 15;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(12, 26);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(268, 13);
            this.Info.TabIndex = 16;
            this.Info.Text = "Enter the number of tickets sold for each class of seats:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Controls.Add(this.lblClassA);
            this.groupBox1.Controls.Add(this.lblClassB);
            this.groupBox1.Controls.Add(this.lblClassC);
            this.groupBox1.Controls.Add(this.txtClassA);
            this.groupBox1.Controls.Add(this.txtClassB);
            this.groupBox1.Controls.Add(this.txtClassC);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 181);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalRevenue);
            this.groupBox2.Controls.Add(this.lblRevenueA);
            this.groupBox2.Controls.Add(this.txtRevenueB);
            this.groupBox2.Controls.Add(this.txtRevenueC);
            this.groupBox2.Controls.Add(this.lblRevenueB);
            this.groupBox2.Controls.Add(this.lblRevenueC);
            this.groupBox2.Controls.Add(this.lblTotalRevenue);
            this.groupBox2.Controls.Add(this.txtRevenueA);
            this.groupBox2.Location = new System.Drawing.Point(319, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 181);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Location = new System.Drawing.Point(98, 133);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRevenue.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.Label lblClassA;
        private System.Windows.Forms.Label lblClassB;
        private System.Windows.Forms.Label lblClassC;
        private System.Windows.Forms.Label lblRevenueA;
        private System.Windows.Forms.Label lblRevenueB;
        private System.Windows.Forms.Label lblRevenueC;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtRevenueA;
        private System.Windows.Forms.TextBox txtRevenueB;
        private System.Windows.Forms.TextBox txtRevenueC;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalRevenue;
    }
}


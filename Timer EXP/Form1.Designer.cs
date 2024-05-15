namespace Timer_EXP
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.L5 = new System.Windows.Forms.Label();
            this.L6 = new System.Windows.Forms.Label();
            this.btnstartstop = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // L1
            // 
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(35, 43);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(42, 31);
            this.L1.TabIndex = 0;
            this.L1.Text = "00";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(83, 45);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(39, 29);
            this.L2.TabIndex = 1;
            this.L2.Text = "00";
            this.L2.Click += new System.EventHandler(this.button1_Click);
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3.Location = new System.Drawing.Point(131, 43);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(39, 29);
            this.L3.TabIndex = 2;
            this.L3.Text = "00";
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L4.Location = new System.Drawing.Point(35, 199);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(39, 29);
            this.L4.TabIndex = 3;
            this.L4.Text = "00";
            // 
            // L5
            // 
            this.L5.AutoSize = true;
            this.L5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L5.Location = new System.Drawing.Point(83, 199);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(39, 29);
            this.L5.TabIndex = 4;
            this.L5.Text = "00";
            // 
            // L6
            // 
            this.L6.AutoSize = true;
            this.L6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L6.Location = new System.Drawing.Point(131, 199);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(39, 29);
            this.L6.TabIndex = 5;
            this.L6.Text = "00";
            // 
            // btnstartstop
            // 
            this.btnstartstop.Location = new System.Drawing.Point(62, 101);
            this.btnstartstop.Name = "btnstartstop";
            this.btnstartstop.Size = new System.Drawing.Size(75, 23);
            this.btnstartstop.TabIndex = 6;
            this.btnstartstop.Text = "start/stop";
            this.btnstartstop.UseVisualStyleBackColor = true;
            this.btnstartstop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(62, 130);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stop watch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Computer Clock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 250);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnstartstop);
            this.Controls.Add(this.L6);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.Label L5;
        private System.Windows.Forms.Label L6;
        private System.Windows.Forms.Button btnstartstop;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}


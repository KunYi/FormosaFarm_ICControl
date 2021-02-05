
namespace FormosaRM_ICControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RM3_IC01 = new Bulb.LedBulb();
            this.RM3_IC02 = new Bulb.LedBulb();
            this.RM3_IC03 = new Bulb.LedBulb();
            this.RM3_IC04 = new Bulb.LedBulb();
            this.RM2_IC01 = new Bulb.LedBulb();
            this.RM2_IC02 = new Bulb.LedBulb();
            this.RM2_IC03 = new Bulb.LedBulb();
            this.RM2_IC04 = new Bulb.LedBulb();
            this.RM1_IC04 = new Bulb.LedBulb();
            this.RM1_IC03 = new Bulb.LedBulb();
            this.RM1_IC02 = new Bulb.LedBulb();
            this.RM1_IC01 = new Bulb.LedBulb();
            this.Status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RM1_IC04);
            this.groupBox1.Controls.Add(this.RM1_IC03);
            this.groupBox1.Controls.Add(this.RM1_IC02);
            this.groupBox1.Controls.Add(this.RM1_IC01);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RM1(E4001)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "水路4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "水路3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "水路2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "水路1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 61);
            this.button4.TabIndex = 7;
            this.button4.Text = "打開";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 61);
            this.button3.TabIndex = 6;
            this.button3.Text = "打開";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "打開";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "打開";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.RM2_IC01);
            this.groupBox2.Controls.Add(this.RM2_IC02);
            this.groupBox2.Controls.Add(this.RM2_IC03);
            this.groupBox2.Controls.Add(this.RM2_IC04);
            this.groupBox2.Location = new System.Drawing.Point(427, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 232);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RM2(E4002)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "水路4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "水路3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "水路2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "水路1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "打開";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(113, 116);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 61);
            this.button6.TabIndex = 5;
            this.button6.Text = "打開";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(203, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 61);
            this.button7.TabIndex = 6;
            this.button7.Text = "打開";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(293, 116);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 61);
            this.button8.TabIndex = 7;
            this.button8.Text = "打開";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.RM3_IC01);
            this.groupBox3.Controls.Add(this.RM3_IC02);
            this.groupBox3.Controls.Add(this.RM3_IC03);
            this.groupBox3.Controls.Add(this.RM3_IC04);
            this.groupBox3.Location = new System.Drawing.Point(841, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 232);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RM3(E4003)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "水路1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "水路2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "水路3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "水路4";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(23, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 61);
            this.button9.TabIndex = 7;
            this.button9.Text = "打開";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(113, 116);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(72, 61);
            this.button10.TabIndex = 6;
            this.button10.Text = "打開";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(203, 116);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 61);
            this.button11.TabIndex = 5;
            this.button11.Text = "打開";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(293, 116);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 61);
            this.button12.TabIndex = 4;
            this.button12.Text = "打開";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 45);
            this.panel1.TabIndex = 10;
            // 
            // RM3_IC01
            // 
            this.RM3_IC01.Location = new System.Drawing.Point(23, 25);
            this.RM3_IC01.Name = "RM3_IC01";
            this.RM3_IC01.On = false;
            this.RM3_IC01.Size = new System.Drawing.Size(72, 72);
            this.RM3_IC01.TabIndex = 0;
            // 
            // RM3_IC02
            // 
            this.RM3_IC02.Location = new System.Drawing.Point(113, 25);
            this.RM3_IC02.Name = "RM3_IC02";
            this.RM3_IC02.On = false;
            this.RM3_IC02.Size = new System.Drawing.Size(72, 72);
            this.RM3_IC02.TabIndex = 1;
            // 
            // RM3_IC03
            // 
            this.RM3_IC03.Location = new System.Drawing.Point(203, 25);
            this.RM3_IC03.Name = "RM3_IC03";
            this.RM3_IC03.On = false;
            this.RM3_IC03.Size = new System.Drawing.Size(72, 72);
            this.RM3_IC03.TabIndex = 2;
            // 
            // RM3_IC04
            // 
            this.RM3_IC04.Location = new System.Drawing.Point(293, 25);
            this.RM3_IC04.Name = "RM3_IC04";
            this.RM3_IC04.On = false;
            this.RM3_IC04.Size = new System.Drawing.Size(72, 72);
            this.RM3_IC04.TabIndex = 3;
            // 
            // RM2_IC01
            //
            this.RM2_IC01.Location = new System.Drawing.Point(23, 25);
            this.RM2_IC01.Name = "RM2_IC01";
            this.RM2_IC01.On = false;
            this.RM2_IC01.Size = new System.Drawing.Size(72, 72);
            this.RM2_IC01.TabIndex = 0;

            // 
            // RM2_IC02
            // 
            this.RM2_IC02.Location = new System.Drawing.Point(113, 25);
            this.RM2_IC02.Name = "RM2_IC02";
            this.RM2_IC02.On = false;
            this.RM2_IC02.Size = new System.Drawing.Size(72, 72);
            this.RM2_IC02.TabIndex = 1;
            // 
            // RM2_IC03
            // 
            this.RM2_IC03.Location = new System.Drawing.Point(203, 25);
            this.RM2_IC03.Name = "RM2_IC03";
            this.RM2_IC03.On = false;
            this.RM2_IC03.Size = new System.Drawing.Size(72, 72);
            this.RM2_IC03.TabIndex = 2;
            // 
            // RM2_IC04
            // 
            this.RM2_IC04.Location = new System.Drawing.Point(293, 25);
            this.RM2_IC04.Name = "RM2_IC04";
            this.RM2_IC04.On = false;
            this.RM2_IC04.Size = new System.Drawing.Size(72, 72);
            this.RM2_IC04.TabIndex = 3;
            // 
            // RM1_IC04
            // 
            this.RM1_IC04.Location = new System.Drawing.Point(293, 25);
            this.RM1_IC04.Name = "RM1_IC04";
            this.RM1_IC04.On = false;
            this.RM1_IC04.Size = new System.Drawing.Size(72, 72);
            this.RM1_IC04.TabIndex = 3;
            // 
            // RM1_IC03
            // 
            this.RM1_IC03.Location = new System.Drawing.Point(203, 25);
            this.RM1_IC03.Name = "RM1_IC03";
            this.RM1_IC03.On = false;
            this.RM1_IC03.Size = new System.Drawing.Size(72, 72);
            this.RM1_IC03.TabIndex = 2;
            // 
            // RM1_IC02
            // 
            this.RM1_IC02.Location = new System.Drawing.Point(113, 25);
            this.RM1_IC02.Name = "RM1_IC02";
            this.RM1_IC02.On = false;
            this.RM1_IC02.Size = new System.Drawing.Size(72, 72);
            this.RM1_IC02.TabIndex = 1;
            // 
            // RM1_IC01
            // 
            this.RM1_IC01.Location = new System.Drawing.Point(23, 25);
            this.RM1_IC01.Name = "RM1_IC01";
            this.RM1_IC01.On = false;
            this.RM1_IC01.Size = new System.Drawing.Size(72, 72);
            this.RM1_IC01.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(13, 13);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 20);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 308);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "農場溫室水路控制電磁閥驗收用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bulb.LedBulb RM1_IC01;
        private Bulb.LedBulb RM1_IC02;
        private Bulb.LedBulb RM1_IC04;
        private Bulb.LedBulb RM1_IC03;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private Bulb.LedBulb RM2_IC01;
        private Bulb.LedBulb RM2_IC02;
        private Bulb.LedBulb RM2_IC03;
        private Bulb.LedBulb RM2_IC04;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private Bulb.LedBulb RM3_IC01;
        private Bulb.LedBulb RM3_IC02;
        private Bulb.LedBulb RM3_IC03;
        private Bulb.LedBulb RM3_IC04;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Status;
    }
}


namespace CncPlugin
{
    partial class CncControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtProbeMeasurment = new System.Windows.Forms.TextBox();
            this.btn_probe_read = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_set_probe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_step_5 = new System.Windows.Forms.Button();
            this.btn_step_3 = new System.Windows.Forms.Button();
            this.btn_step_4 = new System.Windows.Forms.Button();
            this.btn_step_1 = new System.Windows.Forms.Button();
            this.btn_step_2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_z_minus = new System.Windows.Forms.Button();
            this.btn_z_plus = new System.Windows.Forms.Button();
            this.btn_x_minus = new System.Windows.Forms.Button();
            this.btn_x_plus = new System.Windows.Forms.Button();
            this.btn_y_minus = new System.Windows.Forms.Button();
            this.btn_y_plus = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Probe";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_probe);
            // 
            // txtProbeMeasurment
            // 
            this.txtProbeMeasurment.Location = new System.Drawing.Point(102, 25);
            this.txtProbeMeasurment.Name = "txtProbeMeasurment";
            this.txtProbeMeasurment.Size = new System.Drawing.Size(45, 20);
            this.txtProbeMeasurment.TabIndex = 12;
            // 
            // btn_probe_read
            // 
            this.btn_probe_read.Location = new System.Drawing.Point(296, 25);
            this.btn_probe_read.Name = "btn_probe_read";
            this.btn_probe_read.Size = new System.Drawing.Size(56, 20);
            this.btn_probe_read.TabIndex = 1;
            this.btn_probe_read.Text = "Read";
            this.btn_probe_read.UseMnemonic = false;
            this.btn_probe_read.UseVisualStyleBackColor = true;
            this.btn_probe_read.Click += new System.EventHandler(this.btn_probe_read_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_set_probe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtProbeMeasurment);
            this.groupBox1.Controls.Add(this.btn_probe_read);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 71);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Z-Probe";
            // 
            // btn_set_probe
            // 
            this.btn_set_probe.Location = new System.Drawing.Point(183, 25);
            this.btn_set_probe.Name = "btn_set_probe";
            this.btn_set_probe.Size = new System.Drawing.Size(75, 20);
            this.btn_set_probe.TabIndex = 14;
            this.btn_set_probe.Text = "Set ref";
            this.btn_set_probe.UseVisualStyleBackColor = true;
            this.btn_set_probe.Click += new System.EventHandler(this.btn_set_probe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_step_5);
            this.groupBox2.Controls.Add(this.btn_step_3);
            this.groupBox2.Controls.Add(this.btn_step_4);
            this.groupBox2.Controls.Add(this.btn_step_1);
            this.groupBox2.Controls.Add(this.btn_step_2);
            this.groupBox2.Location = new System.Drawing.Point(276, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 176);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step";
            // 
            // btn_step_5
            // 
            this.btn_step_5.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_step_5.Location = new System.Drawing.Point(13, 23);
            this.btn_step_5.Name = "btn_step_5";
            this.btn_step_5.Size = new System.Drawing.Size(75, 23);
            this.btn_step_5.TabIndex = 15;
            this.btn_step_5.Text = "50 mm";
            this.btn_step_5.UseVisualStyleBackColor = true;
            this.btn_step_5.Click += new System.EventHandler(this.btn_step_5_Click);
            // 
            // btn_step_3
            // 
            this.btn_step_3.BackColor = System.Drawing.SystemColors.Control;
            this.btn_step_3.Location = new System.Drawing.Point(13, 81);
            this.btn_step_3.Name = "btn_step_3";
            this.btn_step_3.Size = new System.Drawing.Size(75, 23);
            this.btn_step_3.TabIndex = 14;
            this.btn_step_3.Text = "5 mm";
            this.btn_step_3.UseVisualStyleBackColor = false;
            this.btn_step_3.Click += new System.EventHandler(this.btn_step_3_Click);
            // 
            // btn_step_4
            // 
            this.btn_step_4.Location = new System.Drawing.Point(13, 52);
            this.btn_step_4.Name = "btn_step_4";
            this.btn_step_4.Size = new System.Drawing.Size(75, 23);
            this.btn_step_4.TabIndex = 13;
            this.btn_step_4.Text = "10 mm";
            this.btn_step_4.UseVisualStyleBackColor = true;
            this.btn_step_4.Click += new System.EventHandler(this.btn_step4_Click);
            // 
            // btn_step_1
            // 
            this.btn_step_1.BackColor = System.Drawing.Color.Gray;
            this.btn_step_1.Location = new System.Drawing.Point(13, 139);
            this.btn_step_1.Name = "btn_step_1";
            this.btn_step_1.Size = new System.Drawing.Size(75, 23);
            this.btn_step_1.TabIndex = 12;
            this.btn_step_1.Text = "0.1 mm";
            this.btn_step_1.UseVisualStyleBackColor = false;
            this.btn_step_1.Click += new System.EventHandler(this.btn_step_1_Click);
            // 
            // btn_step_2
            // 
            this.btn_step_2.BackColor = System.Drawing.SystemColors.Control;
            this.btn_step_2.Location = new System.Drawing.Point(13, 110);
            this.btn_step_2.Name = "btn_step_2";
            this.btn_step_2.Size = new System.Drawing.Size(75, 23);
            this.btn_step_2.TabIndex = 11;
            this.btn_step_2.Text = "1 mm";
            this.btn_step_2.UseVisualStyleBackColor = false;
            this.btn_step_2.Click += new System.EventHandler(this.btn_step_2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_z_minus);
            this.groupBox3.Controls.Add(this.btn_z_plus);
            this.groupBox3.Controls.Add(this.btn_x_minus);
            this.groupBox3.Controls.Add(this.btn_x_plus);
            this.groupBox3.Controls.Add(this.btn_y_minus);
            this.groupBox3.Controls.Add(this.btn_y_plus);
            this.groupBox3.Location = new System.Drawing.Point(12, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 176);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jog";
            // 
            // btn_z_minus
            // 
            this.btn_z_minus.Location = new System.Drawing.Point(183, 96);
            this.btn_z_minus.Name = "btn_z_minus";
            this.btn_z_minus.Size = new System.Drawing.Size(41, 38);
            this.btn_z_minus.TabIndex = 12;
            this.btn_z_minus.Text = "-Z";
            this.btn_z_minus.UseVisualStyleBackColor = true;
            this.btn_z_minus.Click += new System.EventHandler(this.btn_z_minus_Click);
            // 
            // btn_z_plus
            // 
            this.btn_z_plus.Location = new System.Drawing.Point(183, 52);
            this.btn_z_plus.Name = "btn_z_plus";
            this.btn_z_plus.Size = new System.Drawing.Size(41, 38);
            this.btn_z_plus.TabIndex = 13;
            this.btn_z_plus.Text = "+Z";
            this.btn_z_plus.UseVisualStyleBackColor = true;
            this.btn_z_plus.Click += new System.EventHandler(this.btn_z_plus_Click);
            // 
            // btn_x_minus
            // 
            this.btn_x_minus.Location = new System.Drawing.Point(21, 73);
            this.btn_x_minus.Name = "btn_x_minus";
            this.btn_x_minus.Size = new System.Drawing.Size(41, 38);
            this.btn_x_minus.TabIndex = 14;
            this.btn_x_minus.Text = "-X";
            this.btn_x_minus.UseVisualStyleBackColor = true;
            this.btn_x_minus.Click += new System.EventHandler(this.btn_x_minus_Click);
            // 
            // btn_x_plus
            // 
            this.btn_x_plus.Location = new System.Drawing.Point(115, 73);
            this.btn_x_plus.Name = "btn_x_plus";
            this.btn_x_plus.Size = new System.Drawing.Size(41, 38);
            this.btn_x_plus.TabIndex = 15;
            this.btn_x_plus.Text = "+X";
            this.btn_x_plus.UseVisualStyleBackColor = true;
            this.btn_x_plus.Click += new System.EventHandler(this.btn_x_plus_Click);
            // 
            // btn_y_minus
            // 
            this.btn_y_minus.Location = new System.Drawing.Point(68, 115);
            this.btn_y_minus.Name = "btn_y_minus";
            this.btn_y_minus.Size = new System.Drawing.Size(41, 38);
            this.btn_y_minus.TabIndex = 16;
            this.btn_y_minus.Text = "-Y";
            this.btn_y_minus.UseVisualStyleBackColor = true;
            this.btn_y_minus.Click += new System.EventHandler(this.btn_y_minus_Click);
            // 
            // btn_y_plus
            // 
            this.btn_y_plus.Location = new System.Drawing.Point(68, 29);
            this.btn_y_plus.Name = "btn_y_plus";
            this.btn_y_plus.Size = new System.Drawing.Size(41, 38);
            this.btn_y_plus.TabIndex = 17;
            this.btn_y_plus.Text = "+Y";
            this.btn_y_plus.UseVisualStyleBackColor = true;
            this.btn_y_plus.Click += new System.EventHandler(this.btn_y_plus_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(12, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 75);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spindle";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(15, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "ON";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(62, 26);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(273, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(12, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 120);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "G Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Z";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Y";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(272, 81);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 11;
            this.button12.Text = "Send";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(21, 83);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(245, 20);
            this.textBox7.TabIndex = 10;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(272, 55);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 9;
            this.button11.Text = "Set position";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(214, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(140, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(66, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(52, 20);
            this.textBox6.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "G92";
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(272, 28);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 4;
            this.button10.Text = "Move";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(214, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(140, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(66, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Z";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "G1";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 476);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 18;
            this.button13.Text = "Test";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(this.btn_test);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "mm";
            // 
            // CncControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CncControl";
            this.Size = new System.Drawing.Size(451, 511);
            this.Load += new System.EventHandler(this.CoolControl_Load);
            this.VisibleChanged += new System.EventHandler(this.vc);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProbeMeasurment;
        private System.Windows.Forms.Button btn_probe_read;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_step_4;
        private System.Windows.Forms.Button btn_step_1;
        private System.Windows.Forms.Button btn_step_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_z_minus;
        private System.Windows.Forms.Button btn_z_plus;
        private System.Windows.Forms.Button btn_x_minus;
        private System.Windows.Forms.Button btn_x_plus;
        private System.Windows.Forms.Button btn_y_minus;
        private System.Windows.Forms.Button btn_y_plus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_step_3;
        private System.Windows.Forms.Button btn_set_probe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_step_5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label1;
    }
}

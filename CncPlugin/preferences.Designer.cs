namespace CncPlugin
{
    partial class preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preferences));
            this.txt_step_5 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_unit_inch = new System.Windows.Forms.RadioButton();
            this.rb_unit_mm = new System.Windows.Forms.RadioButton();
            this.txt_step_4 = new System.Windows.Forms.TextBox();
            this.txt_step_3 = new System.Windows.Forms.TextBox();
            this.step_size = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_step_2 = new System.Windows.Forms.TextBox();
            this.txt_step_1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_jog_y_plus = new System.Windows.Forms.TextBox();
            this.txt_jog_x_minus = new System.Windows.Forms.TextBox();
            this.txt_jog_x_plus = new System.Windows.Forms.TextBox();
            this.txt_jog_y_minus = new System.Windows.Forms.TextBox();
            this.txt_jog_z_minus = new System.Windows.Forms.TextBox();
            this.txt_jog_z_plus = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_spindle_start = new System.Windows.Forms.TextBox();
            this.txt_spindle_stop = new System.Windows.Forms.TextBox();
            this.txt_spindle_pwm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.step_size.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_step_5
            // 
            this.txt_step_5.Location = new System.Drawing.Point(20, 144);
            this.txt_step_5.Name = "txt_step_5";
            this.txt_step_5.Size = new System.Drawing.Size(43, 20);
            this.txt_step_5.TabIndex = 1;
            this.txt_step_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_unit_inch);
            this.groupBox1.Controls.Add(this.rb_unit_mm);
            this.groupBox1.Location = new System.Drawing.Point(305, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // rb_unit_inch
            // 
            this.rb_unit_inch.AutoSize = true;
            this.rb_unit_inch.Location = new System.Drawing.Point(15, 48);
            this.rb_unit_inch.Name = "rb_unit_inch";
            this.rb_unit_inch.Size = new System.Drawing.Size(45, 17);
            this.rb_unit_inch.TabIndex = 8;
            this.rb_unit_inch.Text = "inch";
            this.rb_unit_inch.UseVisualStyleBackColor = true;
            // 
            // rb_unit_mm
            // 
            this.rb_unit_mm.AutoSize = true;
            this.rb_unit_mm.Checked = true;
            this.rb_unit_mm.Location = new System.Drawing.Point(15, 25);
            this.rb_unit_mm.Name = "rb_unit_mm";
            this.rb_unit_mm.Size = new System.Drawing.Size(41, 17);
            this.rb_unit_mm.TabIndex = 7;
            this.rb_unit_mm.TabStop = true;
            this.rb_unit_mm.Text = "mm";
            this.rb_unit_mm.UseVisualStyleBackColor = true;
            // 
            // txt_step_4
            // 
            this.txt_step_4.Location = new System.Drawing.Point(20, 113);
            this.txt_step_4.Name = "txt_step_4";
            this.txt_step_4.Size = new System.Drawing.Size(43, 20);
            this.txt_step_4.TabIndex = 9;
            this.txt_step_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_step_3
            // 
            this.txt_step_3.Location = new System.Drawing.Point(20, 82);
            this.txt_step_3.Name = "txt_step_3";
            this.txt_step_3.Size = new System.Drawing.Size(43, 20);
            this.txt_step_3.TabIndex = 10;
            this.txt_step_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // step_size
            // 
            this.step_size.Controls.Add(this.txt_step_1);
            this.step_size.Controls.Add(this.txt_step_2);
            this.step_size.Controls.Add(this.txt_step_3);
            this.step_size.Controls.Add(this.txt_step_5);
            this.step_size.Controls.Add(this.txt_step_4);
            this.step_size.Location = new System.Drawing.Point(303, 12);
            this.step_size.Name = "step_size";
            this.step_size.Size = new System.Drawing.Size(89, 177);
            this.step_size.TabIndex = 11;
            this.step_size.TabStop = false;
            this.step_size.Text = "Step size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_jog_z_plus);
            this.groupBox3.Controls.Add(this.txt_jog_z_minus);
            this.groupBox3.Controls.Add(this.txt_jog_y_minus);
            this.groupBox3.Controls.Add(this.txt_jog_x_plus);
            this.groupBox3.Controls.Add(this.txt_jog_x_minus);
            this.groupBox3.Controls.Add(this.txt_jog_y_plus);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 211);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keyboard short cuts";
            // 
            // txt_step_2
            // 
            this.txt_step_2.Location = new System.Drawing.Point(20, 54);
            this.txt_step_2.Name = "txt_step_2";
            this.txt_step_2.Size = new System.Drawing.Size(43, 20);
            this.txt_step_2.TabIndex = 11;
            // 
            // txt_step_1
            // 
            this.txt_step_1.Location = new System.Drawing.Point(20, 23);
            this.txt_step_1.Name = "txt_step_1";
            this.txt_step_1.Size = new System.Drawing.Size(43, 20);
            this.txt_step_1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 183);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txt_jog_y_plus
            // 
            this.txt_jog_y_plus.Location = new System.Drawing.Point(87, 69);
            this.txt_jog_y_plus.Name = "txt_jog_y_plus";
            this.txt_jog_y_plus.Size = new System.Drawing.Size(38, 20);
            this.txt_jog_y_plus.TabIndex = 20;
            // 
            // txt_jog_x_minus
            // 
            this.txt_jog_x_minus.Location = new System.Drawing.Point(42, 109);
            this.txt_jog_x_minus.Name = "txt_jog_x_minus";
            this.txt_jog_x_minus.Size = new System.Drawing.Size(38, 20);
            this.txt_jog_x_minus.TabIndex = 20;
            // 
            // txt_jog_x_plus
            // 
            this.txt_jog_x_plus.Location = new System.Drawing.Point(128, 109);
            this.txt_jog_x_plus.Name = "txt_jog_x_plus";
            this.txt_jog_x_plus.Size = new System.Drawing.Size(38, 20);
            this.txt_jog_x_plus.TabIndex = 20;
            // 
            // txt_jog_y_minus
            // 
            this.txt_jog_y_minus.Location = new System.Drawing.Point(87, 153);
            this.txt_jog_y_minus.Name = "txt_jog_y_minus";
            this.txt_jog_y_minus.Size = new System.Drawing.Size(38, 20);
            this.txt_jog_y_minus.TabIndex = 20;
            // 
            // txt_jog_z_minus
            // 
            this.txt_jog_z_minus.Location = new System.Drawing.Point(207, 142);
            this.txt_jog_z_minus.Name = "txt_jog_z_minus";
            this.txt_jog_z_minus.Size = new System.Drawing.Size(38, 20);
            this.txt_jog_z_minus.TabIndex = 20;
            // 
            // txt_jog_z_plus
            // 
            this.txt_jog_z_plus.Location = new System.Drawing.Point(207, 78);
            this.txt_jog_z_plus.Name = "txt_jog_z_plus";
            this.txt_jog_z_plus.Size = new System.Drawing.Size(38, 20);
            this.txt_jog_z_plus.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_spindle_pwm);
            this.groupBox2.Controls.Add(this.txt_spindle_stop);
            this.groupBox2.Controls.Add(this.txt_spindle_start);
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 102);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sprindle";
            // 
            // txt_spindle_start
            // 
            this.txt_spindle_start.Location = new System.Drawing.Point(51, 20);
            this.txt_spindle_start.Name = "txt_spindle_start";
            this.txt_spindle_start.Size = new System.Drawing.Size(100, 20);
            this.txt_spindle_start.TabIndex = 0;
            // 
            // txt_spindle_stop
            // 
            this.txt_spindle_stop.Location = new System.Drawing.Point(51, 46);
            this.txt_spindle_stop.Name = "txt_spindle_stop";
            this.txt_spindle_stop.Size = new System.Drawing.Size(100, 20);
            this.txt_spindle_stop.TabIndex = 0;
            // 
            // txt_spindle_pwm
            // 
            this.txt_spindle_pwm.Location = new System.Drawing.Point(51, 72);
            this.txt_spindle_pwm.Name = "txt_spindle_pwm";
            this.txt_spindle_pwm.Size = new System.Drawing.Size(100, 20);
            this.txt_spindle_pwm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(6, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "scan codes http://msdn.microsoft.com/en-us/library/aa243025(v=vs.60).aspx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "PWM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.SkyBlue;
            this.label13.Location = new System.Drawing.Point(179, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "%p = PWM";
            // 
            // preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.step_size);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "preferences";
            this.Text = "preferences";
            this.Load += new System.EventHandler(this.preferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.step_size.ResumeLayout(false);
            this.step_size.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_step_5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_unit_inch;
        private System.Windows.Forms.RadioButton rb_unit_mm;
        private System.Windows.Forms.TextBox txt_step_4;
        private System.Windows.Forms.TextBox txt_step_3;
        private System.Windows.Forms.GroupBox step_size;
        private System.Windows.Forms.TextBox txt_step_1;
        private System.Windows.Forms.TextBox txt_step_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_jog_z_plus;
        private System.Windows.Forms.TextBox txt_jog_z_minus;
        private System.Windows.Forms.TextBox txt_jog_y_minus;
        private System.Windows.Forms.TextBox txt_jog_x_plus;
        private System.Windows.Forms.TextBox txt_jog_x_minus;
        private System.Windows.Forms.TextBox txt_jog_y_plus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_spindle_pwm;
        private System.Windows.Forms.TextBox txt_spindle_stop;
        private System.Windows.Forms.TextBox txt_spindle_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
    }
}
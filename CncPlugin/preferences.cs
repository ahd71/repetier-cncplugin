using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;

/* TODO

 * 0.1mm round error
 * use the pref values in the other dialog
 * dropdown with key friendly names
  
  */

namespace CncPlugin
{
    public partial class preferences : Form
    {
        private IHost host;
        private IRegMemoryFolder reg;

        public preferences(IHost h)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            host = h;
            reg = host.GetRegistryFolder("CncPlugin");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferences_Load(object sender, EventArgs e)
        {
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            txt_jog_x_minus.Text = reg.GetDouble("jog_x_minus", 37).ToString();
            txt_jog_x_plus.Text = reg.GetDouble("jog_x_plus", 39).ToString();
            txt_jog_y_minus.Text = reg.GetDouble("jog_y_minus", 38).ToString();
            txt_jog_y_plus.Text = reg.GetDouble("jog_y_plus", 40).ToString();
            txt_jog_z_minus.Text = reg.GetDouble("jog_z_minus", 34).ToString();
            txt_jog_z_plus.Text = reg.GetDouble("jog_z_plus", 33).ToString();

            txt_step_1.Text = (reg.GetDouble("jog_step_1", 50000) / 1000).ToString();  // unit is micrometer to simplify storage
            txt_step_2.Text = (reg.GetDouble("jog_step_2", 10000) / 1000).ToString();
            txt_step_3.Text = (reg.GetDouble("jog_step_3", 5000) / 1000).ToString();
            txt_step_4.Text = (reg.GetDouble("jog_step_4", 1000) / 1000).ToString();
            txt_step_5.Text = (reg.GetDouble("jog_step_5", 100) / 1000).ToString();

            txt_spindle_start.Text = reg.GetString("spindle_start", "M106 %p");
            txt_spindle_stop.Text = reg.GetString("spindle_stop", "M107");
            txt_spindle_pwm.Text = reg.GetString("spindle_pwm", "M106 %p");

            if (reg.GetString("jog_unit", "mm") == "inch") { rb_unit_inch.Checked = true; } else { rb_unit_mm.Checked = true; }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePreferences();
            this.Close();
        }

        private void SavePreferences()
        {
            reg.SetDouble("jog_x_minus", double.Parse(txt_jog_x_minus.Text));
            reg.SetDouble("jog_x_plus", double.Parse(txt_jog_x_plus.Text));
            reg.SetDouble("jog_y_minus", double.Parse(txt_jog_y_minus.Text));
            reg.SetDouble("jog_y_plus", double.Parse(txt_jog_y_plus.Text));
            reg.SetDouble("jog_z_minus", double.Parse(txt_jog_z_minus.Text));
            reg.SetDouble("jog_z_plus", double.Parse(txt_jog_z_plus.Text));

            reg.SetDouble("jog_step_1", (double)(float.Parse(txt_step_1.Text) * 1000));
            reg.SetDouble("jog_step_2", (double)(float.Parse(txt_step_2.Text) * 1000));
            reg.SetDouble("jog_step_3", (double)(float.Parse(txt_step_3.Text) * 1000));
            reg.SetDouble("jog_step_4", (double)(float.Parse(txt_step_4.Text) * 1000));
            reg.SetDouble("jog_step_5", (double)(float.Parse(txt_step_5.Text) * 1000));

            reg.SetString("spindle_start", txt_spindle_start.Text);
            reg.SetString("spindle_stop", txt_spindle_stop.Text);
            reg.SetString("spindle_pwm", txt_spindle_pwm.Text);

            if (rb_unit_inch.Checked == true) { reg.SetString("jog_unit", "inch"); } else { reg.SetString("jog_unit", "mm"); }

            host.LogMessage("CncPlugin preferences saved");
        }

        private void OnlyNumericalData(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) e.Handled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepetierHostExtender.interfaces;

namespace CncPlugin
{
    public class PluginPreferences
    {
        private IHost host;

        public int jog_key_x_minus;
        public int jog_key_x_plus;
        public int jog_key_y_minus;
        public int jog_key_y_plus;
        public int jog_key_z_minus;
        public int jog_key_z_plus;

        public int step_key_1;
        public int step_key_2;
        public int step_key_3;
        public int step_key_4;

        public int stop_key;

        public double jog_step_1;
        public double jog_step_2;
        public double jog_step_3;
        public double jog_step_4;

        public string spindle_start;
        public string spindle_stop;
        public string spindle_pwm;

        public string jog_unit;

        public bool globalkeys;


        public PluginPreferences(IHost h)
        {
            host = h;
            loadDefaults();
        }

        public void loadDefaults()
        {
            IRegMemoryFolder reg = host.GetRegistryFolder("CncPlugin");

            jog_key_x_minus = reg.GetInt("jog_x_minus", 37); // LEFT
            jog_key_x_plus = reg.GetInt("jog_x_plus", 39); // RIGHT
            jog_key_y_minus = reg.GetInt("jog_y_minus", 40); // DOWN
            jog_key_y_plus = reg.GetInt("jog_y_plus", 38); // UP
            jog_key_z_minus = reg.GetInt("jog_z_minus", 34); // PGDN
            jog_key_z_plus = reg.GetInt("jog_z_plus", 33); // PGUP

            jog_step_1 = reg.GetDouble("jog_step_1", 50);
            jog_step_2 = reg.GetDouble("jog_step_2", 10);
            jog_step_3 = reg.GetDouble("jog_step_3", 1);
            jog_step_4 = reg.GetDouble("jog_step_4", 0.1);

            step_key_1 = reg.GetInt("step_key_1", 120); // F9
            step_key_2 = reg.GetInt("step_key_2", 121); // F10
            step_key_3 = reg.GetInt("step_key_3", 122); // F11
            step_key_4 = reg.GetInt("step_key_4", 123); // F12

            stop_key = reg.GetInt("stop_key", 36); // HOME

            spindle_start = reg.GetString("spindle_start", "M106 S%p");
            spindle_stop = reg.GetString("spindle_stop", "M107");
            spindle_pwm = reg.GetString("spindle_pwm", "M106 S%p");

            jog_unit = reg.GetString("jog_unit", "mm");
            globalkeys = reg.GetBool("globalkeys", false);

        }


        public void save()
        {

            IRegMemoryFolder reg = host.GetRegistryFolder("CncPlugin");

            reg.SetInt("jog_x_minus", jog_key_x_minus);
            reg.SetInt("jog_x_plus", jog_key_x_plus);
            reg.SetInt("jog_y_minus", jog_key_y_minus);
            reg.SetInt("jog_y_plus", jog_key_y_plus);
            reg.SetInt("jog_z_minus", jog_key_z_minus);
            reg.SetInt("jog_z_plus", jog_key_z_plus);

            reg.SetDouble("jog_step_1", jog_step_1);
            reg.SetDouble("jog_step_2", jog_step_2);
            reg.SetDouble("jog_step_3", jog_step_3);
            reg.SetDouble("jog_step_4", jog_step_4);

            reg.SetInt("step_key_1", step_key_1);
            reg.SetInt("step_key_2", step_key_2);
            reg.SetInt("step_key_3", step_key_3);
            reg.SetInt("step_key_4", step_key_4);

            reg.SetInt("stop_key", stop_key);

            
            reg.SetString("spindle_start", spindle_start);
            reg.SetString("spindle_stop", spindle_stop);
            reg.SetString("spindle_pwm", spindle_pwm);

            reg.SetString("jog_unit", jog_unit);
            
            reg.SetBool("globalkeys", globalkeys);

        }
    }
}

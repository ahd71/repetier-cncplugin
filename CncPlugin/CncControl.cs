using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;

namespace CncPlugin
{
    public partial class CncControl : UserControl, IHostComponent
    {
        private IHost host;

        private float step_size = 10;

        private float minstep = 0.1F;
        private float maxstep = 50;

        void SetStep(float step)
        {
            step_size = step;

            Color c1 = Control.DefaultBackColor;
            Color c2 = Color.Gray;
            Color c3 = Color.White;
            Color c4 = Color.Black;

            if (step_size > maxstep) step_size = maxstep;
            if (step_size < minstep) step_size = minstep;

            btn_step_1.BackColor = c1;
            btn_step_2.BackColor = c1;
            btn_step_3.BackColor = c1;
            btn_step_4.BackColor = c1;
            btn_step_5.BackColor = c1;

            btn_step_1.ForeColor = c4;
            btn_step_2.ForeColor = c4;
            btn_step_3.ForeColor = c4;
            btn_step_4.ForeColor = c4;
            btn_step_5.ForeColor = c4;

            if (step_size==0.1F)
            {
                btn_step_1.BackColor = c2;
                btn_step_1.ForeColor = c3;
            }
            if (step_size == 1)
            {
                btn_step_2.BackColor = c2;
                btn_step_2.ForeColor = c3;
            }
            if (step_size == 5)
            {
                btn_step_3.BackColor = c2;
                btn_step_3.ForeColor = c3;
            }
            if (step_size == 10)
            {
                btn_step_4.BackColor = c2;
                btn_step_4.ForeColor = c3;
            }
            if (step_size == 50)
            {
                btn_step_5.BackColor = c2;
                btn_step_5.ForeColor = c3;
            }
        }


        public CncControl()
        {
            InitializeComponent();
            SetStep(5);
        }


        /// <summary>
        /// Store reference to host for later use
        /// </summary>
        /// <param name="_host">Host instance</param>
        public void Connect(IHost _host)
        {
            host = _host;

        }
        #region IHostComponent implementation

        // Name inside component repository
        public string ComponentName { get { return "CNC"; } }
        // Name for tab
        public string ComponentDescription { get { return "CNC"; } }
        // Used for positioning.
        public int ComponentOrder { get { return 8000; } }
        // Where to add it. We want it on the right tab.
        public PreferredComponentPositions PreferredPosition { get { return PreferredComponentPositions.SIDEBAR; } }
        // Return the UserControl.
        public Control ComponentControl { get { return this; } }

        #endregion

        #region Button functions

        void Jog(string axis, float step)
        {

            String data = "G1 " + axis + step.ToString();
                
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand(data);
                host.Connection.injectManualCommand("G90");
            }

        }


        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Left))
            {
                Jog("X", -step_size);
                flash(btn_x_minus);
                return true;
            }

            if (keyData == (Keys.Right))
            {
                Jog("X", +step_size);
                 flash(btn_x_plus);
                return true;
            }

            if (keyData == (Keys.Down))
            {
                Jog("Y", -step_size);
                flash(btn_y_minus);
                return true;
            }

            if (keyData == (Keys.Up))
            {
                Jog("Y", +step_size);
                flash(btn_y_plus);
                return true;
            }


            if (keyData == (Keys.Divide))
            {
                SetStep(10);
                flash(btn_step_4);
                return true;
            }

            if (keyData == (Keys.Multiply))
            {
                SetStep(1);
                flash(btn_step_2);
                return true;
            }

            if (keyData == (Keys.Subtract))
            {
                SetStep(0.1F);
                flash(btn_step_1);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CoolControl_Load(object sender, EventArgs e)
        {
        }

        private void btn_probe(object sender, EventArgs e)
        {
            txtProbeMeasurment.Text = "";
            host.Connection.injectManualCommand("G30");

        }
        private void btn_probe_read_Click(object sender, System.EventArgs e)
        {
            host.Connection.injectManualCommand("G31");
        }

        private void vc(object sender, EventArgs e)
        {
            // every time the tab is selected
            btn_step_3.Select(); // select any element to start the ProcessCmdKey event
        }

        private void btn_step_5_Click(object sender, EventArgs e)
        {
            SetStep(50);
        }
        private void btn_step4_Click(object sender, EventArgs e)
        {
            SetStep(10);
        }

        private void btn_step_3_Click(object sender, EventArgs e)
        {
            SetStep(5);
        }

        private void btn_step_2_Click(object sender, EventArgs e)
        {
            SetStep(1);
        }

        private void btn_step_1_Click(object sender, EventArgs e)
        {
            SetStep(0.1F);
        }

        private void btn_y_plus_Click(object sender, EventArgs e)
        {
            Jog("Y", step_size);
        }

        private void btn_y_minus_Click(object sender, EventArgs e)
        {
            Jog("Y", -step_size);
        }

        private void btn_x_minus_Click(object sender, EventArgs e)
        {
            Jog("X", -step_size);
        }

        private void btn_x_plus_Click(object sender, EventArgs e)
        {
            Jog("X", +step_size);
        }

        private void btn_z_plus_Click(object sender, EventArgs e)
        {
            Jog("Z", +step_size);
        }

        private void btn_z_minus_Click(object sender, EventArgs e)
        {
            Jog("Z", -step_size);
        }

        public void setproberesult(string probe_measurement){
            txtProbeMeasurment.Text = probe_measurement;
        }

        private void btn_set_probe_Click(object sender, EventArgs e)
        {
            host.Connection.injectManualCommand("G92 Z" + txtProbeMeasurment.Text);
        }

        private void flash(System.Windows.Forms.Button b){
            Color previous_color = b.BackColor;
            b.BackColor = Color.Black;
            b.Refresh();
            System.Threading.Thread.Sleep(50);
            b.BackColor = previous_color;
            b.Refresh();
        }

        private void btn_test(object sender, EventArgs e)
        {
            host.Connection.open();
        }
    }
}

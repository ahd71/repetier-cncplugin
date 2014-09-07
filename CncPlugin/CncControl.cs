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

        const string release = "CncPlugin - v0.14 - (c) Hellstrand 2014-04-09";

        private double step_size;

        Boolean spindle_on = false;

        PluginPreferences pref;

        Hotkey hk1;
        Hotkey hk2;
        Hotkey hk3;
        Hotkey hk4;
        Hotkey hk5;
        Hotkey hk6;
        Hotkey hk7;
        Hotkey hk8;
        Hotkey hk9;
        Hotkey hk10;

        void SetStep(int step)
        {

            Color c2 = Color.Gray;
            Color c3 = Color.White;

            ResetStepButtonColor();

            switch (step)
            {
                case 1:
                    btn_step_1.BackColor = c2;
                    btn_step_1.ForeColor = c3;
                    step_size = pref.jog_step_1;
                    break;
                case 2:
                    btn_step_2.BackColor = c2;
                    btn_step_2.ForeColor = c3;
                    step_size = pref.jog_step_2;
                    break;
                case 3:
                    btn_step_3.BackColor = c2;
                    btn_step_3.ForeColor = c3;
                    step_size = pref.jog_step_3;
                    break;
                case 4:
                    btn_step_4.BackColor = c2;
                    btn_step_4.ForeColor = c3;
                    step_size = pref.jog_step_4;
                    break;
            }

            host.LogInfo("CncPlugin: Change step size to " + step_size.ToString() + " " + pref.jog_unit);

        }

        private void ResetStepButtonColor()
        {
            Color c1 = Control.DefaultBackColor;
            Color c4 = Color.Black;

            btn_step_1.BackColor = c1;
            btn_step_2.BackColor = c1;
            btn_step_3.BackColor = c1;
            btn_step_4.BackColor = c1;

            btn_step_1.ForeColor = c4;
            btn_step_2.ForeColor = c4;
            btn_step_3.ForeColor = c4;
            btn_step_4.ForeColor = c4;
        }


        public CncControl()
        {
            InitializeComponent();
            enableUI(false);
            lblReleaseMessage.Text = release;

        }


        public void Connect(IHost _host)
        {
            host = _host;
            host.Connection.eventConnectionChange += MyeventConnectionChange;
            host.Connection.eventResponse += Connection_eventResponse;
            ToggleConnection(host.Connection.connector.IsConnected());
            pref = new PluginPreferences(host);
            refreshPref();
        }

        private void UnRegisterAllHotkeys()
        {
            if (hk1 != null && hk1.Registered) hk1.Unregister();
            if (hk2 != null && hk2.Registered) hk2.Unregister();
            if (hk3 != null && hk3.Registered) hk3.Unregister();
            if (hk4 != null && hk4.Registered) hk4.Unregister();
            if (hk5 != null && hk5.Registered) hk5.Unregister();
            if (hk6 != null && hk6.Registered) hk6.Unregister();
            if (hk7 != null && hk7.Registered) hk7.Unregister();
            if (hk8 != null && hk8.Registered) hk8.Unregister();
            if (hk9 != null && hk9.Registered) hk9.Unregister();
            if (hk10 != null && hk10.Registered) hk10.Unregister();
        }

        private void RegisterAllHotkeys()
        {
            hk1 = RegisterOneKey((Keys)pref.jog_key_x_minus);
            hk2 = RegisterOneKey((Keys)pref.jog_key_x_plus);
            hk3 = RegisterOneKey((Keys)pref.jog_key_y_minus);
            hk4 = RegisterOneKey((Keys)pref.jog_key_y_plus);
            hk5 = RegisterOneKey((Keys)pref.jog_key_z_minus);
            hk6 = RegisterOneKey((Keys)pref.jog_key_z_plus);
            hk7 = RegisterOneKey((Keys)pref.step_key_1);
            hk8 = RegisterOneKey((Keys)pref.step_key_2);
            hk9 = RegisterOneKey((Keys)pref.step_key_3);
            hk10 = RegisterOneKey((Keys)pref.step_key_4);
        }

        private Hotkey RegisterOneKey(Keys k)
        {
            Hotkey hk = new Hotkey();
            hk.KeyCode = k;
            hk.Pressed += myglobal;
            hk.Register(this);
            return hk;
        }

        private void myglobal(object sender, HandledEventArgs e)
        {
            Message msg = new Message();
            ProcessCmdKey(ref msg, ((Hotkey)sender).KeyCode);
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

		// Handle the new interface functions in repetier host 1.0.3
		public Control ComponentControl { get { return this; } }
	    public ThreeDView Associated3DView { get { return null; } }
        
		#endregion

        #region Button functions

        void Jog(string axis, double step)
        {

            String data = "G1 " + axis + step.ToString().Replace(',', '.');
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

            if (host.Connection.connector.IsConnected())
            {

                if ((int)keyData == (pref.jog_key_x_minus))
                {
                    Jog("X", -step_size);
                    flash_button_when_keypressed(btn_x_minus);
                    return true;
                }

                if ((int)keyData == (pref.jog_key_x_plus))
                {
                    Jog("X", +step_size);
                    flash_button_when_keypressed(btn_x_plus);
                    return true;
                }

                if ((int)keyData == (pref.jog_key_y_minus))
                {
                    Jog("Y", -step_size);
                    flash_button_when_keypressed(btn_y_minus);
                    return true;
                }

                if ((int)keyData == (pref.jog_key_y_plus))
                {
                    Jog("Y", +step_size);
                    flash_button_when_keypressed(btn_y_plus);
                    return true;
                }


                if ((int)keyData == (pref.jog_key_z_minus))
                {
                    Jog("Z", -step_size);
                    flash_button_when_keypressed(btn_z_minus);
                    return true;
                }


                if ((int)keyData == (pref.jog_key_z_plus))
                {
                    Jog("Z", +step_size);
                    flash_button_when_keypressed(btn_z_plus);
                    return true;
                }


                if ((int)keyData == pref.step_key_1)
                {
                    SetStep(1);
                    flash_button_when_keypressed(btn_step_1);
                    return true;
                }

                if ((int)keyData == pref.step_key_2)
                {
                    SetStep(2);
                    flash_button_when_keypressed(btn_step_2);
                    return true;
                }

                if ((int)keyData == pref.step_key_3)
                {
                    SetStep(3);
                    flash_button_when_keypressed(btn_step_3);
                    return true;
                }

                if ((int)keyData == pref.step_key_4)
                {
                    SetStep(4);
                    flash_button_when_keypressed(btn_step_4);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CoolControl_Load(object sender, EventArgs e)
        {
            //host.LogInfo("SUB: CoolControl_Load");
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

        private void VisibleChange(object sender, EventArgs e)
        {
            // every time the tab is selected
            btn_step_3.Select(); // select any element to start the ProcessCmdKey event
        }

        ////////////////////////////////////////////////////////////

        private void btn_step_1_Click(object sender, EventArgs e)
        {
            SetStep(1);
        }

        private void btn_step_2_Click(object sender, EventArgs e)
        {
            SetStep(2);
        }

        private void btn_step_3_Click(object sender, EventArgs e)
        {
            SetStep(3);
        }

        private void btn_step4_Click(object sender, EventArgs e)
        {
            SetStep(4);
        }

        ////////////////////////////////////////////////////////////

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

        ////////////////////////////////////////////////////////////

        private void btn_set_probe_Click(object sender, EventArgs e)
        {
            host.Connection.injectManualCommand("G92 Z" + txtProbeMeasurment.Text);
        }

        private void flash_button_when_keypressed(System.Windows.Forms.Button b)
        {
            Color previous_color = b.BackColor;
            b.BackColor = Color.Black;
            b.Refresh();
            System.Threading.Thread.Sleep(50);
            b.BackColor = previous_color;
            b.Refresh();
        }

        void enableUI(Boolean state)
        {
            groupBox1.Enabled = state;
            groupBox2.Enabled = state;
            groupBox3.Enabled = state;
            groupBox4.Enabled = state;
            groupBox5.Enabled = state;

            label2.Visible = state;
            label3.Visible = state;
            label10.Visible = state;
            label11.Visible = state;
            label12.Visible = state;

            btn_spindle.BackColor = Color.LightGray;
            btn_spindle.Text = "";

            lblPosX.Visible = state;
            lblPosY.Visible = state;
            lblPosZ.Visible = state;
        }

        void ToggleConnection(Boolean state)
        {
            lnkConnectDisconnect.Enabled = true;
            if (state)
            {
                if (!host.IsMono) { RegisterAllHotkeys(); }
                enableUI(true);
                SetStep(3);
                UpdateSpindleUI();
                lnkConnectDisconnect.Text = "Disconnect";
            }
            else
            {
                if (!host.IsMono) { UnRegisterAllHotkeys(); }
                ResetStepButtonColor();
                enableUI(false);
                lnkConnectDisconnect.Text = "Connect";
            }
        }

        private void MyeventConnectionChange(string msg)
        {
            ToggleConnection(host.Connection.connector.IsConnected());
        }

        private void btnSendG1(object sender, EventArgs e)
        {
            String data = "G1";

            if (txt_g0_x.Text.Trim() != "") { data += " X" + txt_g0_x.Text.Trim(); }
            if (txt_g0_y.Text.Trim() != "") { data += " Y" + txt_g0_y.Text.Trim(); }
            if (txt_g0_z.Text.Trim() != "") { data += " Z" + txt_g0_z.Text.Trim(); }

            host.Connection.injectManualCommand(data);
        }

        private void btnSendG92(object sender, EventArgs e)
        {
            String data = "G92";

            if (txt_g92_x.Text.Trim() != "") { data += " X" + txt_g92_x.Text.Trim(); }
            if (txt_g92_y.Text.Trim() != "") { data += " Y" + txt_g92_y.Text.Trim(); }
            if (txt_g92_z.Text.Trim() != "") { data += " Z" + txt_g92_z.Text.Trim(); }

            host.Connection.injectManualCommand(data);
        }

        private void SendManualCommand()
        {
            host.Connection.injectManualCommand(txt_manual_command.Text.Trim());
        }

        private void btnSendManual(object sender, EventArgs e)
        {
            SendManualCommand();
        }

        private void Command_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendManualCommand();
                txt_manual_command.Text = "";
                e.Handled = true;
                flash_button_when_keypressed(btn_send_manual_command);
            }
        }

        private void spindle_speed_change(object sender, EventArgs e)
        {
            if (spindle_on) { host.Connection.injectManualCommand(pref.spindle_pwm.Replace("%p", slide_spindlespeed.Value.ToString())); }
        }

        private void btn_spindle_click(object sender, EventArgs e)
        {
            spindle_on = !spindle_on;

            UpdateSpindleUI();
        }

        private void UpdateSpindleUI()
        {
            if (spindle_on)
            {
                host.Connection.injectManualCommand(pref.spindle_pwm.Replace("%p", slide_spindlespeed.Value.ToString()));
                btn_spindle.BackColor = Color.Red;
                btn_spindle.Text = "STOP";
            }
            else
            {
                host.Connection.injectManualCommand(pref.spindle_stop);
                btn_spindle.BackColor = Color.Green;
                btn_spindle.Text = "START";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkConnectDisconnect.Enabled = false;

            if (host.Connection.connector.IsConnected())
            {
                host.Connection.close();
            }
            else
            {
                host.Connection.open();
            }

        }

        private void lnkPreferences_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new preferences(host, pref, this);
            f.Show();
        }

        public void refreshPref()
        {
            pref.loadDefaults();
            btn_step_1.Text = pref.jog_step_1.ToString() + " " + pref.jog_unit;
            btn_step_2.Text = pref.jog_step_2.ToString() + " " + pref.jog_unit;
            btn_step_3.Text = pref.jog_step_3.ToString() + " " + pref.jog_unit;
            btn_step_4.Text = pref.jog_step_4.ToString() + " " + pref.jog_unit;

            if (!host.IsMono)
            {
                UnRegisterAllHotkeys();
                if (pref.globalkeys)
                {
                    if (host.Connection.connector.IsConnected()) { RegisterAllHotkeys(); }
                }
            }
        }


        private void Connection_eventResponse(string response, ref RepetierHostExtender.basic.LogLevel level)
        {
            // update position from analyzer

            lblPosX.Text = host.Connection.Analyzer.x.ToString();
            lblPosY.Text = host.Connection.Analyzer.y.ToString();
            lblPosZ.Text = host.Connection.Analyzer.z.ToString();

            string h = host.Connection.extract(response, "Z-probe:");
            if (h != null)
            {
                txtProbeMeasurment.Text = h;
            }

        }

    }
}

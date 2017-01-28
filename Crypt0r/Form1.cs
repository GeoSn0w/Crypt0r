using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypt0r
{
    public partial class EBP : Form
    {
        public EBP()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void button1_Click(object sender, EventArgs e)
        {
            lng.Visible = true;
            var sizef = "";
     
            if (rand_arg1.Checked == true)
            {
                sizef = "40";
                this.lng.Location = new Point(487, 140);

            }
            else if (inco.Checked == true)
            {
                rand_arg1.Checked = false;
                dynlink.Checked = false;
                sizef = "220";
                this.lng.Location = new Point(478, 140);
            }
            else if (dynlink.Checked == true)
            {
                rand_arg1.Checked = false;
                sizef = "60";
                this.lng.Location = new Point(487, 140);
            }
            else {
                sizef = "20";
                this.lng.Location = new Point(487, 140);
            }
            int length = Int32.Parse(sizef);
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOP‰QRSTUVWXYZ111224455234567890!@#$%^&¯¦™—ßÞà*Œ(>)_+Š¬¥£¢¡®±«µþüûúøù÷ðæïîëêéèçåäãÑÐ×ÖÕÔËÆ¿Ÿ§©/•¤‡€ƒ†Ž…|~`,.:;={[]}-";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            SP.Text = res.ToString();
            lng.Text = "Length: " + SP.Text.Length;
     
        }
        private string rcrsmnlklda(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void rand_arg1_CheckedChanged(object sender, EventArgs e)
        {
            if (rand_arg1.Checked == true) {
                dynlink.Checked = false;
                inco.Checked = false;
            }
        }

        private void dynlink_CheckedChanged(object sender, EventArgs e)
        {
            if (dynlink.Checked == true)
            {
                rand_arg1.Checked = false;
                inco.Checked = false;
            }
        }

        private void inco_CheckedChanged(object sender, EventArgs e)
        {
            if (inco.Checked == true)
            {
                rand_arg1.Checked = false;
                dynlink.Checked = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These passwords are usually impossible to remember, so make sure you save a backup of the password. Usually, this kind of passwords is used with security pen drives or password managers. I don't encourage you to use password managers. Once the app is closed, there is no way the same password will be generated again, so please make sure you backup it somewhere safe. You can move the app by clicking anywhere on the white area and dragging", "Crypt0r", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             MessageBox.Show("These passwords are usually impossible to remember, so make sure you save a backup of the password. Usually, this kind of passwords is used with security pen drives or password managers. I don't encourage you to use password managers. Once the app is closed, there is no way the same password will be generated again, so please make sure you backup it somewhere safe. You can move the app by clicking anywhere on the white area and dragging. Padlock icon by Freepik.", "Crypt0r", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string webAddress = "https://twitter.com/FCE365";
            Process.Start(webAddress);
        }
    }
}

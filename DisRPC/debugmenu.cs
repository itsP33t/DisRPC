//-----------------------------------------------------------------------------------------------------------------------------//
//-Programmed by P33t from P33t.net
//-this program is originally published on Github and P33t.net
// NOT ANYWHERE ELSE
// if you downloaded disRPC from site that is not github or P33t.net, i recommend uninstalling it and installing it from original souce
// https://www.p33t.net/downloads
//------------------------------------------------------------------------------------------------------------------------------//
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DisRPC
{
    public partial class debugmenu : Form
    {
        public debugmenu()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            customid.Default.id_1 = ("");
            customid.Default.text1_1 = ("");
            customid.Default.text2_1 = ("");
            customid.Default.logoname_1 = ("");
            customid.Default.smalllogoname_1 = ("");
            customid.Default.imagetext_1 = ("");
            customid.Default.presetname_1 = ("Custom Preset");
            customid.Default.Save();
            reset.Text = ("Done");
            resetchange.Start();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Custom Preset.txt"))
                sw.WriteLine("DisRPC by P33t.net | ID:", lastid.Text);
                
                
        }

        private void debugmenu_Load(object sender, EventArgs e)
        {
            
            lastid.Text = customid.Default.id_1;
            
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            if (console.Text == "font")
            {
                output.Text = ("The font name is Lemon/Milk");
            }
            if (console.Text == "font.install")
            {
                output.Text = ("working...");
                Process.Start("font.otf");
            }
            if (console.Text == "discord")
            {
                output.Text = ("https://discord.gg/r5WYm5hG7g");
                Process.Start("https://discord.gg/r5WYm5hG7g");
            }
        }

        private void resetchange_Tick(object sender, EventArgs e)
        {
            reset.Text = ("Reset Custom Preset");
            resetchange.Stop();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

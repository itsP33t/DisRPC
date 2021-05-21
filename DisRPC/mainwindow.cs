//-----------------------------------------------------------------------------------------------------------------------------//
//-Programmed by P33t from P33t.net
//-this program is originally published on Github and P33t.net
// NOT ANYWHERE ELSE
// if you downloaded disRPC from site that is not github or P33t.net, i recommend uninstalling it and installing it from original souce
// https://www.p33t.net/downloads
//------------------------------------------------------------------------------------------------------------------------------//
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using DiscordRpcDemo;

namespace DisRPC
{
    public partial class mainwindow : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public mainwindow()
        {
            InitializeComponent();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            customid.Default.id_1 = app_id.Text;
            customid.Default.text1_1 = text1.Text;
            customid.Default.text2_1 = text2.Text;
            customid.Default.logoname_1 = logoname.Text;
            customid.Default.smalllogoname_1 = smalllogoname.Text;
            customid.Default.imagetext_1 = imagetext.Text;
            customid.Default.presetname_1 = presetname.Text;
            customid.Default.Save();
            custompresetbtn.Text = (presetname.Text);
            save.Start();

        }

        private void presets_Load(object sender, EventArgs e)
        {
            custompresetbtn.Text = customid.Default.presetname_1;
            
            
            

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            presetname.Text = customid.Default.presetname_1;
            app_id.Text = customid.Default.id_1;
            text1.Text = customid.Default.text1_1;
            text2.Text = customid.Default.text2_1;
            logoname.Text = customid.Default.logoname_1;
            smalllogoname.Text = customid.Default.smalllogoname_1;
            imagetext.Text = customid.Default.imagetext_1;


        }

        private void save_Tick(object sender, EventArgs e)
        {
            savebtn.Text = ("Saved");
            save.Stop();
            save2.Start();
        }

        private void save2_Tick(object sender, EventArgs e)
        {
            savebtn.Text = ("Save Settings");
            save2.Stop();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/MTIdDgXcO2w");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/r5WYm5hG7g");
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            status.Text = ("Status: Started");
            status.ForeColor = System.Drawing.Color.Green;
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(app_id.Text, ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(app_id.Text, ref this.handlers, true, null);
            this.presence.details = text1.Text;
            this.presence.state = text2.Text;
            this.presence.largeImageKey = logoname.Text;
            this.presence.smallImageKey = smalllogoname.Text;
            this.presence.largeImageText = imagetext.Text;
            DiscordRpc.UpdatePresence(ref this.presence);
            startbtn.Text = ("Update");
            lastid.Default.id_1 = app_id.Text;
            lastid.Default.text1_1 = text1.Text;
            lastid.Default.text2_1 = text2.Text;
            lastid.Default.logoname_1 = logoname.Text;
            lastid.Default.smalllogoname_1 = smalllogoname.Text;
            lastid.Default.imagetext_1 = imagetext.Text;
            lastid.Default.presetname_1 = presetname.Text;
            lastid.Default.Save();

            if (app_id.Text == "debug")
            {
                debugmenu debugmenu = new debugmenu();
               debugmenu.Show();
                status.Text = ("Status: Debug Started");
                status.ForeColor = System.Drawing.Color.Orange;
            }
            if (app_id.Text == "DEBUG")
            {
                debugmenu debugmenu = new debugmenu();
                debugmenu.Show();
                status.Text = ("Status: Debug Started");
                status.ForeColor = System.Drawing.Color.Orange;
            }
            if (app_id.Text == "Debug")
            {
                debugmenu debugmenu = new debugmenu();
                debugmenu.Show();
                status.Text = ("Status: Debug Started");
                status.ForeColor = System.Drawing.Color.Orange;
            }
            if (app_id.Text == "p33tui.transparent") ;
                {
                
            }
            
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            presetname.Text = lastid.Default.presetname_1;
            app_id.Text = lastid.Default.id_1;
            text1.Text = lastid.Default.text1_1;
            text2.Text = lastid.Default.text2_1;
            logoname.Text = lastid.Default.logoname_1;
            smalllogoname.Text = lastid.Default.smalllogoname_1;
            imagetext.Text = lastid.Default.imagetext_1;
        }

        private void DisRPC_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mainwindow mainwindow = new mainwindow();
            this.Show();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            debugmenu debugmenu = new debugmenu();
            debugmenu.Show();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}

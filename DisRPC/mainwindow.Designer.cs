
namespace DisRPC
{
    partial class mainwindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.DisRPC = new System.Windows.Forms.Label();
            this.custompresetbtn = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton5 = new Siticone.UI.WinForms.SiticoneButton();
            this.imagetext = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.smalllogoname = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.logoname = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.text2 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.text1 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.app_id = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.savebtn = new Siticone.UI.WinForms.SiticoneButton();
            this.startbtn = new Siticone.UI.WinForms.SiticoneButton();
            this.presetname = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.save = new System.Windows.Forms.Timer(this.components);
            this.save2 = new System.Windows.Forms.Timer(this.components);
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.anima = new Siticone.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(719, 12);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(668, 12);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // DisRPC
            // 
            this.DisRPC.AutoSize = true;
            this.DisRPC.Font = new System.Drawing.Font("Lemon/Milk", 13.25F);
            this.DisRPC.ForeColor = System.Drawing.Color.White;
            this.DisRPC.Location = new System.Drawing.Point(12, 15);
            this.DisRPC.Name = "DisRPC";
            this.DisRPC.Size = new System.Drawing.Size(75, 26);
            this.DisRPC.TabIndex = 3;
            this.DisRPC.Text = "disrpc";
            this.DisRPC.Click += new System.EventHandler(this.DisRPC_Click);
            // 
            // custompresetbtn
            // 
            this.custompresetbtn.BorderRadius = 3;
            this.custompresetbtn.BorderThickness = 1;
            this.custompresetbtn.CheckedState.Parent = this.custompresetbtn;
            this.custompresetbtn.CustomImages.Parent = this.custompresetbtn;
            this.custompresetbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.custompresetbtn.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.custompresetbtn.ForeColor = System.Drawing.Color.White;
            this.custompresetbtn.HoveredState.Parent = this.custompresetbtn;
            this.custompresetbtn.Location = new System.Drawing.Point(12, 81);
            this.custompresetbtn.Name = "custompresetbtn";
            this.custompresetbtn.ShadowDecoration.Parent = this.custompresetbtn;
            this.custompresetbtn.Size = new System.Drawing.Size(339, 55);
            this.custompresetbtn.TabIndex = 6;
            this.custompresetbtn.Text = "Custom Preset";
            this.custompresetbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 3;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(12, 152);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(339, 55);
            this.siticoneButton1.TabIndex = 7;
            this.siticoneButton1.Text = "last info";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderRadius = 3;
            this.siticoneButton2.BorderThickness = 1;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(12, 300);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(339, 55);
            this.siticoneButton2.TabIndex = 9;
            this.siticoneButton2.Text = "join discord";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BorderRadius = 3;
            this.siticoneButton3.BorderThickness = 1;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(12, 228);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(339, 55);
            this.siticoneButton3.TabIndex = 8;
            this.siticoneButton3.Text = "tutorial";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.BorderRadius = 3;
            this.siticoneButton5.BorderThickness = 1;
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneButton5.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
            this.siticoneButton5.Location = new System.Drawing.Point(12, 369);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(339, 55);
            this.siticoneButton5.TabIndex = 10;
            this.siticoneButton5.Text = "hide";
            this.siticoneButton5.Click += new System.EventHandler(this.siticoneButton5_Click);
            // 
            // imagetext
            // 
            this.imagetext.Animated = false;
            this.imagetext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.imagetext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imagetext.DefaultText = "";
            this.imagetext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.imagetext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.imagetext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.imagetext.DisabledState.Parent = this.imagetext;
            this.imagetext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.imagetext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.imagetext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.imagetext.FocusedState.Parent = this.imagetext;
            this.imagetext.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.imagetext.ForeColor = System.Drawing.Color.White;
            this.imagetext.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.imagetext.HoveredState.Parent = this.imagetext;
            this.imagetext.Location = new System.Drawing.Point(377, 326);
            this.imagetext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imagetext.Name = "imagetext";
            this.imagetext.PasswordChar = '\0';
            this.imagetext.PlaceholderForeColor = System.Drawing.Color.White;
            this.imagetext.PlaceholderText = "image text";
            this.imagetext.SelectedText = "";
            this.imagetext.ShadowDecoration.Parent = this.imagetext;
            this.imagetext.Size = new System.Drawing.Size(354, 41);
            this.imagetext.TabIndex = 18;
            // 
            // smalllogoname
            // 
            this.smalllogoname.Animated = false;
            this.smalllogoname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.smalllogoname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.smalllogoname.DefaultText = "";
            this.smalllogoname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.smalllogoname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.smalllogoname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.smalllogoname.DisabledState.Parent = this.smalllogoname;
            this.smalllogoname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.smalllogoname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.smalllogoname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.smalllogoname.FocusedState.Parent = this.smalllogoname;
            this.smalllogoname.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.smalllogoname.ForeColor = System.Drawing.Color.White;
            this.smalllogoname.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.smalllogoname.HoveredState.Parent = this.smalllogoname;
            this.smalllogoname.Location = new System.Drawing.Point(378, 277);
            this.smalllogoname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.smalllogoname.Name = "smalllogoname";
            this.smalllogoname.PasswordChar = '\0';
            this.smalllogoname.PlaceholderForeColor = System.Drawing.Color.White;
            this.smalllogoname.PlaceholderText = "Small logo name";
            this.smalllogoname.SelectedText = "";
            this.smalllogoname.ShadowDecoration.Parent = this.smalllogoname;
            this.smalllogoname.Size = new System.Drawing.Size(354, 41);
            this.smalllogoname.TabIndex = 17;
            // 
            // logoname
            // 
            this.logoname.Animated = false;
            this.logoname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.logoname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoname.DefaultText = "";
            this.logoname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.logoname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.logoname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logoname.DisabledState.Parent = this.logoname;
            this.logoname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logoname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.logoname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoname.FocusedState.Parent = this.logoname;
            this.logoname.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.logoname.ForeColor = System.Drawing.Color.White;
            this.logoname.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoname.HoveredState.Parent = this.logoname;
            this.logoname.Location = new System.Drawing.Point(377, 228);
            this.logoname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoname.Name = "logoname";
            this.logoname.PasswordChar = '\0';
            this.logoname.PlaceholderForeColor = System.Drawing.Color.White;
            this.logoname.PlaceholderText = "logo name";
            this.logoname.SelectedText = "";
            this.logoname.ShadowDecoration.Parent = this.logoname;
            this.logoname.Size = new System.Drawing.Size(354, 41);
            this.logoname.TabIndex = 16;
            // 
            // text2
            // 
            this.text2.Animated = false;
            this.text2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text2.DefaultText = "";
            this.text2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text2.DisabledState.Parent = this.text2;
            this.text2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.text2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text2.FocusedState.Parent = this.text2;
            this.text2.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.text2.ForeColor = System.Drawing.Color.White;
            this.text2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text2.HoveredState.Parent = this.text2;
            this.text2.Location = new System.Drawing.Point(378, 179);
            this.text2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text2.Name = "text2";
            this.text2.PasswordChar = '\0';
            this.text2.PlaceholderForeColor = System.Drawing.Color.White;
            this.text2.PlaceholderText = "Text 2 (state)";
            this.text2.SelectedText = "";
            this.text2.ShadowDecoration.Parent = this.text2;
            this.text2.Size = new System.Drawing.Size(354, 41);
            this.text2.TabIndex = 15;
            // 
            // text1
            // 
            this.text1.Animated = false;
            this.text1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text1.DefaultText = "";
            this.text1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text1.DisabledState.Parent = this.text1;
            this.text1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.text1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text1.FocusedState.Parent = this.text1;
            this.text1.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.text1.ForeColor = System.Drawing.Color.White;
            this.text1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text1.HoveredState.Parent = this.text1;
            this.text1.Location = new System.Drawing.Point(378, 130);
            this.text1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text1.Name = "text1";
            this.text1.PasswordChar = '\0';
            this.text1.PlaceholderForeColor = System.Drawing.Color.White;
            this.text1.PlaceholderText = "Text 1 (details)";
            this.text1.SelectedText = "";
            this.text1.ShadowDecoration.Parent = this.text1;
            this.text1.Size = new System.Drawing.Size(354, 41);
            this.text1.TabIndex = 14;
            // 
            // app_id
            // 
            this.app_id.Animated = false;
            this.app_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.app_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.app_id.DefaultText = "";
            this.app_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.app_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.app_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.app_id.DisabledState.Parent = this.app_id;
            this.app_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.app_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.app_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.app_id.FocusedState.Parent = this.app_id;
            this.app_id.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.app_id.ForeColor = System.Drawing.Color.White;
            this.app_id.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.app_id.HoveredState.Parent = this.app_id;
            this.app_id.Location = new System.Drawing.Point(378, 81);
            this.app_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.app_id.Name = "app_id";
            this.app_id.PasswordChar = '\0';
            this.app_id.PlaceholderForeColor = System.Drawing.Color.White;
            this.app_id.PlaceholderText = "app id";
            this.app_id.SelectedText = "";
            this.app_id.ShadowDecoration.Parent = this.app_id;
            this.app_id.Size = new System.Drawing.Size(354, 41);
            this.app_id.TabIndex = 13;
            // 
            // savebtn
            // 
            this.savebtn.BorderRadius = 3;
            this.savebtn.BorderThickness = 1;
            this.savebtn.CheckedState.Parent = this.savebtn;
            this.savebtn.CustomImages.Parent = this.savebtn;
            this.savebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.savebtn.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.HoveredState.Parent = this.savebtn;
            this.savebtn.Location = new System.Drawing.Point(12, 444);
            this.savebtn.Name = "savebtn";
            this.savebtn.ShadowDecoration.Parent = this.savebtn;
            this.savebtn.Size = new System.Drawing.Size(339, 55);
            this.savebtn.TabIndex = 19;
            this.savebtn.Text = "save settings";
            this.savebtn.Click += new System.EventHandler(this.siticoneButton6_Click);
            // 
            // startbtn
            // 
            this.startbtn.BorderRadius = 3;
            this.startbtn.BorderThickness = 1;
            this.startbtn.CheckedState.Parent = this.startbtn;
            this.startbtn.CustomImages.Parent = this.startbtn;
            this.startbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.startbtn.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.startbtn.ForeColor = System.Drawing.Color.White;
            this.startbtn.HoveredState.Parent = this.startbtn;
            this.startbtn.Location = new System.Drawing.Point(377, 444);
            this.startbtn.Name = "startbtn";
            this.startbtn.ShadowDecoration.Parent = this.startbtn;
            this.startbtn.Size = new System.Drawing.Size(354, 55);
            this.startbtn.TabIndex = 20;
            this.startbtn.Text = "start";
            this.startbtn.Click += new System.EventHandler(this.siticoneButton7_Click);
            // 
            // presetname
            // 
            this.presetname.Animated = false;
            this.presetname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.presetname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.presetname.DefaultText = "";
            this.presetname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.presetname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.presetname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.presetname.DisabledState.Parent = this.presetname;
            this.presetname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.presetname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.presetname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.presetname.FocusedState.Parent = this.presetname;
            this.presetname.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.presetname.ForeColor = System.Drawing.Color.White;
            this.presetname.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.presetname.HoveredState.Parent = this.presetname;
            this.presetname.Location = new System.Drawing.Point(377, 383);
            this.presetname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.presetname.Name = "presetname";
            this.presetname.PasswordChar = '\0';
            this.presetname.PlaceholderForeColor = System.Drawing.Color.White;
            this.presetname.PlaceholderText = "preset name";
            this.presetname.SelectedText = "";
            this.presetname.ShadowDecoration.Parent = this.presetname;
            this.presetname.Size = new System.Drawing.Size(354, 41);
            this.presetname.TabIndex = 21;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // save
            // 
            this.save.Tick += new System.EventHandler(this.save_Tick);
            // 
            // save2
            // 
            this.save2.Interval = 3000;
            this.save2.Tick += new System.EventHandler(this.save2_Tick);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Lemon/Milk", 13.25F);
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(7, 518);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(236, 26);
            this.status.TabIndex = 22;
            this.status.Text = "Status: Ready to start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(721, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "v1.2";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DisRPC";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // anima
            // 
            this.anima.AnimationType = Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_BLEND;
            this.anima.Interval = 5000;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(776, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.presetname);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.imagetext);
            this.Controls.Add(this.smalllogoname);
            this.Controls.Add(this.logoname);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.app_id);
            this.Controls.Add(this.siticoneButton5);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.custompresetbtn);
            this.Controls.Add(this.DisRPC);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "presets";
            this.Load += new System.EventHandler(this.presets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private System.Windows.Forms.Label DisRPC;
        private Siticone.UI.WinForms.SiticoneButton custompresetbtn;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox imagetext;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox smalllogoname;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox logoname;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox text2;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox text1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox app_id;
        private Siticone.UI.WinForms.SiticoneButton savebtn;
        private Siticone.UI.WinForms.SiticoneButton startbtn;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox presetname;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Timer save;
        private System.Windows.Forms.Timer save2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Siticone.UI.WinForms.SiticoneAnimateWindow anima;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
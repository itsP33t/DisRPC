
namespace DisRPC
{
    partial class debugmenu
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
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.DisRPC = new System.Windows.Forms.Label();
            this.reset = new Siticone.UI.WinForms.SiticoneButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lastid = new System.Windows.Forms.Label();
            this.console = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetchange = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(346, 12);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 0;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(295, 12);
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
            this.DisRPC.Size = new System.Drawing.Size(130, 26);
            this.DisRPC.TabIndex = 4;
            this.DisRPC.Text = "Debug Menu";
            // 
            // reset
            // 
            this.reset.BorderRadius = 3;
            this.reset.BorderThickness = 1;
            this.reset.CheckedState.Parent = this.reset;
            this.reset.CustomImages.Parent = this.reset;
            this.reset.FillColor = System.Drawing.Color.Red;
            this.reset.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.HoveredState.Parent = this.reset;
            this.reset.Location = new System.Drawing.Point(33, 92);
            this.reset.Name = "reset";
            this.reset.ShadowDecoration.Parent = this.reset;
            this.reset.Size = new System.Drawing.Size(339, 55);
            this.reset.TabIndex = 10;
            this.reset.Text = "reset custom preset";
            this.reset.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lemon/Milk", 13.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "last id:";
            // 
            // lastid
            // 
            this.lastid.AutoSize = true;
            this.lastid.Font = new System.Drawing.Font("Lemon/Milk", 13.25F);
            this.lastid.ForeColor = System.Drawing.Color.Green;
            this.lastid.Location = new System.Drawing.Point(28, 200);
            this.lastid.Name = "lastid";
            this.lastid.Size = new System.Drawing.Size(312, 26);
            this.lastid.TabIndex = 17;
            this.lastid.Text = "looks like you have no last id";
            // 
            // console
            // 
            this.console.Animated = false;
            this.console.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.console.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.console.DefaultText = "";
            this.console.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.console.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.console.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.console.DisabledState.Parent = this.console;
            this.console.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.console.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.console.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.console.FocusedState.Parent = this.console;
            this.console.Font = new System.Drawing.Font("Lemon/Milk", 9F);
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.console.HoveredState.Parent = this.console;
            this.console.Location = new System.Drawing.Point(33, 369);
            this.console.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.console.Name = "console";
            this.console.PasswordChar = '\0';
            this.console.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.console.PlaceholderText = "Debug Console";
            this.console.SelectedText = "";
            this.console.ShadowDecoration.Parent = this.console;
            this.console.Size = new System.Drawing.Size(339, 47);
            this.console.TabIndex = 18;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 3;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Lemon/Milk", 12F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(33, 423);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(339, 55);
            this.siticoneButton1.TabIndex = 19;
            this.siticoneButton1.Text = "send";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "output:";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Lemon/Milk", 13.25F);
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(28, 329);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(350, 26);
            this.output.TabIndex = 21;
            this.output.Text = "tip: no output = wrong command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lemon/Milk", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "tip: you can find commands at discord";
            // 
            // resetchange
            // 
            this.resetchange.Interval = 3000;
            this.resetchange.Tick += new System.EventHandler(this.resetchange_Tick);
            // 
            // debugmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(403, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.lastid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.DisRPC);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "debugmenu";
            this.Text = "debugmenu";
            this.Load += new System.EventHandler(this.debugmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private System.Windows.Forms.Label DisRPC;
        private Siticone.UI.WinForms.SiticoneButton reset;
        private System.Windows.Forms.Label lastid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox console;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer resetchange;
    }
}
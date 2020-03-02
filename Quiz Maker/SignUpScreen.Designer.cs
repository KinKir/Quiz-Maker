namespace Quiz_Maker
{
    partial class SignUpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpScreen));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnametxtbox_ = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.gmailtxtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passtxtbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fnametxtbox_ = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.signupbtn_ = new Bunifu.Framework.UI.BunifuTileButton();
            this.signupscreenheader = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            this.signupscreendrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.minimizelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Quiz_Maker.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(93, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(277, 142);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(376, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 51);
            this.label2.TabIndex = 19;
            this.label2.Text = "SignUp";
            // 
            // lnametxtbox_
            // 
            this.lnametxtbox_.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.lnametxtbox_.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.lnametxtbox_.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.lnametxtbox_.BorderThickness = 3;
            this.lnametxtbox_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnametxtbox_.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lnametxtbox_.ForeColor = System.Drawing.Color.Gray;
            this.lnametxtbox_.isPassword = false;
            this.lnametxtbox_.Location = new System.Drawing.Point(510, 239);
            this.lnametxtbox_.Margin = new System.Windows.Forms.Padding(4);
            this.lnametxtbox_.Name = "lnametxtbox_";
            this.lnametxtbox_.Size = new System.Drawing.Size(170, 47);
            this.lnametxtbox_.TabIndex = 20;
            this.lnametxtbox_.Text = "Last name";
            this.lnametxtbox_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gmailtxtbox
            // 
            this.gmailtxtbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.gmailtxtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.gmailtxtbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.gmailtxtbox.BorderThickness = 3;
            this.gmailtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gmailtxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gmailtxtbox.ForeColor = System.Drawing.Color.Gray;
            this.gmailtxtbox.isPassword = false;
            this.gmailtxtbox.Location = new System.Drawing.Point(258, 319);
            this.gmailtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.gmailtxtbox.Name = "gmailtxtbox";
            this.gmailtxtbox.Size = new System.Drawing.Size(422, 47);
            this.gmailtxtbox.TabIndex = 22;
            this.gmailtxtbox.Text = "example@gmail.com";
            this.gmailtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passtxtbox
            // 
            this.passtxtbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.passtxtbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.passtxtbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.passtxtbox.BorderThickness = 3;
            this.passtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passtxtbox.ForeColor = System.Drawing.Color.Gray;
            this.passtxtbox.isPassword = true;
            this.passtxtbox.Location = new System.Drawing.Point(258, 405);
            this.passtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(422, 47);
            this.passtxtbox.TabIndex = 23;
            this.passtxtbox.Text = "Password";
            this.passtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fnametxtbox_
            // 
            this.fnametxtbox_.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.fnametxtbox_.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.fnametxtbox_.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.fnametxtbox_.BorderThickness = 3;
            this.fnametxtbox_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnametxtbox_.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fnametxtbox_.ForeColor = System.Drawing.Color.Gray;
            this.fnametxtbox_.isPassword = false;
            this.fnametxtbox_.Location = new System.Drawing.Point(258, 239);
            this.fnametxtbox_.Margin = new System.Windows.Forms.Padding(4);
            this.fnametxtbox_.Name = "fnametxtbox_";
            this.fnametxtbox_.Size = new System.Drawing.Size(192, 47);
            this.fnametxtbox_.TabIndex = 20;
            this.fnametxtbox_.Text = "First name";
            this.fnametxtbox_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signupbtn_
            // 
            this.signupbtn_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.signupbtn_.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.signupbtn_.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(250)))));
            this.signupbtn_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbtn_.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.signupbtn_.ForeColor = System.Drawing.Color.White;
            this.signupbtn_.Image = null;
            this.signupbtn_.ImagePosition = 20;
            this.signupbtn_.ImageZoom = 50;
            this.signupbtn_.LabelPosition = 41;
            this.signupbtn_.LabelText = "Sign Up";
            this.signupbtn_.Location = new System.Drawing.Point(332, 487);
            this.signupbtn_.Margin = new System.Windows.Forms.Padding(6);
            this.signupbtn_.Name = "signupbtn_";
            this.signupbtn_.Size = new System.Drawing.Size(303, 48);
            this.signupbtn_.TabIndex = 24;
            this.signupbtn_.Click += new System.EventHandler(this.signupbtn__Click);
            // 
            // signupscreenheader
            // 
            this.signupscreenheader.Location = new System.Drawing.Point(-2, -6);
            this.signupscreenheader.Name = "signupscreenheader";
            this.signupscreenheader.Size = new System.Drawing.Size(939, 46);
            this.signupscreenheader.TabIndex = 25;
            // 
            // exitlbl
            // 
            this.exitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitlbl.ForeColor = System.Drawing.Color.Red;
            this.exitlbl.Location = new System.Drawing.Point(895, -1);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(23, 26);
            this.exitlbl.TabIndex = 26;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // signupscreendrag
            // 
            this.signupscreendrag.Fixed = true;
            this.signupscreendrag.Horizontal = true;
            this.signupscreendrag.TargetControl = this.signupscreenheader;
            this.signupscreendrag.Vertical = true;
            // 
            // minimizelbl
            // 
            this.minimizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizelbl.ForeColor = System.Drawing.Color.Red;
            this.minimizelbl.Location = new System.Drawing.Point(871, -3);
            this.minimizelbl.Name = "minimizelbl";
            this.minimizelbl.Size = new System.Drawing.Size(23, 26);
            this.minimizelbl.TabIndex = 27;
            this.minimizelbl.Text = "-";
            this.minimizelbl.Click += new System.EventHandler(this.minimizelbl_Click);
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(920, 569);
            this.Controls.Add(this.minimizelbl);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.signupscreenheader);
            this.Controls.Add(this.signupbtn_);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.gmailtxtbox);
            this.Controls.Add(this.fnametxtbox_);
            this.Controls.Add(this.lnametxtbox_);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 569);
            this.Name = "SignUpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpScreen";
            this.Load += new System.EventHandler(this.SignUpScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox lnametxtbox_;
        private Bunifu.Framework.UI.BunifuMetroTextbox gmailtxtbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox passtxtbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox fnametxtbox_;
        private Bunifu.Framework.UI.BunifuTileButton signupbtn_;
        private System.Windows.Forms.Label signupscreenheader;
        private System.Windows.Forms.Label exitlbl;
        private Bunifu.Framework.UI.BunifuDragControl signupscreendrag;
        private System.Windows.Forms.Label minimizelbl;
    }
}
namespace Quiz_Maker
{
    partial class Loginscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginscreen));
            this.emailtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginscreenheader = new System.Windows.Forms.Label();
            this.loginscreendrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.exitlbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginsbtn_ = new Bunifu.Framework.UI.BunifuTileButton();
            this.signupbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.minimizelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.emailtxtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.emailtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.emailtxtbox.HintText = "";
            this.emailtxtbox.isPassword = false;
            this.emailtxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.emailtxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.emailtxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.emailtxtbox.LineThickness = 3;
            this.emailtxtbox.Location = new System.Drawing.Point(297, 251);
            this.emailtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(379, 33);
            this.emailtxtbox.TabIndex = 1;
            this.emailtxtbox.Text = "example@gmail.com";
            this.emailtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailtxtbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.emailtxtbox_MouseDown);
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passwordtxtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordtxtbox.HintText = "Password";
            this.passwordtxtbox.isPassword = true;
            this.passwordtxtbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.passwordtxtbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.passwordtxtbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(230)))));
            this.passwordtxtbox.LineThickness = 3;
            this.passwordtxtbox.Location = new System.Drawing.Point(297, 332);
            this.passwordtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(379, 33);
            this.passwordtxtbox.TabIndex = 3;
            this.passwordtxtbox.Text = "newnewnew";
            this.passwordtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordtxtbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordtxtbox_MouseDown);
            // 
            // loginscreenheader
            // 
            this.loginscreenheader.Location = new System.Drawing.Point(-3, -8);
            this.loginscreenheader.Name = "loginscreenheader";
            this.loginscreenheader.Size = new System.Drawing.Size(910, 46);
            this.loginscreenheader.TabIndex = 5;
            // 
            // loginscreendrag
            // 
            this.loginscreendrag.Fixed = true;
            this.loginscreendrag.Horizontal = true;
            this.loginscreendrag.TargetControl = this.loginscreenheader;
            this.loginscreendrag.Vertical = true;
            // 
            // exitlbl
            // 
            this.exitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitlbl.ForeColor = System.Drawing.Color.Red;
            this.exitlbl.Location = new System.Drawing.Point(895, -1);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(23, 26);
            this.exitlbl.TabIndex = 6;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Quiz_Maker.Properties.Resources.passwordico;
            this.pictureBox3.Location = new System.Drawing.Point(235, 325);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Quiz_Maker.Properties.Resources.usernameico;
            this.pictureBox2.Location = new System.Drawing.Point(235, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_Maker.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(235, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginsbtn_
            // 
            this.loginsbtn_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.loginsbtn_.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.loginsbtn_.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(250)))));
            this.loginsbtn_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginsbtn_.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.loginsbtn_.ForeColor = System.Drawing.Color.White;
            this.loginsbtn_.Image = null;
            this.loginsbtn_.ImagePosition = 20;
            this.loginsbtn_.ImageZoom = 50;
            this.loginsbtn_.LabelPosition = 41;
            this.loginsbtn_.LabelText = "Login";
            this.loginsbtn_.Location = new System.Drawing.Point(332, 428);
            this.loginsbtn_.Margin = new System.Windows.Forms.Padding(6);
            this.loginsbtn_.Name = "loginsbtn_";
            this.loginsbtn_.Size = new System.Drawing.Size(303, 48);
            this.loginsbtn_.TabIndex = 20;
            this.loginsbtn_.Click += new System.EventHandler(this.loginsbtn__Click);
            // 
            // signupbtn
            // 
            this.signupbtn.ActiveBorderThickness = 1;
            this.signupbtn.ActiveCornerRadius = 20;
            this.signupbtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.signupbtn.ActiveForecolor = System.Drawing.Color.Red;
            this.signupbtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.signupbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signupbtn.BackgroundImage")));
            this.signupbtn.ButtonText = "Sign Up";
            this.signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ForeColor = System.Drawing.Color.White;
            this.signupbtn.IdleBorderThickness = 1;
            this.signupbtn.IdleCornerRadius = 20;
            this.signupbtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.signupbtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.signupbtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.signupbtn.Location = new System.Drawing.Point(399, 506);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(5);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(181, 41);
            this.signupbtn.TabIndex = 23;
            this.signupbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // minimizelbl
            // 
            this.minimizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizelbl.ForeColor = System.Drawing.Color.Red;
            this.minimizelbl.Location = new System.Drawing.Point(871, -3);
            this.minimizelbl.Name = "minimizelbl";
            this.minimizelbl.Size = new System.Drawing.Size(23, 26);
            this.minimizelbl.TabIndex = 7;
            this.minimizelbl.Text = "-";
            this.minimizelbl.Click += new System.EventHandler(this.minimizelbl_Click);
            // 
            // Loginscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(920, 569);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.loginsbtn_);
            this.Controls.Add(this.minimizelbl);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.loginscreenheader);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 569);
            this.Name = "Loginscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "loginscreen";
            this.Load += new System.EventHandler(this.Loginscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailtxtbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordtxtbox;
        private System.Windows.Forms.Label loginscreenheader;
        private Bunifu.Framework.UI.BunifuDragControl loginscreendrag;
        private System.Windows.Forms.Label exitlbl;
        private Bunifu.Framework.UI.BunifuTileButton loginsbtn_;
        private Bunifu.Framework.UI.BunifuThinButton2 signupbtn;
        private System.Windows.Forms.Label minimizelbl;
    }
}


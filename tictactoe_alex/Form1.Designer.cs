namespace tictactoe_alex
{
    partial class Form1
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
            this.Example = new System.Windows.Forms.Button();
            this.musicon = new System.Windows.Forms.Button();
            this.musicoff = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.pointO = new System.Windows.Forms.Button();
            this.pointX = new System.Windows.Forms.Button();
            this.Os = new System.Windows.Forms.Label();
            this.Xs = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.resetscore = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chX = new System.Windows.Forms.Button();
            this.chO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Example
            // 
            this.Example.Location = new System.Drawing.Point(44, 158);
            this.Example.Name = "Example";
            this.Example.Size = new System.Drawing.Size(75, 23);
            this.Example.TabIndex = 11;
            this.Example.Text = "Example";
            this.Example.UseVisualStyleBackColor = true;
            this.Example.Click += new System.EventHandler(this.Example_Click);
            // 
            // musicon
            // 
            this.musicon.Location = new System.Drawing.Point(130, 158);
            this.musicon.Name = "musicon";
            this.musicon.Size = new System.Drawing.Size(75, 23);
            this.musicon.TabIndex = 12;
            this.musicon.Text = "Music On";
            this.musicon.UseVisualStyleBackColor = true;
            this.musicon.Click += new System.EventHandler(this.Musicon_Click);
            // 
            // musicoff
            // 
            this.musicoff.Location = new System.Drawing.Point(130, 203);
            this.musicoff.Name = "musicoff";
            this.musicoff.Size = new System.Drawing.Size(75, 23);
            this.musicoff.TabIndex = 13;
            this.musicoff.Text = "Music Off";
            this.musicoff.UseVisualStyleBackColor = true;
            this.musicoff.Click += new System.EventHandler(this.Musicoff_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(44, 203);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset board";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // pointO
            // 
            this.pointO.Location = new System.Drawing.Point(130, 249);
            this.pointO.Name = "pointO";
            this.pointO.Size = new System.Drawing.Size(75, 23);
            this.pointO.TabIndex = 15;
            this.pointO.Text = "point to O";
            this.pointO.UseVisualStyleBackColor = true;
            this.pointO.Click += new System.EventHandler(this.PointO_Click);
            // 
            // pointX
            // 
            this.pointX.Location = new System.Drawing.Point(44, 249);
            this.pointX.Name = "pointX";
            this.pointX.Size = new System.Drawing.Size(75, 23);
            this.pointX.TabIndex = 16;
            this.pointX.Text = "Point to X";
            this.pointX.UseVisualStyleBackColor = true;
            this.pointX.Click += new System.EventHandler(this.PointX_Click);
            // 
            // Os
            // 
            this.Os.AutoSize = true;
            this.Os.Location = new System.Drawing.Point(289, 280);
            this.Os.Name = "Os";
            this.Os.Size = new System.Drawing.Size(22, 13);
            this.Os.TabIndex = 17;
            this.Os.Text = "O\'s";
            // 
            // Xs
            // 
            this.Xs.AutoSize = true;
            this.Xs.Location = new System.Drawing.Point(292, 26);
            this.Xs.Name = "Xs";
            this.Xs.Size = new System.Drawing.Size(21, 13);
            this.Xs.TabIndex = 18;
            this.Xs.Text = "X\'s";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(292, 82);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 19;
            this.labelX.Text = "X";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(292, 336);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(15, 13);
            this.labelO.TabIndex = 20;
            this.labelO.Text = "O";
            // 
            // resetscore
            // 
            this.resetscore.Location = new System.Drawing.Point(260, 182);
            this.resetscore.Name = "resetscore";
            this.resetscore.Size = new System.Drawing.Size(75, 23);
            this.resetscore.TabIndex = 21;
            this.resetscore.Text = "Reset Score";
            this.resetscore.UseVisualStyleBackColor = true;
            this.resetscore.Click += new System.EventHandler(this.Resetscore_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Moccasin;
            this.pictureBox11.Location = new System.Drawing.Point(785, 280);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(161, 114);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox10.Location = new System.Drawing.Point(785, 158);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(161, 114);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox9.Location = new System.Drawing.Point(785, 26);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(161, 114);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.MediumBlue;
            this.pictureBox8.Location = new System.Drawing.Point(596, 280);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(161, 114);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox7.Location = new System.Drawing.Point(596, 26);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(161, 114);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.OliveDrab;
            this.pictureBox6.Location = new System.Drawing.Point(596, 158);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(161, 114);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox5.Location = new System.Drawing.Point(403, 280);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(161, 114);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox4.Location = new System.Drawing.Point(403, 158);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 114);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox3.Location = new System.Drawing.Point(403, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tictactoe_alex.Properties.Resources.cir;
            this.pictureBox2.Location = new System.Drawing.Point(44, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragDrop);
            this.pictureBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragEnter);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tictactoe_alex.Properties.Resources.xxx;
            this.pictureBox1.Location = new System.Drawing.Point(44, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            // 
            // chX
            // 
            this.chX.Location = new System.Drawing.Point(260, 117);
            this.chX.Name = "chX";
            this.chX.Size = new System.Drawing.Size(75, 23);
            this.chX.TabIndex = 22;
            this.chX.Text = "Change X";
            this.chX.UseVisualStyleBackColor = true;
            this.chX.Click += new System.EventHandler(this.ChX_Click);
            // 
            // chO
            // 
            this.chO.Location = new System.Drawing.Point(260, 249);
            this.chO.Name = "chO";
            this.chO.Size = new System.Drawing.Size(75, 23);
            this.chO.TabIndex = 23;
            this.chO.Text = "Change O";
            this.chO.UseVisualStyleBackColor = true;
            this.chO.Click += new System.EventHandler(this.ChO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 426);
            this.Controls.Add(this.chO);
            this.Controls.Add(this.chX);
            this.Controls.Add(this.resetscore);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.Xs);
            this.Controls.Add(this.Os);
            this.Controls.Add(this.pointX);
            this.Controls.Add(this.pointO);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.musicoff);
            this.Controls.Add(this.musicon);
            this.Controls.Add(this.Example);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button Example;
        private System.Windows.Forms.Button musicon;
        private System.Windows.Forms.Button musicoff;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button pointO;
        private System.Windows.Forms.Button pointX;
        private System.Windows.Forms.Label Os;
        private System.Windows.Forms.Label Xs;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Button resetscore;
        private System.Windows.Forms.Button chX;
        private System.Windows.Forms.Button chO;
    }
}


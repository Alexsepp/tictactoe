using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe_alex
{
    public partial class Form1 : Form
    {
        private int _score = 0;
        private int _score1 = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "Resident Evil 7 - Save Room Theme.wav";
            MessageBox.Show("Welcome to Tic Tac Toe, \n" +
                "it's a game about getting 3 X(x) or 3 O(o) in a row,column or diagonal.\n" +
                "the rules are simple ,get the streak of 3x or 3o without been interupted by your opponent");
            //this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2),
            //    (Screen.GetBounds(this).Height / 2) - (this.Height / 2),
            //    this.Width, this.Height, BoundsSpecified.Location);
        }
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;

            

            //pictureBox3.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox3.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox3.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox3.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox3.DragDrop += new DragEventHandler(pictureBox2_DragDrop);

            //pictureBox4.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox4.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox4.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox4.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox4.DragDrop += new DragEventHandler(pictureBox2_DragDrop);

            //pictureBox5.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox5.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox5.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox5.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox5.DragDrop += new DragEventHandler(pictureBox2_DragDrop);

            //pictureBox6.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox6.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox6.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox6.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox6.DragDrop += new DragEventHandler(pictureBox2_DragDrop);

            //pictureBox7.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox7.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox7.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox7.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox7.DragDrop += new DragEventHandler(pictureBox2_DragDrop);

            //pictureBox8.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox8.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox8.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox8.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox8.DragDrop += new DragEventHandler(pictureBox2_DragDrop);

            //pictureBox9.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox9.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox9.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox9.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox9.DragDrop += new DragEventHandler(pictureBox2_DragDrop);

            //pictureBox10.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox10.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox10.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox10.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox10.DragDrop += new DragEventHandler(pictureBox2_DragDrop);

            //pictureBox11.MouseDown += new MouseEventHandler(pictureBox1_MouseDown_1);
            pictureBox11.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            pictureBox11.DragDrop += new DragEventHandler(pictureBox1_DragDrop);
            pictureBox11.DragEnter += new DragEventHandler(pictureBox2_DragEnter);
            pictureBox11.DragDrop += new DragEventHandler(pictureBox2_DragDrop);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void Example_Click(object sender, EventArgs e)
        {
            Form2 form22 = new Form2();
            form22.Show();
        }

        private void Musicon_Click(object sender, EventArgs e)
        {
            player.PlayLooping();

        }

        private void Musicoff_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
        }

        private void PointO_Click(object sender, EventArgs e)
        {
            _score += 1;
            labelO.Text = _score.ToString();
        }

        private void PointX_Click(object sender, EventArgs e)
        {
            _score1 += 1;
            labelX.Text = _score1.ToString();
        }

        private void Resetscore_Click(object sender, EventArgs e)
        {
            _score = 0;
            labelX.Text = _score.ToString();
            _score1 = 0;
            labelO.Text = _score1.ToString();
        }

        private void ChO_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox2.Image = new Bitmap(open.FileName);
            }
        }

        private void ChX_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
    }
}
//http://www.technologyuk.net/computing/software-development/computer-programming/vbnet/graphics-the-pong-game.shtml
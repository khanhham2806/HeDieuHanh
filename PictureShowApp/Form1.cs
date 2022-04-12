using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureShowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {

        }

        private void btSet_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {

        }

        private void btShow_Click(object sender, EventArgs e)
        {

        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Setphoto()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }
        public void Show()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        public void Clear()
        {
            pictureBox1.Image = null;
        }
        private void btSet_Click_1(object sender, EventArgs e)
        {
            Setphoto();
        }

        private void btShow_Click_1(object sender, EventArgs e)
        {
            Show();
        }

        private void btClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClear_Click_1(object sender, EventArgs e)
        {
            Clear();


        }
        public void Stretch()
        {
            if (cb1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
        private void cb1_CheckedChanged_1(object sender, EventArgs e)
        {
            Stretch();
        }

        
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

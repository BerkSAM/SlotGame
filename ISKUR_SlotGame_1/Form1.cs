using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISKUR_SlotGame_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void don()
        {
            Random random = new Random();
            int a;

            foreach (PictureBox pcb in this.Controls.OfType<PictureBox>())
            {
                a = random.Next(3);
                pcb.Image = imageList1.Images[a];
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            imageList1.Images.Add(ISKUR_SlotGame_1.Properties.Resources._1);
            imageList1.Images.Add(ISKUR_SlotGame_1.Properties.Resources._2);
            imageList1.Images.Add(ISKUR_SlotGame_1.Properties.Resources._3);


        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            don();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            don();
            //if (pictureBox1.Image == pictureBox2.Image == pictureBox3.Image)
            //{

            //}
        }
    }
}

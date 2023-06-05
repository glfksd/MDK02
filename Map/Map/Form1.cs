using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        

        

        private void checkpoint1_Click(object sender, EventArgs e)
        {
            heder.Text = "МЦК Лужники";
            picturetoilet.Visible = false;
            toilet.Visible = false;
            picturemedicin.Visible = false;
            medicin.Visible = false;
            pictureinfo.Visible = false;
            info.Visible = false;
            pictureenergi.Visible = true;
            enrgi.Visible = true;
            picturedrink.Visible = true;
            drink.Visible = true;
        }

        private void checkpoint2_Click(object sender, EventArgs e)
        {
            heder.Text = "Новодевичей монастырь";
            picturetoilet.Visible = true;
            toilet.Visible = true;
            picturemedicin.Visible = true;
            medicin.Visible = true;
            pictureinfo.Visible = true;
            info.Visible = true;
            pictureenergi.Visible = true;
            enrgi.Visible = true;
            picturedrink.Visible = true;
            drink.Visible = true;
        }

        private void checkpoint3_Click(object sender, EventArgs e)
        {
            heder.Text = "Метро Киевская";
            picturetoilet.Visible = true;
            toilet.Visible = true;
            picturemedicin.Visible = true;
            medicin.Visible = true;
            pictureinfo.Visible = true;
            info.Visible = true;
            pictureenergi.Visible = false;
            enrgi.Visible = false;
            picturedrink.Visible = false;
            drink.Visible = false;
        }

        private void checkpoint5_Click(object sender, EventArgs e)
        {
            heder.Text = "Парк Горького";
            picturetoilet.Visible = false;
            toilet.Visible = true;
            picturemedicin.Visible = true;
            medicin.Visible = true;
            pictureinfo.Visible = true;
            info.Visible = true;
            pictureenergi.Visible = true;
            enrgi.Visible = true;
            picturedrink.Visible = false;
            drink.Visible = false;
        }

        private void checkpoint6_Click(object sender, EventArgs e)
        {
            heder.Text = "Здания РАН";
            picturetoilet.Visible = true;
            toilet.Visible = true;
            picturemedicin.Visible = true;
            medicin.Visible = true;
            pictureinfo.Visible = true;
            info.Visible = true;
            pictureenergi.Visible = false;
            enrgi.Visible = false;
            picturedrink.Visible = false;
            drink.Visible = false;
        }

        private void checkpoint8_Click(object sender, EventArgs e)
        {
            heder.Text = "Стадион Лужники";
            picturetoilet.Visible = true;
            toilet.Visible = true;
            picturemedicin.Visible = true;
            medicin.Visible = true;
            pictureinfo.Visible = true;
            info.Visible = true;
            pictureenergi.Visible = true;
            enrgi.Visible = true;
            picturedrink.Visible = true;
            drink.Visible = true;
        }

        private void checkpoint7_Click(object sender, EventArgs e)
        {
            heder.Text = "Метро Воробевы горы";
            picturetoilet.Visible = true;
            toilet.Visible = true;
            picturemedicin.Visible = true;
            medicin.Visible = true;
            pictureinfo.Visible = true;
            info.Visible = true;
            pictureenergi.Visible = true;
            enrgi.Visible = true;
            picturedrink.Visible = true;
            drink.Visible = true;
        }

        private void checkpoint4_Click(object sender, EventArgs e)
        {
            heder.Text = "МИД";
            picturetoilet.Visible = true;
            toilet.Visible = true;
            picturemedicin.Visible = true;
            medicin.Visible = true;
            pictureinfo.Visible = true;
            info.Visible = true;
            pictureenergi.Visible = false;
            enrgi.Visible = false;
            picturedrink.Visible = true;
            drink.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            picturetoilet.Visible = false;
            toilet.Visible = false;
            picturemedicin.Visible = false;
            medicin.Visible = false;
            pictureinfo.Visible = false;
            info.Visible = false;
            pictureenergi.Visible = false;
            enrgi.Visible = false;
            picturedrink.Visible = false;
            drink.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            picturetoilet.Visible = false;
            toilet.Visible = false;
            picturemedicin.Visible = false;
            medicin.Visible = false;
            pictureinfo.Visible = false;
            info.Visible = false;
            pictureenergi.Visible = false;
            enrgi.Visible = false;
            picturedrink.Visible = false;
            drink.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            picturetoilet.Visible = false;
            toilet.Visible = false;
            picturemedicin.Visible = false;
            medicin.Visible = false;
            pictureinfo.Visible = false;
            info.Visible = false;
            pictureenergi.Visible = false;
            enrgi.Visible = false;
            picturedrink.Visible = false;
            drink.Visible = false;
        }
    }
}

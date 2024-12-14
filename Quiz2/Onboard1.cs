using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2
{
    public partial class Onboard1 : Form
    {
        public Onboard1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:\\Users\\Singh\\source\\repos\\Quiz2\\Quiz2\\Onboard1.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Onboard1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onboard2 onboard2 = new Onboard2();
            onboard2.Show();
            this.Hide();
        }
    }
}

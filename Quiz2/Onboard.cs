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
    public partial class Onboard : Form
    {
        public Onboard()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:\\Users\\Singh\\source\\repos\\Quiz2\\Quiz2\\Onboard.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Onboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(400, 300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onboard1 onboard1 = new Onboard1();
            onboard1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

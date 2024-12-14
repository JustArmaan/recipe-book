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
    public partial class Onboard2 : Form
    {
        public Onboard2()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:\\Users\\Singh\\source\\repos\\Quiz2\\Quiz2\\Onboard2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Onboard2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginRegister sign = new LoginRegister();
            sign.Show();
            this.Hide();
        }
    }
}

using System;
using System.Windows.Forms;

namespace TestePadawans
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Posts form2 = new Posts();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Albums form3 = new Albums();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToDo form4 = new ToDo();
            form4.Show();
        }
    }
}

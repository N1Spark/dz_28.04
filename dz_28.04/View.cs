using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_28._04
{
    public partial class View : Form
    {
        Controller controller;
        public View()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = controller.GetBook(textBox1.Text).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            controller.NewBook();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.GetAllBooks();
        }
    }
}

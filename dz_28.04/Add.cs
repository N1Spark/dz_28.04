using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dz_28._04.Model;

namespace dz_28._04
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        public Book GetNewBook()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                return new Book(textBox1.Text, textBox3.Text);
            }
            return null;

        }
    }
}

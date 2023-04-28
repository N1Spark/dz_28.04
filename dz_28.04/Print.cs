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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        public void AddBook(Book book)
        {
            listBox1.Items.Add(book.ToString());
        }
    }
}

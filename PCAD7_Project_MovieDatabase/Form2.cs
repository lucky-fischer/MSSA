using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCAD7_Project_MovieDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // creates an instance of form 1
            form1.Show(); // displays form 1 when btnEnter is clicked.
            this.Hide(); // Form2 no loger displays on the screen.
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click_Click(object sender, EventArgs e)
        {
            int cops;
            try
            {
                cops = Convert.ToInt32(txt_Pass.Text);
            }
            catch (FormatException)
            {
                cops = 1;
            }
            for (int i = 0; i < cops; i++)
            {
                MessageBox.Show("Hello World");
            }
        }
    }
}

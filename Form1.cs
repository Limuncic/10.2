using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._2_Rafael
{
    public partial class Form1 : Form
    {
        int i = 0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bt1_Click(object sender, EventArgs e)
        {

            i++;

            pb1.Visible = false;

            if (i % 2 == 1)
             {
                pb1.Visible = true;

             }
            
        }
    }
}

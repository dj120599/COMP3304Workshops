using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FishyNote : Form
    {
        bool MinMax = true;

        public FishyNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MinMax == true)
            {
                this.Size = new Size(478, 148);
                MinMax = false;
            }
            else
            {
                this.Size = new Size(478, 450);
                MinMax = true;
            }
         
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
    }
}

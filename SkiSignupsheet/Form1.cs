using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiSignupsheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is CheckBox checkbox)
                {
                    checkbox.Checked = false;
                }
            }
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selecteditems = Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            if (selecteditems.Any())
            {
                MessageBox.Show("Selected items: " + string.Join(", ", selecteditems), "Selected Items");
            }
            else
            {
                MessageBox.Show("No items selected.", "Selected Items");
            }
        }
    }
}

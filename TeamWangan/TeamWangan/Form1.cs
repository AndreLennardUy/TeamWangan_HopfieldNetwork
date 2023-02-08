using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamWangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += new EventHandler(changeColor);
            button2.Click += new EventHandler(changeColor);
            button3.Click += new EventHandler(changeColor);
            button4.Click += new EventHandler(changeColor);
            button5.Click += new EventHandler(changeColor);
            button6.Click += new EventHandler(changeColor);
            button7.Click += new EventHandler(changeColor);
            button8.Click += new EventHandler(changeColor);
            button9.Click += new EventHandler(changeColor);
            resetBtn.Click += new EventHandler(resetColor);

        }

        private void changeColor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void resetColor(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }
    }
}

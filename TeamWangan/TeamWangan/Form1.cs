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
        int[] inputArr = new int[9];
        int[,] weight = { { 0, 0 , 2 , -2 , -2 , -2 , 2 , 0 , 2 } , 
                        {0 , 0 , 0 , 0 , 0 , 0 , 0 , 2 , 0} , 
                        {2 , 0 , 0 , -2 , -2 , -2 , 2 , 0 , 2} ,
                        {2 , 0 , -2 , 0 , 2 , 2 , -2 , 0 ,-2 } ,
                        {2 , 0 , -2 , 2 , 0, 2 , -2 , 0 , -2 } ,
                        {2 , 0 , -2 , 2 , 2 , 0 , -2 , 0 ,-2} ,
                        {2 , 0 , 2 , -2 , -2 , -2 , 0 , 0 , 2} ,
                        {0 , 2 , 0 , 0 , 0 , 0 , 0 , 0 , 0} ,
                        {2 , 0 , 2 , -2 , -2 , -2 , 2 , 0 , 0} 
        };

        int[] outputArr = new int[9];

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
            ((Control)sender).BackColor = Color.Black;
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
            label2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkMemBtn_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 9; i++)
            //{
            //    foreach (Control c in this.Controls.OfType<Button>())
            //    {
            //        if (c.BackColor == Color.Black)
            //        {
            //            inputArr[i] = 1;
            //        }
            //        else if (c.BackColor == Color.White)
            //        {
            //            inputArr[i] = 0;
            //        }
            //    }
            //}
            if (button1.BackColor == Color.Black)
            {
                inputArr[0] = 1;
            }
            else if (button1.BackColor == Color.White)
            {
                inputArr[0] = 0;
            }

            if (button2.BackColor == Color.Black)
            {
                inputArr[1] = 1;
            }
            else if (button2.BackColor == Color.White)
            {
                inputArr[1] = 0;
            }

            if (button3.BackColor == Color.Black)
            {
                inputArr[2] = 1;
            }
            else if (button3.BackColor == Color.White)
            {
                inputArr[2] = 0;
            }

            if (button4.BackColor == Color.Black)
            {
                inputArr[3] = 1;
            }
            else if (button4.BackColor == Color.White)
            {
                inputArr[3] = 0;
            }

            if (button5.BackColor == Color.Black)
            {
                inputArr[4] = 1;
            }
            else if (button5.BackColor == Color.White)
            {
                inputArr[4] = 0;
            }

            if (button6.BackColor == Color.Black)
            {
                inputArr[5] = 1;
            }
            else if (button6.BackColor == Color.White)
            {
                inputArr[5] = 0;
            }

            if (button7.BackColor == Color.Black)
            {
                inputArr[6] = 1;
            }
            else if (button7.BackColor == Color.White)
            {
                inputArr[6] = 0;
            }

            if (button8.BackColor == Color.Black)
            {
                inputArr[7] = 1;
            }
            else if (button8.BackColor == Color.White)
            {
                inputArr[7] = 0;
            }

            if (button9.BackColor == Color.Black)
            {
                inputArr[8] = 1;
            }
            else if (button9.BackColor == Color.White)
            {
                inputArr[8] = 0;
            }

            


            //foreach (var i in inputArr)
            //{
            //    label2.Text = label2.Text + " " + i;            
            //}
        }
    }
}

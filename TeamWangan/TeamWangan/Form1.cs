using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TeamWangan
{
    /// <summary>
    /// Class <c>Form1</c> is where our application is stored.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// This stores the input vectors.
        /// </summary>
        int[] inputArr = new int[9];

        /// <summary>
        /// This stores the given weight matrix of the plus and minus symobls.
        /// </summary>
        int[,] weight = {
                        {  0,  0,  2, -2, -2, -2,  2, 0 ,  2} ,
                        {  0,  0,  0,  0,  0,  0,  0, 2 ,  0} ,
                        {  2,  0,  0, -2, -2, -2,  2, 0 ,  2} ,
                        {  2,  0, -2,  0,  2,  2, -2, 0 , -2} ,
                        {  2,  0, -2,  2,  0,  2, -2, 0 , -2} ,
                        {  2,  0, -2,  2,  2,  0, -2, 0 , -2} ,
                        {  2,  0,  2, -2, -2, -2,  0, 0 ,  2} ,
                        {  0,  2,  0,  0,  0,  0,  0, 0 ,  0} ,
                        {  2,  0,  2, -2, -2, -2,  2, 0 ,  0}
        };

        /// <summary>
        /// This stores the output vectors.
        /// </summary>
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

        /// <summary>
        /// Toggles the color of the button.
        /// </summary>
        /// <param name="sender">Click the button.</param>
        /// <param name="e">Changes the color of the button.</param>
        private void changeColor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = (((Control)sender).BackColor == Color.Black) ? Color.White : Color.Black;
        }

        /// <summary>
        /// Loads the form.
        /// </summary>
        /// <param name="sender">Auto-start on program execution.</param>
        /// <param name="e">Loads the form.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This resets the application - it sets all the buttons to white and
        /// clears the outputArr.
        /// </summary>
        /// <param name="sender">This is the action of clicking the button.</param>
        /// <param name="e">This is the result of clicking the button, which results
        /// in setting all the buttons back to white.</param>
        private void resetColor(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9,
                                                    button10, button11, button12, button13, button14, button15, button16, button17, button18};

            foreach (Button button in buttons)
            {
                button.BackColor = Color.White;
            }
            label2.Text = "";
            Array.Clear(outputArr, 0, outputArr.Length);
        }

        /// <summary>
        /// This will calculate the output vectors and the threshold from the
        /// input vector.
        /// </summary>
        /// <param name="sender">This is the action of clicking the button.</param>
        /// <param name="e">From the action of clicking the button, this will
        /// toggle the button to white or black.</param>
        private void checkMemBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            
            inputArr[0] = (button1.BackColor == Color.Black) ? 1 : -1;
            inputArr[1] = (button2.BackColor == Color.Black) ? 1 : -1;
            inputArr[2] = (button3.BackColor == Color.Black) ? 1 : -1;
            inputArr[3] = (button4.BackColor == Color.Black) ? 1 : -1;
            inputArr[4] = (button5.BackColor == Color.Black) ? 1 : -1;
            inputArr[5] = (button6.BackColor == Color.Black) ? 1 : -1;
            inputArr[6] = (button7.BackColor == Color.Black) ? 1 : -1;
            inputArr[7] = (button8.BackColor == Color.Black) ? 1 : -1;
            inputArr[8] = (button9.BackColor == Color.Black) ? 1 : -1;


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    outputArr[i] += inputArr[j] * weight[i, j];
                }
            }

            foreach(var i in outputArr)
            {
                output.Text = output.Text + " " + i;
            }

            for (int i = 0; i < 9; i++)
            {
                if (outputArr[i] >= 0)
                {
                    outputArr[i] = 1;
                }
                else if (outputArr[i] < 0)
                {
                    outputArr[i] = -1;
                }
            }

            foreach (var i in outputArr)
            {   
                label2.Text = label2.Text + " " + i;
            }
                
            button10.BackColor = (outputArr[0] == 1) ? Color.Black : Color.White;
            button11.BackColor = (outputArr[1] == 1) ? Color.Black : Color.White;
            button12.BackColor = (outputArr[2] == 1) ? Color.Black : Color.White;
            button13.BackColor = (outputArr[3] == 1) ? Color.Black : Color.White;
            button14.BackColor = (outputArr[4] == 1) ? Color.Black : Color.White;
            button15.BackColor = (outputArr[5] == 1) ? Color.Black : Color.White;
            button16.BackColor = (outputArr[6] == 1) ? Color.Black : Color.White;
            button17.BackColor = (outputArr[7] == 1) ? Color.Black : Color.White;
            button18.BackColor = (outputArr[8] == 1) ? Color.Black : Color.White;
        }

    }
}

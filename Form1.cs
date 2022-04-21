using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzel_15
{
    
    public partial class Form1 : Form
    {
        Button[,] cells;
        int emty_x, emty_y;
        public Form1()
        {
            InitializeComponent();
            cells = new Button[4, 4] { {button1, button2, button3, button4 },
                                       {button5, button6, button7, button8 },
                                       {button9, button10, button11, button12 },
                                       {button13, button14, button15, button16 },};

            Random r = new Random();
            int[] a = new int[16];
            int x;

            for (int i = 0; i < 16; i++)
            {
                do
                {
                    x = r.Next(0, 17);

                } while (a.Contains(x));

                a[i] = x;

            }

            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(a[i]);

            }


            int index = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(a[index] == 16)
                    {
                        cells[i, j].Hide();
                        emty_x = i;
                        emty_y = j;
                    }

                    cells[i, j].Text = Convert.ToString(a[index]);
                    cells[i, j].Font = new Font("Arial", 25);
                    cells[i, j].BackColor = Color.White;
                    cells[i, j].ForeColor = Color.BlueViolet;
                    index++;
                }

            }

            check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //if(button2.Text == "")
                //{
                //    button2.Text = button1.Text;
                //    button1.Text = "";
                //}
                //if (button4.Text == "")
                //{
                //    button4.Text = button1.Text;
                //    button1.Text = "";
                //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (button1.Text == "")
            //{
            //    button1.Text = button2.Text;
            //    button2.Text = "";
            //}
            //if (button5.Text == "")
            //{
            //    button5.Text = button2.Text;
            //    button2.Text = "";
            //}
            //if (button3.Text == "")
            //{
            //    button3.Text = button2.Text;
            //    button2.Text = "";
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (button2.Text == "")
            //{
            //    button2.Text = button3.Text;
            //    button3.Text = "";
            //}
            //if (button6.Text == "")
            //{
            //    button6.Text = button3.Text;
            //    button3.Text = "";
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (button1.Text == "")
            //{
            //    button1.Text = button4.Text;
            //    button4.Text = "";
            //}
            //if (button5.Text == "")
            //{
            //    button5.Text = button4.Text;
            //    button4.Text = "";
            //}
            //if (button7.Text == "")
            //{
            //    button7.Text = button4.Text;
            //    button4.Text = "";

            //}

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (button2.Text == "")
            //{
            //    button2.Text = button5.Text;
            //    button5.Text = "";
            //}
            //if (button4.Text == "")
            //{
            //    button4.Text = button5.Text;
            //    button5.Text = "";
            //}
            //if (button6.Text == "")
            //{
            //    button6.Text = button5.Text;
            //    button5.Text = "";
            //}
            //if (button8.Text == "")
            //{
            //    button8.Text = button5.Text;
            //    button5.Text = "";
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if (button3.Text == "")
            //{
            //    button3.Text = button6.Text;
            //    button6.Text = "";
            //}
            //if (button5.Text == "")

            //{
            //    button5.Text = button6.Text;
            //    button6.Text = "";
            //}
            //if (button9.Text == "")
            //{
            //    button9.Text = button6.Text;
            //    button6.Text = "";
            //}
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button this_button = sender as Button;
            int x = 0, y= 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (cells[i, j] == this_button)
                    {
                       x = i;
                       y = j;

                    }
                }

            }///شرط همسایه خونه خالی بودن در بازی

            if (
                (x == emty_x && (y == emty_y - 1 || y == emty_y + 1))
                ||
                (y == emty_y && (x == emty_x - 1 || x == emty_x + 1))
                )
            {
                cells[emty_x, emty_y].Text = this_button.Text;
                this_button.Text = "16";

                cells[emty_x, emty_y].Show();
                this_button.Hide();

                emty_x = x;
                emty_y = y;
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            //if (button4.Text == "")
            //{
            //    button4.Text = button7.Text;
            //    button7.Text = "";
            //}

            //if (button8.Text == "")
            //{
            //    button8.Text = button7.Text;
            //    button7.Text = "";
            //}
            
        }

        public void check()
        {
            if (
                 button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                 button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                 button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                 button13.Text == "13" && button14.Text == "14" && button15.Text == "15"
                 )
            {
                MessageBox.Show("you Win 😊");
            }
        }
    }
    

    
}

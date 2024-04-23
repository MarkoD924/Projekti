using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private Rectangle bt1Original;
        private Rectangle bt2Original;
        private Rectangle bt3Original;
        private Rectangle bt4Original;
        private Rectangle bt5Original;
        private Rectangle bt6Original;
        private Rectangle bt7Original;
        private Rectangle bt8Original;
        private Rectangle bt9Original;
        private Rectangle bt0Original;
        private Rectangle bttOriginal;
        private Rectangle btEnOriginal;
        private Rectangle btPlOriginal;
        private Rectangle btMinOriginal;
        private Rectangle btPutaOriginal;
        private Rectangle btDeljOriginal;
        private Rectangle btclearOriginal;
        private Rectangle formOriginal;
        private Rectangle btresenjeOriginal;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Uzimanje vrednosti koordinante prave lokacije i velicine objekta
        {
            formOriginal = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            bt1Original = new Rectangle(bt1.Location.X, bt1.Location.Y, bt1.Size.Width, bt1.Size.Height);
            bt2Original = new Rectangle(bt2.Location.X, bt2.Location.Y, bt2.Size.Width, bt2.Size.Height);
            bt3Original = new Rectangle(bt3.Location.X, bt3.Location.Y, bt3.Size.Width, bt3.Size.Height);
            bt4Original = new Rectangle(bt4.Location.X, bt4.Location.Y, bt4.Size.Width, bt4.Size.Height);
            bt5Original = new Rectangle(bt5.Location.X, bt5.Location.Y, bt5.Size.Width, bt5.Size.Height);
            bt6Original = new Rectangle(bt6.Location.X, bt6.Location.Y, bt6.Size.Width, bt6.Size.Height);
            bt7Original = new Rectangle(bt7.Location.X, bt7.Location.Y, bt7.Size.Width, bt7.Size.Height);
            bt8Original = new Rectangle(bt8.Location.X, bt8.Location.Y, bt8.Size.Width, bt8.Size.Height);
            bt9Original = new Rectangle(bt9.Location.X, bt9.Location.Y, bt9.Size.Width, bt9.Size.Height);
            bt0Original = new Rectangle(bt0.Location.X, bt0.Location.Y, bt0.Size.Width, bt0.Size.Height);
            btEnOriginal = new Rectangle(btEn.Location.X, btEn.Location.Y, btEn.Size.Width, btEn.Size.Height);
            btPlOriginal = new Rectangle(btPl.Location.X, btPl.Location.Y, btPl.Size.Width, btPl.Size.Height);
            btMinOriginal = new Rectangle(btMin.Location.X, btMin.Location.Y, btMin.Size.Width, btMin.Size.Height);
            btPutaOriginal = new Rectangle(btPuta.Location.X, btPuta.Location.Y, btPuta.Size.Width, btPuta.Size.Height);
            btDeljOriginal = new Rectangle(btDelj.Location.X, btDelj.Location.Y, btDelj.Size.Width, btDelj.Size.Height);
            btclearOriginal = new Rectangle(btclear.Location.X, btclear.Location.Y, btclear.Size.Width, btclear.Size.Height);
            bttOriginal = new Rectangle(btt.Location.X, btt.Location.Y, btt.Size.Width, btt.Size.Height);
            btresenjeOriginal = new Rectangle(btresenje.Location.X, btresenje.Location.Y, btresenje.Size.Width, btresenje.Size.Height);
        }
        private void resizeControl(Rectangle r, Control c) // metoda za scaling
        {
            float xRatio = (float)(this.Width) / (float)(formOriginal.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginal.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void Form1_Resize(object sender, EventArgs e) //pozivanje scaling metode 
        {
            resizeControl(bt1Original, bt1);
            resizeControl(bt2Original, bt2);
            resizeControl(bt3Original, bt3);
            resizeControl(bt4Original, bt4);
            resizeControl(bt5Original, bt5);
            resizeControl(bt6Original, bt6);
            resizeControl(bt7Original, bt7);
            resizeControl(bt8Original, bt8);
            resizeControl(bt9Original, bt9);
            resizeControl(bt0Original, bt0);
            resizeControl(bttOriginal, btt);
            resizeControl(btEnOriginal, btEn);
            resizeControl(btPlOriginal, btPl);
            resizeControl(btMinOriginal, btMin);
            resizeControl(btPutaOriginal, btPuta);
            resizeControl(btDeljOriginal, btDelj);
            resizeControl(btclearOriginal, btclear);
            resizeControl(btresenjeOriginal, btresenje);
        }

        float num1, num2, resenje;
        char operacije;
        bool decimala=false;


        private void changeLabel(int numPressed)
        {
          

            if (decimala == true)
            {
                int decimalCount = 0;
                foreach( char c in btresenje.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                    if (decimalCount < 1)
                    {
                        btresenje.Text = btresenje.Text + '.';
                    }
                    decimala = false;
                }
            }
            else
            {
                if (btresenje.Text.Equals("0") == true && btresenje.Text != null)
                {
                    btresenje.Text = numPressed.ToString();
                } 
                else if (btresenje.Text.Equals("-0") == true)
                {
                    btresenje.Text ="-"+ numPressed.ToString();
                }
                else
                {
                    btresenje.Text = btresenje.Text + numPressed.ToString();
                }
            }    
                    
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            changeLabel(0);

        }
        private void bt1_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void btt_Click(object sender, EventArgs e)
        {
            decimala= true;
            changeLabel(0);
        }

        private void btEn_Click(object sender, EventArgs e)
        {
            resenje = 0;
            if (btresenje.Text.Equals("0") == false)
            {
                switch(operacije)
                {
                    case '+':
                        num2 = float.Parse(btresenje.Text);
                        resenje = num1 + num2;
                        break;

                    case '-':
                        num2 = float.Parse(btresenje.Text);
                        resenje = num1 - num2;
                        break;

                    case '*':
                        num2 = float.Parse(btresenje.Text);
                        resenje = num1 * num2;
                        break;

                    case '/':
                        num2 = float.Parse(btresenje.Text);
                        resenje = num1 / num2;
                        break;

                   default:
                        break;
                }    
            }
            btresenje.Text = resenje.ToString();
        }

        private void btPl_Click(object sender, EventArgs e)
        {
            num1= float.Parse(btresenje.Text);
            operacije = '+';
            resenje = resenje + num1;
            btresenje.Text = "";
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(btresenje.Text);
            operacije = '-';
            resenje = resenje - num1;
            btresenje.Text = "";
        }

        private void btPuta_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(btresenje.Text);
            operacije = '*';
            resenje = resenje * num1;
            btresenje.Text = "";
        }

        private void btDelj_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(btresenje.Text);
            operacije = '/';
            resenje = resenje / num1;
            btresenje.Text = "";
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            int stringDuzina = btresenje.Text.Length;
            if (stringDuzina > 1)
            {
                btresenje.Text = btresenje.Text.Substring(0, stringDuzina - 1);
            }
            else
            {
                btresenje.Text = "0";
            }
        }

     

    }
}

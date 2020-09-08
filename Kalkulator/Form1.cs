using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        List<TextBox> lista=new List<TextBox>();
        public Form1()
        {
            InitializeComponent();

            lista.Add(tbx0); 
            lista.Add(tbx1); 
            lista.Add(tbx2); 
            lista.Add(tbx3); 
            lista.Add(tbx4); 
            lista.Add(tbx5); 
            lista.Add(tbx6);


        }
        public double Izracunaj(int a,int b,int operacija)
        {
            double rez=0.0;
            
                try
            {
                if (operacija==1)
                {
                     rez = a + b;
                    
                }
                else if (operacija==2)
                {
                    rez = a - b;
                }
                else if (operacija==3)
                {
                    rez = a * b;
                }
                else if (operacija==4)
                {
                    rez = (double)a / (double)b;
                    rez = Math.Round(rez, 2);

                }
                return rez;
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
                return 0;
            }
        }
        int a=0;
        int b=0;
        int oper=0;
        private void btn1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0") || (textBox1.Text=="+")|| (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/") )
            {
                textBox1.Text = 1.ToString();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 2.ToString();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 3.ToString();
                
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 4.ToString();
                
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 5.ToString();
                
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
               
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 6.ToString();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
               
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 7.ToString();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
               
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 8.ToString();
                
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 9.ToString();
                
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
               
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (textBox1.Text == "+") || (textBox1.Text == "-") || (textBox1.Text == "*") || (textBox1.Text == "/"))
            {
                textBox1.Text = 0.ToString();
                
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            for (int i = 0; i < 4; i++)
            {
                lista[i].Controls.Clear();
            }
        }
        string tekst;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            bool isnum = int.TryParse(textBox1.Text, out a);

            if (isnum)
            {
                a = Convert.ToInt32(textBox1.Text);
                tekst = textBox1.Text + "+";
                textBox1.Text = "+";

                textBox2.Text = tekst;
                oper = 1;
            }
            else
            {
                string s = textBox2.Text;

                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    s = "0";
                }
                textBox1.Text = "+";

                a = Convert.ToInt32(s);

                textBox2.Text = s + "+";
                oper = 1;
            }


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            bool isnum = int.TryParse(textBox1.Text, out a);
            if (isnum)
            {
                a = Convert.ToInt32(textBox1.Text);
                tekst = textBox1.Text + "-";
                textBox1.Text = "-";
                textBox2.Text = tekst;
                oper = 2;
            }
            else
            {
                string s = textBox2.Text;

                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    s = "0";
                }
                a = Convert.ToInt32(s);
                textBox1.Text = "-";
               
               
                textBox2.Text = s+"-";
                oper = 2;
            }


        }
        string tekst1;
        private void btnMnozi_Click(object sender, EventArgs e)
        {
            bool isnum = int.TryParse(textBox1.Text, out a);
            if (isnum)
            {
                tekst1 = textBox1.Text;
                a = Convert.ToInt32(textBox1.Text);
                tekst = textBox1.Text + "*";
                textBox1.Text = "*";
                textBox2.Text = tekst;
                oper = 3;
            }
            else
            {
                string s = textBox2.Text;

                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    s = "0";
                }
                textBox1.Text = "*";
                a = Convert.ToInt32(s);

                textBox2.Text = s + "*";
                oper = 3;
            }

        }

        private void btnDeli_Click(object sender, EventArgs e)
        {
            bool isnum = int.TryParse(textBox1.Text, out a);
            if (isnum)
            {
                a = Convert.ToInt32(textBox1.Text);
                tekst = textBox1.Text + "/";
                textBox1.Text = "/";
                textBox2.Text = tekst;
                oper = 4;
            }
            else
            {
                string s = textBox2.Text;

                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    s = "0";
                }
                textBox1.Text = "/";
                a = Convert.ToInt32(s);

                textBox2.Text = s + "/";
                oper = 4;
            }

        }
       int n=-1;
        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            if (oper==0)
            {
                textBox1.Text = 0.ToString();
                textBox2.Text = "";

            }
            else
            {
                int broj;
                bool isnum = int.TryParse(textBox1.Text, out broj);
                if (isnum)
                {
                    b  = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    b = 0;
                }
             
            textBox2.Text = textBox2.Text + b.ToString()+"=";
            double rez = this.Izracunaj(a, b, oper);
            textBox2.Text =textBox2.Text+ rez.ToString();
            textBox1.Text = "0";
                oper = 0;
                n++;
                if (n>6)
                {
                    n =0;
                  
                }
                this.Ubaci(textBox2.Text,n);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="+")
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = tekst1;
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text != "0" || textBox1.Text != "+" || textBox1.Text != "-" || textBox1.Text != "*" || textBox1.Text != "/")
            {
   double rez=    Convert.ToInt32(textBox1.Text) / 10;
                textBox1.Text = Convert.ToString(rez) ;
            }
            
            else
            { 
                textBox1.Text = "0";
            }
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1': this.btn1_Click(sender, e); break;
                case '2': this.btn2_Click(sender, e); break;
                case '3': this.btn3_Click(sender, e); break;
                case '4': this.btn4_Click(sender, e); break;
                case '5': this.btn5_Click(sender, e); break;
                case '6': this.btn6_Click(sender, e); break;
                case '7': this.btn7_Click(sender, e); break;
                case '8': this.btn8_Click(sender, e); break;
                case '9': this.btn9_Click(sender, e); break;
                case '0': this.btn0_Click(sender, e); break;
                case '+':this.btnPlus_Click(sender, e);break;
                case '-':this.btnMinus_Click(sender, e);break;
                case '*':this.btnMnozi_Click(sender, e);break;
                case '/':this.btnDeli_Click(sender, e);break;
                case '=':this.btnIzracunaj_Click(sender, e);break;
                case (char)13:this.btnIzracunaj_Click(sender, e);break;
                case (char)8:this.button2_Click(sender, e);break;
                default:
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case '1': this.btn1_Click(sender, e); break;
                case '2': this.btn2_Click(sender, e); break;
                case '3': this.btn3_Click(sender, e); break;
                case '4': this.btn4_Click(sender, e); break;
                case '5': this.btn5_Click(sender, e); break;
                case '6': this.btn6_Click(sender, e); break;
                case '7': this.btn7_Click(sender, e); break;
                case '8': this.btn8_Click(sender, e); break;
                case '9': this.btn9_Click(sender, e); break;
                case '0': this.btn0_Click(sender, e); break;
                case '+': this.btnPlus_Click(sender, e); break;
                case '-': this.btnMinus_Click(sender, e); break;
                case '*': this.btnMnozi_Click(sender, e); break;
                case '/': this.btnDeli_Click(sender, e); break;
                case '=': this.btnIzracunaj_Click(sender, e); break;
                case (char)13: this.btnIzracunaj_Click(sender, e); break;
                case (char)8: this.button2_Click(sender, e); break;
                default:
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1': this.btn1_Click(sender, e); break;
                case '2': this.btn2_Click(sender, e); break;
                case '3': this.btn3_Click(sender, e); break;
                case '4': this.btn4_Click(sender, e); break;
                case '5': this.btn5_Click(sender, e); break;
                case '6': this.btn6_Click(sender, e); break;
                case '7': this.btn7_Click(sender, e); break;
                case '8': this.btn8_Click(sender, e); break;
                case '9': this.btn9_Click(sender, e); break;
                case '0': this.btn0_Click(sender, e); break;
                case '+': this.btnPlus_Click(sender, e); break;
                case '-': this.btnMinus_Click(sender, e); break;
                case '*': this.btnMnozi_Click(sender, e); break;
                case '/': this.btnDeli_Click(sender, e); break;
                case '=': this.btnIzracunaj_Click(sender, e); break;
                case (char)13: this.btnIzracunaj_Click(sender, e); break;
                case (char)8: this.button2_Click(sender, e); break;
                default:
                    break;
            }
        }
       

        public void Ubaci(string rez,int n)
        {
            
            lista[n].Text=string.Empty;
            lista[n].Text=rez;

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

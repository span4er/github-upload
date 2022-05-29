using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
  

    public partial class Form1 : MetroSetForm
    {
        Number16 A, B;
        Button[] Operation = new Button[10];
        Button[] ArrButton = new Button[16];
        string znak = "";
        string chislo1;
        string chislo2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrButton[0] = button1;
            ArrButton[1] = button2;
            ArrButton[2] = button3;
            ArrButton[3] = button4;
            ArrButton[4] = button5;
            ArrButton[5] = button6;
            ArrButton[6] = button7;
            ArrButton[7] = button8;
            ArrButton[8] = button9;
            ArrButton[9] = button10;
            ArrButton[10] = button11;
            ArrButton[11] = button12;
            ArrButton[12] = button13;
            ArrButton[13] = button14;
            ArrButton[14] = button15;
            ArrButton[15] = button16;
            Operation[0] = button18; //*
            Operation[1] = button19; //+
            Operation[2] = button20; //-
            Operation[3] = button21; ///
            Operation[4] = button22; //<
            Operation[5] = button23; //>
            Operation[6] = button24; //<=
            Operation[7] = button25; //>=
            Operation[8] = button26; //!=
            Operation[9] = button27; //==


            for (int i = 0; i < 16; i++)
            {
                ArrButton[i].Tag = i;
                ArrButton[i].Click += Digit_Click;
            }

            for (int i = 0; i < 10; i++)
            {
                Operation[i].Click += Operation_Click;
            }
            chislo1 = "";
            chislo2 = "";
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(((Button)sender).Tag);
            textBox2.Text += ArrButton[i].Text;
        }
        private void Operation_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                int res = Convert.ToInt32(textBox2.Text, 16);
            }
            catch (Exception f)
            {
                clear();
                textBox1.Text = "Ошибка максимальное значение превышено";
                i = 1;
            }
            if (i == 0)
            {
                znak = ((Button)sender).Text;
                chislo1 = textBox2.Text;
                textBox2.Text = "";
                textBox1.Text = chislo1 + " " + znak + " ";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (textBox2.Text != "" && chislo1 != "")
            {
                try
                {
                    int res = Convert.ToInt32(textBox2.Text, 16);
                }
                catch (Exception f)
                {
                    clear();
                    textBox1.Text = "Ошибка максимальное значение превышено";
                    i = 1;
                }
                if (i == 0)
                {
                    chislo2 = textBox2.Text;
                    textBox1.Text += chislo2 + " = ";
                    A = new Number16(chislo1);
                    B = new Number16(chislo2);
                    string ans = "";
                    switch (znak)
                    {
                        case "+":
                            ans = (A + B).Chislo; break;
                        case "-":
                            ans = (A - B).Chislo; break;
                        case "*":
                            ans = (A * B).Chislo; break;
                        case "/":
                            ans = (A / B).Chislo; break;
                        case ">":
                            ans = (A > B).ToString(); break;
                        case "<":
                            ans = (A < B).ToString(); break;
                        case ">=":
                            ans = (A >= B).ToString(); break;
                        case "<=":
                            ans = (A <= B).ToString(); break;
                        case "==":
                            ans = (A == B).ToString(); break;
                        case "!=":
                            ans = (A != B).ToString(); break;
                    }
                    textBox1.Text += ans;
                    textBox2.Text = "";
                }
            }
            else
            {
                clear();
                textBox1.Text = "Ай ай ай";
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int i = 0;
            chislo1 = textBox2.Text;
            A = new Number16(chislo1);
            try
            {
                int a = Convert.ToInt32(chislo1, 16);
                i = 1;
            }
            catch (Exception f)
            {
                clear();
                textBox2.Text = "Превыщение возможностей";
            }
            if (i == 1)
            {
                A.From16to10();
                textBox2.Text = A.Chislo;
            }
            chislo1 = "";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            chislo1 = textBox2.Text;
            A = new Number16(chislo1);
            textBox2.Text = Convert.ToString(A.IsCorrect16());

        }

        private void вфвцфвфвToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void фцвфвцфвToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));


        }

        private void описаниеПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); // создаем объект типа Form2

            f.ShowDialog();
            /*if (f.ShowDialog() == DialogResult.OK) // вызов диалогового окна формы Form2
            {
                label1.Text = "Result = OK!";
            }
            else
            {
                label1.Text = "Result = Cancel!";
            }*/

        }

   
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            chislo1 = "";
            chislo2 = "";
            znak = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

    }

}
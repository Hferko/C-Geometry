using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Geometry
{
    public partial class Form1 : Form
    {
        szamolas szamol = new szamolas();
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        int c = 0;
        int r = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "";
            label1.Text = "      Add meg a kör sugarát:";
            label2.Text = "";
            textBox2.Visible = false;
            label3.Text = "";
            textBox3.Visible = false;
            pictureBox1.Image = Image.FromFile("kor.png");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "";
            label1.Text = " Add meg a téglalap egyik oldalát:";
            label2.Text = "    Kérem a másik oldalát:";            
            textBox2.Visible = true;
            label3.Text = "";
            textBox3.Visible = false;
            pictureBox1.Image = Image.FromFile("tlap.png");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "";
            label1.Text = " Add a háromszög első oldalát:";            
            label2.Text = "   Kérem a másik oldalát:";
            textBox2.Visible = true;            
            label3.Text = " Kérem a harmadik oldalát:";
            textBox3.Visible = true;
            pictureBox1.Image = Image.FromFile("harom.png");
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Itt egy egyenlő oldalú sokszögről van szó"; 
            label1.Text = " Milyen hosszú a sokszög egy oldala:";
            label2.Text = " Hány oldalú legyen a sokszög:";
            textBox2.Visible = true;
            label3.Text = "";
            textBox3.Visible = false;
            pictureBox1.Image = Image.FromFile("sok.png");
        }       
        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            label8.Text = "";
            label1.Text = "     Add meg a gömb sugarát:";
            label2.Text = "";
            textBox2.Visible = false;
            label3.Text = "";
            textBox3.Visible = false;
            pictureBox1.Image = Image.FromFile("gomb.png");
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "";
            label1.Text = " Add a téglatest élének hosszát:";
            label2.Text = "      Kérem a másik élét:";
            textBox2.Visible = true;
            label3.Text = " Kérem a harmadik élét:";
            textBox3.Visible = true;
            pictureBox1.Image = Image.FromFile("tegla.png");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Itt egy négyszög alapú egyenes gúláról lesz szó";
            label1.Text = " Add meg a gúla alapjának egyik hosszát:";
            label2.Text = " A gúla alapjának másik hossza:";
            textBox2.Visible = true;
            label3.Text = " Kérem a gúla magasságát:";
            textBox3.Visible = true;
            pictureBox1.Image = Image.FromFile("gula.png");
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "";
            label1.Text = " Kérem a henger alapkörének sugarát:";
            label2.Text = "   Add meg a henger magasságát:";
            textBox2.Visible = true;
            label3.Text = "";
            textBox3.Visible = false;
            pictureBox1.Image = Image.FromFile("henger.png");
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "";
            label1.Text = " Kérem a kúp alapkörének sugarát:";
            label2.Text = "   Add meg a kúp magasságát:";
            textBox2.Visible = true;
            label3.Text = "";
            textBox3.Visible = false;
            pictureBox1.Image = Image.FromFile("kup.png");
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "A szabályos hasáb két párhuzamos alapját azonos hosszúságú oldalak képzik";
            label1.Text = " Milyen hosszú az alap egy oldala:";
            label2.Text = " Hány oldalú legyen az alap:";
            textBox2.Visible = true;
            label3.Text = " Kérem a hasáb magasságát:";
            textBox3.Visible = true;
            pictureBox1.Image = Image.FromFile("hasab.png");
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Általános értelemben a tetraéder háromszög alapú gúla.";
            label1.Text = "Kérem a tetraéder egy élének hosszát:";
            label2.Text = "A szabályos tetraéder élének hosszai egyenlőek.";
            textBox2.Visible = false;
            label3.Text = "";
            textBox3.Visible = false;
            pictureBox1.Image = Image.FromFile("tetra.png");
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Egyenlő oldalú négyzet alapú két piramis egymásra fordítva";
            label1.Text = "Kérem az oktaéder egy élének hosszát:";
            label2.Text = "A szabályos oktaéder élének hosszai egyenlőek.";
            textBox2.Visible = false;
            label3.Text = "A szabályos oktaédernek 8 egyenlő oldalú háromszög lapja van.";
            textBox3.Visible = false;
            pictureBox1.Image = Image.FromFile("okta.png");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
            try
            {
                if (radioButton1.Checked == true)
                {                    
                    r = Convert.ToInt32(textBox1.Text);
                    label4.Text = " A kör kerülete K = " + szamol.korker(r);
                    label5.Text = " A kör területe T = " + szamol.korter(r);
                }
                else if (radioButton2.Checked == true)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    label4.Text = " A téglalap kerülete = " + szamol.negyker(a, b);
                    label5.Text = " A téglalap területe = " + szamol.negyter(a, b);
                }
                else if (radioButton3.Checked == true)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    c = Convert.ToInt32(textBox3.Text);
                    double aa = Math.Pow(a, 2), bb = Math.Pow(b, 2), cc = Math.Pow(c, 2);                                    

                    if (a + b > c && a + c > b && b + c > a)
                    {
                                                
                        if (a == b || a == c || c == b)
                        {
                            label6.Text = "Ez egyenlő szárú háromszög";
                            if (a == b && a == c && c == b)
                            {
                                label6.Text = "Ez egyenlő oldalú háromszög";
                            }
                        }
                        else if (aa + bb == cc || aa + cc == bb || cc + bb == aa)
                        {
                            label6.Text = "Ez derékszögű háromszög";
                        }
                        
                        label4.Text = " A háromszög kerülete: " + szamol.haromker(a, b, c);
                        label5.Text = " A háromszög területe: " + szamol.haromter(a, b, c);
                    }
                    else
                    {
                        MessageBox.Show("Két oldal összege rövidebb, mint a harmadik.\nÍgy nem szerkeszthetó a háromszög");
                    }
                }

                // sokszög
                else if (radioButton4.Checked == true)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    if (b == 4)
                    {
                        label8.Text = "Hiszen ez egy négyzet !";
                    }
                    if (b == 3)
                    {
                        label8.Text = "Ez egy egyenlő oldalú háromszög";
                    }
                    label4.Text = "A(z) "+b+"-szög belső szögeinek mértéke " + szamol.szog(a, b) + "°";
                    label5.Text = " A beírt kör sugara: " + szamol.beirtkor(a,b);
                    label6.Text = " A(z) " + b + " oldalú sokszög kerülete: " + a * b;
                    label7.Text = " A szabályos sokszög területe: " + szamol.sokszog(a, b);
                }

                else if (radioButton5.Checked == true)
                {
                    r = Convert.ToInt32(textBox1.Text);
                    label4.Text = " A gömb felszíne A = " + szamol.gombfelsz(r);
                    label5.Text = " A gömb térfogata V = "+ szamol.gombterf(r);
                }

                else if (radioButton6.Checked == true)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    c = Convert.ToInt32(textBox3.Text);
                    if (a == b && b==c)
                    {
                        label8.Text = "Hiszen ez egy kocka !";
                    }
                    label4.Text = " A téglatest felszíne A = " + szamol.teglafelsz(a, b, c);
                    label5.Text = " A téglatest térfogata V = " + szamol.teglaterf(a, b, c);                    
                }
                else if (radioButton7.Checked == true)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    c = Convert.ToInt32(textBox3.Text);
                    label4.Text = " A gúla alapjának területe = " + szamol.gulaalap(a, b);
                    label5.Text = " A gúla felszíne A = " + szamol.gulafelsz(a, b, c);
                    label6.Text = " A gúla térfogata V = " + szamol.gulaterf(a, b, c);
                    label7.Text = " Az oldaf élének hossza= " + szamol.gulaoldal(a, b, c);
                }
                else if (radioButton8.Checked == true)
                {
                    r = Convert.ToInt32(textBox1.Text);
                    a = Convert.ToInt32(textBox2.Text);
                    double P = szamol.palast(r, a);
                    double alap = szamol.korter(r);
                    label4.Text = " Az alapkör területe = " + alap;
                    label5.Text = " A henger palástja = " + P;
                    label6.Text = " A henger felszíne A = " + szamol.hengfelsz(P, alap);
                    label7.Text = " A henger térfogata V = " + szamol.hengterf(r, a);
                }
                else if (radioButton9.Checked == true)
                {
                    r = Convert.ToInt32(textBox1.Text);
                    a = Convert.ToInt32(textBox2.Text);
                    double P = szamol.kuppalast(r, a);
                    double alap = szamol.korter(r);
                    label4.Text = " Az alapkör területe = " + alap;
                    label5.Text = " A kúp palástja = " + P;
                    label6.Text = " A kúp felszíne A = " + szamol.kupfelsz(P, alap);
                    label7.Text = " A kúp térfogata V = " + (szamol.hengterf(r, a))/3;
                }
                else if (radioButton10.Checked == true)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    c = Convert.ToInt32(textBox3.Text);                    
                    double alap = szamol.sokszog(a, b);
                    label4.Text = " Az alap területe = " + alap;
                    label5.Text = " A hasáb palástja = "+ (a*b*c);
                    label6.Text = " A hasáb felszíne A = " + ((a*b*c)+(2*alap));
                    label7.Text = " A hasáb térfogata V = " + szamol.hasab(c, alap);
                }
                else if (radioButton11.Checked == true)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    label4.Text = " A tetraéder felszíne A = " + (a*a*Math.Sqrt(3));
                    label5.Text = " A tetraéder térfogata V = " + (Math.Pow(a, 3)*Math.Sqrt(2)/12);
                }
                else if (radioButton12.Checked == true)
                {
                    a = Convert.ToInt32(textBox1.Text);
                    label4.Text = " Az oktaéder felszíne A = " + (2*a * a * Math.Sqrt(3));
                    label5.Text = " Az  oktaéder térfogata V = " + (Math.Pow(a, 3) * Math.Sqrt(2) / 3);
                }

            }
            catch (Exception)
            {
                Console.Beep();
                MessageBox.Show("Kérem adjon egész számot");
            }
        }

        
    }
}

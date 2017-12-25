using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }    
        Hypotheses[] pozitifDizi = new Find_S.Hypotheses[50];
        Hypotheses hyeni = new Hypotheses();
        public int sayac = 1,dsayac=0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hypotheses h1 = new Hypotheses();
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" )
                MessageBox.Show("EKSIK ALAN BIRAKMAYINIZ!");
            else if (dsayac>=50)
            {
                MessageBox.Show("Max 50 Olumlu Hipotez Giriniz");
            }
            else
            {
                h1.hava = comboBox1.Text;
                h1.isi = comboBox2.Text;
                h1.nem = comboBox3.Text;
                h1.ruzgar = comboBox4.Text;
                h1.oyun = comboBox5.Text; 
                if (h1.oyun == "Oynanır")
                {  
                    listBox2.Items.Add(h1.hava + "   " + h1.isi + "   " + h1.nem + "   " + h1.ruzgar);
                    pozitifDizi[dsayac] = h1;
                    dsayac++;
                }
                else
                {
                    listBox3.Items.Add(h1.hava + "   " + h1.isi + "   " + h1.nem + "   " + h1.ruzgar + "   " + h1.oyun);
                }
            }
            
            
        }

        private void button5_Click (object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
                MessageBox.Show("Pozitif Hipotez Bulunmuyor!");
            else
            {
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("1.Adım: " + listBox2.Items[0].ToString());

                }
                else
                {
                    if (sayac == listBox2.Items.Count)
                        MessageBox.Show("En Genel Hipotez : " + pozitifDizi[sayac-1].hava + "   " + pozitifDizi[sayac-1].isi + "   " + pozitifDizi[sayac-1].nem + "   " + pozitifDizi[sayac-1].ruzgar);
                    else
                    {
                        if (pozitifDizi[sayac].hava == pozitifDizi[sayac - 1].hava)
                            hyeni.hava = pozitifDizi[sayac].hava.ToString();
                        else
                            hyeni.hava = "   ?   ";
                        if (pozitifDizi[sayac].isi == pozitifDizi[sayac - 1].isi)
                            hyeni.isi = pozitifDizi[sayac].isi.ToString();
                        else
                            hyeni.isi = "   ?   ";
                        if (pozitifDizi[sayac].nem == pozitifDizi[sayac - 1].nem)
                            hyeni.nem = pozitifDizi[sayac].nem.ToString();
                        else
                            hyeni.nem = "   ?   ";
                        if (pozitifDizi[sayac].ruzgar == pozitifDizi[sayac - 1].ruzgar)
                            hyeni.ruzgar = pozitifDizi[sayac].ruzgar.ToString();
                        else
                            hyeni.ruzgar = "   ?   ";
                        listBox1.Items.Add(sayac + 1 + ".Adım: " + hyeni.hava + "   " + hyeni.isi + "   " + hyeni.nem + "   " + hyeni.ruzgar);
                        pozitifDizi[sayac] = hyeni;
                        sayac++;
                    }
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(listBox2.Items.Count==0)
            {
                MessageBox.Show("Pozitif Hipotez Bulunmuyor!");
            }
            else
            {
                for (int i = 0; i <= listBox2.Items.Count; i++)
                {
                    if (listBox1.Items.Count == 0)
                    {
                        listBox1.Items.Add("1.Adım: " + listBox2.Items[0].ToString());

                    }
                    else
                    {
                        if (sayac == listBox2.Items.Count)
                            MessageBox.Show("En Genel Hipotez : " + hyeni.hava + "   " + hyeni.isi + "   " + hyeni.nem + "   " + hyeni.ruzgar);
                        else
                        {
                            if (pozitifDizi[sayac].hava == pozitifDizi[sayac - 1].hava)
                                hyeni.hava = pozitifDizi[sayac].hava.ToString();
                            else
                                hyeni.hava = "   ?   ";
                            if (pozitifDizi[sayac].isi == pozitifDizi[sayac - 1].isi)
                                hyeni.isi = pozitifDizi[sayac].isi.ToString();
                            else
                                hyeni.isi = "   ?   ";
                            if (pozitifDizi[sayac].nem == pozitifDizi[sayac - 1].nem)
                                hyeni.nem = pozitifDizi[sayac].nem.ToString();
                            else
                                hyeni.nem = "   ?   ";
                            if (pozitifDizi[sayac].ruzgar == pozitifDizi[sayac - 1].ruzgar)
                                hyeni.ruzgar = pozitifDizi[sayac].ruzgar.ToString();
                            else
                                hyeni.ruzgar = "   ?   ";
                            listBox1.Items.Add(sayac + 1 + ".Adım: " + hyeni.hava + "   " + hyeni.isi + "   " + hyeni.nem + "   " + hyeni.ruzgar);
                            pozitifDizi[sayac] = hyeni;
                            sayac++;
                        }
                    }
                }
            }
            
          
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Array.Clear(pozitifDizi,0,pozitifDizi.Count());
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            sayac = 1;
            dsayac = 0;
        }
    }
}

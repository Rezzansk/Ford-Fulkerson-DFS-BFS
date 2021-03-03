using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        static int musluk; //Grafikteki köşe noktası sayısı
        public int[,] graf;
        public int[,] graf_2;
        public int baslangic, bitis;
        Point vana1;
        Point vana2;

        public Form1()
        {
            InitializeComponent();
        }

        public void point_bul(int i, int j)
        {

        }
        public void vana_bul(int i, int j)
        {
            Point nokta1 = new Point(pictureBox1.Location.X + 24, pictureBox1.Location.Y + 24);
            Point nokta2 = new Point(pictureBox2.Location.X + 24, pictureBox2.Location.Y + 24);
            Point nokta3 = new Point(pictureBox3.Location.X + 24, pictureBox3.Location.Y + 24);
            Point nokta4 = new Point(pictureBox4.Location.X + 24, pictureBox4.Location.Y + 24);
            Point nokta5 = new Point(pictureBox5.Location.X + 24, pictureBox5.Location.Y + 24);
            Point nokta6 = new Point(pictureBox6.Location.X + 24, pictureBox6.Location.Y + 24);
            Point nokta7 = new Point(pictureBox7.Location.X + 24, pictureBox7.Location.Y + 24);
            Point nokta8 = new Point(pictureBox8.Location.X + 24, pictureBox8.Location.Y + 24);
            Point nokta9 = new Point(pictureBox9.Location.X + 24, pictureBox9.Location.Y + 24);
            Point nokta10 = new Point(pictureBox10.Location.X + 24, pictureBox10.Location.Y + 24);
            Point nokta11 = new Point(pictureBox11.Location.X + 24, pictureBox11.Location.Y + 24);
            Point nokta12 = new Point(pictureBox12.Location.X + 24, pictureBox12.Location.Y + 24);
            Point nokta13 = new Point(pictureBox13.Location.X + 24, pictureBox13.Location.Y + 24);
            Point nokta14 = new Point(pictureBox14.Location.X + 24, pictureBox14.Location.Y + 24);
            Point nokta15 = new Point(pictureBox15.Location.X + 24, pictureBox15.Location.Y + 24);
            Point nokta16 = new Point(pictureBox16.Location.X + 24, pictureBox16.Location.Y + 24);
            Point nokta17 = new Point(pictureBox17.Location.X + 24, pictureBox17.Location.Y + 24);
            Point nokta18 = new Point(pictureBox18.Location.X + 24, pictureBox18.Location.Y + 24);
            Point nokta19 = new Point(pictureBox19.Location.X + 24, pictureBox19.Location.Y + 24);
            Point nokta20 = new Point(pictureBox20.Location.X + 24, pictureBox20.Location.Y + 24);
            if (i == 1) vana1 = nokta1;
            else if (i == 2) vana1 = nokta2;
            else if (i == 3) vana1 = nokta3;
            else if (i == 4) vana1 = nokta4;
            else if (i == 5) vana1 = nokta5;
            else if (i == 6) vana1 = nokta6;
            else if (i == 7) vana1 = nokta7;
            else if (i == 8) vana1 = nokta8;
            else if (i == 9) vana1 = nokta9;
            else if (i == 10) vana1 = nokta10;
            else if (i == 1) vana1 = nokta11;
            else if (i == 12) vana1 = nokta12;
            else if (i == 13) vana1 = nokta13;
            else if (i == 14) vana1 = nokta14;
            else if (i == 15) vana1 = nokta15;
            else if (i == 16) vana1 = nokta16;
            else if (i == 17) vana1 = nokta17;
            else if (i == 18) vana1 = nokta18;
            else if (i == 19) vana1 = nokta19;
            else if (i == 20) vana1 = nokta20;
            if (j == 1) vana2 = nokta1;
            else if (j == 2) vana2 = nokta2;
            else if (j == 3) vana2 = nokta3;
            else if (j == 4) vana2 = nokta4;
            else if (j == 5) vana2 = nokta5;
            else if (j == 6) vana2 = nokta6;
            else if (j == 7) vana2 = nokta7;
            else if (j == 8) vana2 = nokta8;
            else if (j == 9) vana2 = nokta9;
            else if (j == 10) vana2 = nokta10;
            else if (j == 11) vana2 = nokta11;
            else if (j == 12) vana2 = nokta12;
            else if (j == 13) vana2 = nokta13;
            else if (j == 14) vana2 = nokta14;
            else if (j == 15) vana2 = nokta15;
            else if (j == 16) vana2 = nokta16;
            else if (j == 17) vana2 = nokta17;
            else if (j == 18) vana2 = nokta18;
            else if (j == 19) vana2 = nokta19;
            else if (j == 20) vana2 = nokta20;
        }

        public void yerlestir(int i, int j)
        {
            i = i + 1;
            j = j + 1;
            if (i == 1) pictureBox1.Image = imageList1.Images[1];
            else if (i == 2) pictureBox2.Image = imageList1.Images[1];
            else if (i == 3) pictureBox3.Image = imageList1.Images[1];
            else if (i == 4) pictureBox4.Image = imageList1.Images[1];
            else if (i == 5) pictureBox5.Image = imageList1.Images[1];
            else if (i == 6) pictureBox6.Image = imageList1.Images[1];
            else if (i == 7) pictureBox7.Image = imageList1.Images[1];
            else if (i == 8) pictureBox8.Image = imageList1.Images[1];
            else if (i == 9) pictureBox9.Image = imageList1.Images[1];
            else if (i == 10) pictureBox10.Image = imageList1.Images[1];
            else if (i == 1) pictureBox11.Image = imageList1.Images[1];
            else if (i == 12) pictureBox12.Image = imageList1.Images[1];
            else if (i == 13) pictureBox13.Image = imageList1.Images[1];
            else if (i == 14) pictureBox14.Image = imageList1.Images[1];
            else if (i == 15) pictureBox15.Image = imageList1.Images[1];
            else if (i == 16) pictureBox16.Image = imageList1.Images[1];
            else if (i == 17) pictureBox17.Image = imageList1.Images[1];
            else if (i == 18) pictureBox18.Image = imageList1.Images[1];
            else if (i == 19) pictureBox19.Image = imageList1.Images[1];
            else if (i == 20) pictureBox20.Image = imageList1.Images[1];
            if (j == 1) pictureBox1.Image = imageList1.Images[2];
            else if (j == 2) pictureBox2.Image = imageList1.Images[2];
            else if (j == 3) pictureBox3.Image = imageList1.Images[2];
            else if (j == 4) pictureBox4.Image = imageList1.Images[2];
            else if (j == 5) pictureBox5.Image = imageList1.Images[2];
            else if (j == 6) pictureBox6.Image = imageList1.Images[2];
            else if (j == 7) pictureBox7.Image = imageList1.Images[2];
            else if (j == 8) pictureBox8.Image = imageList1.Images[2];
            else if (j == 9) pictureBox9.Image = imageList1.Images[2];
            else if (j == 10) pictureBox10.Image = imageList1.Images[2];
            else if (j == 11) pictureBox11.Image = imageList1.Images[2];
            else if (j == 12) pictureBox12.Image = imageList1.Images[2];
            else if (j == 13) pictureBox13.Image = imageList1.Images[2];
            else if (j == 14) pictureBox14.Image = imageList1.Images[2];
            else if (j == 15) pictureBox15.Image = imageList1.Images[2];
            else if (j == 16) pictureBox16.Image = imageList1.Images[2];
            else if (j == 17) pictureBox17.Image = imageList1.Images[2];
            else if (j == 18) pictureBox18.Image = imageList1.Images[2];
            else if (j == 19) pictureBox19.Image = imageList1.Images[2];
            else if (j == 20) pictureBox20.Image = imageList1.Images[2];
        }

        private void hat_dose(int i, int j)
        {
            vana_bul(i, j);
            Graphics grafik = CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.Gray, 4);
            grafik.DrawLine(kalem, vana1, vana2);
        }

        public void hat_su(int i, int j)
        {
            i = i + 1;
            j = j + 1;
            vana_bul(i, j);
            Graphics grafik = CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.Blue, 4);
            grafik.DrawLine(kalem, vana1, vana2);
        }

        public void hat_kapa(int i, int j)
        {
            i = i + 1;
            j = j + 1;
            vana_bul(i, j);
            Graphics grafik = CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.Red, 4);
            grafik.DrawLine(kalem, vana1, vana2);
        }
        public void oran_yaz(int i, int j, int[,] graf_4, bool[,] kontrol)
        {
            vana_bul(i + 1, j + 1);
            int temp;
            var midX = (vana1.X + vana2.X + 20) / 2;
            var midY = (vana1.Y + vana2.Y + 0) / 2;
            Point merkez = new Point(midX, midY);
            if (graf_4[i, j] > graf[i, j])
            {
                temp = graf_4[i, j] - graf[i, j];
                temp = graf[i, j] - temp;
            }
            else
            {
                temp = graf_4[i, j];
            }
            Graphics grafik = CreateGraphics();
            String yuzde = ("" + temp + " / " + graf[i, j]); 
            grafik.DrawString(yuzde, new Font("Tahoma", 8), Brushes.Black, midX, midY);
        }

        public void oran_goster(int[,] son_graf)
        {
            int i, j;
            bool[,] kontrol = new bool[musluk,musluk];
            int temp = 0;

            for (i = 0; i < musluk; i++)
                for (j = 0; j < musluk; j++)
                    kontrol[i, j] = false;

            for (i = 0; i < musluk; i++)
            {
                for (j = 0; j < musluk; j++)
                {
                    if (graf[i, j] > 0 && kontrol[i, j] == false)
                    {
                        kontrol[i, j] = true;
                        kontrol[j, i] = true;
                        oran_yaz(i, j, son_graf, kontrol);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musluk = Convert.ToInt32(textBox1.Text);
            baslangic = Convert.ToInt32(textBox2.Text) - 1;
            bitis = Convert.ToInt32(textBox3.Text) - 1;

            graf = new int[musluk, musluk];
            int i = 0, j = 0;

            for (i = 0; i < musluk; i++)
            {
                for (j = 0; j < musluk; j++)
                {
                    graf[i, j] = 0;
                    Console.Write(graf[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for ( i = 1; i <= musluk; i++)
            {
                if (i == 1) { label1.Visible = true; pictureBox1.Visible = true;  }
                else if (i == 2) { label2.Visible = true; pictureBox2.Visible = true;  }
                else if (i == 3) { label3.Visible = true; pictureBox3.Visible = true;  }
                else if (i == 4) { label4.Visible = true; pictureBox4.Visible = true;  }
                else if (i == 5) { label5.Visible = true; pictureBox5.Visible = true;  }
                else if (i == 6) { label6.Visible = true; pictureBox6.Visible = true;  }
                else if (i == 7) { label7.Visible = true; pictureBox7.Visible = true;  }
                else if (i == 8) { label8.Visible = true; pictureBox8.Visible = true;  }
                else if (i == 9) { label9.Visible = true; pictureBox9.Visible = true;  }
                else if (i == 10) { label10.Visible = true; pictureBox10.Visible = true;  }
                else if (i == 11) { label11.Visible = true; pictureBox11.Visible = true;  }
                else if (i == 12) { label12.Visible = true; pictureBox12.Visible = true;  }
                else if (i == 13) { label13.Visible = true; pictureBox13.Visible = true;  }
                else if (i == 14) { label14.Visible = true; pictureBox14.Visible = true;  }
                else if (i == 15) { label15.Visible = true; pictureBox15.Visible = true;  }
                else if (i == 16) { label16.Visible = true; pictureBox16.Visible = true;  }
                else if (i == 17) { label17.Visible = true; pictureBox17.Visible = true;  }
                else if (i == 18) { label18.Visible = true; pictureBox18.Visible = true;  }
                else if (i == 19) { label19.Visible = true; pictureBox19.Visible = true;  }
                else if (i == 20) { label20.Visible = true; pictureBox20.Visible = true;  }
            }

            yerlestir(baslangic, bitis);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox4.Text);
            int j = Convert.ToInt32(textBox5.Text);
            int k = Convert.ToInt32(textBox6.Text);

            hat_dose(i,j);

            if (i != j)
            {
                i = i - 1;
                j = j - 1;
                graf[i, j] = k;
                graf[j, i] = k;
            }
        }

        public void oncelik(int basla, bool[] kontrol)
        {
            int k;
            kontrol[basla] = true;             // dfs öncelik algoritması
            for (k = 0; k < musluk; k++)
            {
                if (kontrol[k] == false && graf_2[basla, k] > 0)
                {
                    oncelik(k, kontrol);
                }
            }
        }

        public void akis_bul(int baslangic, int bitis)
        {
            baslangic = this.baslangic;
            bitis = this.bitis;
            int i, j;

            graf_2 = new int[musluk, musluk];
            graf_2 = graf.Clone() as int[,];

            for (i = 0; i < musluk; i++)
            {
                for (j = 0; j < musluk; j++)
                {
                    Console.Write(graf[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[] tut = new int[musluk];
            int maximum_f = 0;
            bool[] kontrol = new bool[musluk];
            List<int> liste = new List<int>();             /// BFS = SIĞ ÖNCELİKLİ ARAMA yap

            while (true)
            {

                for (j = 0; j < musluk; j++)
                    kontrol[j] = false;

                kontrol[baslangic] = true;
                tut[baslangic] = -1;
                liste.Add(baslangic);

                int temp = liste.Count; // List Nesnesinin Uzunluğunu Alma
                while ( 0 != temp )   
                {
                    i = liste[0];
                    liste.RemoveAt(0);    // ilk sıradaki değeri siler

                    for (j= 0; j < musluk; j++)
                    {
                        if (graf_2[i, j] > 0 && kontrol[j] == false )  // kontrol edilmemiş ve matris sıfırdan büyükse yani boru varsa
                        {
                            kontrol[j] = true;
                            liste.Add(j);
                            tut[j] = i;
                        }
                    }
                    temp = liste.Count;
                }

                int temp_f;

                if (kontrol[bitis] == true)
                {
                    temp_f = int.MaxValue;
                    j = bitis;
                    while (j != baslangic)
                    {
                        i = tut[j];
                        temp_f = Math.Min(temp_f, graf_2[i, j]);
                        j = tut[j];
                    }

                    j = bitis;
                    while (j != baslangic)
                    {
                        i = tut[j];
                        graf_2[i, j] -= temp_f; 
                        graf_2[j, i] += temp_f; 
                        System.Threading.Thread.Sleep(700);
                        hat_su(i, j);
                        j = tut[j];
                    }
                    maximum_f = maximum_f + temp_f;
                }
                else
                    break;
            }
            for (i = 0; i < musluk; i++)
            {
                for (j = 0; j < musluk; j++)
                {
                    Console.Write(graf_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            oran_goster(graf_2);
            label27.Text = "Maksimum Akış Kapasitesi(Max. Flow): " + Convert.ToString(maximum_f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int vana_1, vana_2;
            bool[] kontrol = new bool[musluk];

            oncelik(baslangic, kontrol);

            for (vana_1 = 0; vana_1 < musluk; vana_1++)            //min cut algoritması
            {
                for (vana_2 = 0; vana_2 < musluk; vana_2++)
                {
                    if (kontrol[vana_1] == true && kontrol[vana_2] == false && graf[vana_1, vana_2] > 0)
                    {
                        hat_kapa(vana_1, vana_2);
                        label28.Text = label28.Text + String.Format((vana_1 + 1) + ". ve " + (vana_2 + 1) + ".arası kapatildi.") + "\n";
                        Console.WriteLine(vana_1 + " - " + vana_2);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            akis_bul(baslangic, bitis);
        }
    }

}
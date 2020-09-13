using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Pr_InformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listBox1Adı.Items.Add(textBox1Ad.Text);
            listBox2Marka.Items.Add(textBox2Marka.Text);
            listBox3Fiyat.Items.Add(textBox3Fiyat.Text);
            kaydet();
        }

        void kaydet()
        {

            FileStream fsadı=new FileStream("C:/Kayıtlar/adı.txt", FileMode.Create, FileAccess.Write);
            StreamWriter swadı = new StreamWriter(fsadı);
            for(int i=0; i< listBox1Adı.Items.Count; i++)
            {

                swadı.WriteLine(listBox1Adı.Items [i].ToString());

            }
            swadı.Close();
            fsadı.Close();
            

            FileStream fsmarka = new FileStream("C:/Kayıtlar/marka.txt", FileMode.Create, FileAccess.Write);
            StreamWriter swmarka = new StreamWriter(fsmarka);
            for(int j=0; j<listBox2Marka.Items.Count; j++)
            {

                swmarka.WriteLine(listBox2Marka.Items [j].ToString());

            }
            swmarka.Close();
            fsmarka.Close();
            

            FileStream fsfiyat =new FileStream("C:/Kayıtlar/fiyat.txt", FileMode.Create, FileAccess.Write);
            StreamWriter swfiyat = new StreamWriter(fsfiyat);
            for(int s=0; s<listBox3Fiyat.Items.Count; s++)
            {

                swfiyat.WriteLine(listBox3Fiyat.Items[s].ToString());

            }
            swfiyat.Close();
            fsfiyat.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fsadıal = new FileStream("C:/Kayıtlar/adı.txt", FileMode.Open, FileAccess.Read);
            StreamReader swadıal = new StreamReader(fsadıal);
            string adı = swadıal.ReadLine();
            while (adı !=null)
            {

                listBox1Adı.Items.Add(adı);
                adı = swadıal.ReadLine();


            }
            swadıal.Close();
            fsadıal.Close();

            FileStream fsmarkaal = new FileStream("C:/Kayıtlar/marka.txt", FileMode.Open, FileAccess.Read);
            StreamReader swmarkaal = new StreamReader(fsmarkaal);
            string marka = swmarkaal.ReadLine();
            while(marka !=null)
            {
                listBox2Marka.Items.Add(marka);
                marka = swmarkaal.ReadLine(); 

            }
            swmarkaal.Close();
            fsmarkaal.Close();

            FileStream fsfiyatal = new FileStream("C:/Kayıtlar/fiyat.txt", FileMode.Open, FileAccess.Read);
            StreamReader swfiyatal = new StreamReader(fsfiyatal);
            string fiyat = swfiyatal.ReadLine();
            while(fiyat !=null)
            {

                listBox3Fiyat.Items.Add(fiyat);
                fiyat = swfiyatal.ReadLine();

            }
            swfiyatal.Close();
            fsfiyatal.Close();
        }

        private void ListBox1Adı_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2Marka.SelectedIndex = listBox1Adı.SelectedIndex;
            listBox3Fiyat.SelectedIndex = listBox1Adı.SelectedIndex;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int a = listBox1Adı.SelectedIndex;
            listBox1Adı.Items.RemoveAt(a);
            listBox2Marka.Items.RemoveAt(a);
            listBox3Fiyat.Items.RemoveAt(a);
            kaydet();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int a = listBox1Adı.SelectedIndex;
            listBox1Adı.Items[a] = textBox1Ad.Text;
            listBox2Marka.Items[a] = textBox2Marka.Text;
            listBox3Fiyat.Items[a] = textBox3Fiyat.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close(); 
        }

        private void textBox1Ad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

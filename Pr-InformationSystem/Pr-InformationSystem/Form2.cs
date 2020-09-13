using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_InformationSystem
{
    public partial class Form2 : Form
    {

        public Form2() => InitializeComponent();

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader streamRader = File.OpenText(@"C:\Kayıtlar\adı,fiyat,marka");
            string strRe;
            while ((strRe=streamRader.ReadLine())!=null)
            {
                listBox4.Items.Add(strRe);

            }

            streamRader.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2cls_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, turkceYanlis, matDogru, matYanlis, turkceNet, matNet, turkcePuan, matPuan;
            turkceDogru = Convert.ToDouble(textBox1.Text);
            turkceYanlis = Convert.ToDouble(textBox2.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));
            textBox3.Text = turkceNet.ToString();
            turkcePuan = (turkceNet * 100);
            textBox4.Text = turkcePuan.ToString();
            matDogru = Convert.ToDouble(textBox5.Text);
            matYanlis = Convert.ToDouble(textBox6.Text);
            matNet = (matDogru -(matYanlis /4));
            textBox7.Text = matNet.ToString();
            matPuan = (matNet * 125);
            textBox8.Text = matPuan.ToString();
        }
    }
   }

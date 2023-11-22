using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Csharp_Gui_Allfariz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilaiharian, nilaimid, nilaiuas;
            double ratanilai;

            nilaiharian = int.Parse(textBox3.Text);
            nilaimid = int.Parse(textBox4.Text);
            nilaiuas = int.Parse(textBox5.Text);
            ratanilai = ((2 * nilaiharian) + (3 * nilaimid) + (5 * nilaiuas)) / 10;

            if (ratanilai <= 70)
            {
                if (radioButton1.Checked)
                    richTextBox1.Text = textBox1.Text + " Dengan nomor absen = " + textBox2.Text + " Jurusan " + radioButton1.Text + " TIDAK LULUS mata pelajaran " + comboBox1.Text + " dengan nilai " + Convert.ToString(ratanilai);

                if (radioButton2.Checked)
                    richTextBox1.Text = textBox1.Text + " Dengan nomor absen = " + textBox2.Text + " Jurusan " + radioButton2.Text + " TIDAK LULUS  mata pelajaran " + comboBox1.Text + " dengan nilai " + Convert.ToString(ratanilai);
                if (radioButton3.Checked)
                    richTextBox1.Text = textBox1.Text + " Dengan nomor absen = " + textBox1.Text + " Jurusan " + radioButton3.Text + " TIDAK LULUS  mata pelajaran " + comboBox1.Text + " dengan nilai " + Convert.ToString(ratanilai);
            }
            else
            {
                if (radioButton1.Checked)
                    richTextBox1.Text = textBox1.Text + " Dengan nomor absen = " + textBox2.Text + " Jurusan " + radioButton1.Text + " LULUS mata pelajaran " + comboBox1.Text + " dengan nilai " + Convert.ToString(ratanilai);

                if (radioButton2.Checked)
                    richTextBox1.Text = textBox1.Text + " Dengan nomor absen = " + textBox2.Text + " Jurusan " + radioButton2.Text + " LULUS mata pelajaran " + comboBox1.Text + " dengan nilai " + Convert.ToString(ratanilai);

                if (radioButton3.Checked)
                    richTextBox1.Text = textBox1.Text + " Dengan nomor absen = " + textBox2.Text + " Jurusan " + radioButton3.Text + " LULUS mata pelajaran " + comboBox1.Text + " dengan nilai " + Convert.ToString(ratanilai);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            radioButton1.Checked = true; radioButton2.Checked = false; radioButton3.Checked = false;
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            richTextBox1.Text = " ";
        }
    }
}
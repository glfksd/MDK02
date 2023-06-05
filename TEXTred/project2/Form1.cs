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


namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            
                if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
                {
                    richTextBox.Clear(); //Очищаем richTextBox
                    openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                    string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                    richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBo
                }

            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            
if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
                
{
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
                
}
            richTextBox.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void левыйКрайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.DeselectAll();
        }

        private void центрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.DeselectAll();
        }

        private void правыйКрайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox.DeselectAll();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox.ForeColor;
            if(MyDialog.ShowDialog()== DialogResult.OK)
            {
                richTextBox.ForeColor= MyDialog.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox.Font;
            fontDialog1.Color = richTextBox.ForeColor;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.Font = fontDialog1.Font;
                richTextBox.ForeColor= fontDialog1.Color;
            }

        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }
    }
}

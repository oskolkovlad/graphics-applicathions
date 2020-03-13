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

namespace ControlElements
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile(@"D:/Media/Images/JOKER/OxsPMp2VGr4.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            webBrowser1.Url = new Uri("https://www.google.com");
            button1.Click += button1_Click;


            imageList1.Images.Add(Image.FromFile(@"D:/Media/Images/JOKER/OxsPMp2VGr4.jpg"));

            notifyIcon1.Click += notifyIcon1_Click;
            ShowInTaskbar = false;
            notifyIcon1.Text = "Показать форму!";
            notifyIcon1.BalloonTipTitle = "Уведомление";
            notifyIcon1.BalloonTipText = "Нажми, чтобы открыть окно...";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(5000);


            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = @"Q:/Projects/Learn/Graphics_applications/1_WindowsForms/ControlElements/bin/Debug";
            saveFileDialog1.InitialDirectory = @"Q:/Projects/Learn/Graphics_applications/1_WindowsForms/ControlElements/bin/Debug";
            saveFileDialog1.OverwritePrompt = true;


            textBox3.Validating += textBox3_Validating;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            errorProvider1.BlinkRate = 1000;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = openFileDialog1.FileName;
            string text = File.ReadAllText(fileName);
            textBox2.Text = text;
            MessageBox.Show("Файл открыт");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = saveFileDialog1.FileName;
            string text = textBox2.Text;
            File.WriteAllText(fileName, text);
            MessageBox.Show("Файл сохранен");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //if (textBox3.Text.Length > 10)
            //{
            //    errorProvider1.SetError(textBox3, "Слишком много");
            //}
            //else if (textBox3.Text.Length < 3)
            //{
            //    errorProvider1.SetError(textBox3, "Слишком мало");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 10)
            {
                errorProvider1.SetError(textBox3, "Слишком много");
            }
            else if (textBox3.Text.Length < 3)
            {
                errorProvider1.SetError(textBox3, "Слишком мало");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}

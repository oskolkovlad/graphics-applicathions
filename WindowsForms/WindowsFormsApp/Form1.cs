using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // По умолчанию здесь есть только конструктор формы, в котором просто
            // вызывается метод InitializeComponent(), объявленный в файле дизайнера Form1.Designer.cs.
            InitializeComponent();

            Text = "Hello WORLD";
            Size = new Size(1000, 1000);
            StartPosition = FormStartPosition.CenterParent;
            Opacity = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();

            MessageBox.Show("Hello World!");

            Form form2 = new Form2(this);
            form2.Show();
        }
    }
}

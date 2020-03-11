using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contaibers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Text = "Добавленная кнопка";
            button1.Location = new Point(10, 10);
            button1.Width = 160;
            Controls.Add(button1);
        }
    }
}

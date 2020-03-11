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
        private Point moveStart;

        public Form1()
        {
            // По умолчанию здесь есть только конструктор формы, в котором просто
            // вызывается метод InitializeComponent(), объявленный в файле дизайнера Form1.Designer.cs.
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            Text = "Hello WORLD";
            //Size = new Size(1000, 1000);
            //StartPosition = FormStartPosition.CenterParent;
            Opacity = 100;

            Button button2 = new Button()
            {
                Location = new Point(Width / 3, Width / 3),
                Text = "Закрыть"
            };
            button2.Click += button1_Click;
            Controls.Add(button2);

            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;

            //Load += LoadEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            // создаем эллипс с высотой и шириной формы
            graphicsPath.AddEllipse(0, 0, Width, Height);

            // создаем эллипс с высотой и шириной формы
            Region region = new Region(graphicsPath);
            Region = region;
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // получаем новую точку положения формы
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                // устанавливаем положение формы
                Location = new Point(Location.X + deltaPos.X, Location.Y + deltaPos.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form form1 = new Form1();
            //form1.Show();

            //MessageBox.Show("Hello World!");

            //Form form2 = new Form2(this);
            //form2.Show();

            Close();
        }
    }
}

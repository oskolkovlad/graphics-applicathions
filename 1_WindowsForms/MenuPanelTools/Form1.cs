using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPanelTools
{
    public partial class Form1 : Form
    {
        ToolStripLabel l1;
        ToolStripLabel l2;
        ToolStripLabel l3;

        string buffer;

        public Form1()
        {
            InitializeComponent();

            toolStrip1.Items.Add("ToolStrip");
            toolStrip1.ShowItemToolTips = true;
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.CanOverflow = true;

            ToolStripComboBox cb = new ToolStripComboBox("Gang");
            ToolStripButton button = new ToolStripButton("Button");
            ToolStripDropDownButton db = new ToolStripDropDownButton("Drop");
            ToolStripSplitButton sb = new ToolStripSplitButton("Split");
            ToolStripSeparator separator = new ToolStripSeparator();
            
            toolStrip1.Items.Add(cb);
            toolStrip1.Items.Add(button);
            toolStrip1.Items.Add(separator);
            toolStrip1.Items.Add(db);
            toolStrip1.Items.Add(sb);


            //************************************************************************************//


            ToolStripMenuItem menuItem = new ToolStripMenuItem("File");
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Open");
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Save");

            menuItem1.ShortcutKeys = Keys.Control | Keys.O;
            menuItem2.CheckOnClick = true;
            menuItem.DropDownItems.Add(menuItem1);
            menuItem.DropDownItems.Add(menuItem2);

            menuStrip1.Items.Add(menuItem);
            menuStrip1.Items.Add(separator);
            menuStrip1.Items.Add(db);


            //************************************************************************************//

            l1 = new ToolStripLabel();
            l2 = new ToolStripLabel();
            l3 = new ToolStripLabel();

            l1.Text = "Текущие дата и время: ";

            statusStrip1.Items.Add(l1);
            statusStrip1.Items.Add(l2);
            statusStrip1.Items.Add(l3);

            timer1.Interval = 1000;
            timer1.Tick += timer_Tick;
            timer1.Start();


            //************************************************************************************//


            ToolStripMenuItem copy = new ToolStripMenuItem("Копировать");
            ToolStripMenuItem paste = new ToolStripMenuItem("Вставить");

            contextMenuStrip1.Items.Add(copy);
            contextMenuStrip1.Items.Add(paste);

            textBox1.ContextMenuStrip = contextMenuStrip1;

            copy.Click += copy_Click;
            paste.Click += paste_Click;

        }


        private void timer_Tick(object sender, EventArgs e)
        {
            l2.Text = DateTime.Now.ToLongDateString();
            l3.Text = DateTime.Now.ToLongTimeString();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            buffer = textBox1.SelectedText;
        }

        private void paste_Click(object sender, EventArgs e)
        {
            textBox1.Paste(buffer);
        }
    }
}

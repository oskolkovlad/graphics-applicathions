using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containers
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            tableLayoutPanel1.RowStyles[0].SizeType = SizeType.AutoSize;
            tableLayoutPanel1.RowStyles[0].Height = 50;

        }
    }
}

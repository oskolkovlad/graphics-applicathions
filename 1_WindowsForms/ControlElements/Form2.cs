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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listView1.SmallImageList = imageList1;

            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.BeforeSelect += treeView1_BeforeSelect;

            FillDriveNodes();

            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Scroll += trackBar1_Scroll;

            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;

            string[] files = Directory.GetFiles(path);

            foreach(var f in files)
            {
                ListViewItem item = new ListViewItem();
                item.Text = f.Remove(0, f.LastIndexOf('\\') + 1);
                item.ImageIndex = 0;
                listView1.Items.Add(item);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;

            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetFiles(e.Node.FullPath);

                    if(dirs != null)
                    {
                        foreach(var d in dirs)
                        {
                            TreeNode item = new TreeNode(new DirectoryInfo(d).Name);
                            FillTreeNode(item, d);
                            e.Node.Nodes.Add(item);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;

            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);

                    if (dirs != null)
                    {
                        foreach (var d in dirs)
                        {
                            TreeNode item = new TreeNode(new DirectoryInfo(d).Name);
                            FillTreeNode(item, d);
                            e.Node.Nodes.Add(item);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDriveNodes()
        {
            try
            {
                foreach(var drive in DriveInfo.GetDrives())
                {
                    TreeNode treeNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(treeNode, drive.Name);
                    treeView1.Nodes.Add(treeNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillTreeNode(TreeNode node, string dir)
        {
            try
            {
                string[] dirs = Directory.GetFiles(dir);
                foreach (var d in dirs)
                {
                    TreeNode item = new TreeNode();
                    item.Text = d.Remove(0, d.LastIndexOf('\\') + 1);
                    node.Nodes.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }
    }
}

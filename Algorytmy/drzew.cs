using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy
{
    public partial class drzew : Form
    {
        public drzew()
        {
            InitializeComponent();
            //InitializeTreeView();
        }
        Drzewo tree1 = new Drzewo(0);
        void ShowNode(Wezel node, TreeNode treeNode)
        {
            treeNode.Text += node.wartosc;
            if (node.lewe != null)
            {
                ShowNode(node.lewe, treeNode.Nodes.Add("Lewe: "));
            }
            if (node.prawe != null)
            {
                ShowNode(node.prawe, treeNode.Nodes.Add("Prawe: "));
            }
        }
        void Show(Drzewo tree)
        {
            ShowNode(tree.korzen, treeView1.Nodes.Add("Korzen: "));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            treeView1.BeginUpdate(); // aktualiowanie zawartosci drzewa
            tree1.Push(x);
            treeView1.Nodes.Clear();
            Show(tree1);
            treeView1.ExpandAll();
            treeView1.EndUpdate();
            textBox1.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            tree1.Pop();
            treeView1.Nodes.Clear();
            Show(tree1);
            treeView1.ExpandAll();
            treeView1.EndUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

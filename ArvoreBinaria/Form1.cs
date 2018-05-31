using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ArvoreBinaria.Node;

namespace ArvoreBinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert(12);
            insert(4);
            insert(8);
            insert(2);
            insert(6);
            insert(16);
            textBox1.Text = preOrdem(root);
            textBox2.Text = posOrdem(root);
            preOrdem(root);
        }
    }
}

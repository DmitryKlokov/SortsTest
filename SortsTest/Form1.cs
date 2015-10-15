using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> li = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 23; i++)
            {
                li.Add(r.Next(0, 344));
            }
            foreach(int i in li)
            {
                richTextBox1.Text+=i.ToString()+" ";
            }
            richTextBox1.Text+="\n";
            GenericSortBubble<int> gsb = new GenericSortBubble<int>();
            li = gsb.Sort(li);
            foreach(int i in li)
            {
                richTextBox1.Text+=i.ToString()+" ";
            }
            richTextBox1.Text+="\n";
        }
    }
}

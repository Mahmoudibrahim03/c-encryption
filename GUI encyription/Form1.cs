using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_encyription
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9]*$") && textBox1.Text.Length == 0)
            {
                e.Handled = true;
                toolTip1.Show("just number allowed here",textBox1, 5, textBox2.Height - 2, 500);
            }
           
        }

        public void textBox2_KeyPress(object sender, KeyPressEventArgs e)

        {
            string key = textBox1.Text; // key
            string data = textBox2.Text; // data
           Queue<int> result = new Queue<int>();

            for (int i = 0; i <= data.Length; i++)
            {
                result.Enqueue(key[data[i]]);
            }
            foreach (int s in result)
                textBox3.Text += s.ToString();
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9]*$"))
            {
                e.Handled = true;
                toolTip1.Show("just number allowed here",textBox2,5,textBox2.Height-2,500);
                data = textBox2.Text;
            }

        }

    }
}

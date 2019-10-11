using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Froms
{
    public partial class Form2 : Form
    {
        private TextBox textBox;
        public Form2(TextBox text)
        {
            InitializeComponent();
            textBox = text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "Hello";
        }
    }
}

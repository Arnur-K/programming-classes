using System;
using System.IO;
using System.Windows.Forms;

namespace InvoiceApp
{
    public partial class Form1 : Form
    {
        private string _path = @"C:\Users\W59513\Desktop\Invoice1.txt"
        public Form1()
        {
            InitializeComponent();
            statusLabel.Text = "Press Open file to open file";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var content = File.ReadAllLines(_path);
        }
    }
}

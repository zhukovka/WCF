using BinaryConverterUI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverterUI
{
    public partial class Form1 : Form
    {
        private BinaryConverterServiceClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(inputBox.Text);
                string binary = client.GetBinary(m);
                int oneCount = client.GetOneCount(m);
                MessageBox.Show($"Binary of {m} is {binary}. It has {oneCount} of 1");
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new BinaryConverterServiceClient();
        }
    }
}

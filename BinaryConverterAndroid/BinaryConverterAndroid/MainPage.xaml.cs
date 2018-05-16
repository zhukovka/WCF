using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BinaryConverterAndroid
{
	public partial class MainPage : ContentPage
	{
        BinaryConverterLib.BinaryConverterLib lib;

        public MainPage()
		{
			InitializeComponent();
            lib = new BinaryConverterLib.BinaryConverterLib();
            string myIP = lib.getMyIP();
            addr.Text = myIP;
        }

        void OnCalculate(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(input.Text);
                string res = lib.RequestToBinaryConverter(addr.Text, m);
                output.Text = $"Binary of {m} is: {res}";
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
        }
	}
}

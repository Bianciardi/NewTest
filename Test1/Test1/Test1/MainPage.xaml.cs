using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        void OnButtonClicked(object sender, Exception args)
        {
            lblSaluto.Text = "Buongiorno";
            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum1.Text);
            Calc c = new Calc();
            int resp = c.Add(a, b);
            lblRisultato.Text = resp.ToString();
        }
    }
}

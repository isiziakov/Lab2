using Lab2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //Content = new StackLayout()
            //{
            //    Children = { new Label() { Text = "Test" } }
            //};
            InitializeComponent();
            BindingContext = new MainViewModel(); 
        }
    }
}

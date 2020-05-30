using Lab2_Xam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab2_Xam.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentDetails : ContentPage
    {
        public StudentDetails(Student student)
        {
            InitializeComponent();
            BindingContext = student;
        }
    }
}
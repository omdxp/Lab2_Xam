using Lab2_Xam.Models;
using Lab2_Xam.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab2_Xam.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Student> Students { get; set; }

        private Student selectedStudent;
        public Student SelectedStudent
        {
            get
            {
                return selectedStudent;
            }
            set
            {
                if (selectedStudent != value)
                {
                    selectedStudent = value;
                    OnPropertyChanged();
                }
            }
        }
        public MainPageViewModel()
        {
            Students = new ObservableCollection<Student>();
            // Initialize the list of students
            Students = new ObservableCollection<Student>();
            Students.Add(new Student { Name = "Omar", Surname = "Belghaouti", StudentID = 1 });
            Students.Add(new Student { Name = "Nail", Surname = "Kamilov", StudentID = 2 });
            Students.Add(new Student { Name = "Jose David Lopez", Surname = "Piqueras", StudentID = 3 });
            Students.Add(new Student { Name = "Borja Aran", Surname = "Tesapa", StudentID = 4 });
            Students.Add(new Student { Name = "Ermek", Surname = "Ashirov", StudentID = 5 });
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

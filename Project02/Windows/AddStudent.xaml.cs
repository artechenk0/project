﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project02.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Student.CreateStudent(TextBoxFullName.Text, TextBoxCourse.Text, TextBoxSpeciality.Text, TextBoxStartDate.Text, TextBoxEndDate.Text, TextBoxType.Text, TextBoxView.Text, TextBoxCharacteristic.Text);
        }

    }
}

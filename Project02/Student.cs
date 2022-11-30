using System;
using System.Collections.ObjectModel;

namespace Project02
{
    class Student
    {
        public static ObservableCollection<Student> students = new ObservableCollection<Student>();
        public string FullName { get; set; }
        public string Course { get; set; }
        public string Speciality { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Type { get; set; }
        public string View { get; set; }
        public string Characteristic { get; set; }

        public static void CreateStudent(string fullName, string course, string speciality, string startData, string endData, string type, string view, string characteristic)
        {
            Student student = new Student();

            student.FullName = fullName;
            student.Course = course;
            student.Speciality = speciality;
            student.StartDate = startData;
            student.EndDate = endData;
            student.Type = type;
            student.View = view;
            student.Characteristic = characteristic;

            students.Add(student);
        }
    }
}

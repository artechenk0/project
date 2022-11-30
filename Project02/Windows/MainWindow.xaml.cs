using System.Linq;
using System.Windows;


namespace Project02.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            ListStudent.ItemsSource = Student.students;
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void ButtonRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            Student[] selectedItem = ListStudent.SelectedItems.Cast<Student>().ToArray();
            foreach (Student item in selectedItem)
            {
                Student.students.Remove(item);
            }
        }

        private void ButtonChangeStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int selectedIndex = ListStudent.SelectedIndex;
                string mes = $"ФИО: {Student.students[selectedIndex].FullName}\n" +
                    $"Специальность: {Student.students[selectedIndex].Speciality}\n" +
                    $"Курс: {Student.students[selectedIndex].Course}\n" +
                    $"Дата начала обучения: {Student.students[selectedIndex].StartDate}\n" +
                    $"Дата окончания обучения: {Student.students[selectedIndex].EndDate}\n" +
                    $"Тип обучения: {Student.students[selectedIndex].Type}\n" +
                    $"Вид обучения: {Student.students[selectedIndex].View}\n" +
                    $"Характеристика: {Student.students[selectedIndex].Characteristic}\n";
                MessageBox.Show(mes);
            }
            catch
            {
                MessageBox.Show("Выбирите студента в списке");
            }

        }
    }
    

}

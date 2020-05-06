using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizThreeForCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> studentsList;

        public MainWindow()
        {
            InitializeComponent();
            studentsList = new List<Student>();
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            int id;
            if (!int.TryParse(tbId.Text, out id))
            {
                MessageBox.Show(this, "The Id must be a number", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            student.Id = id;
            student.FirstName = tbFirstName.Text;
            student.LastName = tbLastName.Text;
            if (true == cbIsRegisterd.IsChecked)
            {
                student.IsRegisterd = true;
            }
            else
            {
                student.IsRegisterd = false;
            }
            studentsList.Add(student);
            MessageBox.Show(this, $"There are {studentsList.Count} students added", "Results", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btShowStudents_Click(object sender, RoutedEventArgs e)
        {
            new StudentsListDialog(studentsList).Show();
        }

        private void btShowQuestionThree_Click(object sender, RoutedEventArgs e)
        {
            List<int> numbersList = new List<int>() { 55, 200, 740, 76, 230, 482, 95, };
            var greaterThan80 = (from n in numbersList where n > 80 select n).ToList();
            string result = "The numbers greater than 80 are:\n";
            result += string.Join("\n", greaterThan80.ToArray());
            MessageBox.Show(this, result, "Question 3", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
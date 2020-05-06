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
using System.Windows.Shapes;

namespace QuizThreeForCSharp
{
    /// <summary>
    /// Interaction logic for StudentsListDialog.xaml
    /// </summary>
    public partial class StudentsListDialog : Window
    {
        private List<Student> studentsList;

        public StudentsListDialog()
        {
            InitializeComponent();
        }

        public StudentsListDialog(List<Student> studentsList)
        {
            this.studentsList = studentsList;
            InitializeComponent();
            lvStudents.ItemsSource = studentsList;
            lvStudents.Items.Refresh();
        }
    }
}
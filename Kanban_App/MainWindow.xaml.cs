using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Kanban_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Projects_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }

    public class MainViewModel
    {
        public ObservableCollection<ColumnViewModel> Columns { get; set; }

        public MainViewModel()
        {
            Columns = new ObservableCollection<ColumnViewModel>
        {
            new ColumnViewModel { Name = "TO-DO", Tasks = new ObservableCollection<TaskViewModel>
            {
                new TaskViewModel { Title = "System Design", Description = "Fun, Research, Due Dec. 24th" },
                new TaskViewModel { Title = "Colour Pick", Description = "Research, Due Dec. 24th" }
            }},
            new ColumnViewModel { Name = "IN PROGRESS", Tasks = new ObservableCollection<TaskViewModel>
            {
                new TaskViewModel { Title = "Code Development", Description = "Dev, Due Dec. 24th" }
            }},
            new ColumnViewModel { Name = "DONE", Tasks = new ObservableCollection<TaskViewModel>
            {
                new TaskViewModel { Title = "Project Planning", Description = "Web, Research, Mobile, Due Dec. 24th" }
            }}
        };
        }
    }

    public class ColumnViewModel
    {
        public string Name { get; set; }
        public ObservableCollection<TaskViewModel> Tasks { get; set; }
    }

    public class TaskViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}


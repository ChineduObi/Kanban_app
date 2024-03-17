using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Kanban_App.Commands;
using Kanban_App.Entities;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace Kanban_App.ViewModel
{
    public class ViewModelBase: INotifyPropertyChanged
    {
        public ObservableCollection<TaskCard> Tasks { get; } = new ObservableCollection<TaskCard>();

        public ICommand AddTaskCommand { get; }

        public ViewModelBase()
        {
            AddTaskCommand = new RelayCommand(addTask: AddTask);
        }

        private void AddTask()
        {
            // You can customize this with a dialog to enter task details or add default values
            Tasks.Add(new TaskCard { Title = "New Task", Description = "Task Description" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Implement OnPropertyChanged method to notify the view of property changes
    }

}

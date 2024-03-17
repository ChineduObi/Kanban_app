using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_App.Entities
{
    public class TaskCard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now;
        public List<string> Tags { get; set; } = new List<string>();
        public ObservableCollection<Task> Tasks { get; set; } = new ObservableCollection<Task>();
    }
}

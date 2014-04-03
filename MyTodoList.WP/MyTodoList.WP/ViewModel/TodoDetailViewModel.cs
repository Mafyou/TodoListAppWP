using GalaSoft.MvvmLight;
using MyTodoList.WP.Model;

namespace MyTodoList.WP.ViewModel
{
    public class TodoDetailViewModel : ViewModelBase
    {
        public TodoItem CurrentTodoItem { get; set; }
    }
}

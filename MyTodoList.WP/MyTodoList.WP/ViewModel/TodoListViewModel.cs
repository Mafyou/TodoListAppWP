using GalaSoft.MvvmLight;
using System.Collections.Generic;
using MyTodoList.WP.Data;
using MyTodoList.WP.Model;

namespace MyTodoList.WP.ViewModel
{
    public class TodoListViewModel : ViewModelBase
    {
        #region Properties
        public List<TodoItem> TodoItems { get; set; }

        private TodoItem _currentTodoItem;
        public TodoItem CurrentTodoItem
        {
            get
            {
                return _currentTodoItem ?? new TodoItem();
            }
            set
            {
                _currentTodoItem = value;
                RaisePropertyChanged("CurrentTodoItem");
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the TodoViewModel class.
        /// </summary>
        public TodoListViewModel()
        {
            TodoItems = new List<TodoItem>();
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                TodoItems = new BuildDataMoq().GetItems();
            }
            else
            {
                // Code runs "for real"
                if (TodoItems.Count == 0)
                    TodoItems = new BuildDataMoq().GetItems();
            }
        }
    }
}

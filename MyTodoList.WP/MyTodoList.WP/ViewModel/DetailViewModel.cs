using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using MyTodoList.WP.Helpers;
using MyTodoList.WP.Model;

namespace MyTodoList.WP.ViewModel
{
    public class DetailViewModel : ViewModelBase
    {
        #region properties
        /// <summary>
        /// Mode of the detail view
        /// </summary>
        public TodoMode Mode { get; set; }
        /// <summary>
        /// If in edit mode, this item should be filled out
        /// </summary>
        public TodoItem CurrentTodoItem { get; set; }
        #endregion

        public DetailViewModel()
        {
            if (Mode == TodoMode.New)
            {
                CurrentTodoItem = new TodoItem();
            }
        }

        public void ResetCurrentTodoItem()
        {
            if (CurrentTodoItem == null) return;
            CurrentTodoItem.Id = Guid.Empty;
            CurrentTodoItem.Title = string.Empty;
            CurrentTodoItem.Description = string.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Practices.ServiceLocation;
using MyTodoList.WP.Model;
using MyTodoList.WP.ViewModel;

namespace MyTodoList.WP.View
{
    public partial class TodoView : PhoneApplicationPage
    {
        public TodoView()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get selected item
            TodoViewModel vm = ServiceLocator.Current.GetInstance<TodoViewModel>();
            TodoItem current = vm.CurrentTodoItem;

            // Set selected to current item of detail tododetail
            ServiceLocator.Current.GetInstance<TodoDetailViewModel>().CurrentTodoItem = current;

            // Move our ass to the detail view
            NavigationService.Navigate(new Uri("/View/TodoDetailView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
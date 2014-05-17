using System;
using System.Windows.Controls;
using Microsoft.Practices.ServiceLocation;
using MyTodoList.WP.Helpers;
using MyTodoList.WP.Model;
using MyTodoList.WP.ViewModel;

namespace MyTodoList.WP.View
{
    public partial class TodoListView
    {
        public TodoListView()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get selected item
            TodoListViewModel currentVM = ServiceLocator.Current.GetInstance<TodoListViewModel>();

            TodoItem current = currentVM.CurrentTodoItem;

            // Set selected to current item of detail tododetail
            DetailViewModel detailVM =  ServiceLocator.Current.GetInstance<DetailViewModel>();
            detailVM.Mode = TodoMode.Edit;
            detailVM.CurrentTodoItem = current;

            // Move our ass to the detail view
            NavigationService.Navigate(new Uri("/View/DetailView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void OnClick_AddButton(object sender, EventArgs e)
        {
            DetailViewModel detailVM = ServiceLocator.Current.GetInstance<DetailViewModel>();
            detailVM.Mode = TodoMode.Edit;

            NavigationService.Navigate(new Uri("/View/DetailView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
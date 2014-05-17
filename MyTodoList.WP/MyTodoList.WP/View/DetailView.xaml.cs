
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Practices.ServiceLocation;
using MyTodoList.WP.ViewModel;

namespace MyTodoList.WP.View
{
    public partial class DetailView
    {
        public DetailView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigate from this
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            DetailViewModel vm = ServiceLocator.Current.GetInstance<DetailViewModel>();
            // Reset inputs
            vm.ResetCurrentTodoItem();
            base.OnNavigatedFrom(e);
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DetailViewModel vm = ServiceLocator.Current.GetInstance<DetailViewModel>();
            string lineSelected = vm.CurrentTodoItem.CurrentLineNumber;
            if (lineSelected.Equals("1"))
                vm.CurrentTodoItem.StopsList.Add("Bastille");
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ButtonValidate_OnClick(object sender, RoutedEventArgs e)
        {
            // Record the todo item
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyTodoList.WP.Model
{
    public class TodoItem : INotifyPropertyChanged
    {
        public Guid Id { get; set; }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged();
            }
        }
        public List<CoordinateItem> Coordinates { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string member = "")
        {
            if (PropertyChanged != null)
            {
                if (member != null && !string.IsNullOrEmpty(member))
                    PropertyChanged(this, new PropertyChangedEventArgs(member));
            }
        }
    }
}

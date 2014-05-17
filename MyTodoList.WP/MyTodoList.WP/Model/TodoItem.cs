using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyTodoList.WP.Model
{
    public class TodoItem : INotifyPropertyChanged
    {
        #region properties
        /// <summary>
        /// Unique identifier
        /// </summary>
        public Guid Id { get; set; }

        private string _title;
        /// <summary>
        /// Title of the item
        /// </summary>
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
        /// <summary>
        /// Little description about the item
        /// </summary>
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged();
            }
        }

        private List<string> _lineNumberList;
        /// <summary>
        /// Line Number chosen
        /// </summary>
        public List<string> LineNumberList {
            get { return _lineNumberList;  }
            set
            {
                _lineNumberList = value;
                RaisePropertyChanged();
            }
        }

        private string _currentLineNumber;
        /// <summary>
        /// Current line selected
        /// </summary>
        public string CurrentLineNumber
        {
            get { return _currentLineNumber; }
            set
            {
                _currentLineNumber = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<string> _stopsList;
        /// <summary>
        /// Stop Enumeration
        /// </summary>
        public ObservableCollection<string> StopsList
        {
            get { return _stopsList; }
            set
            {
                _stopsList = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region logic
        /// <summary>
        /// Constructor to help us create metro line and number
        /// </summary>
        public TodoItem()
        {
            LineNumberList = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            StopsList = new ObservableCollection<string>();
        }
        #endregion

        #region Ifnotify stuff
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string member = "")
        {
            if (PropertyChanged != null)
            {
                if (member != null && !string.IsNullOrEmpty(member))
                    PropertyChanged(this, new PropertyChangedEventArgs(member));
            }
        }
        #endregion
    }
}

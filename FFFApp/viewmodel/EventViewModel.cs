﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FFFApp.Annotations;
using FFFApp.common;
using FFFApp.model;

namespace FFFApp.viewmodel
{
    class EventViewModel:INotifyPropertyChanged
    {

        private Event _newEvent = new Event();
        private RelayCommand _OpretEvent;

        public Event NewEvent
        {
            get { return _newEvent; }
            set { _newEvent = value; OnPropertyChanged(); }
        }

        public RelayCommand OpretEvent => _OpretEvent;

        public EventViewModel()
        {
            _OpretEvent = new RelayCommand(OpretEventMetode);
        }

        private void OpretEventMetode()
        {
            // Kan restservice
        }





        #region Notification
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}

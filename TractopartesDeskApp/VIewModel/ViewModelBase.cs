using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.VIewModel
{
    internal class ViewModelBase : INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler? PropertyChanging;

        protected virtual void OnpropertyChanged(string propertyName)
        {
            PropertyChanging?.Invoke(this,new PropertyChangingEventArgs(propertyName));
        }
    }
}

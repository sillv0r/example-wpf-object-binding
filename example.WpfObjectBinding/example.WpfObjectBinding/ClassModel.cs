using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.WpfObjectBinding
{
    public class ClassModel : INotifyPropertyChanged
    {
        private ObservableCollection<ClassInfo> _classes;
        public ObservableCollection<ClassInfo> Classes
        {
            get { return this._classes; }
            set
            {
                this._classes = value;

                // The name of the property so the WPF framework updates any bindings referring to it.
                this.sendPropertyChanged("Classes");    
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void sendPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion
    }
}

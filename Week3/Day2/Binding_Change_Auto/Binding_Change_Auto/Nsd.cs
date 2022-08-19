using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_Change_Auto
{
    class Nsd : INotifyPropertyChanged
    {
        private string _pass = "";
        private string _name = "";

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                string oldval = _name;
                _name = value;
                if (oldval != value)
                    NotifyChanged("Name");
            }
        }
        public string Password
        {
            get
            {
                return _pass;
            }
            set
            {
                string oldval = _pass;
                _pass = value;
                if (oldval != value)
                    NotifyChanged("Password");
            }
        }

        private void NotifyChanged(string name)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public Nsd()
        {

        }
        public Nsd(int id, string name, string pass)
        {
            Id = id;
            Name = name;
            Password = pass;

        }


    }
}

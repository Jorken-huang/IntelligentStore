using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore.Data
{
    public class ShopItems : INotifyPropertyChanged
    {
        private string name;
        private string quality;
        private string plice;

        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged("Name"); }
        }
        public string Quality
        {
            get { return quality; }
            set { quality = value; NotifyPropertyChanged("Quality"); }
        }

        public string Plice
        {
            get { return plice; }
            set { plice = value; NotifyPropertyChanged("Plice"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}

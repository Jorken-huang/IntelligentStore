using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore.Data
{
   public class ShopModel : INotifyPropertyChanged
    {
        ObservableCollection<ShopItems> shoplist = new ObservableCollection<ShopItems>();
        private int count;

        public ShopModel()
        {
            count = 0;
            shoplist = new ObservableCollection<ShopItems>();
        }
        public ObservableCollection<ShopItems> ShopList
        {
            get { return shoplist; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; NotifyPropertyChanged("Count"); }
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

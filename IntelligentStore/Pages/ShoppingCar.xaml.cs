using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using IntelligentStore.Data;
using Windows.UI.Popups;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace IntelligentStore.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ShoppingCar : Page
    {
        int count=0;
        string y="0";
        ShopModel shopModel = new ShopModel();
        public ShoppingCar()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Enabled;   
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {            
            ShopItems mg = (ShopItems)e.Parameter;            
            if (shopModel.ShopList.Count != 0)
            {
                int plice = Convert.ToInt32(mg.Plice.Substring(0, mg.Plice.Length - 1)) * Convert.ToInt32(mg.Quality);
                shopModel.ShopList.Add(new ShopItems { Name = mg.Name, Quality = mg.Quality + "个", Plice = plice.ToString()+"元" });                    
                count += plice;
            }
                shopModel.ShopList.Add(new ShopItems { Name = "总计", Quality = "", Plice = count.ToString() + "元" });
                if (shopModel.ShopList.Count > 2)
                    shopModel.ShopList.RemoveAt(shopModel.ShopList.Count - 3);
                carList.ItemsSource = shopModel.ShopList;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private async void btnShop_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dlg = new MessageDialog("共："+y,"付款成功，谢谢惠顾！");
            await dlg.ShowAsync();            
        }

        private void AppButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void carList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            y = ((ShopItems)e.AddedItems[0]).Plice;
        }
    }
}

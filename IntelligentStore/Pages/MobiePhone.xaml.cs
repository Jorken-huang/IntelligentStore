using System;
using System.Collections.Generic;
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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace IntelligentStore.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MobiePhone : Page
    {
        public MobiePhone()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel viewModel = new ViewModel();
            viewModel.PhoneStore(gvPhone);
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
        StoreData storeData;
        private void gvPhone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            storeData = new StoreData();
            storeData.Image = ((StoreData)e.AddedItems[0]).Image;
            storeData.Name = ((StoreData)e.AddedItems[0]).Name;
            storeData.Desc = ((StoreData)e.AddedItems[0]).Desc;
            storeData.Plice = ((StoreData)e.AddedItems[0]).Plice;
            //传递类实例
            Frame.Navigate(typeof(ItemDtail), storeData);
        }
    }
}

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
using Windows.UI.Xaml.Media.Imaging;
using System.Collections.ObjectModel;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace IntelligentStore.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ItemDtail : Page
    {
        StoreData store;
        ViewModel viewModel = new ViewModel();
        public ItemDtail()
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
                //信息加载
                store = (StoreData)e.Parameter;
                txtName.Text = store.Name;
                txtDesc.Text = store.Desc;
                txtPlice.Text = store.Plice.ToString();
                imgMsg.Source = store.Image;
                //图片列表     
                viewModel.ImgList(store.Name,lstItem,100,100);
                viewModel.ImgList(store.Name,fvItem,1000,600);
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void AppButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}

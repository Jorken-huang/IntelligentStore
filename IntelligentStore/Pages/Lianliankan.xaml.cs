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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace IntelligentStore.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Lianliankan : Page
    {
        public Lianliankan()
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
            for (int i = 0; i < 10; i++)
            {
                RowDefinition row = new RowDefinition();
                layout.RowDefinitions.Add(row);

            }
            for (int i = 0; i < 10; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                layout.ColumnDefinitions.Add(col);
            }
            Random randow = new Random();
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Image img = new Image();
                    int num = randow.Next(1, 10);
                    string fileName = "ms-appx:///images/lianliankan/" + num + ".png";
                    img.Source = new BitmapImage(new Uri(fileName));

                    layout.Children.Add(img);
                    Grid.SetRow(img, row);
                    Grid.SetColumn(img, col);
                    //为图片添加事件
                    img.PointerPressed += img_PointerPressed;
                    //机制Image的tag属性为随机数以便区分
                    img.Tag = num;
                }
            }
        }
        int count = 0;  //全局变量记录鼠标点击次数
        //定义两个Images对象，分别存放两次点击的图片
        Image fst = new Image();
        Image sec = new Image();

        void img_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            count++;
            if (count % 2 != 0)
                fst = sender as Image;
            else
            {
                sec = sender as Image;


                //判断两幅图片是否一样
                if (Convert.ToInt16(fst.Tag) == Convert.ToInt16(sec.Tag) && fst != sec)
                {
                    layout.Children.Remove(fst);
                    layout.Children.Remove(sec);
                }
            }
        }
        private int counSecond = 100;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DispatcherTimer disTimer = new DispatcherTimer();
            disTimer.Interval = new TimeSpan(0,0,0,1);
            disTimer.Tick+=disTimer_Tick;
            disTimer.Start();
        }

        private void disTimer_Tick(object sender, object e)
        {
            if (counSecond == 0)
            {
                txtSecond.Text = "游戏结束";
            }
            else
            {
                if (txtSecond.Dispatcher.HasThreadAccess)
                {
                    txtSecond.Text = "离游戏结束还剩" + counSecond.ToString() +"秒";
                }
                counSecond--;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
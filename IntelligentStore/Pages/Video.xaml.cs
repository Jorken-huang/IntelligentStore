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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace IntelligentStore.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Video : Page
    {
        public Video()
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
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += timer_Tick;
            timer.Start();
            txtDesc.Text = "       应用商店其实是一个很通俗的说法了，其本质上是一个平台，用以展示、下载手机适用的应用软件。";
            txtDesc.Text +="那么，在苹果以前的应用商店为啥没有红火起来呢？其一，网络环境还没有成熟，  下载应用等待时间长而且资费巨大";
            txtDesc.Text += "其一，在苹果以前的应用商店为啥没有红火起来呢？";
            txtDesc.Text +="其二，手机硬件限制，  在iPhone之前的手机基本是按键式操作，手机屏幕小、屏幕分辨率低、处理能力不高在手机上只能运行一些很简单应用";
            txtDesc.Text +="其三参与者缺乏热虽然部分平台接口面向大众是开放的，但是在业绩分成方面，运营商稳拿大头，开发者的投入与产出相差悬殊，以至智慧资本不愿分流过来。";
        }

        private void timer_Tick(object sender, object e)
        {
            slider.Value = media.Position.TotalSeconds;
        }
        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            slider.Value = 0.0;
        }
        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            //设置完成事件为视频最大值
            slider.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
            slider.Value = 0.0;
        }
        private void media_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (media.CurrentState == MediaElementState.Playing)
                media.Pause();
            if (media.CurrentState == MediaElementState.Paused)
                media.Play();
        }
        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //但拖动slider的时候，改变播放的位置
            media.Position = TimeSpan.FromSeconds(e.NewValue);
        }
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            //播放
            media.Play();
        }

        private void btnPause_Click_1(object sender, RoutedEventArgs e)
        {
            if (media.CurrentState == MediaElementState.Playing)
                media.Pause();
            if (media.CurrentState == MediaElementState.Paused)
                media.Play(); 
        }
    }
}

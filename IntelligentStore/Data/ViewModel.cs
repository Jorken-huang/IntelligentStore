using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace IntelligentStore.Data
{
    public class ViewModel
    {

        //加载信息函数
        public void AddItems(int imgId,ItemsControl itemcl, string name, string desc, string plice)
        {
            StoreData storeData = new StoreData();
            string fileName = "ms-appx:///Images/" + imgId.ToString() + ".jpg";
            storeData.Image = new BitmapImage(new Uri(fileName));
            storeData.Name = name;
            storeData.Desc = desc;
            storeData.Plice = plice;
            itemcl.Items.Add(storeData);
        }
        //电脑信息
        public void ComputerStore(ItemsControl gvComputer)
        {
            AddItems(1, gvComputer, "宏碁 VN7-592G-58NG", "酷睿I5-6300HQ NVIDIAGTX 960M2GB独显15.6寸高清屏", "6199元");
            AddItems(2, gvComputer, "华硕 X550", "酷睿I7-4710HQ NVIDIAGTX 820M2GB 独显1080P高清屏", "4799元");
            AddItems(3, gvComputer, "苹果 MacBook Air", "酷睿I5-4710HQ NVIDIAGTX 840M2GB 独显1080P高清屏", "4465元");
            AddItems(4, gvComputer, "炫龙A60L", "酷睿I5-6300HQ NVIDIAGTX 970M2GB独显15.6寸高清屏", "5695元");
            AddItems(5, gvComputer, "戴尔 XPS13系列 XPS", "酷睿I5-4710HQ NVIDIAGTX 840M2GB 独显1080P高清屏", "6199元");
            AddItems(6, gvComputer, "神舟 战神 Z7-I78", "酷睿I7-6300HQ NVIDIAGTX 980M2GB独显15.6寸高清屏", "4588元");
            AddItems(7, gvComputer, "ThinkPad T450", "酷睿I7-4710HQ NVIDIAGTX 860M2GB 独显1080P高清屏", "5066元");
            AddItems(8, gvComputer, "联想 y50 Y50-70", "酷睿I7-6300HQ NVIDIAGTX 980M2GB独显15.6寸高清屏", "5677元");
        }
        //手机信息
        public void PhoneStore(ItemsControl gvPhone)
        {
            AddItems(9, gvPhone, "iPhone 6s", "苹果iPhone6S全网通搭载A9+M9芯片组合", "4788元");
            AddItems(10, gvPhone, "乐视1S", "乐视超级手机1S双4GID无边框设计增添2.0快充电", "1088元");
            AddItems(11, gvPhone, "魅蓝", "魅族魅蓝metal双4G千元金属机指纹识别采用Flyme5.0", "1099元");
            AddItems(12, gvPhone, "华为5X", "华为荣耀畅玩5XKIW-AL10/全网通全网通3GB RAM", "1475元");
            AddItems(13, gvPhone, "魅族MX5", "魅族MX5移动4G首次采用了全金属机身设计不同于MX4", "1570元");
            AddItems(14, gvPhone, "vivo X5Pro", "vivoX5Pro双4G号称vivo最美手机两面采用弧度玻璃", "2088元");
            AddItems(15, gvPhone, "酷派锋尚MAX", "酷派锋尚MAXA8-930全网通金属机身设计指纹识别", "2399元");
            AddItems(16, gvPhone, "LG G4", "LGG4H818双4GLG旗舰机采用曲面屏幕带有阳光屏技术", "2999元");
        }
        //游戏信息
        public void GameStore(ItemsControl gvGame)
        {
            AddItems(20,gvGame, "连连看", "好玩的简单易学的休闲游戏，专为忙碌的你而造", "免费");
            AddItems(18, gvGame, "俄罗斯方块", "永远的经典，激扬你的美好童年的回忆", "免费");
        }
        //图片列表
        Image img;
        public void ImgList(string name,ItemsControl ic,int width,int height)
        {           
            switch (name)
            {
                case "宏碁 VN7-592G-58NG":
                    for (int i = 1; i <= 4; i++)
                    {
                        img = new Image();
                        img.VerticalAlignment = VerticalAlignment.Top;
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
                case "华硕 X550":
                    for (int i = 5; i <= 8; i++)
                    {
                        img = new Image();
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
                case "苹果 MacBook Air":
                    for (int i = 9; i <= 12; i++)
                    {
                        img = new Image();
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
                case "炫龙A60L":
                    for (int i = 13; i <= 16; i++)
                    {
                        img = new Image();
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
                case "iPhone 6s":
                    for (int i = 33; i <= 35; i++)
                    {
                        img = new Image();
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
                case "乐视1S":
                    for (int i = 36; i <= 38; i++)
                    {
                        img = new Image();
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
                case "魅蓝":
                    for (int i = 39; i <= 41; i++)
                    {
                        img = new Image();
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
                case "华为5X":
                    for (int i = 42; i <= 44; i++)
                    {
                        img = new Image();
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
                case "连连看":
                    for (int i = 42; i <= 44; i++)
                    {
                        img = new Image();
                        string fileName = "ms-appx:///images/" + i.ToString() + "c.jpg";
                        img.Source = new BitmapImage(new Uri(fileName));
                        img.Width = width;
                        img.Height = height;
                        ic.Items.Add(img);
                    }
                    break;
            }
        }
    }
}

﻿using GL.WinUI3;
using GL.WinUI3.Model;
using GL.WinUI3.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MyApp1.Models;
using MyApp1.View;
using MyApp1.View.Pages;
using MyApp1.WindowHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1.ViewModel
{
    public class DefaultGameViewModel:ObservableRecipient
    {

        string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public DefaultGameViewModel()
        {
            IsActive = true;
            StartGame = new AsyncRelayCommand(async () => await start());
            Resource.myini = new Launcher_Ini($@"{docpath}/GSIConfig/Config/LauncherConfig.ini");
        }

        private async Task start()
        {
            StartGame startAgument = new StartGame();
            string a = await startAgument.GO(Resource.myini.GetAgument(),() => NotificationHelper.Show("应用隐藏", "可以双击任务栏托盘图标进行重新打开"));
            if (a == "1")
            {
                TipWindow.Show("启动游戏成功！", "可以快乐的玩耍了");
            }
            else
            {

                TipWindow.Show("启动失败，请检查游戏文件夹！", "😒");
            };
        }

        public AsyncRelayCommand StartGame { get; private set; }


        public RelayCommand NewConfig { get; private set; } = new RelayCommand(() =>
        {
            NavigationHelper helper = new NavigationHelper();
            INavigations navigations = new INavigations();
            navigations.MyAction = () =>
            {
                (App.MainWindow.Content as MainPage).MyFrame.Navigate(typeof(NewStartConfig));

            };
            navigations.Message = "跳转到配置页";
            helper.GO(navigations);
        });
    }
}
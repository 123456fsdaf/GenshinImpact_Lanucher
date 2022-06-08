﻿using GenshinImpact_Lanuncher.MiHaYouAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GenshinImpact_Lanuncher.ItemsControlDT
{
    /// <summary>
    /// HomeDT.xaml 的交互逻辑
    /// </summary>
    public partial class HomeDT : UserControl
    {
        public HomeDT()
        {
            InitializeComponent();
        }




        public GenshinWorld MyData
        {
            get { return (GenshinWorld)GetValue(MyDataProperty); }
            set { SetValue(MyDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyDataProperty =
            DependencyProperty.Register("MyData", typeof(GenshinWorld), typeof(HomeDT), new PropertyMetadata(default(GenshinWorld)));


    }
}

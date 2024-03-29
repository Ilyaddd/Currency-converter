﻿using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace Currency_Converter
{
    public partial class MainWindow : Window
    {
        //Создание экземпляров классов
        public static Courses Page_Cources = new Courses();
        public static Calcutator Page_Calcutator = new Calcutator();
        public static Settings Page_Settings = new Settings();
        public static AppSettings Page_AppSettings = new AppSettings();
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            try
            {
                if(Registry.CurrentUser.CreateSubKey("Software\\Currency converter").GetValue("LastPage").ToString() == "Calcutator")
                    Page_Loader.Navigate(Page_Calcutator);
                else
                    Page_Loader.Navigate(Page_Cources);
            }
            catch
            {
                Page_Loader.Navigate(Page_Cources);
            }
        }
        void TrayOff()
        {
            Show();
            Tray.Visibility = Visibility.Hidden;
        }
        
        void MainForm_Activated(object sender, EventArgs e)
        {
        }
        private void DragForm(object sender, MouseButtonEventArgs e)
        {
            try
            { DragMove(); }
            catch { }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Minimized(object sender, RoutedEventArgs e)
        {
            MainForm.WindowState = WindowState.Minimized;
        }

        // Сворачивание в трей Hardcodet.Wpf.TaskbarNotification
        void TrayMinimized(object sender, RoutedEventArgs e)
        {
            Hide();
            Tray.Visibility = Visibility.Visible;
        }
        void TaskbarIcon_TrayLeftMouseDown(object sender, RoutedEventArgs e)
        {
            TrayOff();
        }
        private void Pin(object sender, RoutedEventArgs e)
        {
            if (App.Current.MainWindow.Topmost)
            {
                App.Current.MainWindow.Topmost = false;
                pin.Kind = PackIconKind.PinOffOutline;
            }
            else
            {
                App.Current.MainWindow.Topmost = true;
                pin.Kind = PackIconKind.Pin;
            }
        }
        void Settings(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_Settings);
        }

        void Course_Click(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_Cources);
        }
        void Calcutator_Click(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_Calcutator);
        }

        void AppSettings(object sender, RoutedEventArgs e)
        {
            TrayOff();
            Page_Loader.Navigate(Page_AppSettings);
        }

        void MainForm_Closed(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

    }
}

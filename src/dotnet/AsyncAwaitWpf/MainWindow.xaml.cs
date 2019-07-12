﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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

namespace AsyncAwaitWpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        Task<string> task;
        private void Button_Click(object sender, RoutedEventArgs e) {
            var wc = new WebClient();
            task = wc.DownloadStringTaskAsync(
                "https://facebook.com");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            this.textBox.Text = task.Result;
        }
    }
}

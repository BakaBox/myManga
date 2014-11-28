﻿using System;
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
using Core.Other;

namespace myManga_App.Views
{
    /// <summary>
    /// Interaction logic for ReaderView.xaml
    /// </summary>
    public partial class ReaderView : UserControl
    {
        public ReaderView()
        {
            InitializeComponent();
        }

        private void ImageContent_SourceUpdated(object sender, DataTransferEventArgs e)
        { this.ImageContentScrollViewer.ScrollToHome(); }

        private void PageList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { this.PageList.ScrollToCenterOfView(this.PageList.SelectedItem); }
    }
}
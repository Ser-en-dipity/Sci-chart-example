﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SciChart.Charting.Model.DataSeries;
using System;

namespace Sci_Chart;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var dataSeries = new XyDataSeries<double, double>();
        for(int i = 0; i < 100; i++)
            dataSeries.Append(i, Math.Sin(i*0.2));
        lineSeries.DataSeries = dataSeries;
    }
}
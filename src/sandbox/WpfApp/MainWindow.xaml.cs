﻿using System;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random rand = new();
            for (int i = 0; i < 200; i++)
            {
                WpfPlot1.Plot.AddArrow(
                    xTip: rand.NextDouble() * 10,
                    yTip: rand.NextDouble() * 10,
                    xBase: rand.NextDouble() * 10,
                    yBase: rand.NextDouble() * 10,
                    lineWidth: 1);
            }

            WpfPlot1.Plot.AxisScaleLock(true, ScottPlot.EqualScaleMode.PreserveSmallest);

            WpfPlot1.Render();
        }
    }
}
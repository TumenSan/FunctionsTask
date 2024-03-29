﻿using FunctionsTask.ViewModel;
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

namespace FunctionsTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new FunctionViewModel();
        }

        /// <summary>
        /// Обновление высоты таблицы при изменении размеров окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateDataGridMaxHeight();
        }

        /// <summary>
        /// Определение части высоты окна для таблицы
        /// </summary>
        private void UpdateDataGridMaxHeight()
        {
            double dataGridHeight = this.ActualHeight / 2;

            dataGrid.MaxHeight = dataGridHeight;
        }
    }
}

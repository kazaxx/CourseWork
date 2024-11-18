﻿using EuroBuld.DataBase;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace EuroBuld.Page
{
    /// <summary>
    /// Логика взаимодействия для ServiceAdd.xaml
    /// </summary>
    public partial class ServiceAdd : Window
    {
        EuroBuldEntities7 _context;
        private byte[] _Image;
        public ServiceAdd()
        {
            InitializeComponent();
            _context = new EuroBuldEntities7();
        }

        private void AddImage(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Выберите изображение для машины"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                _Image = File.ReadAllBytes(openFileDialog.FileName);
            }
        }


        private async void Send_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text) || string.IsNullOrWhiteSpace(PriceTextBox.Text) || _Image == null)
            {
                System.Windows.MessageBox.Show("Пожалуйста, заполните все поля и выберите изображение.");
                return;
            }

            string priceWithRubleSign = PriceTextBox.Text.Trim() + "₽";
            var newService = new EuroBuld.DataBase.Service
            {
                Item_Name = NameTextBox.Text,
                Item_Description = DescriptionTextBox.Text,
                Price = priceWithRubleSign,
                Image = _Image
            };

            try
            {
                _context.Service.Add(newService);
                await _context.SaveChangesAsync();

                System.Windows.MessageBox.Show("добавлена успешно!");

                this.Close();
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Ошибка при добавлении машины: {ex.Message}");
            }
        }


        private void ClearFields()
        {
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            PriceTextBox.Clear();
            _Image = null;
        }
    }
}
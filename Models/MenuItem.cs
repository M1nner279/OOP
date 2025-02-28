using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MenuApp.Models
{
    public abstract class MenuItem : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Price { get; set; }
        private string _imagepath = "";
        public string ImagePath { 
            get => _imagepath;
            set
            {
                _imagepath = value;
                OnPropertyChanged(nameof(ImagePath)); // Уведомление UI
            } 
        }

        public Bitmap ImageBitmap { get; set; }
        private Bitmap LoadBitmap(string imagePath)
        {
            try
            {
                var fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", imagePath);
                return new Bitmap(fullPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки изображения: {ex.Message}");
                return null;
            }
        }
        public MenuItem(string name, int price, string imagePath)
        {
            Name = name;
            Price = price;
            ImagePath = $"avares://MenuApp/Assets/{imagePath}";
            Console.WriteLine($"ImagePath: {ImagePath}");
            ImageBitmap = LoadBitmap(imagePath);
        }
        public abstract string GetInfo
        {
            get;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
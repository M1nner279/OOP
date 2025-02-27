using System;
using System.Collections.Generic;
using System.IO;
using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace MenuApp.Models
{
    public abstract class MenuItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImgSource { get; set; }

        public Bitmap Image { get; set; }

        public MenuItem(string name, int price, string imgSource)
        {
            Name = name;
            Price = price;
            ImgSource = $"avares://MenuApp/Assets/{imgSource}";
            LoadImage(imgSource);
            Console.WriteLine($"ImagePath: {ImgSource}");
        }

        private void LoadImage(string path)
        {
            if (File.Exists(path))
            {
                using var stream = File.OpenRead(path);
                Image = new Bitmap(stream);
                stream.Close();
            }
        }

        public abstract string GetInfo
        {
            get;
        }
    }
}
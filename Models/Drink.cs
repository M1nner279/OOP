namespace MenuApp.Models
{
    public class Drink : MenuItem
    {
        public int Volume { get; set; }
        
        public Drink(string name, int price, string imagePath, int volume) : base(name, price, imagePath)
        {
            Volume = volume;
        }

        public override string GetInfo => $"Объём: {Volume} мл";
    }
}
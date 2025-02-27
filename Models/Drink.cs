namespace MenuApp.Models
{
    public class Drink : MenuItem
    {
        public int Volume { get; set; }
        
        public Drink(string name, int price, string imgSource, int volume) : base(name, price, imgSource)
        {
            Volume = volume;
        }

        public override string GetInfo => $"Объём: {Volume} мл";
    }
}
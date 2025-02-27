namespace laboop.Models
{
    public class Drink : MenuItem
    {
        public int Volume { get; set; }
        
        public Drink(string name, int price, int volume) : base(name, price)
        {
            Volume = volume;
        }

        public override string GetInfo => $"Объём: {Volume} мл";
    }
}
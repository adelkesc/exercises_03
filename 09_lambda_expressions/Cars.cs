namespace ex8
{
    public class Car
    {
        public Colors Color { set; get; } 
        public int EngineSize { set; get; }
        public double FuelEconomy { set; get; }

        public override string ToString()
        {
            return $"car in the color: {Color} with an engine size of {EngineSize} and Fuel economy {FuelEconomy}";
        }
    }
}
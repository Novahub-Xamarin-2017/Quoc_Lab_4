namespace ex_7
{
    public class Country : ICompare<Country>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Country()
        {
        }

        public Country(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public override string ToString() => $"Country : {Name}, Area : {Area}";

        public bool IsBigger(Country another) => Area > another.Area;
    }
}
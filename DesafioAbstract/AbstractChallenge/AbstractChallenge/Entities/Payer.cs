namespace AbstractChallenge.Entities
{
    abstract class Payer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected Payer(string name, double income)
        {
            Name = name;
            Income = income;
        }
        public abstract double CalPayer();

        public override string ToString()
        {
            return Name + ": "
                   +"$ " + CalPayer().ToString("F2");
        }
    }

}

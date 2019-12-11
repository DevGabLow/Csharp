namespace AbstractChallenge.Entities
{
    class Individual : Payer
    {
        public double Expenditures { get; set; }

        public Individual(string name, double income, double expenditures) : base(name, income)
        {
            Expenditures = expenditures;
        }

        public override double CalPayer()
        {
            double imp = 0.0;
          if(Income > 20000) { imp += (Income * 0.25) - (Expenditures * 0.50); }
          else { imp += (Income * 0.15) - (Expenditures * 0.50); }

            return imp;
        }
    }
}

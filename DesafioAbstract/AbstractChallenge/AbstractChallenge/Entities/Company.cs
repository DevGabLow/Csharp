namespace AbstractChallenge.Entities
{
    class Company : Payer
    {
        public int Employee { get; set; }
     

        public Company(string name, double income,int employee) : base(name,income)
        {
           
            Employee = employee;
        }

        public override double CalPayer()
        {
            double imp = 0.0;
            if (Employee > 10)
            {
                imp +=  Income *  0.14;
            }
            else {
                imp += Income * 0.16;
            }
            return imp;
        }

    }
}

namespace SolidConcepts.Entities
{
    public class Beer : TaxItem
    {
        public Beer(string description, decimal price) : base("Beer", description, price)
        {

        }

        public override decimal GetTax()
        {
            return (decimal)0.1;
        }
    }
}

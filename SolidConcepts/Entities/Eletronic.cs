namespace SolidConcepts.Entities
{
    public class Eletronic : TaxItem
    {
        public Eletronic(string description, decimal price) : base("Eletronic", description, price)
        {

        }

        public override decimal GetTax()
        {
            return (decimal)0.5;
        }
    }
}

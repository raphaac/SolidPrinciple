namespace SolidConcepts.Entities
{
    public class Cigar : TaxItem
    {
        public Cigar(string description, decimal price) : base("Cigar", description, price)
        {

        }

        public override decimal GetTax()
        {
            return (decimal)0.2;
        }
    }
}

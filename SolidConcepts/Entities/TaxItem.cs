namespace SolidConcepts.Entities
{
    public abstract class TaxItem : Item
    {
        public TaxItem(string category, string description, decimal price) : base(category, description, price)
        {

        }

        public decimal CalculateTaxes()
        {
            return this.Price * GetTax();
        }

        public abstract decimal GetTax();

    }
}

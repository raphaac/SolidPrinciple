namespace SolidConcepts.Entities
{
    public abstract class Item
    {
        private string Category;
        private string Description;
        public decimal Price;
        
        public Item(string category, string description, decimal price)
        {
            this.Category = category;
            this.Description = description;
            this.Price = price;
        }
    }
}

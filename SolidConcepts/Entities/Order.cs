using System;
using System.Collections.Generic;

namespace SolidConcepts.Entities
{
    public class Order
    {
        public Guid Code { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();

        public Order()
        {
            Code = Guid.NewGuid();
        }

        public void AddItem(Item item)
        {
            this.Itens.Add(item);
        }

        public decimal GetSubtotal()
        {
            decimal total = 0;

            foreach (var item in Itens)
                total += item.Price;

            return total;
        }

        public decimal GetTaxes()
        {
            decimal taxes = 0;

            var itemWithTax = new List<Item>();

            foreach (var item in Itens)
                if (typeof(TaxItem).IsInstanceOfType(item))
                    itemWithTax.Add(item);

            foreach (var item in itemWithTax)
            {
                if (item.GetType() == typeof(TaxItem))
                    taxes += item.CalculateTaxes();
            }

            return taxes;
        }

        public decimal GetTotal()
        {
            return this.GetSubtotal() + this.GetTaxes();
        }
    }
}

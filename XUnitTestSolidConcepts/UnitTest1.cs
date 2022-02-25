using SolidConcepts.Entities;
using Xunit;

namespace XUnitTestSolidConcepts
{
    public class UnitTest1
    {
        /// <summary>
        /// Given, When and Than
        /// Dado que, quando e então.
        /// </summary>

        [Fact()]
        public void TestOrderSolidConceptsSubTotal()
        {
            var order = new Order();

            order.AddItem(new Cigar("Holly", 10));
            order.AddItem(new Beer("Black", 5));
            order.AddItem(new Water("Liquid", 2));

            var subTotal = order.GetSubtotal();
            
            Assert.Equal(17, subTotal);
        }

        [Fact()]
        public void TestOrderSolidConceptsSubTaxes()
        {
             var order = new Order();

            order.AddItem(new Cigar("Holly", 10));
            order.AddItem(new Beer("Black", 5));
            order.AddItem(new Water("Liquid", 2));

            var taxes = order.GetTaxes();

            Assert.Equal((decimal)2.5, taxes);
        }

        [Fact()]
        public void TestOrderSolidConceptsTotals()
        {
            var order = new Order();

            order.AddItem(new Cigar("Holly", 10));
            order.AddItem(new Beer("Black", 5));
            order.AddItem(new Water("Liquid", 2));

            var total = order.GetTotal();

            Assert.Equal((decimal)19.5, total);
        }


    }
}

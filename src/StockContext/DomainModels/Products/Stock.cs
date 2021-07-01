using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockContext.DomainModels.Products
{
    public class Stock
    {
        private Stock()
        {
        }

        public Stock(
            ProductId productId,
            StockAddressId addressId,
            int quantity)
        {
            ProductId = productId;
            AddressId = addressId;
            Quantity = quantity;
        }

        public ProductId ProductId { get; private set; }
        public StockAddressId AddressId { get; private set; }
        public int Quantity { get; private set; }

        public void ChangeAddress(StockAddress stockAddress)
        {
            AddressId = stockAddress.Id;
        }

    }
}

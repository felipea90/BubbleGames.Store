using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockContext.DomainModels.Products
{
    public class Stock
    {
        public ProductId ProductId { get; private set; }
        public StockAddressId AddressId { get; private set; }
        public int Quantity { get; private set; }

        public void ChangeAddress()
        {

        }

    }
}

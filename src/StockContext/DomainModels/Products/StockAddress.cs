using System;

namespace StockContext.DomainModels.Products
{
    public class StockAddress
    {
        private StockAddress()
        {
        }

        public StockAddress(
            string description)
        {
            Id = new StockAddressId(Guid.NewGuid());
            Description = description;
        }

        public StockAddressId Id { get; private set; }
        public string Description { get; private set; }
    }
}

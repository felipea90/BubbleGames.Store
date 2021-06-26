using System;

namespace StockContext.DomainModels.Products
{
    public struct StockAddressId
    {
        public StockAddressId(
            Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }
    }
}

using System;

namespace StockContext.DomainModels.Products
{
    public struct ProductId
    {
        public ProductId(
            Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }
    }
}

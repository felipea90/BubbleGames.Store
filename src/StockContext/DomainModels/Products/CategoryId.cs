using System;

namespace StockContext.DomainModels.Products
{
    public struct CategoryId
    {
        public CategoryId(
            Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }

    }
}

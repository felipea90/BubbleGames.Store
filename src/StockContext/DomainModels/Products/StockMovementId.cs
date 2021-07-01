using System;

namespace StockContext.DomainModels.Products
{
    public struct StockMovementId
    {
        public StockMovementId(
            Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }
    }
}

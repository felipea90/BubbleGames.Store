using System;

namespace StockContext.DomainModels.Products
{
    public class StockMovement
    {
        private StockMovement()
        {
        }

        public StockMovement(
            ProductId productId,
            int quantity)
        {
            Id = new StockMovementId(Guid.NewGuid());
            ProductId = productId;
            CreatedAt = DateTime.Now;
            Quantity = quantity;
        }

        public StockMovementId Id { get; private set; }
        public ProductId ProductId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int Quantity { get; private set; }

    }
}

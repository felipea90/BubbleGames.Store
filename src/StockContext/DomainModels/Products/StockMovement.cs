using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockContext.DomainModels.Products
{
    public class StockMovement
    {
        public StockMovementId Id { get; private set; }
        public ProductId ProductId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int Quantity { get; private set; }

    }
}

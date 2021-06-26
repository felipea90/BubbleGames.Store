using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using System;

namespace StockContext.DomainModels.Products
{
    public sealed class Product
    {
        private Product()
        {
        }

        public Product(
            CategoryId categoryId,
            string name,
            string barCode)
            : this(new ProductId(Guid.NewGuid()), categoryId, name, barCode)
        {
        }

        public Product(
            Category category,
            string name,
            string barCode)
            : this(new ProductId(Guid.NewGuid()), category.Id, name, barCode)
        {
        }

        public Product(
            ProductId id,
            CategoryId categoryId,
            string name, 
            string barCode)
        {
            Id = id;
            CategoryId = categoryId;
            Name = name;
            BarCode = barCode;
        }

        public ProductId Id { get; private set; }
        public string Name { get; private set; }
        public CategoryId CategoryId { get; private set; }
        public string BarCode { get; private set; }
    }
}

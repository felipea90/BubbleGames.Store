using System;

namespace StockContext.DomainModels.Products
{
    public sealed class Category
    {
        private Category()
        {
        }

        public Category(
            string description)
        {
            Id = new CategoryId(Guid.NewGuid());
            Description = description;
        }

        public CategoryId Id { get; private set; }
        public string Description { get; private set; }

        public Product NewProduct(
            string name,
            string barCode)
        {
            return new Product(
                category: this, 
                name: name, 
                barCode: barCode);
        }
    }
}

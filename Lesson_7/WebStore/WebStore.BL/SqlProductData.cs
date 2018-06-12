using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebStore.BL.Contract;
using WebStore.DAL.Context;
using WebStore.Domain.Entities;
using WebStore.Domain.Filters;

namespace WebStore.BL
{
    public class SqlProductData : IProductData
    {
        private readonly WebStoreDbContext _context;

        public SqlProductData(WebStoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Section> GetSections()
        {
            return _context.Sections.ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products.Include("Brand").Include("Section").AsQueryable();
            if (filter.BrandId.HasValue)
                query = query.Where(c => c.BrandId.HasValue && c.BrandId.Value.Equals(filter.BrandId.Value));
            if (filter.SectionId.HasValue)
                query = query.Where(c => c.SectionId.Equals(filter.SectionId.Value));

            if (filter.Ids != null && filter.Ids.Count > 0)
                query = query.Where(c => filter.Ids.Contains(c.Id));

            return query.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include("Brand").Include("Section").FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}

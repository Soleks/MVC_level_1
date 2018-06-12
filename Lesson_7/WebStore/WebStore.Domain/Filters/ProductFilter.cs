using System.Collections.Generic;

namespace WebStore.Domain.Filters
{
    public class ProductFilter
    {
        /// <summary>
        /// Секция к которой принадлежит товар
        /// </summary>
        public int? SectionId { get; set; }

        /// <summary>
        /// Бренд товара
        /// </summary>
        public int? BrandId { get; set; }
        public IList<int> Ids { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Dto
{
    public class BrandViewModel : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Количество товаров бренда
        /// </summary>
        public int ProductsCount { get; set; }

        public int Order { get; set; }

    }
}

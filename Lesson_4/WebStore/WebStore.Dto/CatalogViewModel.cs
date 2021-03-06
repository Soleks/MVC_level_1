﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Dto
{
    public class CatalogViewModel
    {
        public int? BrandId { get; set; }
        public int? SectionId { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }

    }
}

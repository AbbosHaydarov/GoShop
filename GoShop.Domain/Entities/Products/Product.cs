﻿using GoShop.Domain.Commons;
using GoShop.Domain.Entities.Categories;
using GoShop.Domain.Entities.ShtrixCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities.Products
{
    public class Products : Auditable
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public int ShtrixCodeId { get; set; }
        public ShtrixCode ShtrixCode { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

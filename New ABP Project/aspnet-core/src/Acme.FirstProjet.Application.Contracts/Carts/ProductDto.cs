﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Basket.Baskets
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
    }
}

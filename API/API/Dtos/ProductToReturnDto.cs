﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductToReturnDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PictureURL { get; set; }

        public decimal Price { get; set; }

        public string ProductBrand { get; set; }

        public string ProductType { get; set; }

    }
}

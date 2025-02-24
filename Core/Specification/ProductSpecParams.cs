﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specification
{
    public class ProductSpecParams
    {
        private const int MaxPaginPage = 50;

        public int PageIndex { get; set; } = 1;

        private int _pageSize = 12;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPaginPage) ? MaxPaginPage : value;
        }


        public int? BrandId { get; set; }

        public int? TypeId { get; set; }

        public string Sort { get; set; }

        private string _search ;
        public string Search 
        { 
            get => _search; 
            set => _search = value.ToLower(); 
        }
    }
}

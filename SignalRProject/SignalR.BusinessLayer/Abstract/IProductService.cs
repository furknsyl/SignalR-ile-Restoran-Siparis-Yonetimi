﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        public int TProductCount();
        public int TProductCountByCategoryNameHamburger();
        public int TProductCountByCategoryNameDrink();
        public decimal TProductPriceAvg();

        public string TProductNameByMinPrice();
        public string TProductNameByMaxPrice();
        public decimal TProductAvgPriceByHamburger();
		List<Product> TGetLast9Products();
	}
}

﻿using Pilat.Eshop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilat.Eshop.Web.Models.ViewModels
{
    public class IndexViewModel
    {
        public IList<CarouselItem> CarouselItems { get; set; }
        public IList<Product> Products { get; set; }

        public IList<Order> Orders { get; set; }

    }
}

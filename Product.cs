﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payald.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }  // Navigation property
    }
}
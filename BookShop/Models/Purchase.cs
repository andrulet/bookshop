﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int BookId { get; set; }
        public DateTime dateTime { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
    }
}
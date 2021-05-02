﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExampleSite.Entity;

namespace ExampleSite.Models
{
    public class AdminOrder
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderState OrderState { get; set; }
        public int Count { get; set; }
    }
}
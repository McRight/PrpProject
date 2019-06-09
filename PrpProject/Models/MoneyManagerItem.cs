﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrpProject.Models
{
    public class MoneyManagerItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public decimal Balance { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.DTOs.ShoppingCartDto
{
    public class UpdateCartItemDto
    {
        public string userId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

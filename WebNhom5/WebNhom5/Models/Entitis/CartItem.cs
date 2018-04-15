using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebNhom5.Models.Entitis
{
    [Serializable]
    public class CartItem
    {
        public Product product { set; get; }
        public int Quantity { set; get; }
    }
}
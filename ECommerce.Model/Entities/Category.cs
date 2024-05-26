﻿
using ECommerce.Model.Base;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model.Entities
{
    public class Category :BaseEntity
    {
        public string CategoryName { get; set; }
        public string? Description { get; set; }


        //Mapping--Bir kategirinin ... ürünü olur.
        public List<Product> Products { get; set; }
    }
}

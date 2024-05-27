using ECommerce.BLL.ViewModels.CategoryViewModels;
using ECommerce.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.ProductViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        [Display(Name = "Ürün adı")]
        [Required(ErrorMessage = "Ürün ad boş geçilemez!")]
        public string ProductName { get; set; }
        
        public int CategoryId { get; set; }

        [Display(Name = "Ürün Fiyat")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Ürün Stok")]
        public short UnitsInStock { get; set; }

        [Display(Name = "Ürün Görsel")]
        public string? ImagePath { get; set; }

        [Display(Name = "Durum")]
        public DataStatus Status { get; set; }

        public List<CategoryViewModel>? Categories { get; set; }


    }
}

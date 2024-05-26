using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels
{
    public class ProductViewModel
    {
        [Display(Name ="Ürün adı")]
        public string ProductName { get; set; }

        [Display(Name ="Ürün açıklama")]
        public string Description { get; set; }

    }
}

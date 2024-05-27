using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.CategoryViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Kategori ad")]
        public string CategoryName { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}

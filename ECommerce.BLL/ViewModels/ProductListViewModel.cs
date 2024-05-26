using ECommerce.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public int ProductName { get; set;}
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DataStatus   Status { get; set; }
    }
}

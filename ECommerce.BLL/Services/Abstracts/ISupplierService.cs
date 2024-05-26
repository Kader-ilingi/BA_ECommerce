using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Abstracts
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Supplier GetSupplierById(int id);
        Task<string> CreateSupplier(Supplier supplier);
        Task<string> DeleteSupplier(Supplier supplier);
        Task<string> UpdateSupplier(Supplier supplier);
        IEnumerable<Supplier> GetActiveSuppliers();
        IEnumerable<Supplier> GetPassiveSuppliers();
        Task<string> DestroySupplier(Supplier supplier);
    }
}

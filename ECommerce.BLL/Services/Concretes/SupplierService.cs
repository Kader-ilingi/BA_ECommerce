using ECommerce.BLL.Repositories.Abstracts.Base;
using ECommerce.BLL.Services.Abstracts;
using ECommerce.Model.Entities;


namespace ECommerce.BLL.Services.Concretes
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepository<Supplier> _supplierRepository;

        public SupplierService(IRepository<Supplier> supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public async Task<string> CreateSupplier(Supplier supplier)
        {
            return await _supplierRepository.Create(supplier);
        }

        public async Task<string> DeleteSupplier(Supplier supplier)
        {
            return await _supplierRepository.Delete(supplier);
        }

        public async Task<string> DestroySupplier(Supplier supplier)
        {
            return await _supplierRepository.DestroyData(supplier);
        }

        public IEnumerable<Supplier> GetActiveSuppliers()
        {
            return _supplierRepository.GetActives();
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAll();
        }

        public IEnumerable<Supplier> GetPassiveSuppliers()
        {
            return _supplierRepository.GetPassives();
        }

        public Supplier GetSupplierById(int id)
        {
            return _supplierRepository.GetById(id);
        }

        public Task<string> UpdateSupplier(Supplier supplier)
        {
            return _supplierRepository.Update(supplier);
        }
    }
}

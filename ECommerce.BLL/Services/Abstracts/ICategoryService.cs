using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Abstracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        Task<string> CreateCategory(Category category);
        Task<string> DeleteCategory(Category category);
        Task<string> UpdateCategory(Category category);

        IEnumerable<Category> GetActiveCategories();
        IEnumerable<Category> GetPassiveCategories();
        Task<string> DestroyCategory(Category category);
    }
}

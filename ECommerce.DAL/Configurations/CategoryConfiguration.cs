using Bogus;
using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Properties
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.CategoryName).HasMaxLength(255);


            //HasData: veritabanında category tablosu oluşturulurken beraberinde varsayılan datalar ile birlikte oluşturulmasını sağlar.
            builder.HasData(SeedCategoryData());
        }
        //Category Data

        private List<Category> SeedCategoryData()
        {
            Faker faker = new Faker();
            List<Category> categories = new List<Category>();

            categories.Add(new Category { ID = 1, CategoryName = "Category 1", Description = "Category 1 Description" });
            categories.Add(new Category { ID = 2, CategoryName = "Category 2", Description = "Category 2 Description" });
            categories.Add(new Category { ID = 3, CategoryName = "Category 3", Description = "Category 3 Description" });
            //Category category = new Category()
            //{
            //    CategoryName = faker.Commerce.Categories;
            //};

            return categories;
        }
    }
}

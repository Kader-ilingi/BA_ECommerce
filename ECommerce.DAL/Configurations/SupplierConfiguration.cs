using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            //Property Customize
            builder.Property(x => x.CompanyName).IsRequired(true);
            builder.Property(x => x.CompanyName).HasMaxLength(255);

            builder.Property(x => x.Address).IsRequired(true);
            builder.Property(x => x.Address).HasMaxLength(255);

            builder.Property(x => x.PhoneNumber).IsRequired(false);
           
            

            //HasData
            builder.HasData(SeedSupplierData());

        }
        //Supplier Data
        private List<Supplier> SeedSupplierData()
        {
            List<Supplier> suppliers = new List<Supplier>();

            suppliers.Add(new Supplier
            {
                ID = 1,
                CompanyName = "Test Supplier-1",
                Address = "Test Supplier Adress-1",
                ContactName = "Test ContactName-11"

            });
            suppliers.Add(new Supplier
            {
                ID = 2,
                CompanyName = "Test Supplier-2",
                Address = "Test Supplier Adress-2",
                ContactName = "Test ContactName-2"
            });
            suppliers.Add(new Supplier
            {
                ID = 3,
                CompanyName = "Test Supplier-3",
                Address = "Test Supplier Adress-3",
                ContactName = "Test ContactName-3"
            });
            return suppliers;
        }
    }
}

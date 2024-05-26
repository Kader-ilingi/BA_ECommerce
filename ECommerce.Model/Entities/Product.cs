using ECommerce.Model.Base;


namespace ECommerce.Model.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string ImagePath { get; set; }


        //Mapping--bir ürünün bir kategorsi olur
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        //bir productın .... tane categorisi olur
        //Mappin
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }


    }
}

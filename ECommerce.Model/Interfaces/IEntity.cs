using ECommerce.Model.Enums;


namespace ECommerce.Model.Interfaces
{
    //Bu interface bütün entity'lere içerisinde barındırdığı özellikleri (property) miras yöntemiyle tesimli edecek. Aynı zamanda bu interface dışarıdan <T> alacak. almış olduğu bu generic tip'e göre ID'nin tipini belirleyecek.
    public interface IEntity<T>
    {
        //Id: verinin veritabanında PK olarak tanımlanmasını temsil edecek.
        //MasterId: verinin UI'da ya da tedarikçilerde görüntülenmesi için kullanılacak.
        public int ID { get; set; }
        public T MasterId { get; set; }
        //Created
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }

        //Updated
        public DateTime UpdatedData { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIpAddress { get; set; }

        public bool IsActive { get; set; }
        public DataStatus Status{ get; set; }

    }
}

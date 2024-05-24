using ECommerce.Model.Enums;
using ECommerce.Model.Interfaces;


namespace ECommerce.Model.BaseEntity
{
    public class BaseEntity : IEntity<Guid>//Baseentity nin somut nesne olmasını istemediğimiz için yani geneli temsil ettiği için abstract tanımlamalıyız.
    {
        public BaseEntity()
        {
            //
            Status = DataStatus.INSERTED;
            //create anında
            CreatedDate = DateTime.Now;
            CreatedComputerName = System.Environment.MachineName;
            CreatedIpAddress = "111.21.2.5";//todo: ıp yi gördüğümüzde burayı düzenleyeceğiz
            IsActive = true;
            MasterId = Guid.NewGuid();
        }
        public int ID { get ; set ; }
        public Guid MasterId { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public string CreatedComputerName { get ; set ; }
        public string CreatedIpAddress { get ; set ; }
        public DateTime UpdatedData { get ; set ; }
        public string UpdatedComputerName { get ; set ; }
        public string UpdatedIpAddress { get ; set ; }
        public bool IsActive { get ; set ; }
        public DataStatus Status { get ; set ; }
    }
}

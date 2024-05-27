using ECommerce.BLL.Repositories.Abstracts.Base;
using ECommerce.DAL.Context;
using ECommerce.Model.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Concretes.BaseConcrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;
        private DbSet<T> _entities;

        public BaseRepository(ECommerceContext context)
        {
            _context = context;
            _entities=_context.Set<T>();//cast işlemini bir kere aldımconstructırda ve bunu constructır  tetiklendiği anda bu cast işlemi devreye alınmış olcaktır
        }
        /// <summary>
        /// parametreden alınan entity'i veritabanın ekler ve bir string değer döner.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> Create(T entity)
        {
            try
            {
                entity.Status = Model.Enums.DataStatus.INSERTED;
                await _entities.AddAsync(entity);
                await _context.SaveChangesAsync();
                return "Kayıt işlemi başarılı";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        /// <summary>
        /// Delete işlemi veritabanında veriyi doğrudan kaldırmaktan ziyade o verinin durumunu Deleted olarak değiştirilmesini sağlar.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> Delete(T entity)
        {
            try
            {
                entity.Status = Model.Enums.DataStatus.DELETED;
                await Update(entity);
                await _context.SaveChangesAsync();
                return "Silme işlemi başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        /// <summary>
        /// Veritabanından veriyi komple kaldırmak için kullanılır.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> DestroyData(T entity)
        {
            _entities.Remove(entity);
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return "Veri kalıcı olarak silindi!";
            }
            else
            {
                return "bir hata meydana geldi";
            }
        }
        /// <summary>
        /// Aktif olan verileri liste olarak teslim eder.
        /// </summary>
        /// <returns></returns>
        public  IEnumerable<T> GetActives()
        {
            return _entities.Where(x => x.IsActive == true).ToList();
        }
        /// <summary>
        /// Bütün verileri teslim eder.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }
        /// <summary>
        /// Parametreden almış olduğu ID'e göre veriyi tekil oalrak teslim eder.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            try
            {
                return _entities.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Pasif olarak tanımlanan verileri liste halinde teslim eder.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetPassives()
        {
            return _entities.Where(x => x.IsActive == false).ToList();
        }
        /// <summary>
        /// Parametreden almış olduğu veriyi doğrudan veritabanında günceller.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> Update(T entity)
        {
            string result = "";
            switch (entity.Status)
            {
                case Model.Enums.DataStatus.DELETED:
                    entity.Status = Model.Enums.DataStatus.DELETED;

                    //EntityFramework ile birlikte bize sunulan Entry() metot paramaternin değerlerini veritabanındaki değerler ile otomatik olarak karşılaştırır eğer değişiklik görürse o değişikliği kendisi otomatik gerçekleştirir.

                    //_context veritabanını temsil ettiği için 

                    _context.Entry(entity).State = EntityState.Modified;
                    result = "Veri Güncellendi";


                    break;

                case Model.Enums.DataStatus.UPDATED:
                    entity.Status = Model.Enums.DataStatus.UPDATED;
                    _context.Entry(entity).State = EntityState.Modified;
                    result = "Veri Güncellendi";
                    break;
            }
            return result;
        }
    }
}

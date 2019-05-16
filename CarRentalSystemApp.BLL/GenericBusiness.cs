using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystemApp.DAL2;
using CarRentalSystemApp.Models;

namespace CarRentalSystemApp.BLL
{
    public class GenericBusiness<T> where  T: class
    {
        private static CarRentalAppContext _context;

        public static CarRentalAppContext Context
        {
            get
            {//context'in her koşulda dolu gelmesi sağlandı
                if (_context == null)
                    _context = new CarRentalAppContext();
                return _context;
            }
            set { _context = value; }
        }

        public void Ekle(T entity)
        {
            try
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Business:AraclarBusiness::AracEkle::Error occured.", ex);
            }
        }
        public T SelectById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void DeleteById(int id)
        {
            try
            {
                Context.Set<T>().Remove(SelectById(id));
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Business:AraclarBusiness::AracEkle::Error occured.", ex);
            }
        }

        public List<T> ListAll()
        {
            return Context.Set<T>().ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

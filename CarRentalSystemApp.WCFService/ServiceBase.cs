using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;


namespace CarRentalSystemApp.WCFService
{
    using CarRentalSystemApp.DTO;
    using CarRentalSystemApp.Models;
    using CarRentalSystemApp.DAL2.Repositories.Abstractions;

    public class ServiceBase<Rep, Ent, DTO> : IServiceBase<DTO> where Rep : IRepositoryBase<Ent>
    {
        private static Rep _repository;

        public static Rep Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = Activator.CreateInstance<Rep>();
                }
                return _repository;
            }
            set { _repository = value; }
        }

        //arayüzden bilgi girilir kaydede basarız buradaki ekleyi tetikler dto gelmiştir entity nesnesine dönüştürülür repositorye nesnelenelenir.
        public bool Ekle(DTO entity)
        {
            try
            {
                //var arac = Mapper.Map<DTO>(entity);


                Repository.Ekle(Mapper.Map<DTO, Ent>(entity));
                return true;
            }
            catch (Exception )
            {
                return false;
            }
            //return Repository.Ekle(Mapper.Map<DTO, Ent>(entity));
        }

        public bool Güncelle(DTO entity)
        {
            return Repository.Guncelle(Mapper.Map<DTO, Ent>(entity));
        }

            public List<DTO> Listele()
        {
            var arac = Repository.Listele();
            //Repository.Listele().Select(x => x.MapTo<DTO>()).ToList()
            return Mapper.Map<List<DTO>>(arac);
        }
        //var arac = Repository.Listele();
        //Repository.Listele().Select(x => x.MapTo<DTO>()).ToList()
        //return Mapper.Map<List<DTO>>(arac);

        public bool Sil(DTO entity)
        {
            return Repository.Sil(Mapper.Map<DTO, Ent>(entity));
        }

        public bool DeleteById(int id)
        {
            var entity = Repository.GetById(id);
            //var entity2 = Mapper.Map<Ent, DTO>(entity);Mapper.Map<DTO, Ent>(entity2)
            return Repository.Sil(entity);
        }

        public DTO GetById(int id)
        {
            var entity = Repository.GetById(id);
            return Mapper.Map<Ent, DTO>(entity);
        }

    }
}
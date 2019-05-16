using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarRentalSystemApp.Models;
using CarRentalSystemApp.DTO;

namespace CarRentalSystem.Helpers.Mapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Araclar, AraclarDTO>();
            CreateMap<KiralikBilgi, KiralikBilgiDTO>();
            CreateMap<Sirket, SirketDTO>();
            CreateMap<Musteriler, MusterilerDTO>();
            CreateMap<Calisanlar, CalisanlarDTO>();
            CreateMap<RezervasyonBilgi, RezervasyonBilgiDTO>();

        }
        /*
         private static Rep _repository;

        public static Rep Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = Activator.CreateInstance<Rep>();
                }
                return _repository; }
            set { _repository = value; }
        }

        //arayüzden bilgi girilir kaydede basarız buradaki ekleyi tetikler dto gelmiştir entity nesnesine dönüştürülür repositorye nesnelenelenir.
        public bool Ekle(DTO entity)
        {
            return Repository.Ekle(Mapper.Map<DTO, Ent>(entity));
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
          */
    }
}

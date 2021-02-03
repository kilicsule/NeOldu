using NeOldu.Data.Dal.Abstract;
using AutoMapper;
using Neoldu.Data.Domain.EntitiesDTO;
using Neoldu.Data.Domain.Entities;

namespace NeOldu.Data.Dal.Concrete.Manager
{
    public class AutoMapperManager : IMapperService
    {
        private Mapper _mapper;

        public AutoMapperManager()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ApplicaitonBlock, ApplicationUserBlockDTO>();
                cfg.CreateMap<ApplicationUserBlockDTO, ApplicaitonBlock>();
            });
            config.CreateMapper();

            _mapper = new Mapper(config);
        }
    public THedef Map<TKaynak, THedef>(TKaynak kaynak)
        {
            return _mapper.Map<THedef>(kaynak);
        }

        public THedef Map<TKaynak, THedef>(TKaynak kaynak, THedef hedef)
        {
            return _mapper.Map(kaynak, hedef);
        }
    }
}

using AutoMapper;

namespace NadTech.Service.MappingConfig
{
    public interface IMap<T>
    {
        void Map(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}

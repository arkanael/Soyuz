using AutoMapper;

namespace Soyuz.Application.Mappings
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutoMapperMap>();
            });
        }
    }
}

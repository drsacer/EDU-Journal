using AutoMapper;
using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            // .ForMember(x => x.Id, o => o.Ignore());

            CreateMap<WorkingDayDto, WorkingDay>();

            CreateMap<VacationDto, Vacation>();

            CreateMap<NonWorkingDayDto, NonWorkingDay>();
        }
    }
}

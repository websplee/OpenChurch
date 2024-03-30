using AutoMapper;
using OC.Domain.Models.Locations;
using OC.Domain.Models.Members;
using OC.Domain.Models.Users;
using OC.Domain.ViewModels.Locations;
using OC.Domain.ViewModels.Members;
using OC.Domain.ViewModels.Users;

namespace OC.Domain.ViewModels
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Member      
            CreateMap<Member, MemberViewModel>()
            .ReverseMap();            
            #endregion Member    
            #region User      
            CreateMap<RegisterViewModel, User>()
            .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email))
            .ReverseMap();
            CreateMap<UserViewModel, User>()
                .ReverseMap();
            CreateMap<RoleModule, RoleModuleViewModel>()
                .ReverseMap();
            #endregion User    

            #region Locations
            CreateMap<Country, CountryViewModel>()
                .ReverseMap();
            CreateMap<RegionLeadership, RegionLeadershipViewModel>()
                .ReverseMap();
            #endregion Locations


        }
    }
}

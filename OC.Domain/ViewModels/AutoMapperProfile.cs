using AutoMapper;
using OC.Domain.Models.Accounting;
using OC.Domain.Models.Branches;
using OC.Domain.Models.Locations;
using OC.Domain.Models.Members;
using OC.Domain.Models.Users;
using OC.Domain.ViewModels.Accounting;
using OC.Domain.ViewModels.Branches;
using OC.Domain.ViewModels.Locations;
using OC.Domain.ViewModels.Members;
using OC.Domain.ViewModels.Users;

namespace OC.Domain.ViewModels
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Accounting

            CreateMap<Expense, ExpenseViewModel>()
                .ReverseMap();
            CreateMap<ExpenseType, ExpenseTypeViewModel>()
                .ReverseMap();
            CreateMap<Income, IncomeViewModel>()
                .ReverseMap();
            CreateMap<IncomeType, IncomeTypeViewModel>()
                .ReverseMap();
            CreateMap<Pledge, PledgeViewModel>()
                .ReverseMap();

            #endregion Accounting

            #region Branches
            CreateMap<Branch, BranchViewModel>()
                .ReverseMap();
            CreateMap<Branch, BranchNewViewModel>()
                .ReverseMap();
            CreateMap<Branch, BranchMiniViewModel>()
                .ReverseMap();
            CreateMap<BranchLeadership, BranchLeadershipViewModel>()
                .ReverseMap();
            CreateMap<BranchMinistry, BranchMinistryViewModel>()
                .ReverseMap();
            CreateMap<BranchMinistryLeadership, BranchMinistryLeadershipViewModel>()
                .ReverseMap();
            CreateMap<BranchStaff, BranchStaffViewModel>()
                .ReverseMap();
            CreateMap<BranchStaffResignation, BranchStaffResignationViewModel>()
                .ReverseMap();
            CreateMap<CellGroup, CellGroupsDataViewModel>()
                .ReverseMap();
            CreateMap<CellGroup, CellGroupViewModel>()
                .ReverseMap();
            CreateMap<CellGroup, CellGroupMiniViewModel>()
                .ReverseMap();
            CreateMap<CellGroup, CellGroupNewViewModel>()
                .ReverseMap();
            CreateMap<CellGroupHost, CellGroupHostViewModel>()
                .ReverseMap();
            CreateMap<CellLeadership, CellLeadershipViewModel>()
                .ReverseMap();
            CreateMap<ChurchProgram, ChurchProgramViewModel>()
                .ReverseMap();
            CreateMap<ChurchProgramSession, ChurchProgramSessionViewModel>()
                .ReverseMap();
            CreateMap<ChurchProgramSession, ChurchProgramSessionEventViewModel>()
                .ReverseMap();
            CreateMap<ChurchProgramSession, ChurchProgramSessionEventDataViewModel>()
                .ReverseMap();
            CreateMap<ChurchProgramSessionAttendance, ChurchProgramSessionAttendanceViewModel>()
                .ReverseMap();
            CreateMap<ChurchProgramSessionVisitor, ChurchProgramSessionVisitorViewModel>()
                .ReverseMap();
            CreateMap<IncomingTransfer, IncomingTransferViewModel>()
                .ReverseMap();
            CreateMap<Ministry, MinistryViewModel>()
                .ReverseMap();
            CreateMap<OutgoingTransfer, OutgoingTransferViewModel>()
                .ReverseMap();
            #endregion Branches

            #region Locations
            CreateMap<ChurchSettings, ChurchSettingsViewModel>()
                 .ReverseMap();
            CreateMap<Continent, ContinentViewModel>()
                .ForMember(c => c.CountriesCount, opt => opt.MapFrom(src => (src.Countries ?? new List<Country>()).Count()))
                .ForMember(c => c.RegionsCount, opt => opt.MapFrom(src => (src.Countries.SelectMany(r => r.Regions).Count())))
                .ForMember(c => c.BranchesCount, opt => opt.MapFrom(src => (src.Countries.SelectMany(r => r.Regions).SelectMany(b => b.Branches).Count())))
                .ReverseMap();
            CreateMap<Country, CountryViewModel>()
                .ForMember(c => c.RegionsCount, opt => opt.MapFrom(src => (src.Regions ?? new List<Region>()).Count()))
                .ForMember(c => c.BanchesCount, opt => opt.MapFrom(src => (src.Regions.SelectMany(r => r.Branches).Count())))
                .ReverseMap();
            CreateMap<RegionLeadership, RegionLeadershipViewModel>()
                .ReverseMap();
            CreateMap<Region, RegionViewModel>()
                .ForMember(c => c.ContinentName, opt => opt.MapFrom(src => (src.Country.Continent.Name)))
                .ForMember(c => c.BranchesCount, opt => opt.MapFrom(src => (src.Branches ?? new List<Branch>()).Count()))
                .ForMember(c => c.RegionLeadershipsCount, opt => opt.MapFrom(src => (src.RegionLeaderships ?? new List<RegionLeadership>()).Count()))
                .ReverseMap();
            #endregion Locations

            #region Member       
            CreateMap<EducationField, EducationFieldViewModel>()
            .ReverseMap();      
            CreateMap<EducationLevel, EducationLevelViewModel>()
            .ReverseMap();      
            CreateMap<Family, FamilyViewModel>()
            .ReverseMap();      
            CreateMap<LeadershipRole, LeadershipRoleViewModel>()
            .ReverseMap();      
            CreateMap<MemberEducation, MemberEducationViewModel>()
            .ReverseMap();      
            CreateMap<MemberTransaction, MemberTransactionViewModel>()
            .ReverseMap();      
            CreateMap<Member, MemberViewModel>()
            .ReverseMap();       
          CreateMap<Member, MemberNewViewModel>()
            .ReverseMap();       
            CreateMap<Member, MembersDataViewModel>()
            .ReverseMap();       
            CreateMap<Member, AgeGroupViewModel>()
            .ReverseMap();        
            CreateMap<Member, RecentMemberViewModel>()
            .ReverseMap();      
            CreateMap<TransactionType, TransactionTypeViewModel>()
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
        }
    }
}

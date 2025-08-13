using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace AccountOwnerServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerDto>();
            CreateMap<Account, AccountDto>();
            CreateMap<OwnerCreationDto, Owner>();
            CreateMap<OwnerUpdateDto, Owner>();
            CreateMap<Owner, OwnerWithAccountsDto>();
            CreateMap<Account, AccountOfOwnerDTO>()
            ;//    .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.Owner!.Name));
            CreateMap<AccountCreationDto, Account>();
            CreateMap<AccountUpdateDto, Account>();
        }
    }
}


namespace Entities.DataTransferObjects
{
    public class OwnerWithAccountsDto : _ownerBaseDto
    {
        public IEnumerable<AccountDto>? Accounts { get; set; }
    }
}

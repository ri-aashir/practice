using Entities.Models;

namespace Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountById(Guid id);
        IEnumerable<Account> AccountsByOwner(Guid ownerId);
        void UpdateAccount(Account account);
        void CreateAccount(Account account);
        void DeleteAccount(Account account);
    }
}
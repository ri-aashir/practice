using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Account> GetAllAccounts() => FindAll().OrderBy(ac => ac.Owner.Name).ToList();

        public Account GetAccountById(Guid id) => 
            FindByCondition(account => account.Id.Equals(id))
            .FirstOrDefault();

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }

        public void UpdateAccount(Account account)
        {
            Update(account);
        }

        public void CreateAccount(Account account)
        {
            Create(account);
        }

        public void DeleteAccount(Account account)
        {
            Delete(account);
        }


    }
}
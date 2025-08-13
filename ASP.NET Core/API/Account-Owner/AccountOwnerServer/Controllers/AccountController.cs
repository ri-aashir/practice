using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        private ILoggerManager _logger;

        public AccountController(IRepositoryWrapper repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllAccounts()
        {
            try
            {
                var accounts = _repository.Account.GetAllAccounts();

                _logger.LogInfo($"Successfully retrieved all accounts from database.");

                var result = _mapper.Map<IEnumerable<AccountDto>>(accounts);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllAccounts action: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("{id}", Name = "AccountById")]
        public IActionResult GetAccountById(Guid id)
        {
            try
            {
                var account = _repository.Account.GetAccountById(id);

                if (account is null)
                {
                    _logger.LogError($"account with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Successfully retrieved account with id {id}.");
                    
                    var result = _mapper.Map<AccountDto>(account);
                    return Ok(result);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAccountById action: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("{ownerId}/accounts")]
        public IActionResult GetAccountsOfOwner(Guid ownerId)
        {
            try
            {
                var account = _repository.Account.AccountsByOwner(ownerId);

                if (!account.Any())
                {
                    _logger.LogError($"No registered account by this user");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned Accounts associated to owner");

                    var result = _mapper.Map<IEnumerable<AccountOfOwnerDTO>>(account);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetOwnerWithDetails action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAccount(Guid id, [FromBody] AccountUpdateDto account)
        {
            try
            {
                if (account is null)
                {
                    _logger.LogError("account object sent from client is null.");
                    return BadRequest("account object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid account object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var accountEntity = _repository.Account.GetAccountById(id);

                if (accountEntity is null)
                {
                    _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _mapper.Map(account, accountEntity);

                _repository.Account.UpdateAccount(accountEntity);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateAccount action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpPost]
        public IActionResult CreateAccount([FromBody] AccountCreationDto account)
        {
            try
            {
                if (account is null)
                {
                    _logger.LogError("Account object sent from client is null.");
                    return BadRequest("Account object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid account object sent from client.");
                    return BadRequest("Invalid model object");
                }

                if (_repository.Owner.GetOwnerById(account.OwnerId) is null)
                {
                    _logger.LogError("Non-existing Owner specified by client.");
                    return BadRequest($"No existing owner with the identifier {account.OwnerId}");
                }

                var accountEntity = _mapper.Map<Account>(account);

                _repository.Account.CreateAccount(accountEntity);
                _repository.Save();

                var createdAccount = _mapper.Map<AccountDto>(accountEntity);

                return CreatedAtRoute("AccountById", new { id = createdAccount.Id }, createdAccount);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateAccount action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAccount(Guid id)
        {
            try
            {
                var account = _repository.Account.GetAccountById(id);
                if (account == null)
                {
                    _logger.LogError($"Account with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _repository.Account.DeleteAccount(account);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteAccount action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }


    }
}

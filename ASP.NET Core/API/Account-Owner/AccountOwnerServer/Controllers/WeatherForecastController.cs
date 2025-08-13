using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly ILoggerManager _nlogger;
        private readonly IRepositoryWrapper _repository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ILoggerManager nlogger, IRepositoryWrapper repository)
        {
            _logger = logger;

            _nlogger = nlogger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            _nlogger.LogInfo("Here is info message from the controller.");
            _nlogger.LogDebug("Here is debug message from the controller.");
            _nlogger.LogWarn("Here is warn message from the controller.");
            _nlogger.LogError("Here is error message from the controller.");

            var domesticAccounts = _repository.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
            var owners = _repository.Owner.FindAll();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRoom.Services.Business;
using TheRoom.Services.Domain;

namespace TheRoom.Services.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicesController : ControllerBase
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly IServiceLogic _serviceLogic;

        public ServicesController(ILogger<ServicesController> logger, IServiceLogic serviceLogic)
        {
            _logger = logger;
            _serviceLogic = serviceLogic;
        }

        [HttpGet]
        [Route("search")]
        public IList<Service> Search(string filter, int pageSize, int pageNumber)
        {
            try
            {
                return _serviceLogic.SearchDescription(filter, pageSize, pageNumber);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Search failed!");
                throw;
            }
        }
    }
}

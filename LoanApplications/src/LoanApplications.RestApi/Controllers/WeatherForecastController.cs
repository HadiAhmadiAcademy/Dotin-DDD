using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.Application;
using LoanApplications.Application;

namespace LoanApplications.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanApplicationsController : ControllerBase
    {
        private readonly ICommandBus _bus;
        public LoanApplicationsController(ICommandBus bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public IActionResult Post()
        {
            //TODO: for demo purpose
            var placeLoanApplication = new PlaceLoanApplication()
            {
                Amount = 1000,
                PackBackPeriodInDays = 2000,
                ApplicantId = 10
            };
            _bus.Dispatch(placeLoanApplication);
            return Ok();
        }
    }
}

using Framework.Application;
using LoanApplications.Application;
using Microsoft.AspNetCore.Mvc;

namespace LoanApplications.RestApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanApplicationsController : ControllerBase
    {
        private ICommandBus _bus;
        public LoanApplicationsController(ICommandBus bus)
        {
            this._bus = bus;
        }

        [HttpPost]
        public IActionResult Post(PlaceLoanApplication command)
        {
            _bus.Dispatch(command);
            return Ok();
        }
    }
}

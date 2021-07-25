using System.Collections.Generic;
using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Interfaces;
using GlobalKinetic.Models.Requests;
using GlobalKinetic.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GlobalKinetic.Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinJarController : ControllerBase
    {
        private ICoinJarService _coinJarService;

        public CoinJarController(ICoinJarService coinJarService)
        {
            _coinJarService = coinJarService;
        }

        [Authorize]
        [HttpPost("addusacoin")]
        public ActionResult AddCoin(USACoin coin)
        {
            try
            {
                var response = _coinJarService.AddCoin(coin);

                if (response == 0)
                    return BadRequest(new { message = "Error adding coin to coin jar" });

                return Ok(response);
            }
            catch (System.Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [Authorize]
        [HttpPost("addrsacoin")]
        public ActionResult AddCoin(RSACoin coin)
        {
            try
            {
                var response = _coinJarService.AddCoin(coin);

                if (response == 0)
                    return BadRequest(new { message = "Error adding coin to coin jar" });

                return Ok(response);
            }
            catch (System.Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [Authorize]
        [HttpPost("gettotalamount")]
        public ActionResult GetTotalAmount()
        {
            var response = _coinJarService.GetTotalAmount();

            if (response < 0)
                return BadRequest(new { message = "Error getting total coin jar amount" });

            return Ok(response);
        }

        [Authorize]
        [HttpPost("reset")]
        public ActionResult Reset()
        {
            var response = _coinJarService.Reset();

            if (response == 0)
                return BadRequest(new { message = "Error re-setting coin jar" });

            return Ok(response);
        }
    }
}

using AccountingSystem.Services.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountingSystem.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        //Post: Payments file upload api/<PaymentController>

        public void UploadPayments([FromForm] IFormFile file)
        {
            //Parse file if valid call process payment logic
            string payments = FileParser.ParsePaymentFile(file);
            //call project manager logic
        }

    }
}

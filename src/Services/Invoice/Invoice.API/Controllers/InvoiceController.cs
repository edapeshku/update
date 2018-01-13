using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace eSupport.Services.Invoice.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize]
    public class InvoiceController : ControllerBase
    {
        
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace eSupport.Services.Equipment.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class EquipmentContoller : ControllerBase
    {
        public readonly EquipmentContext _equipmentContext;
        public readonly EquipmentSettings _settings;
    }
}
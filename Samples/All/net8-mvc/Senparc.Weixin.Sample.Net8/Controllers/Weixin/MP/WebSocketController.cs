﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senparc.Weixin.Sample.Net8.Controllers
{
    public class WebSocketController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

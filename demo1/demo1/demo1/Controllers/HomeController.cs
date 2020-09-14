using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace demo1.Controllers
{
    public class HomeController : AbpController
    {
        public string Get()
        {
            return "测试";
        }
    }
}

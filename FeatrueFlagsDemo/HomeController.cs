using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeatrueFlagsDemo
{
    //controller基本的功能开关
    [FeatureGate(FeatureFlags.EnableWebApi)]
    public class HomeController : Controller
    {

        private readonly IFeatureManager _featureManager;

        public HomeController(IFeatureManager featureManager)

        {

            _featureManager = featureManager;

        }


        public IActionResult Index()
        {
            return View();
        }

        //action级别的功能开关
        [FeatureGate(FeatureFlags.EnableAudit)]
        public async Task<IActionResult> Test()
        {
            //从DI中取出功能开关的值
            if (await _featureManager.IsEnabledAsync(nameof(FeatureFlags.EnableWebApi)))

            {

                // 执行代码  
                return Content("已经启用了EnableWebApi");

            }
            else
            {
                return Content("另一个返回");
            }

        }
    }
}

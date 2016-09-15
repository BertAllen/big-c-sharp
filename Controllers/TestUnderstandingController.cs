using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace big_c_sharp.Controllers
{
    public class TestUnderstandingController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "This is my test understanding controller.";
        }

        public string Test1()
        {
            return "This is my test #1 action ...";
        }

        public string Test2()
        {
            return "This is my second test action ...";
        }
    }
}

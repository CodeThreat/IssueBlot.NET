using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NETMVCBlot.Controllers
{
    public abstract class BaseController : Controller
    {
        protected abstract void Utility();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MistralMoviesApp.Controllers
{
    /// <summary>
    /// Extending base controller in case there is need for updating all controllers with same functionalities.
    /// Currently used for authorization example. 
    /// Could be extended for logging purposes and similar.
    /// </summary>
    [Authorize]
    public class BaseController : Controller
    {
    }
}

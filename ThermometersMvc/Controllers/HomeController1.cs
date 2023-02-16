using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ThermometersMvc.Controllers
{
    public class HomeController1 : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}

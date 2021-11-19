using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class c : Controller
    {
        public string Index()
        {
            //return View();
            return "Esta é minha action padrão!";
        }

        public string Welcome()
        {
            return "Esta é a ação bem-vindo!";
        }
    }
}

using EGames.Models;
using Microsoft.AspNetCore.Mvc;

namespace EGames.Controllers
{
    public class EquipeController : Controller
    {
        //ActionResult representam os vários códigos HTTP,

        //Códigos  HTTP - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status

        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //ViewBag = Reserva do espaço para armazenar informações para recuperar na VIEW

            ViewBag.Equips = equipeModel.LerEquipes();

            return View();
        }
    }
}

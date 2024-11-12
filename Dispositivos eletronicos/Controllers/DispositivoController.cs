using Dispositivos_eletronicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dispositivos_eletronicos.Controllers
{
    public class DispositivoController : Controller
    {
        
        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, Ehlaptop = true, MemoriaRam = 16, SistemOperacional = "Windows 11" }
            };
            return View(dispositivos);
        }
    }
}

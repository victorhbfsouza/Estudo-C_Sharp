using CardapioOnlineAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CardapioOnlineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly MenuService _service;

        public MenuController(MenuService menuService)
        {
            _service = menuService;
        }

        [HttpGet]
        public string ListarMenu()
        {
            string resposta = _service.GetAllMenuItems();
            return resposta;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReleaseManagement.Application.Interfaces;
using ReleaseManagement.Application.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReleaseManagement.Mvvm.Controllers
{
    public class ClientController : Controller
    {
        private IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ClientViewModel model = _clientService.GetClients();
            return View(model);
        }
    }
}

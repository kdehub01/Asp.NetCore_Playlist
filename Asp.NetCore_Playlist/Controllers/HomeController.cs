using Asp.NetCore_Playlist.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asp.NetCore_Playlist.Controllers
{
    public class HomeController : Controller // this Controller class present in Microsoft.AspNetCore.Mvc
    {
        //Here we are using constructor to inject IEmployeeRepository which is known as constructor injection
        
        //This home controller is not creating an instance of IEmployeeRepository using new keyword instead of it we are injecting it into this constructor
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

            //_employeeRepository = new MockEmployeeRepository(); -> We are not doing this because its tightly bind with this controller & we have many controller also which creates an issue

        }

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

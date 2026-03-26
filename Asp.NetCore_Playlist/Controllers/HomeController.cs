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
            ViewData["employeedata"] = _employeeRepository.GetEmployee(2).Name;
            ViewBag.EmailId = "abc@gmail.com";
            return _employeeRepository.GetEmployee(1).Name;
            // return View("xyz") :- when we wanna return some other view
            //return View("MyTempViews/tempviiew.cshtml") :- when we wanna return some other view which is not inside views folder , so for that we used absolute path ( file extension also required in this case )
            //return View("../SomeCustomViews/customviewfile") :- this .. means to move one level up in a hierarchy
            //return View();

           
        }

        public ActionResult MethodM1()
        {
            Employee data = _employeeRepository.GetEmployee(1);
            return View(data);
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

using iSchoolWebAppBogaard.Models;
using iSchoolWebAppBogaard.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace iSchoolWebAppBogaard.Controllers {
    public class HomeController : Controller {
        private readonly DataRetrieval _dataRetrieval;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _dataRetrieval = new DataRetrieval();
            _logger = logger;
        }
        
        public async Task<IActionResult> Index() {
            var dr = new DataRetrieval();
            var loadedAbout = await dr.GetData("about/");
            var aboutResult = JsonConvert.DeserializeObject<IndexModel>(loadedAbout);
            
            aboutResult.PageTitle = "RIT iSchool";
            return View(aboutResult);
        }
        
        public async Task<IActionResult> People() {
            var dr = new DataRetrieval();
            var loadedPeople = await dr.GetData("people/");
            var peopleResult = JsonConvert.DeserializeObject<PeopleModel>(loadedPeople);
            
            peopleResult.PageTitle = "iSchool Faculty & Staff";
            return View(peopleResult);
        }
        
        public async Task<IActionResult> Degrees() {
            var dr = new DataRetrieval();
            var loadedDegrees = await dr.GetData("degrees/");
            var degreesResult = JsonConvert.DeserializeObject<DegreeModel>(loadedDegrees);
            
            degreesResult.PageTitle = "iSchool Degrees";
            return View(degreesResult);
        }
        
        public async Task<IActionResult> Minors() {
            var dr = new DataRetrieval();
            var loadedMinors = await dr.GetData("minors/");
            var minorsResult = JsonConvert.DeserializeObject<MinorModel>(loadedMinors);
            
            minorsResult.PageTitle = "iSchool Minors";
            return View(minorsResult);
        }
        
        public async Task<IActionResult> Employment() {
            var dr = new DataRetrieval();
            var loadedEmployment = await dr.GetData("employment/employmentTable/");
            var employmentResult = JsonConvert.DeserializeObject<EmploymentModel>(loadedEmployment);

            employmentResult.PageTitle = "iSchool Employment";
            return View(employmentResult);
        }
        
        public async Task<IActionResult> Coop() {
            var dr = new DataRetrieval();
            var loadedCoop = await dr.GetData("employment/coopTable/");
            var coopResult = JsonConvert.DeserializeObject<CoopModel>(loadedCoop);
            
            coopResult.PageTitle = "iSchool Co-op";
            return View(coopResult);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
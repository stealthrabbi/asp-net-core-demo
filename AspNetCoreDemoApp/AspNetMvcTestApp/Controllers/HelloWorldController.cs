using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestDataLib.DomainModel;

namespace AspNetMvcTestApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private IList<DummyDataStructure> m_list;

        public HelloWorldController()
        {
            m_list = new List<DummyDataStructure>();
            m_list.Add(new DummyDataStructure
            {
                Name = "Luke",
                AltitudeMeters = 33.1f,
                NumberOfMarbles = 88,
            });
            m_list.Add(new DummyDataStructure
            {
                Name = "Leia",
                AltitudeMeters = 43.1f,
                NumberOfMarbles = 48,
            });
        }

        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public IEnumerable<DummyDataStructure> DefaultDataList()
        {
            return m_list;
        }
    }
}
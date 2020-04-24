using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using VeridiaApp.Models;

namespace VeridiaApp.Controllers
{
    public class NpcController : Controller
    {
        //GET: Npc
        public IActionResult Index()
        {
            IEnumerable<NpcViewModel> npcs = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http:localhost:44345/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Npcs");
                responseTask.Wait();

                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<NpcViewModel>>();

                    npcs = readTask.Result;
                }
                else //web api sent error response
                {
                    //TODO log response status here (create log method to send error to console.error output

                    npcs = Enumerable.Empty<NpcViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Contact administrator.");
                }
            }

            return View(npcs);
        }
    }
}
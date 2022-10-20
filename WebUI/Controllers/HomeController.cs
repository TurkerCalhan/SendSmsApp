using Business;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISmsService _smsService;

        public HomeController(ISmsService smsService)
        {
            _smsService = smsService;
        }

        public IActionResult Index()
        {           
            var list = new List<SmsServisSaglayici>();
            list.Add(new() { Id = 0, ServisSaglayici = "GuvenTelekom" });
            list.Add(new() { Id = 1, ServisSaglayici = "TFonTelekom" });
            list.Add(new() { Id = 2, ServisSaglayici = "NetGsm" });
            list.Add(new() { Id = 3, ServisSaglayici = "SmartMessage" });
            list.Add(new() { Id = 4, ServisSaglayici = "RelatedDigital" });
            list.Add(new() { Id = 5, ServisSaglayici = "Telsam" });
            list.Add(new() { Id = 6, ServisSaglayici = "Verimor" });            
            return View(list);
        }       
        
        
        [HttpPost]
        public IActionResult SendSms(SendSmsDto sendSmsDto)
        {
            var result = _smsService.SmsGonder(sendSmsDto.Telefon, sendSmsDto.Mesaj, sendSmsDto.ServisSaglayici);
            return RedirectToAction("Index");
        }
    }
}
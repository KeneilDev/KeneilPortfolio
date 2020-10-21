using KeneilPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace KeneilPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //Email Service
        private EmailAddress FromAndToEmailAddress;
        private IEmailService EmailService;

        public HomeController(EmailAddress _fromAddress,
            IEmailService _emailService)
        {
            FromAndToEmailAddress = _fromAddress;
            EmailService = _emailService;
        }


        public IActionResult Index()
        {
            return View();

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SendMail(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                EmailMessage msgToSend = new EmailMessage
                {
                    FromAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    ToAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    Content = $"Contact Name: {model.Name}\n" +
                    $"Email: {model.Email} \nMessage: {model.Message}",
                    Subject = "KeneilDev Contact Form"
                };
                EmailService.Send(msgToSend);
                System.Threading.Thread.Sleep(2800);
                return RedirectToAction("Index");
            }
            else
            {
                return Index();
            }
        }
    }
}

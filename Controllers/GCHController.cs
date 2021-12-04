using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GameCodeHut.Data;
using GameCodeHut.Models;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity;

namespace GameCodeHut.Controllers
{
    public class GCHController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GCHController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Receipt()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactForm record)
        {
            var contactrec = new ContactForm()
            {
                Email = record.Email,
                Subject = record.Subject,
                Message = record.Message,
                DateAdded = DateTime.Now

            };

            _context.ContactForms.Add(contactrec);
            _context.SaveChanges();

            return RedirectToAction("Contact");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Games()
        {
            return View();
        }

        public IActionResult Gamepurchase()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Gamepurchase(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "League of Legends Riot Points",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }

        public IActionResult Gamepurchase2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Gamepurchase2(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "Valorant Riot Points",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }

        public IActionResult Gamepurchase3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Gamepurchase3(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "Apex Gold Coins",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }

        public IActionResult Gamepurchase4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Gamepurchase4(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "Cyber Punk Credits",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }

        public IActionResult Gamepurchase5()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Gamepurchase5(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "Call of Duty Credits",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }

        public IActionResult Gamepurchase6()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Gamepurchase6(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "GTA Points",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }

        public IActionResult Gamepurchase7()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Gamepurchase7(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "Siege Points",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }

        public IActionResult Gamepurchase8()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Gamepurchase8(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "OverWatch Points",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }

        public IActionResult Gamepurchase9()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Gamepurchase9(Order record)
        {
            var orderrec = new Order()
            {
                GameAcct = record.GameAcct,
                Product = "Diamonds",
                Customer = record.Customer,
                Quantity = record.Quantity,
                OrderDate = DateTime.Now

            };

            _context.Orders.Add(orderrec);
            _context.SaveChanges();

            return RedirectToAction("Receipt");
        }
    }
}

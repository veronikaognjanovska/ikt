using Cinema.Domain.Domain;
using Cinema.Domain.DTO;
using Cinema.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClosedXML.Excel;
using GemBox.Document;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Cinema.Domain.Identity;

namespace Cinema.Web.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketService _TicketService;

        public TicketsController(ITicketService TicketServicet)
        {
            _TicketService = TicketServicet;
        }

        // GET: Tickets
        [HttpGet]
        public IActionResult Index()
        {
            var allTickets = this._TicketService.GetAllTickets();
            return View(allTickets);
        }

        [HttpPost]
        public IActionResult Index(string Date)
        {
            if (Date==null)
            {
                return RedirectToAction("Index");
            }
            var allTickets = this._TicketService.GetAllTicketsOnDate(Date);
            return View(allTickets);
        }

        [Authorize]
        public IActionResult AddTicketToCard(Guid? id)
        {
            var model = this._TicketService.GetShoppingCartInfo(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult AddTicketToCard([Bind("TicketId", "Quantity")] AddToShoppingCardDto item)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._TicketService.AddToShoppingCart(item, userId);

            if (result)
            {
                return RedirectToAction("Index", "Tickets");
            }

            return View(item);
        }

        // GET: Tickets/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Ticket = this._TicketService.GetDetailsForTicket(id);

            if (Ticket == null)
            {
                return NotFound();
            }

            return View(Ticket);
        }

        // GET: Tickets/Create
        [Authorize(Roles = RoleName.Admin)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public IActionResult Create([Bind("Id,MovieTitle,MovieImage,MovieDescription,TicketPrice,Genre,Date")] Ticket Ticket)
        {
            if (ModelState.IsValid)
            {
                this._TicketService.CreateNewTicket(Ticket);
                return RedirectToAction(nameof(Index));
            }
            return View(Ticket);
        }

        // GET: Tickets/Edit/5
        [Authorize(Roles = RoleName.Admin)]
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Ticket = this._TicketService.GetDetailsForTicket(id);

            if (Ticket == null)
            {
                return NotFound();
            }
            return View(Ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public IActionResult Edit(Guid id, [Bind("Id,MovieTitle,MovieImage,MovieDescription,TicketPrice,Genre,Date")] Ticket Ticket)
        {
            if (id != Ticket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._TicketService.UpdeteExistingTicket(Ticket);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(Ticket.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(Ticket);
        }

        // GET: Tickets/Delete/5
        [Authorize(Roles = RoleName.Admin)]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Ticket = this._TicketService.GetDetailsForTicket(id);

            if (Ticket == null)
            {
                return NotFound();
            }

            return View(Ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public IActionResult DeleteConfirmed(Guid id)
        {
            this._TicketService.DeleteTicket(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(Guid id)
        {
            return this._TicketService.GetDetailsForTicket(id) != null;
        }


        [HttpGet]
        [Authorize(Roles = RoleName.Admin)]
        public IActionResult ExportAllTickets()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public FileContentResult ExportAllTickets([Bind("Genre")] Ticket ticket)
        {
            string fileName = "Tickets-"+ticket.Genre+".xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("All Tickets - " + ticket.Genre);
                worksheet.ColumnWidth = 50;
                worksheet.Cell(1, 1).Value = "Ticket Id";
                worksheet.Cell(1, 2).Value = "Movie Title";
                worksheet.Cell(1, 3).Value = "Ticket Price";
                worksheet.Cell(1, 4).Value = "Date";
                worksheet.Cell(1, 5).Value = "Genre";
                worksheet.Cell(1, 6).Value = "Movie Description";
                worksheet.Cell(1, 7).Value = "Movie Image";

                var result = this._TicketService.GetAllTicketsGenre(ticket.Genre);
                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];
                    worksheet.Cell(i + 1, 1).Value = item.Id.ToString();
                    worksheet.Cell(i + 1, 2).Value = item.MovieTitle;
                    worksheet.Cell(i + 1, 3).Value = item.TicketPrice.ToString()+"$";
                    worksheet.Cell(i + 1, 4).Value = item.Date.ToString();
                    worksheet.Cell(i + 1, 5).Value = item.Genre;
                    worksheet.Cell(i + 1, 6).Value = item.MovieDescription;
                    worksheet.Cell(i + 1, 7).Value = item.MovieImage;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, contentType, fileName);
                }
            }
        }

        



    }
}
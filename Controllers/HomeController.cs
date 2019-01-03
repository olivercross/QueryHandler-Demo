using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QueryHandler.Domain;
using QueryHandler.Infrastructure;
using QueryHandler.Models;

namespace QueryHandler.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQueryHandler<AuditQuery, AuditDTO> _auditQuery;

        public HomeController(IQueryHandler<AuditQuery, AuditDTO> auditQuery)
        {
         _auditQuery = auditQuery;   
        }

        public IActionResult Index()
        {
            var query = new AuditQuery();
            query.AuditState = AuditState.InProgress;

            var result = _auditQuery.Handle(query);
            return View(result);
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

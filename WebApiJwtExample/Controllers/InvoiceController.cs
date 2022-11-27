using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwtExample.Model;
using WebApiJwtExample.Service.Abstract;

namespace WebApiJwtExample.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public IActionResult Save(Invoice invoice)
        {
            return Ok(_invoiceService.Save(invoice));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_invoiceService.GetAll());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            return Ok(_invoiceService.GetById(id));
        }

    }
}

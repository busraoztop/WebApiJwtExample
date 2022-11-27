using WebApiJwtExample.Data;
using WebApiJwtExample.Model;
using WebApiJwtExample.Service.Abstract;

namespace WebApiJwtExample.Service.Concrete
{
    public class InvoiceService : IInvoiceService
    {
        private readonly DatabaseContext _db;

        public InvoiceService(DatabaseContext db)
        {
            _db = db;
        }

        public IQueryable<string> GetById(int id)
        {
            var invoiceNo = _db.Set<Invoice>().Where(w => w.Id == id).Select(s => s.No);
            return invoiceNo;
        }
        

        public List<Invoice> GetAll()
        {
            var invoices = _db.Set<Invoice>().ToList();
            return invoices;
        }

        public bool Save(Invoice invoice)
        {
            _db.Add(invoice);
            _db.SaveChanges();
            return true;
        }
    }
}

using WebApiJwtExample.Model;

namespace WebApiJwtExample.Service.Abstract
{
    public interface IInvoiceService
    {
        bool Save(Invoice invoice);
        List<Invoice> GetAll();
        IQueryable<string> GetById(int id);
    }
}

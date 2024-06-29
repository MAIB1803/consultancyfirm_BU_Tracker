using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Domain.Entities;

namespace ConsultancyFirm.Application.Interfaces
{
    public interface IInvoiceService
    {
        Task<IEnumerable<Invoice>> GetAllInvoices();
        Task<Invoice> GetInvoiceById(int id);
        Task AddInvoice(Invoice invoice);
        Task UpdateInvoice(Invoice invoice);
        Task DeleteInvoice(int id);
    }
}

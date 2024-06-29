using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Application.Interfaces;
using ConsultancyFirm.Domain.Entities;
using ConsultancyFirm.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsultancyFirm.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ApplicationDbContext _context;

        public InvoiceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Invoice>> GetAllInvoices()
        {
            return await _context.Invoices.ToListAsync();
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            return await _context.Invoices.FindAsync(id);
        }

        public async Task AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateInvoice(Invoice invoice)
        {
            _context.Entry(invoice).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInvoice(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();
            }
        }
    }
}

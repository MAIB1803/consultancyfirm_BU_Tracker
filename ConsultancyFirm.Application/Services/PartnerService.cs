using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Application.Interfaces;
using ConsultancyFirm.Domain.Entities;
using ConsultancyFirm.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsultancyFirm.Application.Services
{
    public class PartnerService : IPartnerService
    {
        private readonly ApplicationDbContext _context;

        public PartnerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Partner>> GetAllPartners()
        {
            return await _context.Partners.ToListAsync();
        }

        public async Task<Partner> GetPartnerById(int id)
        {
            return await _context.Partners.FindAsync(id);
        }

        public async Task AddPartner(Partner partner)
        {
            _context.Partners.Add(partner);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePartner(Partner partner)
        {
            _context.Entry(partner).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePartner(int id)
        {
            var partner = await _context.Partners.FindAsync(id);
            if (partner != null)
            {
                _context.Partners.Remove(partner);
                await _context.SaveChangesAsync();
            }
        }
    }
}

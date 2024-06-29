using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Application.Interfaces;
using ConsultancyFirm.Domain.Entities;
using ConsultancyFirm.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsultancyFirm.Application.Services
{
    public class BusinessTrackerService : IBusinessTrackerService
    {
        private readonly ApplicationDbContext _context;

        public BusinessTrackerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BusinessTracker>> GetAllBusinessTrackers()
        {
            return await _context.BusinessTrackers.ToListAsync();
        }

        public async Task<BusinessTracker> GetBusinessTrackerById(int id)
        {
            return await _context.BusinessTrackers.FindAsync(id);
        }

        public async Task AddBusinessTracker(BusinessTracker businessTracker)
        {
            _context.BusinessTrackers.Add(businessTracker);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBusinessTracker(BusinessTracker businessTracker)
        {
            _context.Entry(businessTracker).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBusinessTracker(int id)
        {
            var businessTracker = await _context.BusinessTrackers.FindAsync(id);
            if (businessTracker != null)
            {
                _context.BusinessTrackers.Remove(businessTracker);
                await _context.SaveChangesAsync();
            }
        }
    }
}

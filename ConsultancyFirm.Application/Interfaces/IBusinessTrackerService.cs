using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Domain.Entities;

namespace ConsultancyFirm.Application.Interfaces
{
    public interface IBusinessTrackerService
    {
        Task<IEnumerable<BusinessTracker>> GetAllBusinessTrackers();
        Task<BusinessTracker> GetBusinessTrackerById(int id);
        Task AddBusinessTracker(BusinessTracker businessTracker);
        Task UpdateBusinessTracker(BusinessTracker businessTracker);
        Task DeleteBusinessTracker(int id);
    }
}

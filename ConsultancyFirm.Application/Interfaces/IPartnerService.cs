using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Domain.Entities;

namespace ConsultancyFirm.Application.Interfaces
{
    public interface IPartnerService
    {
        Task<IEnumerable<Partner>> GetAllPartners();
        Task<Partner> GetPartnerById(int id);
        Task AddPartner(Partner partner);
        Task UpdatePartner(Partner partner);
        Task DeletePartner(int id);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Application.Interfaces;
using ConsultancyFirm.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConsultancyFirm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartnersController : ControllerBase
    {
        private readonly IPartnerService _partnerService;

        public PartnersController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partner>>> GetPartners()
        {
            return Ok(await _partnerService.GetAllPartners());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Partner>> GetPartner(int id)
        {
            var partner = await _partnerService.GetPartnerById(id);
            if (partner == null)
            {
                return NotFound();
            }
            return Ok(partner);
        }

        [HttpPost]
        public async Task<ActionResult> AddPartner([FromBody] Partner partner)
        {
            await _partnerService.AddPartner(partner);
            return CreatedAtAction(nameof(GetPartner), new { id = partner.PartnerID }, partner);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePartner(int id, [FromBody] Partner partner)
        {
            if (id != partner.PartnerID)
            {
                return BadRequest();
            }

            await _partnerService.UpdatePartner(partner);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePartner(int id)
        {
            await _partnerService.DeletePartner(id);
            return NoContent();
        }
    }
}

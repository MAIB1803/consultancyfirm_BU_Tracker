namespace ConsultancyFirm.Domain.Entities
{
    public class Partner
    {
        public int PartnerID { get; set; }
        public string PartnerName { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
        public DateTime JoinedDate { get; set; }
        public string Role { get; set; }
    }
}

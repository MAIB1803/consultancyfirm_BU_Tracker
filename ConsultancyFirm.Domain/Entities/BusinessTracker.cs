namespace ConsultancyFirm.Domain.Entities
{
    public class BusinessTracker
    {
        public int TrackerID { get; set; }
        public int PartnerID { get; set; }
        public DateTime Date { get; set; }
        public string ClientName { get; set; }
        public string ProjectName { get; set; }
        public string IndustryType { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectDirectorManager { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeadSource { get; set; }
        public string LeadStatus { get; set; }
        public decimal EstimatedValue { get; set; }
        public DateTime ExpectedDealCloseDate { get; set; }
        public string TaskDescription { get; set; }
        public int BillableHours { get; set; }
        public string CommentsNotes { get; set; }
    }
}

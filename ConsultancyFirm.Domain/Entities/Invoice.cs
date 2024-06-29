namespace ConsultancyFirm.Domain.Entities
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string ClientName { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public int RelatedProjectID { get; set; }
        public string CommentsNotes { get; set; }
    }
}

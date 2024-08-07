namespace ConsultancyFirm.Domain.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DOJ { get; set; }
        public string Designation { get; set; }
        public string Competency { get; set; }
        public string SubCompetency { get; set; }
        public int AssignedPartnerID { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string EmployeeType { get; set; }
    }
}

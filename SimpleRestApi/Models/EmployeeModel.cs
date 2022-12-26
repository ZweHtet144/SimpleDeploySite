namespace SimpleRestApi.Models
{
    public class RequestModel
    {
        public string EmployeeId { get; set; }
    }
    public class EmployeeModel
    {
        public string Id { get; set; }
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string StartDate { get; set; }
        public string Division { get; set; }
        public string JobTitle { get; set; }
        public string Mobile { get; set; }
        public string OfficeNumber { get; set; }
        public string Mail { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string Manager { get; set; }
        public string City { get; set; }
        public string BranchCode { get; set; }
        public string Office { get; set; }
    }

    public class ResponseModel
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}

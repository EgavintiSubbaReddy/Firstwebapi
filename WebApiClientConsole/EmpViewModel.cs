namespace DemoWebApi.Models
{
    public class EmpViewModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Title { get; set; } = string.Empty;   
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string City { get; set; }
        public int ReportsTo { get; set; }
    }
}

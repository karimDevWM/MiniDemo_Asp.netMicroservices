namespace MiniDemo.Model
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Citizenship { get; set; }
    }

    public class EmployeeCollection
    {
        public List<Employee> Employees { get; set; }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    EmployeeName = "Karim Trabelsi",
                    Citizenship = "France",
                    EmployeeId = "4"
                },
                new Employee()
                {
                    EmployeeName = "Ali Trabelsi",
                    Citizenship = "France",
                    EmployeeId = "3"
                },
                new Employee()
                {
                    EmployeeName = "Nabiha Trabelsi",
                    Citizenship = "Tunisia",
                    EmployeeId = "2"
                },
                new Employee()
                {
                    EmployeeName = "Mohamed Trabelsi",
                    Citizenship = "Tunisia",
                    EmployeeId = "1"
                }
            };
        }
    }
}

namespace AB108EmployeeManagement;
#region Notes

/*
 Field və Property-lərə dəyər assign olunmadığı müddətcə özlərinə tiplərinə uyğun olaraq default value-ları götürürlər.
 
 */

#endregion
internal class Program
{
    static void Main(string[] args)
    {
        int id = 1;
        DateTime startTime = DateTime.Now;
        DateTime deadline = startTime.AddDays(7);
        Project project = new Project(id, startTime, deadline);


        Employee[] employees = new Employee[3];
        for (int i = 0; i < employees.Length; i++)
        {
            Employee employee = new Employee()
            {
                FullName = $"TestName {i}",
                Id = i,
            };

            employees[i] = employee;
        }

        project.Employees = employees;


        Employee newEmployee = new Employee()
        {
            Id = 999,
            FullName = "Musa",
        };
        project.AssignEmployee(newEmployee);
        project.Print();


        Console.WriteLine("-----------------------");

        project.RemoveEmployee(123);
        project.Print();

    }
}

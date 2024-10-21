namespace AB108EmployeeManagement;



#region Task

/*
  Project CLASS

Xüsusiyyətlər:
-Id
-Employees[]
-Starttime
-Deadline
-IsSuccessful

Davranışlar:
-AssignEmployee() - Employee object qəbul edəcək, method proyektə employee assign olunması üçün istifadə ediləcək

-RemoveEmployee() - Method proyektdən employee çıxarılması üçün istifadə ediləcək (həmçinin employee obyektindəki projects array-dən bu proyektin adı silinəcək) id qəbul edəcək

-Finish() - Method-u çağırıldıqda indiki vaxt start time ilə deadline time arasındadırsa(yəni deadline-ı keçməyibsə) isSuccesful dəyəri true olsun 

-Print() - Method-u proyektin bütün məlumatlarını console-a çıxartsın

Not: Project obyekti id, starttime və deadline dəyərlərini qəbul etmədən yaradıla bilməz
 
 
 */


#endregion
public class Project
{

    public int Id { get; set; }
    private Employee[] _employees;
    public Employee[] Employees
    {
        get { return _employees; }
        set { _employees = value; }
    }
    public DateTime StartTime { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsSuccessful { get; set; }



    public Project(int id, DateTime startTime, DateTime deadline)
    {
        Id = id;
        StartTime = startTime;
        Deadline = deadline;
        Employees = new Employee[1]; // potensial bug
    }


    public void AssignEmployee(Employee employee)
    {

        Array.Resize(ref _employees, Employees.Length + 1);
        Employees[Employees.Length - 1] = employee;

    }


    public void RemoveEmployee(int id)
    {
        Employee[] newEmployees = new Employee[Employees.Length - 1];
        int index = 0;

        for (int i = 0; i < Employees.Length; i++)
        {
            if (Employees[i].Id != id)
            {

                if (index == newEmployees.Length)
                {
                    Console.WriteLine("Hemin Id-li deyisene rast gelinmedi");
                    return;
                }
                else
                {
                    newEmployees[index] = Employees[i];
                    index++;

                }

            }

        }

        Employees = newEmployees;
    }


    public void Finish()
    {
        //
        IsSuccessful = true;
    }

    public void Print()
    {
        Console.WriteLine($"Id:{Id} Start time:{StartTime} Deadline:{Deadline} Successful:{IsSuccessful}");

        Console.WriteLine("Employees' datas:");
        foreach (Employee employee in Employees)
        {
            Console.WriteLine($"Employee Id:{employee.Id} Full name:{employee.FullName} ");
        }

        //cw Employees
    }
}
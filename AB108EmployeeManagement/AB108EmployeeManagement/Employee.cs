namespace AB108EmployeeManagement;

#region Task


/*
 Employee class

Xüsusiyyətlər:
-Id
-FullName
-Projects[]

Davranışlar:
-Leave() - Method proyektin id-sini qəbul edəcək. Həmin proyekt , projects array-dən silinəcək. Həmçinin project obyektinin özündə saxladığı employees array-dən silinəcək.

 */

#endregion
public class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public Project[] Projects { get; set; }


    public void Leave(int id)
    {
        //id axtaris ve project arrayden silinecek
    }
}

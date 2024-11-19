namespace AcademyManagementEFProject.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DOB { get; set; }
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public DateTime EnrollmentDate { get; set; }


    public override string ToString()
    {

        return $"{Id}-li  {FirstName} {LastName} adli telebe {Username} username-e sahibdir. Qeydiyyat tarixi:{EnrollmentDate}";
    }
}



using AcademyManagementEFProject.Contexts;
using AcademyManagementEFProject.Models;
using Microsoft.EntityFrameworkCore;

AcademyManagementDbContext context = new AcademyManagementDbContext();

Student student = new()
{
    FirstName = "Sumaya",
    LastName = "Mammadova",
    DOB = new(2006, 03, 12),
    EnrollmentDate = DateTime.Now,
    Username = "Mamedova777",
    Password = "Suma12345",
};

Student student2 = new()
{
    FirstName = "Ilqar",
    LastName = "Hacizade",
    DOB = new(2006, 03, 12),
    EnrollmentDate = DateTime.Now,
    Username = "Ilqar666",
    Password = "Ilqar123!",
};

Student student3 = new()
{
    FirstName = "Naciba",
    LastName = "Rasulova",
    DOB = new(2006, 03, 12),
    EnrollmentDate = DateTime.Now,
    Username = "Nadjiba",
    Password = "Naciba123!",
};

Student student4 = new()
{
    FirstName = "Revan",
    LastName = "Bayramov",
    DOB = new(2006, 03, 12),
    EnrollmentDate = DateTime.Now,
    Username = "YaraLi AwIq222",
    Password = "parolusindirma!",
};


await context.Students.AddAsync(student);
await context.Students.AddRangeAsync(student2, student3, student4);

await context.SaveChangesAsync();


List<Student> students = await context.Students.ToListAsync();
foreach (var st in students)
{
    Console.WriteLine(st);
}
using Project.DAL.Enums;

namespace Project.DAL.Models;

public class MyEntity
{

    //BaseEntity Properties
    public int Id { get; set; }
    public bool IsDeleted { get; set; }


    //SpecificEntity Properties

    public string Name { get; set; }

    public MyEntityStatus MyEntityStatus { get; set; }

    //AuditableEntity Properties

    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime DeletedAt { get; set; }
    public string DeletedBy { get; set; }

}

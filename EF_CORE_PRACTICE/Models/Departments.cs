namespace EF_CORE_PRACTICE.Models;

public class Department
{
    public int DepartmentId { get; set; }
    public string? DepartmentName { get; set; } = string.Empty;
    public string? Location { get; set; }
    public bool IsActive { get; set; }
    public string? PhoneNumber { get; set; }
}
//  update databse
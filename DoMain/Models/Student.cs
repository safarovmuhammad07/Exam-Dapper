namespace DoMain.Models;

public class Student
{
    public int StudentID { get; set; }
    public string StudentCode { get; set; }
    public string StudentFullName { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int SchoolId { get; set; }
    public int Stage { get; set; }
    public string Section { get; set; }
    public bool is_active { get; set; }
    public DateTime JoinDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
}

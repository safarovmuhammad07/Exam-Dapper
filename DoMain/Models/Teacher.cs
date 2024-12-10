namespace DoMain.Models;

public class Teacher
{
    public int TeacherId { get; set; }
    public string Teacher_Code { get; set; }
    public string Teacher_Full_Name { get; set; }
    public string Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public byte is_active { get; set; }
    public DateTime Join_Date { get; set; }
    public int Working_days { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; } 
}
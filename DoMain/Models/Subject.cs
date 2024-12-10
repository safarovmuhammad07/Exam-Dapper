namespace DoMain.Models;

public class Subject
{
    public int SubjectId { get; set; }
    public string Title { get; set; }
    public int  SchoolId { get; set; }
    public int Stage { get; set; }
    public int term { get; set; }
    public int Carry_Mark { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
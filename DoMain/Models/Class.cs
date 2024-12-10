namespace DoMain.Models;

public class Class
{
    public int  ClassId { get; set; }
    public string ClassName { get; set; }
    public int StudentId { get; set; }
    public string TeacherId { get; set; }
    public string ClassroomId { get; set; }
    public string Section { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
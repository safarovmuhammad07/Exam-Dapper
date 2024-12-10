namespace DoMain.Models;

public class School
{
    public int SchoolID { get; set; }
    public string School_Title { get; set; }
    public int Level_Count { get; set; }
    public bool Is_Active { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ParentService:IParentService
{
    private DapperContext context;

    public ParentService()
    {
        context = new DapperContext();
    }


    public List<Classroom> GetClassrooms()
    {
        return context.GetConnection().Query<Classroom>("SELECT * FROM Classrooms").ToList();
    }

    public Classroom GetClassroombyId(int id)
    {
        return context.GetConnection().Query<Classroom>("SELECT * FROM Classrooms WHERE ClassroomId = @id", new { id }).FirstOrDefault();
    }

    public bool AddClassroom(Classroom classroom)
    {
       return context.GetConnection().Execute("Insert Classroom(ClassroomId,Capacity,RoomType,Description) values(@ClassroomId,@Capacity,@RoomType,@Description) ", classroom) > 0;
    }

    public bool UpdateClassroom(Classroom classroom)
    {
        return context.GetConnection().Execute("Update Classroom set Capacity=@Capacity, RoomType=@RoomType, Description=@Description ", classroom) > 0;

    }

    public bool DeleteClassroom(int id)
    {
        return context.GetConnection().Execute("Delete Classroom where ClassroomId=@Id", new{id}) > 0;

    }
}
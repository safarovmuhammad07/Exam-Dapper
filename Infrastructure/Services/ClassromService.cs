using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassromService:IClassroomService
{
    private DapperContext context;

    public ClassromService()
    {
        context = new DapperContext();
    }

    public List<Classroom> GetClassrooms()
    {
        var sql = "select * from Classrooms";
        var res=context.GetConnection().Query<Classroom>(sql).ToList();
        return res;
    }

    public Classroom GetClassroomById(int id)
    {
        var sql = "select * from Classrooms where ClassroomId=@ClassroomId";
        var res = context.GetConnection().Query<Classroom>(sql, new { ClassroomId = id }).FirstOrDefault();
        return res;
    }

    public bool AddClassroom(Classroom classroom)
    {
        var sql = "insert into Classrooms (Capacity,RoomType,Description,CreatedAt,UpdatedAt) values (@Capacity,@RoomType,@Description,@CreatedAt,@UpdatedAt)";
        return context.GetConnection().Execute(sql, classroom)>0;
      
    }

    public bool UpdateClassroom(Classroom classroom)
    {
        var sql= "Update Classrooms set Capacity=@Capacity,RoomType=@RoomType,Description=@Description,CreatedAt=@CreatedAt,UpdatedAt=@UpdatedAt ";
        var res = context.GetConnection().Execute(sql, classroom)>0;
        return res;
    }

    public bool DeleteClassroom(int id)
    {
        var sql = "delete from Classrooms where ClassroomId=@ClassroomId";
        var res = context.GetConnection().Execute(sql, new { ClassroomId = id })>0;
        return res;
    }
    
    
    
}
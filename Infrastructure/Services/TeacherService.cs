using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class TeacherService: ITeacherService

{
    private DapperContext context;

    public TeacherService()
    {
        context = new DapperContext();
    }


    public List<Teacher> GetTeachers()
    {
        return  context.GetConnection().Query<Teacher>("SELECT * FROM Teacher").ToList();
    }

    public Teacher GetTeacherById(int teacherId)
    {
        return context.GetConnection().Query<Teacher>("Select * From Teacher Where Id = @id", new { id = teacherId }).FirstOrDefault();
    }

    public bool AddTeacher(Teacher teacher)
    {
        return context.GetConnection()
            .Execute(
                "Insert into Teacher(TeacherId,Teacher_Code,Teacher_Full_Name) values (@TeacherId,@Teacher_Code,@Teacher_Full_Name)", teacher)>0;
    }

    public bool UpdateTeacher(Teacher teacher)
    {
        return context.GetConnection()
            .Execute("Update Teacher set TeacherId=@TeacherId, Teacher_Code=@Teacher_Code", teacher) > 0;
    }

    public bool DeleteTeacher(Teacher teacher)
    {
        return context.GetConnection().Execute("Delete From Teacher Where TeacherId=@TeacherId", teacher) > 0;
    }
}
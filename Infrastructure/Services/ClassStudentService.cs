using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassStudentService: IClassStudentService
{
    private DapperContext context;

    public ClassStudentService()
    {
        context = new DapperContext();
    }

    public List<ClassStudent> GetClassStudents()
    {
        return context.GetConnection().Query<ClassStudent>("SELECT * FROM ClassStudent").ToList();
    }

    public ClassStudent GetClassStudentById(int id)
    {
        return context.GetConnection().Query<ClassStudent>("select * from ClassStudent where ClassStudentId = @id", new { id }).FirstOrDefault();
    }

    public bool AddClassStudent(ClassStudent classStudent)
    {
        return context.GetConnection()
                   .Execute(
                       "Insert ClassStudent(ClassStudentID,ClassId,StudentID) values(@ClassStudentID,@ClassId,@StudentId)", @classStudent) >
               0;
    }

    public bool UpdateClassStudent(ClassStudent classStudent)
    {
        return context.GetConnection()
            .Execute("Update ClassStudent set ClassStudent=@ClassStudent, ClassId=@ClassId, StudentId=@StudentId") > 0;
    }

    public bool DeleteClassStudent(int id)
    {
        return context.GetConnection().Execute("Delete ClassStudent where ClassStudentId = @id", new { id }) > 0;
    }
}
using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class StudentParentService: IStudentParentService
{
    private DapperContext context;

    public StudentParentService()
    {
        context = new DapperContext();
    }

    public List<StudentParent> GetStudentParentss()
    {
        return context.GetConnection().Query<StudentParent>("SELECT * FROM StudentParents").ToList();
    }

    public StudentParent GetStudentParentById(int id)
    {
        return context.GetConnection().Query<StudentParent>("Select * FROM StudentParents WHERE StudentParentId = @id", new { id }).FirstOrDefault();
    }

    public bool AddStudentParent(StudentParent studentParent)
    {
        return context.GetConnection()
                   .Execute(
                       "Insert into StudentParent(StudentParentId, StudentId, ParentId) values (@StudentParentId, @StudentId, @ParentId)") >
               0;
    }

    public bool UpdateStudentParent(StudentParent studentParent)
    {
        return context.GetConnection()
            .Execute(
                "Update StudentParent set ParentId = @ParentId where StudentParentId = @StudentParentId",
                studentParent) > 0;
    }

    public bool DeleteStudentParent(int id)
    {
        return context.GetConnection().Execute("Delete StudentParent WHERE StudentParentId = @id", new { id }) > 0;
    }
}
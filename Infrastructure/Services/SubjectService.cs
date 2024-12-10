using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class SubjectService: ISubjectService
{
    private DapperContext context;

    public SubjectService()
    {
        context = new DapperContext();
    }

    public List<Subject> GetSubjects()
    {
        return context.GetConnection().Query<Subject>("SELECT * FROM Subject").ToList();
    }

    public Subject GetSubjectById(int id)
    {
        return context.GetConnection().Query<Subject>("SELECT * FROM Subject WHERE SubjectId = @SubjectId", new { SubjectId = id }).FirstOrDefault();
    }

    public bool AddSubject(Subject subject)
    {
        return context.GetConnection()
            .Execute("Insert into Subject(SectionId, SubjectName) values (@SectionId, @SubjectName)", subject) > 0;
    }

    public bool UpdateSubject(Subject subject)
    {
        return context.GetConnection().Execute("Update Subject set SubjectName = @SubjectName where SubjectId = @SubjectId", subject) > 0;
    }

    public bool DeleteSubject(int id)
    {
        return context.GetConnection().Execute("Delete From Subject where SubjectId = @SubjectId", new { SubjectId = id }) > 0;
    }
}
using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class SchoolService: ISchoolService
{
    private DapperContext context;

    public SchoolService()
    {
        context = new DapperContext();
    }

    public List<School> GetSchools()
    {
        return context.GetConnection().Query<School>("SELECT * FROM School").ToList();
    }

    public School GetSchoolById(int id)
    {
        return context.GetConnection().Query<School>("SELECT * FROM School WHERE Id = @Id", new { Id = id }).FirstOrDefault();
    }

    public bool AddSchool(School school)
    {
        return context.GetConnection().Execute("INSERT INTO School (Name) VALUES (@Name)", school)>0;
    }

    public bool UpdateSchool(School school)
    {
        return context.GetConnection().Execute("UPDATE School SET Name = @Name WHERE Id = @Id", school)>0;
    }

    public bool DeleteSchool(int id)
    {
        return context.GetConnection().Execute("DELETE FROM School WHERE Id = @Id", new { Id = id })>0;
    }
}
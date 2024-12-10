using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassService: IClassService
{
    private DapperContext context;

    public ClassService()
    {
        context = new DapperContext();
    }


    public List<Class> GetClasses()
    {
        return context.GetConnection().Query<Class>("SELECT * FROM Class").ToList();
    }

    public Class? GetClassById(int id)
    {
        return context.GetConnection().Query<Class>("SELECT * FROM Class WHERE Id = @Id", new { Id = id }).FirstOrDefault();
    }

    public bool AddClass(Class @class)
    {
        return context.GetConnection().Execute("INSERT INTO Class (Name) VALUES (@Name)", @class) >= 1;
    }

    public bool UpdateClass(Class @class)
    {
        return context.GetConnection().Execute("UPDATE Class SET Name = @Name WHERE Id = @Id", @class) >= 1;
    }

    public bool DeleteClass(Class @class)
    {
        return context.GetConnection().Execute("DELETE FROM Class WHERE Id = @Id", @class) >= 1;
    }
}
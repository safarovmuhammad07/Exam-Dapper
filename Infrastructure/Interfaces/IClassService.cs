using DoMain.Models;

namespace Infrastructure.Interfaces;

public interface IClassService
{
    List<Class> GetClasses();
    Class? GetClassById(int id);
    bool AddClass(Class @class);
    bool UpdateClass(Class @class);
    bool DeleteClass(Class @class);
}
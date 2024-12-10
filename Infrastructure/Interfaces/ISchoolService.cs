using DoMain.Models;

namespace Infrastructure.Interfaces;

public interface ISchoolService
{
    List<School> GetSchools();
    School GetSchoolById(int id);
    bool AddSchool(School school);
    bool UpdateSchool(School school);
    bool DeleteSchool(int id);
    
    
}
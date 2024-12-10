using DoMain.Models;

namespace Infrastructure.Interfaces;

public interface ITeacherService
{
    List<Teacher> GetTeachers();
    Teacher GetTeacherById(int teacherId);
    bool AddTeacher(Teacher teacher);
    bool UpdateTeacher(Teacher teacher);
    bool DeleteTeacher(Teacher teacher);
}
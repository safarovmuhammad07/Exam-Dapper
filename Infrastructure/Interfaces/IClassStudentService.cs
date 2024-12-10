using DoMain.Models;

namespace Infrastructure.Interfaces;

public interface IClassStudentService
{
    List<ClassStudent> GetClassStudents();
    ClassStudent GetClassStudentById(int id);
    bool AddClassStudent(ClassStudent classStudent);
    bool UpdateClassStudent(ClassStudent classStudent);
    bool DeleteClassStudent(int id);
}
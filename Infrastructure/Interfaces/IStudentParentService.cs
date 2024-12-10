using DoMain.Models;

namespace Infrastructure.Interfaces;

public interface IStudentParentService
{
    List<StudentParent> GetStudentParentss();
    StudentParent GetStudentParentById(int id);
    bool AddStudentParent(StudentParent studentParent);
    bool UpdateStudentParent(StudentParent studentParent);
    bool DeleteStudentParent(int id);
}
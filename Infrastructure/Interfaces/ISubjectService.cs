using DoMain.Models;

namespace Infrastructure.Interfaces;

public interface ISubjectService
{
    List<Subject> GetSubjects();
    Subject GetSubjectById(int id);
    bool AddSubject(Subject subject);
    bool UpdateSubject(Subject subject);
    bool DeleteSubject(int id);
}
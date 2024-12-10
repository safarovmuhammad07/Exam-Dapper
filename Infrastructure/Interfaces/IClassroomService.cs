using DoMain.Models;

namespace Infrastructure.Interfaces;

public interface IClassroomService
{
    List<Classroom> GetClassrooms();
    Classroom GetClassroomById(int id);
    bool AddClassroom(Classroom classroom);
    bool UpdateClassroom(Classroom classroom);
    bool DeleteClassroom(int id);
    
}
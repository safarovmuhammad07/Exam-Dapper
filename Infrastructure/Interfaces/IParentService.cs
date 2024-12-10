using DoMain.Models;

namespace Infrastructure.Interfaces;

public interface IParentService
{
    List<Classroom> GetClassrooms();
    Classroom GetClassroombyId(int id);
    bool AddClassroom(Classroom classroom);
    bool UpdateClassroom(Classroom classroom);
    bool DeleteClassroom(int id);
    
}
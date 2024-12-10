using Dapper;
using DoMain.Models;
using Infrastructure.DapperConText;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class StudentService:IStudentService
{
    private DapperContext context;

    public StudentService()
    {
        context = new DapperContext();
    }

    public List<Student> GetStudents()
    {
        return context.GetConnection().Query<Student>("select * from Students").ToList();
    }

    public Student GetStudentById(int id)
    {
        return context.GetConnection().Query<Student>("select * from Students where Id = @id", new { id }).FirstOrDefault();
    }

    public bool AddStudent(Student student)
    {
        return context.GetConnection().Execute("Insert into Student(StudentId,StudentCode,StudentFullName,Gender) values (@StudentId,@StudentCode,@StudentFullName,@Gender) ",student)>0;
    }

    public bool UpdateStudent(Student student)
    {
        return context.GetConnection().Execute("Update Student set StudentCode=@StudentCode, StudentFullName=@StudentFullName, Gender=@Gender where Id=@Id",student)>0;
    }

    public bool DeleteStudent(int id)
    {
        return context.GetConnection().Execute("Delete Student where Id=@Id", new { Id = id }) > 0;
    }
}
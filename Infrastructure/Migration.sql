
CREATE TABLE  Student
(
    Student_Id serial primary key ,
    Student_Code varchar(45),
    Student_Full_Name varchar(45),
    Gender int,
    birthdate   TIMESTAMP,
    email varchar(45),
    phone varchar(45),
    schoolId int references School.schoolId,
    Stage int ,
    section char(12),
    is_active    bool,
    Joined_at   TIMESTAMP,

)
    
create table School
(
    schoolId     serial primary key,
    school_title varchar(45),
    Level_count  int,
    is_active    bool,
    Created_at   TIMESTAMP,
    Updated_at   TIMESTAMP
)        
create table Subject
(
    
    subjectId serial primary key ,
    Title varchar(45),
    schoolId int references School.schoolId,
    Stage int ,
    Term int ,
    Carry_Mark int,
    Created_at   TIMESTAMP,
    Updated_at   TIMESTAMP
)

create table Class 
(
    ClassId serial primary key ,
    ClassName varchar(45),
    StudentId  references StudentId.studentId,,
    TeacherId  references TeacherId.TeacherId,
    section varchar(45),
    Created_at   TIMESTAMP,
    Updated_at   TIMESTAMP
    
    
)








namespace SimpleOOP.Classes;

public class Course
{
    public string Name { get; private set; }
    public string Code { get; private set; }
    public string Type { get; private set; }

    public Course(string name, string code, string type)
    {
        Name = name;
        Code = code;
        Type = type;
    }

    public void EnrolStudents(List<Student> students)
    {
        students.ForEach(student => student.Courses.Add(this));
    }
}
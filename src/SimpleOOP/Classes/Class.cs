namespace SimpleOOP.Classes;

public class Class
{
    public DateTime ClassStart { get; private set; }
    public DateTime ClassFinish { get; private set; }
    public Course Course { get; private set; }
    public List<Student> Students { get; private set; }
    public Teacher Teacher { get; private set; }

    public Class(Course course, DateTime start, DateTime finish, Teacher? teacher = null)
    {
        Course = course;
        ClassStart = start;
        ClassFinish = finish;
        Teacher = teacher!;
        Students = new List<Student>();
    }
}
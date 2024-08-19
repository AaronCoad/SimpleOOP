namespace SimpleOOP.Classes;

public class Class
{
    public DateTime Date { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime FinishTime { get; private set; }
    public Course Course { get; private set; }
    public List<Student> Students { get; private set; }
    public Teacher Teacher { get; private set; }

    public Class(Course course, DateTime date, DateTime startTime, DateTime finishTime, Teacher? teacher = null)
    {
        Course = course;
        Date = date;
        StartTime = startTime;
        FinishTime = finishTime;
        Teacher = teacher!;
        Students = new List<Student>();
    }
}
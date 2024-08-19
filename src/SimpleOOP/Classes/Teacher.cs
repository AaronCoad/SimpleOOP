namespace SimpleOOP.Classes;

public class Teacher
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public List<Class> Classes { get; private set; }
    public List<Course> Courses { get; private set; }

    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Classes = new List<Class>();
        Courses = new List<Course>();
    }
}
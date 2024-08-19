using SimpleOOP.Classes;
using FluentAssertions;

namespace SimpleOOPTest;

public class StudentTests
{
    [Fact]
    public void CourseAddedToCoursesOnEnrol()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("Jimmy", "Rees"));
        students.Add(new Student("Anne", "Boleyne"));
        Course course = new Course("Projects 101", "P101", "Short");

        course.EnrolStudents(students);

        students.ForEach(student => student.Courses.Count.Should().Be(1));
    }
}
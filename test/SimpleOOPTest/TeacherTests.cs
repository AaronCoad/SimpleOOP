using SimpleOOP.Classes;
using FluentAssertions;
namespace SimpleOOPTest;

public class TeacherTests
{
    [Fact]
    public void NewTeacherProperlyInitialised()
    {
        Teacher teacher = new Teacher("Jane", "Smith");
        teacher.FirstName.Should().Be("Jane");
        teacher.LastName.Should().Be("Smith");
        teacher.Courses.Should().NotBeNull();
        teacher.Classes.Should().NotBeNull();
    }
}
namespace CrashCourse;

public class Model2 : IHasId
{
    public int Id { get; set; } = 2;
    public string Text { get; set; } = string.Empty;
    public int Number { get; set; }
}
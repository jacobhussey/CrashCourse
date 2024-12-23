namespace CrashCourse;

public class Model : IHasId
{
    public int Id { get; set; } = 1;
    public string Text { get; set; } = string.Empty;
    public int Number { get; set; }
}        
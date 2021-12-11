namespace asp_Lesson_2;

public interface IMyDayOfWeek
{
    DateTime Date { get; }
}

public class MyDayOfWeek : IMyDayOfWeek
{
    public DateTime Date => DateTime.UtcNow;
}
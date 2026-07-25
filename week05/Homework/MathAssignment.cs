public class MathAssignment : Assignment
{
    private string _textbookSections;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSections = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSections} Problem {_problems}";
    }
}
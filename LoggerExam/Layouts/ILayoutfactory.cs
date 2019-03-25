namespace LoggerExam.Layouts
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);

    }
}
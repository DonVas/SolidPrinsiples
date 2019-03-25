using System;

namespace LoggerExam.Layouts
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            string typeToLower = type.ToLower();
            switch (typeToLower)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw  new  ArgumentException("Invalide layout type!");
            }
        }
    }
}

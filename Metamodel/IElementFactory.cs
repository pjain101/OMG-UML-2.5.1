using UML.CommonStructure;

namespace UML
{
    public interface IElementFactory
    {
        TElement Create<TElement>(string uniqName) where TElement : Element;
    }
}
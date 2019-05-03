using UML.CommonStructure;

namespace UML.Factory.CommonStructure
{
    internal class PackageableElementImpl : NamedElementImpl, PackageableElement
    {
        public TemplateParameter templateParameter { get; set; }
    }
}
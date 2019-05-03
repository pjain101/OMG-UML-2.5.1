using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.Factory.CommonStructure
{
    internal class TemplateableElementImpl : ElementImpl, TemplateableElement
    {
        public TemplateSignature ownedTemplateSignature { get; set; }
        public IEnumerable<TemplateBinding> templateBinding { get; set; }
    }
}
using System;
using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.Factory.CommonStructure
{
    internal abstract class ElementImpl : Element
    {
        public IEnumerable<Comment> ownedComments { get; set; }

        public IEnumerable<Element> ownedElement { get; set; }

        public Element allOwnedElements(Element result)
        {
            throw new NotImplementedException();
        }

        public bool mustBeOwned()
        {
            throw new NotImplementedException();
        }
    }
}
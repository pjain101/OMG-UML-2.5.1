using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.Factory.CommonStructure
{
    internal sealed class CommentImpl : ElementImpl, Comment
    {
        public string Body { get; set; }

        public IEnumerable<Element> AnnotatedElements { get; set; }
    }
}
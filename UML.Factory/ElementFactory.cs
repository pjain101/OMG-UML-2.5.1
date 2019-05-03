using System;
using UML.CommonStructure;
using UML.Factory.Packages;

namespace UML.Factory
{
    public sealed class ElementFactory : IElementFactory
    {
        public TElement Create<TElement>(string uniqName) where TElement : Element
        {
            switch (typeof(TElement).Name)
            {
                //case "Package":
                //    var package = new PackageImpl();

                //    return package;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
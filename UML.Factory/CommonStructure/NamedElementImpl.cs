using System;
using System.Collections.Generic;
using UML.CommonStructure;
using UML.Packages;
using UML.Values;

namespace UML.Factory.CommonStructure
{
    internal abstract class NamedElementImpl : ElementImpl, NamedElement
    {
        public string name { get; set; }

        public string qualifiedName
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public VisibilityKind visibility
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public IEnumerable<Dependency> clientDependency
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public StringExpression nameExpression
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public IEnumerable<Namespace> allNamespaces(Namespace result)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Package> allOwningPackages(Package result)
        {
            throw new NotImplementedException();
        }

        public bool isDistinguishableFrom(NamedElement n, Namespace ns)
        {
            throw new NotImplementedException();
        }
    }
}
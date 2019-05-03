using System;
using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.Factory.CommonStructure
{
    internal class NamespaceImpl : NamedElementImpl, Namespace
    {
        public IEnumerable<PackageableElement> importedMember { get; set; }

        public IEnumerable<NamedElement> member { get; set; }

        public IEnumerable<PackageImport> packageImport { get; set; }

        public IEnumerable<Constraint> ownedRule { get; set; }

        public IEnumerable<NamedElement> ownedMember { get; set; }

        public IEnumerable<ElementImport> elementImport { get; set; }

        public PackageableElement excludeCollisions(PackageableElement result, PackageableElement imps)
        {
            throw new NotImplementedException();
        }

        public string getNamesOfMember(NamedElement element)
        {
            throw new NotImplementedException();
        }
    }
}
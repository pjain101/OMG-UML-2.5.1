///////////////////////////////////////////////////////////
//  TypedElement.cs
//  Implementation of the Class TypedElement
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:16
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.CommonStructure
{
    /// <summary>
    ///     A TypedElement is a NamedElement that may have a Type specified for it.
    /// </summary>
    public interface TypedElement : NamedElement
    {
        /// <summary>
        ///     The type of the TypedElement.
        /// </summary>
        Type type { get; set; }
    }
} //end namespace CommonStructure
///////////////////////////////////////////////////////////
//  ExpansionKind.cs
//  Implementation of the Enumeration ExpansionKind
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:00
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Actions
{
    /// <summary>
    ///     ExpansionKind is an enumeration type used to specify how an ExpansionRegion
    ///     executes its contents.
    /// </summary>
    public enum ExpansionKind
    {
        /// <summary>
        ///     The content of the ExpansionRegion is executed concurrently for the elements of
        ///     the input collections.
        /// </summary>
        parallel,

        /// <summary>
        ///     The content of the ExpansionRegion is executed iteratively for the elements of
        ///     the input collections, in the order of the input elements, if the collections
        ///     are ordered.
        /// </summary>
        iterative,

        /// <summary>
        ///     A stream of input collection elements flows into a single execution of the
        ///     content of the ExpansionRegion, in the order of the collection elements if the
        ///     input collections are ordered.
        /// </summary>
        stream
    } //end ExpansionKind
} //end namespace Actions
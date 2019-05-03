///////////////////////////////////////////////////////////
//  Lifeline.cs
//  Implementation of the Class Lifeline
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:04
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonStructure;
using UML.StructuredClassifiers;
using UML.Values;

namespace UML.Interactions
{
    /// <summary>
    ///     A Lifeline represents an individual participant in the Interaction. While parts
    ///     and structural features may have multiplicity greater than 1, Lifelines
    ///     represent only one interacting entity.
    /// </summary>
    public interface Lifeline : NamedElement
    {
        /// <summary>
        ///     References the InteractionFragments in which this Lifeline takes part.
        /// </summary>
        IEnumerable<InteractionFragment> coveredBy { get; set; }

        /// <summary>
        ///     References the ConnectableElement within the classifier that contains the
        ///     enclosing interaction.
        /// </summary>
        ConnectableElement represents { get; set; }

        /// <summary>
        ///     References the Interaction that represents the decomposition.
        /// </summary>
        PartDecomposition decomposedAs { get; set; }

        /// <summary>
        ///     If the referenced ConnectableElement is multivalued, then this specifies the
        ///     specific individual part within that set.
        /// </summary>
        ValueSpecification selector { get; set; }
    }
} //end namespace Interactions
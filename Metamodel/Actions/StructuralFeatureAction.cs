///////////////////////////////////////////////////////////
//  StructuralFeatureAction.cs
//  Implementation of the Class StructuralFeatureAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:14
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.Classification;

namespace UML.Actions
{
    /// <summary>
    ///     StructuralFeatureAction is an class for all Actions that operate on
    ///     StructuralFeatures.
    /// </summary>
    public interface StructuralFeatureAction : Action
    {
        /// <summary>
        ///     The StructuralFeature to be read or written.
        /// </summary>
        StructuralFeature structuralFeature { get; set; }

        /// <summary>
        ///     The InputPin from which the object whose StructuralFeature is to be read or
        ///     written is obtained.
        /// </summary>
        InputPin Object { get; set; }
    }
} //end namespace Actions
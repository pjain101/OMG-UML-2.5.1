///////////////////////////////////////////////////////////
//  StructuralFeature.cs
//  Implementation of the Class StructuralFeature
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:14
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.CommonStructure;

namespace UML.Classification
{
    /// <summary>
    ///     A StructuralFeature is a typed feature of a Classifier that specifies the
    ///     structure of instances of the Classifier.
    /// </summary>
    public interface StructuralFeature : Feature, TypedElement, MultiplicityElement
    {
        /// <summary>
        ///     If isReadOnly is true, the StructuralFeature may not be written to after
        ///     initialization.
        /// </summary>
        bool isReadOnly { get; set; }
    }
} //end namespace Classification
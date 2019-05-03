///////////////////////////////////////////////////////////
//  RemoveStructuralFeatureValueAction.cs
//  Implementation of the Class RemoveStructuralFeatureValueAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:13
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Actions
{
    /// <summary>
    ///     A RemoveStructuralFeatureValueAction is a WriteStructuralFeatureAction that
    ///     removes values from a StructuralFeature.
    /// </summary>
    public interface RemoveStructuralFeatureValueAction : WriteStructuralFeatureAction
    {
        /// <summary>
        ///     Specifies whether to remove duplicates of the value in nonunique
        ///     StructuralFeatures.
        /// </summary>
        bool isRemoveDuplicates { get; set; }

        /// <summary>
        ///     An InputPin that provides the position of an existing value to remove in
        ///     ordered, nonunique structural features. The type of the removeAt InputPin is
        ///     UnlimitedNatural, but the value cannot be zero or unlimited.
        /// </summary>
        InputPin removeAt { get; set; }
    }
} //end namespace Actions
///////////////////////////////////////////////////////////
//  Feature.cs
//  Implementation of the Class Feature
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:01
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Classification
{
    /// <summary>
    ///     A Feature declares a behavioral or structural characteristic of Classifiers.
    /// </summary>
    public interface Feature : RedefinableElement
    {
        /// <summary>
        ///     Specifies whether this Feature characterizes individual instances classified by
        ///     the Classifier (false) or the Classifier itself (true).
        /// </summary>
        bool isStatic { get; set; }

        /// <summary>
        ///     The Classifiers that have this Feature as a feature.
        /// </summary>
        Classifier featuringClassifier { get; set; }
    }
} //end namespace Classification
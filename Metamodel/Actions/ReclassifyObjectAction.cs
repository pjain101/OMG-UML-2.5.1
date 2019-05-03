///////////////////////////////////////////////////////////
//  ReclassifyObjectAction.cs
//  Implementation of the Class ReclassifyObjectAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:12
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Classification;

namespace UML.Actions
{
    /// <summary>
    ///     A ReclassifyObjectAction is an Action that changes the Classifiers that
    ///     classify an object.
    /// </summary>
    public interface ReclassifyObjectAction : Action
    {
        /// <summary>
        ///     Specifies whether existing Classifiers should be removed before adding the new
        ///     Classifiers.
        /// </summary>
        bool isReplaceAll { get; set; }

        /// <summary>
        ///     A set of Classifiers to be removed from the Classifiers of the given object.
        /// </summary>
        IEnumerable<Classifier> oldClassifier { get; set; }

        /// <summary>
        ///     A set of Classifiers to be added to the Classifiers of the given object.
        /// </summary>
        IEnumerable<Classifier> newClassifier { get; set; }

        /// <summary>
        ///     The InputPin that holds the object to be reclassified.
        /// </summary>
        InputPin Object { get; set; }
    }
} //end namespace Actions
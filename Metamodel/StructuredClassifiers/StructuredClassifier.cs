///////////////////////////////////////////////////////////
//  StructuredClassifier.cs
//  Implementation of the Class StructuredClassifier
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:15
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Classification;

namespace UML.StructuredClassifiers
{
    /// <summary>
    ///     StructuredClassifiers may contain an internal structure of connected elements
    ///     each of which plays a role in the overall Behavior modeled by the
    ///     StructuredClassifier.
    /// </summary>
    public interface StructuredClassifier : Classifier
    {
        /// <summary>
        ///     The roles that instances may play in this StructuredClassifier.
        /// </summary>
        IEnumerable<ConnectableElement> role { get; set; }

        /// <summary>
        ///     The Properties owned by the StructuredClassifier.
        /// </summary>
        IEnumerable<Property> ownedAttribute { get; set; }

        /// <summary>
        ///     The connectors owned by the StructuredClassifier.
        /// </summary>
        IEnumerable<Connector> ownedConnector { get; set; }

        /// <summary>
        ///     The Properties specifying instances that the StructuredClassifier owns by
        ///     composition. This collection is derived, selecting those owned Properties where
        ///     isComposite is true.
        /// </summary>
        IEnumerable<Property> part { get; set; }

        /// <summary>
        /// All features of type ConnectableElement, equivalent to all direct and inherited
        /// roles.
        /// </summary>
        /// <param name="result"></param>
        //ConnectableElement allRoles(ConnectableElement result){

        //	return null;
        //}

        /// <summary>
        /// Derivation for StructuredClassifier::/part
        /// </summary>
        /// <param name="result"></param>
        //UML.Classification.Property part(Property result){

        //	return null;
        //}
    }
} //end namespace StructuredClassifiers
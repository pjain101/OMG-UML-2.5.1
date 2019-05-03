///////////////////////////////////////////////////////////
//  Port.cs
//  Implementation of the Class Port
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:09
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Classification;
using UML.SimpleClassifiers;
using UML.StateMachines;

namespace UML.StructuredClassifiers
{
    /// <summary>
    ///     A Port is a property of an EncapsulatedClassifier that specifies a distinct
    ///     interaction point between that EncapsulatedClassifier and its environment or
    ///     between the (behavior of the) EncapsulatedClassifier and its internal parts.
    ///     Ports are connected to Properties of the EncapsulatedClassifier by Connectors
    ///     through which requests can be made to invoke BehavioralFeatures. A Port may
    ///     specify the services an EncapsulatedClassifier provides (offers) to its
    ///     environment as well as the services that an EncapsulatedClassifier expects
    ///     (requires) of its environment.  A Port may have an associated
    ///     ProtocolStateMachine.
    /// </summary>
    public interface Port : Property
    {
        /// <summary>
        ///     Specifies whether requests arriving at this Port are sent to the classifier
        ///     behavior of this EncapsulatedClassifier. Such a Port is referred to as a
        ///     behavior Port. Any invocation of a BehavioralFeature targeted at a behavior
        ///     Port will be handled by the instance of the owning EncapsulatedClassifier
        ///     itself, rather than by any instances that it may contain.
        /// </summary>
        bool isBehavior { get; set; }

        /// <summary>
        ///     Specifies the way that the provided and required Interfaces are derived from
        ///     the Port�s Type.
        /// </summary>
        bool isConjugated { get; set; }

        /// <summary>
        ///     If true, indicates that this Port is used to provide the published
        ///     functionality of an EncapsulatedClassifier.  If false, this Port is used to
        ///     implement the EncapsulatedClassifier but is not part of the essential
        ///     externally-visible functionality of the EncapsulatedClassifier and can,
        ///     therefore, be altered or deleted along with the internal implementation of the
        ///     EncapsulatedClassifier and other properties that are considered part of its
        ///     implementation.
        /// </summary>
        bool isService { get; set; }

        /// <summary>
        ///     The Interfaces specifying the set of Operations and Receptions that the
        ///     EncapsulatedCclassifier offers to its environment via this Port, and which it
        ///     will handle either directly or by forwarding it to a part of its internal
        ///     structure. This association is derived according to the value of isConjugated.
        ///     If isConjugated is false, provided is derived as the union of the sets of
        ///     Interfaces realized by the type of the port and its supertypes, or directly
        ///     from the type of the Port if the Port is typed by an Interface. If isConjugated
        ///     is true, it is derived as the union of the sets of Interfaces used by the type
        ///     of the Port and its supertypes.
        /// </summary>
        IEnumerable<Interface> provided { get; set; }

        /// <summary>
        ///     A Port may be redefined when its containing EncapsulatedClassifier is
        ///     specialized. The redefining Port may have additional Interfaces to those that
        ///     are associated with the redefined Port or it may replace an public interface by one of
        ///     its subtypes.
        /// </summary>
        IEnumerable<Port> redefinedPort { get; set; }

        /// <summary>
        ///     The Interfaces specifying the set of Operations and Receptions that the
        ///     EncapsulatedCassifier expects its environment to handle via this port. This
        ///     association is derived according to the value of isConjugated. If isConjugated
        ///     is false, required is derived as the union of the sets of Interfaces used by
        ///     the type of the Port and its supertypes. If isConjugated is true, it is derived
        ///     as the union of the sets of Interfaces realized by the type of the Port and its
        ///     supertypes, or directly from the type of the Port if the Port is typed by an
        ///     Interface.
        /// </summary>
        IEnumerable<Interface> required { get; set; }

        /// <summary>
        ///     An optional ProtocolStateMachine which describes valid interactions at this
        ///     interaction point.
        /// </summary>
        ProtocolStateMachine protocol { get; set; }

        /// <summary>
        /// The union of the sets of Interfaces realized by the type of the Port and its
        /// supertypes, or directly the type of the Port if the Port is typed by an
        /// Interface.
        /// </summary>
        /// <param name="result"></param>
        //UML.SimpleClassifiers.public interface basicProvided(public interface result){

        //	return null;
        //}

        /// <summary>
        /// The union of the sets of Interfaces used by the type of the Port and its
        /// supertypes.
        /// </summary>
        /// <param name="result"></param>
        //UML.SimpleClassifiers.public interface basicRequired(public interface result){

        //	return null;
        //}

        /// <summary>
        /// Derivation for Port::/provided
        /// </summary>
        /// <param name="result"></param>
        //UML.SimpleClassifiers.public interface provided(public interface result){

        //	return null;
        //}

        /// <summary>
        /// Derivation for Port::/required
        /// </summary>
        /// <param name="result"></param>
        //UML.SimpleClassifiers.public interface required(public interface result){

        //	return null;
        //}
    }
} //end namespace StructuredClassifiers
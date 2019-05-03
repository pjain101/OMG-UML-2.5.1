///////////////////////////////////////////////////////////
//  BehavioralFeature.cs
//  Implementation of the Class BehavioralFeature
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:53
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonBehavior;
using UML.CommonStructure;

namespace UML.Classification
{
    /// <summary>
    ///     A BehavioralFeature is a feature of a Classifier that specifies an aspect of
    ///     the behavior of its instances.  A BehavioralFeature is implemented (realized)
    ///     by a Behavior. A BehavioralFeature specifies that a Classifier will respond to
    ///     a designated request by invoking its implementing method.
    /// </summary>
    public interface BehavioralFeature : Namespace, Feature
    {
        /// <summary>
        ///     Specifies the semantics of concurrent calls to the same passive instance (i.e.,
        ///     an instance originating from a Class with isActive being false). Active
        ///     instances control access to their own BehavioralFeatures.
        /// </summary>
        CallConcurrencyKind concurrency { get; set; }

        /// <summary>
        ///     If true, then the BehavioralFeature does not have an implementation, and one
        ///     must be supplied by a more specific Classifier. If false, the BehavioralFeature
        ///     must have an implementation in the Classifier or one must be inherited.
        /// </summary>
        bool Is { get; set; }

        /// <summary>
        ///     A Behavior that implements the BehavioralFeature. There may be at most one
        ///     Behavior for a particular pairing of a Classifier (as owner of the Behavior)
        ///     and a BehavioralFeature (as specification of the Behavior).
        /// </summary>
        IEnumerable<Behavior> method { get; set; }

        /// <summary>
        ///     The ParameterSets owned by this BehavioralFeature.
        /// </summary>
        IEnumerable<ParameterSet> ownedParameterSet { get; set; }

        /// <summary>
        ///     The Types representing exceptions that may be raised during an invocation of
        ///     this BehavioralFeature.
        /// </summary>
        IEnumerable<Type> raisedException { get; set; }

        /// <summary>
        ///     The ordered set of formal Parameters of this BehavioralFeature.
        /// </summary>
        IEnumerable<Parameter> ownedParameter { get; set; }

        /// <summary>
        ///     The ownedParameters with direction in and inout.
        /// </summary>
        /// <param name="result"></param>
        Parameter inputParameters(Parameter result);

        /// <summary>
        ///     The query isDistinguishableFrom() determines whether two BehavioralFeatures may
        ///     coexist in the same Namespace. It specifies that they must have different
        ///     signatures.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="n"></param>
        /// <param name="ns"></param>
        bool isDistinguishableFrom(NamedElement n, Namespace ns);

        /// <summary>
        ///     The ownedParameters with direction out, inout, or return.
        /// </summary>
        /// <param name="result"></param>
        Parameter outputParameters(Parameter result);
    }
} //end namespace Classification
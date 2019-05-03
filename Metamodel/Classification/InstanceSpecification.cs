///////////////////////////////////////////////////////////
//  InstanceSpecification.cs
//  Implementation of the Class InstanceSpecification
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:03
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonStructure;
using UML.Deployments;
using UML.Values;

namespace UML.Classification
{
    /// <summary>
    ///     An InstanceSpecification is a model element that represents an instance in a
    ///     modeled system. An InstanceSpecification can act as a DeploymentTarget in a
    ///     Deployment relationship, in the case that it represents an instance of a Node.
    ///     It can also act as a DeployedArtifact, if it represents an instance of an
    ///     Artifact.
    /// </summary>
    public interface InstanceSpecification : DeployedArtifact, PackageableElement, DeploymentTarget
    {
        /// <summary>
        ///     A specification of how to compute, derive, or construct the instance.
        /// </summary>
        ValueSpecification specification { get; set; }

        /// <summary>
        ///     A Slot giving the value or values of a StructuralFeature of the instance. An
        ///     InstanceSpecification can have one Slot per StructuralFeature of its
        ///     Classifiers, including inherited features. It is not necessary to model a Slot
        ///     for every StructuralFeature, in which case the InstanceSpecification is a
        ///     partial description.
        /// </summary>
        IEnumerable<Slot> slot { get; set; }

        /// <summary>
        ///     The Classifier or Classifiers of the represented instance. If multiple
        ///     Classifiers are specified, the instance is classified by all of them.
        /// </summary>
        IEnumerable<Classifier> classifier { get; set; }
    }
} //end namespace Classification
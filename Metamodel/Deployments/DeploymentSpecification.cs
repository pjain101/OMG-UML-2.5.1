///////////////////////////////////////////////////////////
//  DeploymentSpecification.cs
//  Implementation of the Class DeploymentSpecification
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:58
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Deployments
{
    /// <summary>
    ///     A deployment specification specifies a set of properties that determine
    ///     execution parameters of a component artifact that is deployed on a node. A
    ///     deployment specification can be aimed at a specific type of container. An
    ///     artifact that reifies or implements deployment specification properties is a
    ///     deployment descriptor.
    /// </summary>
    public interface DeploymentSpecification : Artifact
    {
        /// <summary>
        ///     The location where an Artifact is deployed onto a Node. This is typically a
        ///     'directory' or 'memory address.'
        /// </summary>
        string deploymentLocation { get; set; }

        /// <summary>
        ///     The location where a component Artifact executes. This may be a local or remote
        ///     location.
        /// </summary>
        string executionLocation { get; set; }
    }
} //end namespace Deployments
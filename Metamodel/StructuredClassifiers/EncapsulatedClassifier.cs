///////////////////////////////////////////////////////////
//  EncapsulatedClassifier.cs
//  Implementation of the Class EncapsulatedClassifier
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:59
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.StructuredClassifiers
{
    /// <summary>
    ///     An EncapsulatedClassifier may own Ports to specify typed interaction points.
    /// </summary>
    public interface EncapsulatedClassifier : StructuredClassifier
    {
        /// <summary>
        ///     The Ports owned by the EncapsulatedClassifier.
        /// </summary>
        IEnumerable<Port> ownedPort { get; set; }

        /// <summary>
        /// Derivation for EncapsulatedClassifier::/ownedPort : Port
        /// </summary>
        /// <param name="result"></param>
        //Port ownedPort(Port result){

        //	return null;
        //}
    }
} //end namespace StructuredClassifiers
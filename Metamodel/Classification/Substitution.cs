///////////////////////////////////////////////////////////
//  Substitution.cs
//  Implementation of the Class Substitution
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:15
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.CommonStructure;

namespace UML.Classification
{
    /// <summary>
    ///     A substitution is a relationship between two classifiers signifying that the
    ///     substituting classifier complies with the contract specified by the contract
    ///     classifier. This implies that instances of the substituting classifier are
    ///     runtime substitutable where instances of the contract classifier are expected.
    /// </summary>
    public interface Substitution : Realization
    {
        /// <summary>
        ///     The contract with which the substituting classifier complies.
        /// </summary>
        Classifier contract { get; set; }
    }
} //end namespace Classification
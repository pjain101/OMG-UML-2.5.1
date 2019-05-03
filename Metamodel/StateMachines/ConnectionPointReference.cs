///////////////////////////////////////////////////////////
//  ConnectionPointReference.cs
//  Implementation of the Class ConnectionPointReference
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:56
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.StateMachines
{
    /// <summary>
    ///     A ConnectionPointReference represents a usage (as part of a submachine State)
    ///     of an entry/exit point Pseudostate defined in the StateMachine referenced by
    ///     the submachine State.
    /// </summary>
    public interface ConnectionPointReference : Vertex
    {
        /// <summary>
        ///     The exitPoints kind Pseudostates corresponding to this connection point.
        /// </summary>
        IEnumerable<Pseudostate> exit { get; set; }

        /// <summary>
        ///     The entryPoint Pseudostates corresponding to this connection point.
        /// </summary>
        IEnumerable<Pseudostate> entry { get; set; }

        /// <summary>
        /// The query isConsistentWith() specifies a ConnectionPointReference can only be
        /// redefined by a ConnectionPointReference.
        /// </summary>
        /// <param name="redefiningElement"></param>
        /// <param name="result"></param>
        //void isConsistentWith(RedefinableElement redefiningElement, result){

        //}
    }
} //end namespace StateMachines
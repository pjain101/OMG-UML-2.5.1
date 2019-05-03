///////////////////////////////////////////////////////////
//  ProtocolConformance.cs
//  Implementation of the Class ProtocolConformance
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:10
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.CommonStructure;

namespace UML.StateMachines
{
    /// <summary>
    ///     A ProtocolStateMachine can be redefined into a more specific
    ///     ProtocolStateMachine or into behavioral StateMachine. ProtocolConformance
    ///     declares that the specific ProtocolStateMachine specifies a protocol that
    ///     conforms to the general ProtocolStateMachine or that the specific behavioral
    ///     StateMachine abides by the protocol of the general ProtocolStateMachine.
    /// </summary>
    public interface ProtocolConformance : DirectedRelationship
    {
        /// <summary>
        ///     Specifies the ProtocolStateMachine to which the specific ProtocolStateMachine
        ///     conforms.
        /// </summary>
        ProtocolStateMachine generalMachine { get; set; }
    }
} //end namespace StateMachines
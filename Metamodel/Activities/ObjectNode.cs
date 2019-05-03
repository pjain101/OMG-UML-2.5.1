///////////////////////////////////////////////////////////
//  ObjectNode.cs
//  Implementation of the Class ObjectNode
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:07
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonBehavior;
using UML.CommonStructure;
using UML.StateMachines;
using UML.Values;

namespace UML.Activities
{
    /// <summary>
    ///     An ObjectNode is an ActivityNode that may hold tokens within the
    ///     object flow in an Activity. ObjectNodes also support token selection,
    ///     limitation on the number of tokens held, specification of the state required
    ///     for tokens being held, and carrying control values.
    /// </summary>
    public interface ObjectNode : ActivityNode, TypedElement
    {
        /// <summary>
        ///     Indicates whether the type of the ObjectNode is to be treated as representing
        ///     control values that may traverse ControlFlows.
        /// </summary>
        bool isControlType { get; set; }

        /// <summary>
        ///     Indicates how the tokens held by the ObjectNode are ordered for selection to
        ///     traverse ActivityEdges outgoing from the ObjectNode.
        /// </summary>
        ObjectNodeOrderingKind ordering { get; set; }

        /// <summary>
        ///     The maximum number of tokens that may be held by this ObjectNode. Tokens cannot
        ///     flow into the ObjectNode if the upperBound is reached. If no upperBound is
        ///     specified, then there is no limit on how many tokens the ObjectNode can hold.
        /// </summary>
        ValueSpecification upperBound { get; set; }

        /// <summary>
        ///     The States required to be associated with the values held by tokens on this
        ///     ObjectNode.
        /// </summary>
        IEnumerable<State> inState { get; set; }

        /// <summary>
        ///     A Behavior used to select tokens to be offered on outgoing ActivityEdges.
        /// </summary>
        Behavior selection { get; set; }
    }
} //end namespace Activities
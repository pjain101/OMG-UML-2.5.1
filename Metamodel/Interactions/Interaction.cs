///////////////////////////////////////////////////////////
//  Interaction.cs
//  Implementation of the Class Interaction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:03
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Actions;
using UML.CommonBehavior;

namespace UML.Interactions
{
    /// <summary>
    ///     An Interaction is a unit of Behavior that focuses on the observable exchange of
    ///     information between connectable elements.
    /// </summary>
    public interface Interaction : Behavior, InteractionFragment
    {
        /// <summary>
        ///     The Messages contained in this Interaction.
        /// </summary>
        IEnumerable<Message> message { get; set; }

        /// <summary>
        ///     The ordered set of fragments in the Interaction.
        /// </summary>
        IEnumerable<InteractionFragment> fragment { get; set; }

        /// <summary>
        ///     Specifies the participants in this Interaction.
        /// </summary>
        IEnumerable<Lifeline> lifeline { get; set; }

        /// <summary>
        ///     Specifies the gates that form the message public interface between this Interaction
        ///     and any InteractionUses which reference it.
        /// </summary>
        IEnumerable<Gate> formalGate { get; set; }

        /// <summary>
        ///     Actions owned by the Interaction.
        /// </summary>
        IEnumerable<Action> action { get; set; }
    }
} //end namespace Interactions
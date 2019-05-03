///////////////////////////////////////////////////////////
//  BroadcastSignalAction.cs
//  Implementation of the Class BroadcastSignalAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:54
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.SimpleClassifiers;

namespace UML.Actions
{
    /// <summary>
    ///     A BroadcastSignalAction is an InvocationAction that transmits a Signal instance
    ///     to all the potential target objects in the system. Values from the argument
    ///     InputPins are used to provide values for the attributes of the Signal. The
    ///     requestor continues execution immediately after the Signal instances are sent
    ///     out and cannot receive reply values.
    /// </summary>
    public interface BroadcastSignalAction : InvocationAction
    {
        /// <summary>
        ///     The Signal whose instances are to be sent.
        /// </summary>
        Signal signal { get; set; }
    }
} //end namespace Actions
///////////////////////////////////////////////////////////
//  TimeObservation.cs
//  Implementation of the Class TimeObservation
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:16
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.CommonStructure;

namespace UML.Values
{
    /// <summary>
    ///     A TimeObservation is a reference to a time instant during an execution. It
    ///     points out the NamedElement in the model to observe and whether the observation
    ///     is when this NamedElement is entered or when it is exited.
    /// </summary>
    public interface TimeObservation : Observation
    {
        /// <summary>
        ///     The value of firstEvent is related to the event. If firstEvent is true, then
        ///     the corresponding observation event is the first time instant the execution
        ///     enters the event Element. If firstEvent is false, then the corresponding
        ///     observation event is the time instant the execution exits the event Element.
        /// </summary>
        bool firstEvent { get; set; }

        /// <summary>
        ///     The TimeObservation is determined by the entering or exiting of the event
        ///     Element during execution.
        /// </summary>
        NamedElement Event { get; set; }
    }
} //end namespace Values
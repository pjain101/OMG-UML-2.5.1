///////////////////////////////////////////////////////////
//  TimeEvent.cs
//  Implementation of the Class TimeEvent
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:16
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.Values;

namespace UML.CommonBehavior
{
    /// <summary>
    ///     A TimeEvent is an Event that occurs at a specific point in time.
    /// </summary>
    public interface TimeEvent : Event
    {
        /// <summary>
        ///     Specifies whether the TimeEvent is specified as an absolute or relative time.
        /// </summary>
        bool isRelative { get; set; }

        /// <summary>
        ///     Specifies the time of the TimeEvent.
        /// </summary>
        TimeExpression when { get; set; }
    }
} //end namespace CommonBehavior
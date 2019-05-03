///////////////////////////////////////////////////////////
//  DurationConstraint.cs
//  Implementation of the Class DurationConstraint
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:59
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Values
{
    /// <summary>
    ///     A DurationConstraint is a Constraint that refers to a DurationInterval.
    /// </summary>
    public interface DurationConstraint : IntervalConstraint
    {
        /// <summary>
        ///     The value of firstEvent[i] is related to constrainedElement[i] (where i is 1 or
        ///     2). If firstEvent[i] is true, then the corresponding observation event is the
        ///     first time instant the execution enters constrainedElement[i]. If firstEvent[i]
        ///     is false, then the corresponding observation event is the last time instant the
        ///     execution is within constrainedElement[i].
        /// </summary>
        bool firstEvent { get; set; }

        /// <summary>
        ///     The DurationInterval constraining the duration.
        /// </summary>
        DurationInterval specification { get; set; }
    }
} //end namespace Values
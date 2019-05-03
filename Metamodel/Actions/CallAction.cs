///////////////////////////////////////////////////////////
//  CallAction.cs
//  Implementation of the Class CallAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:54
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Classification;

namespace UML.Actions
{
    /// <summary>
    ///     CallAction is an class for Actions that invoke a Behavior with given
    ///     argument values and (if the invocation is synchronous) receive reply values.
    /// </summary>
    public interface CallAction : InvocationAction
    {
        /// <summary>
        ///     If true, the call is synchronous and the caller waits for completion of the
        ///     invoked Behavior. If false, the call is asynchronous and the caller proceeds
        ///     immediately and cannot receive return values.
        /// </summary>
        bool isSynchronous { get; set; }

        /// <summary>
        ///     The OutputPins on which the reply values from the invocation are placed (if the
        ///     call is synchronous).
        /// </summary>
        IEnumerable<OutputPin> result { get; set; }

        /// <summary>
        ///     Return the in and inout ownedParameters of the Behavior or Operation being
        ///     called. (This operation is and should be overridden by subclasses of
        ///     CallAction.)
        /// </summary>
        /// <param name="result"></param>
        Parameter inputParameters(Parameter result);

        /// <summary>
        ///     Return the inout, out and return ownedParameters of the Behavior or Operation
        ///     being called. (This operation is and should be overridden by
        ///     subclasses of CallAction.)
        /// </summary>
        /// <param name="result"></param>
        Parameter outputParameters(Parameter result);
    }
} //end namespace Actions
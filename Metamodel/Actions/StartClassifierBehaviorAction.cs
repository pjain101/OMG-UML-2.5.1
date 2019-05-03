///////////////////////////////////////////////////////////
//  StartClassifierBehaviorAction.cs
//  Implementation of the Class StartClassifierBehaviorAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:14
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Actions
{
    /// <summary>
    ///     A StartClassifierBehaviorAction is an Action that starts the classifierBehavior
    ///     of the input object.
    /// </summary>
    public interface StartClassifierBehaviorAction : Action
    {
        /// <summary>
        ///     The InputPin that holds the object whose classifierBehavior is to be started.
        /// </summary>
        InputPin Object { get; set; }
    }
} //end namespace Actions
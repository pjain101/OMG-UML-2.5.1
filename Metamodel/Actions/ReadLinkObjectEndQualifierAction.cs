///////////////////////////////////////////////////////////
//  ReadLinkObjectEndQualifierAction.cs
//  Implementation of the Class ReadLinkObjectEndQualifierAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:11
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.Classification;

namespace UML.Actions
{
    /// <summary>
    ///     A ReadLinkObjectEndQualifierAction is an Action that retrieves a qualifier end
    ///     value from a link object.
    /// </summary>
    public interface ReadLinkObjectEndQualifierAction : Action
    {
        /// <summary>
        ///     The OutputPin where the result value is placed.
        /// </summary>
        OutputPin result { get; set; }

        /// <summary>
        ///     The InputPin from which the link object is obtained.
        /// </summary>
        InputPin Object { get; set; }

        /// <summary>
        ///     The qualifier Property to be read.
        /// </summary>
        Property qualifier { get; set; }
    }
} //end namespace Actions
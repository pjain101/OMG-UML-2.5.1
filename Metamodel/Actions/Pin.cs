///////////////////////////////////////////////////////////
//  Pin.cs
//  Implementation of the Class Pin
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:09
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.Activities;
using UML.CommonStructure;

namespace UML.Actions
{
    /// <summary>
    ///     A Pin is an ObjectNode and MultiplicityElement that provides input values to an
    ///     Action or accepts output values from an Action.
    /// </summary>
    public interface Pin : MultiplicityElement, ObjectNode
    {
        /// <summary>
        ///     Indicates whether the Pin provides data to the Action or just controls how the
        ///     Action executes.
        /// </summary>
        bool isControl { get; set; }
    }
} //end namespace Actions
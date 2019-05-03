///////////////////////////////////////////////////////////
//  PseudostateKind.cs
//  Implementation of the Enumeration PseudostateKind
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:10
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.StateMachines
{
    /// <summary>
    ///     PseudostateKind is an Enumeration type that is used to differentiate various
    ///     kinds of Pseudostates.
    /// </summary>
    public enum PseudostateKind
    {
        initial,
        deepHistory,
        shallowHistory,
        join,
        fork,
        junction,
        choice,
        entryPoint,
        exitPoint,
        terminate
    } //end PseudostateKind
} //end namespace StateMachines
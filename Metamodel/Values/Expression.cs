///////////////////////////////////////////////////////////
//  Expression.cs
//  Implementation of the Class Expression
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:01
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.Values
{
    /// <summary>
    ///     An Expression represents a node in an expression tree, which may be non-
    ///     terminal or terminal. It defines a symbol, and has a possibly empty sequence of
    ///     operands that are ValueSpecifications. It denotes a (possibly empty) set of
    ///     values when evaluated in a context.
    /// </summary>
    public interface Expression : ValueSpecification
    {
        /// <summary>
        ///     The symbol associated with this node in the expression tree.
        /// </summary>
        string symbol { get; set; }

        /// <summary>
        ///     Specifies a sequence of operand ValueSpecifications.
        /// </summary>
        IEnumerable<ValueSpecification> operand { get; set; }
    }
} //end namespace Values
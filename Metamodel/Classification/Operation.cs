///////////////////////////////////////////////////////////
//  Operation.cs
//  Implementation of the Class Operation
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:08
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.Classification
{
    /// <summary>
    ///     An Operation is a BehavioralFeature of a Classifier that specifies the name,
    ///     type, parameters, and constraints for invoking an associated Behavior. An
    ///     Operation may invoke both the execution of method behaviors as well as other
    ///     behavioral responses. Operation specializes TemplateableElement in order to
    ///     support specification of template operations and bound operations. Operation
    ///     specializes ParameterableElement to specify that an operation can be exposed as
    ///     a formal template parameter, and provided as an actual parameter in a binding
    ///     of a template.
    /// </summary>
    public interface Operation : BehavioralFeature, ParameterableElement, TemplateableElement
    {
        /// <summary>
        ///     Specifies whether the return parameter is ordered or not, if present.  This
        ///     information is derived from the return result for this Operation.
        /// </summary>
        bool isOrdered { get; set; }

        /// <summary>
        ///     Specifies whether an execution of the BehavioralFeature leaves the state of the
        ///     system unchanged (isQuery=true) or whether side effects may occur
        ///     (isQuery=false).
        /// </summary>
        bool isQuery { get; set; }

        /// <summary>
        ///     Specifies whether the return parameter is unique or not, if present. This
        ///     information is derived from the return result for this Operation.
        /// </summary>
        bool isUnique { get; set; }

        /// <summary>
        ///     Specifies the lower multiplicity of the return parameter, if present. This
        ///     information is derived from the return result for this Operation.
        /// </summary>
        bool lower { get; set; }

        /// <summary>
        ///     The upper multiplicity of the return parameter, if present. This information is
        ///     derived from the return result for this Operation.
        /// </summary>
        bool upper { get; set; }

        /// <summary>
        ///     The parameters owned by this Operation.
        /// </summary>
        IEnumerable<Parameter> ownedParameter { get; set; }

        /// <summary>
        ///     An optional set of Constraints on the state of the system when the Operation is
        ///     invoked.
        /// </summary>
        IEnumerable<Constraint> precondition { get; set; }

        /// <summary>
        ///     The Types representing exceptions that may be raised during an invocation of
        ///     this operation.
        /// </summary>
        IEnumerable<Type> raisedException { get; set; }

        /// <summary>
        ///     The Operations that are redefined by this Operation.
        /// </summary>
        IEnumerable<Operation> redefinedOperation { get; set; }

        /// <summary>
        ///     An optional set of Constraints specifying the state of the system when the
        ///     Operation is completed.
        /// </summary>
        IEnumerable<Constraint> postcondition { get; set; }

        /// <summary>
        ///     An optional Constraint on the result values of an invocation of this Operation.
        /// </summary>
        Constraint bodyCondition { get; set; }

        /// <summary>
        ///     The OperationTemplateParameter that exposes this element as a formal parameter.
        /// </summary>
        OperationTemplateParameter templateParameter { get; set; }

        /// <summary>
        ///     The return type of the operation, if present. This information is derived from
        ///     the return result for this Operation.
        /// </summary>
        Type type { get; set; }

        /// <summary>
        ///     The query isConsistentWith() specifies, for any two Operations in a context in
        ///     which redefinition is possible, whether redefinition would be consistent. A
        ///     redefining operation is consistent with a redefined operation if
        ///     it has the same number of owned parameters, and for each parameter the
        ///     following holds:
        ///     - Direction, ordering and uniqueness are the same.
        ///     - The corresponding types are covariant, contravariant or invariant.
        ///     - The multiplicities are compatible, depending on the parameter direction.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="redefiningElement"></param>
        bool isConsistentWith(RedefinableElement redefiningElement);

        /// <summary>
        /// If this operation has a return parameter, isOrdered equals the value of
        /// isOrdered for that parameter. Otherwise isOrdered is false.
        /// </summary>
        /// <param name="result"></param>
        //bool isOrdered();

        /// <summary>
        /// If this operation has a return parameter, isUnique equals the value of isUnique
        /// for that parameter. Otherwise isUnique is true.
        /// </summary>
        /// <param name="result"></param>
        //bool isUnique();

        /// <summary>
        /// If this operation has a return parameter, lower equals the value of lower for
        /// that parameter. Otherwise lower has no value.
        /// </summary>
        /// <param name="result"></param>
        //bool lower();

        /// <summary>
        ///     The query returnResult() returns the set containing the return parameter of the
        ///     Operation if one exists, otherwise, it returns an empty set
        /// </summary>
        /// <param name="result"></param>
        Parameter returnResult(Parameter result);

        /// <summary>
        ///     If this operation has a return parameter, type equals the value of type for
        ///     that parameter. Otherwise type has no value.
        /// </summary>
        /// <param name="result"></param>
        Type Type(Type result);

        /// <summary>
        /// If this operation has a return parameter, upper equals the value of upper for
        /// that parameter. Otherwise upper has no value.
        /// </summary>
        /// <param name="result"></param>
        //bool upper();
    }
} //end namespace Classification
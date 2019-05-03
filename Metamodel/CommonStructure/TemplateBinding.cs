///////////////////////////////////////////////////////////
//  TemplateBinding.cs
//  Implementation of the Class TemplateBinding
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:15
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.CommonStructure
{
    /// <summary>
    ///     A TemplateBinding is a DirectedRelationship between a TemplateableElement and a
    ///     template. A TemplateBinding specifies the TemplateParameterSubstitutions of
    ///     actual parameters for the formal parameters of the template.
    /// </summary>
    public interface TemplateBinding : DirectedRelationship
    {
        /// <summary>
        ///     The TemplateParameterSubstitutions owned by this TemplateBinding.
        /// </summary>
        IEnumerable<TemplateParameterSubstitution> parameterSubstitution { get; set; }

        /// <summary>
        ///     The TemplateSignature for the template that is the target of this
        ///     TemplateBinding.
        /// </summary>
        TemplateSignature signature { get; set; }
    }
} //end namespace CommonStructure
///////////////////////////////////////////////////////////
//  ClassifierTemplateParameter.cs
//  Implementation of the Class ClassifierTemplateParameter
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:55
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.Classification
{
    /// <summary>
    ///     A ClassifierTemplateParameter exposes a Classifier as a formal template
    ///     parameter.
    /// </summary>
    public interface ClassifierTemplateParameter : TemplateParameter
    {
        /// <summary>
        ///     Constrains the required relationship between an actual parameter and the
        ///     parameteredElement for this formal parameter.
        /// </summary>
        bool allowSubstitutable { get; set; }

        /// <summary>
        ///     The Classifier exposed by this ClassifierTemplateParameter.
        /// </summary>
        Classifier parameteredElement { get; set; }

        /// <summary>
        ///     The classifiers that constrain the argument that can be used for the parameter.
        ///     If the allowSubstitutable attribute is true, then any Classifier that is
        ///     compatible with this constraining Classifier can be substituted; otherwise, it
        ///     must be either this Classifier or one of its specializations. If this property
        ///     is empty, there are no constraints on the Classifier that can be used as an
        ///     argument.
        /// </summary>
        IEnumerable<Classifier> constrainingClassifier { get; set; }
    }
} //end namespace Classification
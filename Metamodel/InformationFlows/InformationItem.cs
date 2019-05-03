///////////////////////////////////////////////////////////
//  InformationItem.cs
//  Implementation of the Class InformationItem
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:03
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Classification;

namespace UML.InformationFlows
{
    /// <summary>
    ///     InformationItems represent many kinds of information that can flow from sources
    ///     to targets in very ways.� They represent the kinds of information that
    ///     may move within a system, but do not elaborate details of the transferred
    ///     information.� Details of transferred information are the province of other
    ///     Classifiers that may ultimately define InformationItems.� Consequently,
    ///     InformationItems cannot be instantiated and do not themselves have features,
    ///     generalizations, or associations.�An important use of InformationItems is to
    ///     represent information during early design stages, possibly before the detailed
    ///     modeling decisions that will ultimately define them have been made. Another
    ///     purpose of InformationItems is to portions of complex models in less
    ///     precise, but perhaps more general and communicable, ways.
    /// </summary>
    public interface InformationItem : Classifier
    {
        /// <summary>
        ///     Determines the classifiers that will specify the structure and nature of the
        ///     information. An information item represents all its represented classifiers.
        /// </summary>
        IEnumerable<Classifier> represented { get; set; }
    }
} //end namespace InformationFlows
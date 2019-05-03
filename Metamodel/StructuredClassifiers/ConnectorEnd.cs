///////////////////////////////////////////////////////////
//  ConnectorEnd.cs
//  Implementation of the Class ConnectorEnd
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:56
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.Classification;
using UML.CommonStructure;

namespace UML.StructuredClassifiers
{
    /// <summary>
    ///     A ConnectorEnd is an endpoint of a Connector, which attaches the Connector to a
    ///     ConnectableElement.
    /// </summary>
    public interface ConnectorEnd : MultiplicityElement
    {
        /// <summary>
        ///     The ConnectableElement attached at this ConnectorEnd. When an instance of the
        ///     containing Classifier is created, a link may (depending on the multiplicities)
        ///     be created to an instance of the Classifier that types this ConnectableElement.
        /// </summary>
        ConnectableElement role { get; set; }

        /// <summary>
        ///     A derived property referencing the corresponding end on the Association which
        ///     types the Connector owing this ConnectorEnd, if any. It is derived by selecting
        ///     the end at the same place in the ordering of Association ends as this
        ///     ConnectorEnd.
        /// </summary>
        Property definingEnd { get; set; }

        /// <summary>
        ///     Indicates the role of the internal structure of a Classifier with the Port to
        ///     which the ConnectorEnd is attached.
        /// </summary>
        Property partWithPort { get; set; }

        /// <summary>
        /// Derivation for ConnectorEnd::/definingEnd : Property
        /// </summary>
        /// <param name="result"></param>
        //UML.Classification.Property definingEnd(Property result){

        //	return null;
        //}
    }
} //end namespace StructuredClassifiers
///////////////////////////////////////////////////////////
//  AggregationKind.cs
//  Implementation of the Enumeration AggregationKind
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:53
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Classification
{
    /// <summary>
    ///     AggregationKind is an Enumeration for specifying the kind of aggregation of a
    ///     Property.
    /// </summary>
    public enum AggregationKind
    {
        /// <summary>
        ///     Indicates that the Property has no aggregation.
        /// </summary>
        none,

        /// <summary>
        ///     Indicates that the Property has shared aggregation.
        /// </summary>
        shared,

        /// <summary>
        ///     Indicates that the Property is aggregated compositely, i.e., the composite
        ///     object has responsibility for the existence and storage of the composed objects
        ///     (parts).
        /// </summary>
        composite
    } //end AggregationKind
} //end namespace Classification
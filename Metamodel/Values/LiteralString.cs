///////////////////////////////////////////////////////////
//  LiteralString.cs
//  Implementation of the Class LiteralString
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:05
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Values
{
    /// <summary>
    ///     A LiteralString is a specification of a String value.
    /// </summary>
    public interface LiteralString : LiteralSpecification
    {
        /// <summary>
        ///     The specified String value.
        /// </summary>
        string value { get; set; }


        /// <summary>
        /// The query isComputable() is redefined to be true.
        /// </summary>
        /// <param name="result"></param>
        //void isComputable(result){

        //}

        /// <summary>
        /// The query stringValue() gives the value.
        /// </summary>
        /// <param name="result"></param>
        //void stringValue(result){

        //}
    }
} //end namespace Values
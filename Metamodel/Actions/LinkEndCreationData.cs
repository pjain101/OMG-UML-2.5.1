///////////////////////////////////////////////////////////
//  LinkEndCreationData.cs
//  Implementation of the Class LinkEndCreationData
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:05
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Actions
{
    /// <summary>
    ///     LinkEndCreationData is LinkEndData used to provide values for one end of a link
    ///     to be created by a CreateLinkAction.
    /// </summary>
    public interface LinkEndCreationData : LinkEndData
    {
        /// <summary>
        ///     Specifies whether the existing links emanating from the object on this end
        ///     should be destroyed before creating a new link.
        /// </summary>
        bool isReplaceAll { get; set; }

        /// <summary>
        ///     For ordered Association ends, the InputPin that provides the position where the
        ///     new link should be inserted or where an existing link should be moved to. The
        ///     type of the insertAt InputPin is UnlimitedNatural, but the input cannot be zero.
        ///     It is omitted for Association ends that are not ordered.
        /// </summary>
        InputPin insertAt { get; set; }

        /// <summary>
        ///     Adds the insertAt InputPin (if any) to the set of all Pins.
        /// </summary>
        /// <param name="result"></param>
        InputPin allPins(InputPin result);
    }
} //end namespace Actions
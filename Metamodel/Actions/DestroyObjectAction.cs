///////////////////////////////////////////////////////////
//  DestroyObjectAction.cs
//  Implementation of the Class DestroyObjectAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:58
//  Original author: ������
///////////////////////////////////////////////////////////

namespace UML.Actions
{
    /// <summary>
    ///     A DestroyObjectAction is an Action that destroys objects.
    /// </summary>
    public interface DestroyObjectAction : Action
    {
        /// <summary>
        ///     Specifies whether links in which the object participates are destroyed along
        ///     with the object.
        /// </summary>
        bool isDestroyLinks { get; set; }

        /// <summary>
        ///     Specifies whether objects owned by the object (via composition) are destroyed
        ///     along with the object.
        /// </summary>
        bool isDestroyOwnedObjects { get; set; }

        /// <summary>
        ///     The InputPin providing the object to be destroyed.
        /// </summary>
        InputPin target { get; set; }
    }
} //end namespace Actions
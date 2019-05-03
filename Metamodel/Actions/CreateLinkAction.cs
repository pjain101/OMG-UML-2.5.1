///////////////////////////////////////////////////////////
//  CreateLinkAction.cs
//  Implementation of the Class CreateLinkAction
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 21:59:57
//  Original author: ������
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.Actions
{
    /// <summary>
    ///     A CreateLinkAction is a WriteLinkAction for creating links.
    /// </summary>
    public interface CreateLinkAction : WriteLinkAction
    {
        /// <summary>
        ///     The LinkEndData that specifies the values to be placed on the Association ends
        ///     for the new link.
        /// </summary>
        IEnumerable<LinkEndCreationData> endData { get; set; }
    }
} //end namespace Actions
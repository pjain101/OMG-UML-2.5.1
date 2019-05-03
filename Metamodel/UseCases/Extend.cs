///////////////////////////////////////////////////////////
//  Extend.cs
//  Implementation of the Class Extend
//  Generated by Enterprise Architect
//  Created on:      31-���-2019 22:00:01
//  Original author: ������
///////////////////////////////////////////////////////////

using UML.CommonStructure;

namespace UML.UseCases
{
    /// <summary>
    ///     A relationship from an extending UseCase to an extended UseCase that specifies
    ///     how and when the behavior defined in the extending UseCase can be inserted into
    ///     the behavior defined in the extended UseCase.
    /// </summary>
    public interface Extend : DirectedRelationship, NamedElement
    {
        /// <summary>
        ///     The UseCase that is being extended.
        /// </summary>
        UseCase extendedCase { get; set; }

        /// <summary>
        ///     References the condition that must hold when the first ExtensionPoint is
        ///     reached for the extension to take place. If no constraint is associated with
        ///     the Extend relationship, the extension is unconditional.
        /// </summary>
        Constraint condition { get; set; }

        /// <summary>
        ///     An ordered list of ExtensionPoints belonging to the extended UseCase,
        ///     specifying where the respective behavioral fragments of the extending UseCase
        ///     are to be inserted. The first fragment in the extending UseCase is associated
        ///     with the first extension point in the list, the second fragment with the second
        ///     point, and so on. Note that, in most practical cases, the extending UseCase has
        ///     just a single behavior fragment, so that the list of ExtensionPoints is trivial.
        /// </summary>
        ExtensionPoint extensionLocation { get; set; }
    }
} //end namespace UseCases
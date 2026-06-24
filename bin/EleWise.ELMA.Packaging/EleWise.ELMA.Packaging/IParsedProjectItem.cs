using System.Collections.Generic;

namespace EleWise.ELMA.Packaging;

internal interface IParsedProjectItem
{
	IParsedProject Project { get; }

	string UnevaluatedInclude { get; }

	string EvaluatedInclude { get; }

	string ItemTypeId { get; }

	ParsedProjectItemType ItemType { get; }

	IEnumerable<IProjectMetadata> Metadata { get; }
}

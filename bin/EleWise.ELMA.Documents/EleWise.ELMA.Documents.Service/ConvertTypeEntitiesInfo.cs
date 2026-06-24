using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Services;

internal class ConvertTypeEntitiesInfo
{
	public List<EntityMetadata> EntitiesToInsert { get; set; }

	public List<EntityMetadata> EntitiesToDelete { get; set; }

	public List<EntityMetadata> IntersectEntities { get; set; }

	public List<EntityMetadata> SourceEntities { get; set; }

	public List<EntityMetadata> SourceBlocks { get; set; }

	public List<EntityMetadata> BlocksToInsert { get; set; }

	public List<EntityMetadata> BlocksToDelete { get; set; }

	public List<EntityMetadata> ClassesToDelete { get; set; }

	public EntityMetadata SourceTypeMd { get; set; }

	public EntityMetadata TargetTypeMd { get; set; }
}

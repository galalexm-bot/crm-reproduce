using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class LoadMetadataHeaders
{
	public Guid TypeUid { get; set; }

	public long[] Ids { get; set; }
}

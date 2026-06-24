using System;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class MetadataHeaderDTO
{
	public Guid MetadataType { get; set; }

	public Guid Uid { get; set; }

	public Guid ModuleUid { get; set; }

	public bool Internal { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }

	public string Namespace { get; set; }

	public string NamespaceForDisplay { get; set; }

	public long GroupId { get; set; }

	public int Status { get; set; }

	public bool ShowInTypeTree { get; set; }

	public bool ShowInCatalogList { get; set; }
}

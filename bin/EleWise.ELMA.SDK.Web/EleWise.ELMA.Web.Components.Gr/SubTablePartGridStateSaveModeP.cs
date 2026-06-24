using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Components.GridStateSaveModeProviders;

[Component(Order = 100)]
internal class SubTablePartGridStateSaveModeProvider : ITablePartGridStateSaveModeProvider
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	public SubTablePartGridStateSaveModeProvider(IMetadataRuntimeService metadataRuntimeService)
	{
		this.metadataRuntimeService = metadataRuntimeService;
	}

	public GridStateSaveMode? GetGridStateSaveMode(Guid typeUid)
	{
		Type typeByUid = metadataRuntimeService.GetTypeByUid(typeUid);
		if (IsSubTablePart(typeByUid))
		{
			return GridStateSaveMode.None;
		}
		return null;
	}

	private bool IsSubTablePart(Type type)
	{
		if (type == null)
		{
			return false;
		}
		ITablePartMetadata metadata = (ITablePartMetadata)MetadataLoader.LoadMetadata(type, inherit: false);
		return IsSubTablePart(metadata);
	}

	private bool IsSubTablePart(ITablePartMetadata metadata)
	{
		PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == metadata.ParentPropertyUid);
		if (propertyMetadata != null)
		{
			return MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid) is ITablePartMetadata;
		}
		return false;
	}
}

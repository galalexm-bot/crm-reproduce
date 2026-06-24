using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Services;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ComponentMetadataLoader : IComponentMetadataLoader
{
	private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;

	private IMetadataService MetadataService => MetadataServiceContext.Service;

	public ComponentMetadataLoader(IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager)
	{
		this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
	}

	public ComponentMetadata GetComponentMetadata(Guid metadataUid)
	{
		return LoadFromMetadataService(metadataUid) ?? LoadFromDB(metadataUid) ?? throw new Exception(SR.T("Не найден опубликованный компонент Uid: {0}", metadataUid));
	}

	private ComponentMetadata LoadFromMetadataService(Guid moduleUid)
	{
		try
		{
			return MetadataService.GetMetadata(moduleUid) as ComponentMetadata;
		}
		catch (TypeNotFoundException)
		{
			return null;
		}
	}

	private ComponentMetadata LoadFromDB(Guid moduleUid)
	{
		return componentMetadataItemHeaderManager.LoadOrNull(moduleUid)?.Published?.Metadata as ComponentMetadata;
	}
}

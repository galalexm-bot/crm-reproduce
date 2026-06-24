using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Ioc;

namespace EleWise.ELMA.Core.Services;

[Service]
internal sealed class MetadataRegistrationService : IMetadataRegistrationService
{
	private readonly ILazy<MetadataServiceContext> metadataServiceContextLazy;

	private MetadataServiceContext MetadataServiceContext => metadataServiceContextLazy.Value();

	public MetadataRegistrationService(ILazy<MetadataServiceContext> metadataServiceContextLazy)
	{
		this.metadataServiceContextLazy = metadataServiceContextLazy;
	}

	public void Register(IMetadata metadata)
	{
		MetadataServiceContext.ProcessMetadata(metadata);
	}

	public void Register(System.Collections.Generic.IEnumerable<IMetadata> metadataList)
	{
		MetadataServiceContext.ProcessMetadata(metadataList);
	}
}

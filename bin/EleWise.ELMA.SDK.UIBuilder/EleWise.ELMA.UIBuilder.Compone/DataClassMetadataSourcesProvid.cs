using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.Components;

[Component(Type = ComponentType.Server)]
internal sealed class DataClassMetadataSourcesProvider : IMetadataSourcesProvider
{
	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	public DataClassMetadataSourcesProvider(IUITypeGenerationFacade uiTypeGenerationFacade)
	{
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
	}

	public IEnumerable<(string, string)> GetClientSources(MetadataSourcesProviderArgs args)
	{
		if (!(args?.Metadata is DataClassMetadata dataClassMetadata))
		{
			return Enumerable.Empty<(string, string)>();
		}
		return new(string, string)[1] { (dataClassMetadata.Name, GetClientSources(dataClassMetadata)) };
	}

	public IEnumerable<(string, string)> GetViewSources(MetadataSourcesProviderArgs args)
	{
		return Enumerable.Empty<(string, string)>();
	}

	public IEnumerable<string> GetServerSources(MetadataSourcesProviderArgs args)
	{
		if (!(args?.Metadata is DataClassMetadata metadata))
		{
			return Enumerable.Empty<string>();
		}
		return GetServerSources(metadata);
	}

	private string GetClientSources(IMetadata metadata)
	{
		GeneratedFileInfo generatedFileInfo = ((ICodeGenerator)new DataClassWebGenerator(uiTypeGenerationFacade)
		{
			Metadata = metadata
		}).GenerateMainFile();
		return Encoding.UTF8.GetString(generatedFileInfo.Data);
	}

	private static IEnumerable<string> GetServerSources(IMetadata metadata)
	{
		return from fi in ((ICodeGenerator)new DataClassGenerator
			{
				Metadata = metadata
			}).Generate()
			where fi.Type == GeneratedFileType.CS
			select Encoding.UTF8.GetString(fi.Data);
	}
}

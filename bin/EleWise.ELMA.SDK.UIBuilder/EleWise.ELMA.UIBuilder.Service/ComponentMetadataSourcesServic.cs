using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.CodeGeneration;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ComponentMetadataSourcesService : IComponentMetadataSourcesService
{
	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private readonly IEnumerable<IMetadataTypeInfo> metadataTypeInfos;

	public ComponentMetadataSourcesService(IUITypeGenerationFacade uiTypeGenerationFacade, IEnumerable<IMetadataTypeInfo> metadataTypeInfos)
	{
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
		this.metadataTypeInfos = metadataTypeInfos;
	}

	public string ServerControllerName(ComponentMetadata metadata)
	{
		return string.Join(".", metadata.Name, "ServerController");
	}

	public IEnumerable<IScriptSource> GetServerSources(MetadataSourcesProviderArgs args)
	{
		List<IScriptSource> list = new List<IScriptSource>();
		ComponentMetadata metadata = args.Metadata as ComponentMetadata;
		if (metadata == null)
		{
			return list;
		}
		if (args.ScriptModule != null)
		{
			ScriptSource item = new ScriptSource(ServerControllerName(metadata), args.ScriptModule.SourceCode, ScriptSourceType.Edit);
			list.Add(item);
		}
		ICodeGenerator obj = (ICodeGenerator)Activator.CreateInstance(metadataTypeInfos.FirstOrDefault((IMetadataTypeInfo info) => info.MetadataType == metadata.GetType())?.GeneratorType ?? typeof(ComponentMetadataGenerator));
		obj.Metadata = metadata;
		obj.GenerationParams.Mode = args.GenerationMode;
		GeneratedFileInfo[] array = obj.Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			if (generatedFileInfo.Type == GeneratedFileType.CS)
			{
				list.Add(new ScriptSource(metadata.Name + generatedFileInfo.Extension, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
			}
		}
		return list;
	}

	public string ClientControllerName(ComponentMetadata metadata)
	{
		return string.Join(".", metadata.Name, "Controller");
	}

	public IEnumerable<IScriptSource> GetClientSources(MetadataSourcesProviderArgs args)
	{
		if (!(args.Metadata is ComponentMetadata componentMetadata) || args.ClientScriptModule == null)
		{
			return Enumerable.Empty<IScriptSource>();
		}
		ComponentClientScriptGenerator obj = new ComponentClientScriptGenerator(args.ScriptModule, uiTypeGenerationFacade)
		{
			Metadata = componentMetadata,
			GenerationParams = 
			{
				Mode = args.GenerationMode
			}
		};
		List<IScriptSource> list = new List<IScriptSource>
		{
			new ScriptSource(ClientControllerName(componentMetadata), args.ClientScriptModule.SourceCode, ScriptSourceType.Edit)
		};
		GeneratedFileInfo[] array = ((ICodeGenerator)obj).Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			if (generatedFileInfo.Type == GeneratedFileType.CS)
			{
				list.Add(new ScriptSource(componentMetadata.Name + generatedFileInfo.Extension, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
			}
		}
		return list;
	}

	public string ViewControllerName(ComponentMetadata metadata)
	{
		return string.Join(".", metadata.Name, "View");
	}

	public IEnumerable<IScriptSource> GetViewSources(MetadataSourcesProviderArgs args)
	{
		if (!(args.Metadata is ComponentMetadata componentMetadata) || args.ViewScriptModule == null)
		{
			return Enumerable.Empty<IScriptSource>();
		}
		ICodeGenerator codeGenerator = new ComponentViewClientScriptGenerator(args.ClientScriptModule, uiTypeGenerationFacade);
		codeGenerator.Metadata = componentMetadata;
		codeGenerator.GenerationParams.Mode = args.GenerationMode;
		List<IScriptSource> list = new List<IScriptSource>();
		list.Add(new ScriptSource(string.Join(".", componentMetadata.Name, "View"), args.ViewScriptModule.SourceCode, ScriptSourceType.Edit));
		List<IScriptSource> list2 = list;
		GeneratedFileInfo[] array = codeGenerator.Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			if (generatedFileInfo.Type == GeneratedFileType.CS)
			{
				list2.Add(new ScriptSource(componentMetadata.Name + generatedFileInfo.Extension, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
			}
		}
		return list2;
	}

	public string TestControllerName(ComponentMetadata metadata)
	{
		return string.Join(".", metadata.Name, "Test");
	}

	public IEnumerable<IScriptSource> GetTestSources(MetadataSourcesProviderArgs args)
	{
		if (!(args.Metadata is ComponentMetadata componentMetadata) || args.TestScriptModule == null)
		{
			return Enumerable.Empty<IScriptSource>();
		}
		ComponentTestScriptGenerator obj = new ComponentTestScriptGenerator
		{
			Metadata = componentMetadata,
			GenerationParams = 
			{
				Mode = args.GenerationMode
			}
		};
		List<IScriptSource> list = new List<IScriptSource>
		{
			new ScriptSource(TestControllerName(componentMetadata), args.TestScriptModule.SourceCode, ScriptSourceType.Edit)
		};
		GeneratedFileInfo[] array = ((ICodeGenerator)obj).Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			if (generatedFileInfo.Type == GeneratedFileType.CS)
			{
				list.Add(new ScriptSource(componentMetadata.Name + generatedFileInfo.Extension, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
			}
		}
		return list;
	}
}

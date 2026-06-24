using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using EleWise.ELMA.UIBuilder.Model;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ModuleBuilderService : IModuleBuilderService
{
	private readonly IEnumerable<IMetadataSourcesProvider> metadataSourcesProviders;

	private readonly IJavaScriptCompilerService javaScriptCompilerService;

	private readonly IModuleAssemblyLoader moduleAssemblyLoader;

	private readonly IScriptLoader scriptLoader;

	private readonly IModulePublishDataProvider modulePublishDataProvider;

	public ModuleBuilderService(IEnumerable<IMetadataSourcesProvider> metadataSourcesProviders, IJavaScriptCompilerService javaScriptCompilerService, IModuleAssemblyLoader moduleAssemblyLoader, IScriptLoader scriptLoader, IModulePublishDataProvider modulePublishDataProvider)
	{
		this.metadataSourcesProviders = metadataSourcesProviders;
		this.javaScriptCompilerService = javaScriptCompilerService;
		this.moduleAssemblyLoader = moduleAssemblyLoader;
		this.scriptLoader = scriptLoader;
		this.modulePublishDataProvider = modulePublishDataProvider;
	}

	public ModuleBuildResult Build(Guid itemUid, ModuleInfoMetadata module, string version, bool withoutJsOutput)
	{
		IReadOnlyCollection<ModuleVersion> readOnlyCollection = modulePublishDataProvider.PrepareData(module);
		Dictionary<Guid, ScriptModule> dictionary = new Dictionary<Guid, ScriptModule>(module.Components.Count + module.Functions.Count);
		Dictionary<Guid, ScriptModule> dictionary2 = new Dictionary<Guid, ScriptModule>(module.Components.Count);
		Dictionary<Guid, ScriptModule> dictionary3 = new Dictionary<Guid, ScriptModule>(module.Components.Count);
		Dictionary<Guid, ScriptModule> testScripts = new Dictionary<Guid, ScriptModule>(module.Components.Count);
		using (MetadataServiceContext.Extend(module.DataClasses.Concat<IMetadata>(module.Functions).Concat(module.Components).Concat(readOnlyCollection.SelectMany((ModuleVersion infoMetadata) => infoMetadata.Metadata.DataClasses))
			.Concat(readOnlyCollection.SelectMany((ModuleVersion infoMetadata) => infoMetadata.Metadata.Functions))
			.Concat(readOnlyCollection.SelectMany((ModuleVersion infoMetadata) => infoMetadata.Metadata.Components))))
		{
			foreach (ComponentMetadata component in module.Components)
			{
				if (component.ScriptUid.HasValue)
				{
					dictionary.Add(component.Uid, scriptLoader.GetScript(component.ScriptUid));
				}
				if (component.ClientScriptUid.HasValue)
				{
					dictionary2.Add(component.Uid, scriptLoader.GetScript(component.ClientScriptUid));
				}
				if (component.ViewScriptUid.HasValue)
				{
					dictionary3.Add(component.Uid, scriptLoader.GetScript(component.ViewScriptUid));
				}
			}
			foreach (FunctionMetadata function in module.Functions)
			{
				if (function.ScriptUid.HasValue)
				{
					dictionary.Add(function.Uid, scriptLoader.GetScript(function.ScriptUid));
				}
			}
			using ModuleAssemblyBuilder moduleAssemblyBuilder = new ModuleAssemblyBuilder(itemUid, module, dictionary, dictionary2, dictionary3, testScripts, version, metadataSourcesProviders, javaScriptCompilerService, GetPublishedModuleModels(module, readOnlyCollection, withoutJsOutput).ToList());
			AdditionalReferences(module, moduleAssemblyBuilder);
			return moduleAssemblyBuilder.Build(withoutJsOutput);
		}
	}

	private static void AdditionalReferences(ModuleInfoMetadata module, ModuleAssemblyBuilder builder)
	{
		builder.AddServerReference(TypeOf<DataClass>.Assembly);
		builder.AddServerReference(ComponentManager.FindLoadedAssembly("EleWise.ELMA.DynamicModel", isFullName: false));
		builder.AddClientReference(File.ReadAllBytes(Path.Combine(ComponentManager.Current.WorkDirectory, "CompiledUIModel", "DynamicUIModel.dll")));
		builder.AddClientReference(File.ReadAllBytes(Path.Combine(ComponentManager.Current.WorkDirectory, "CompiledUIModel", "ExternalUIModel.dll")));
	}

	private IEnumerable<PublishedModule> GetPublishedModuleModels(ModuleInfoMetadata module, IEnumerable<ModuleVersion> moduleVersions, bool withoutJsOutput)
	{
		return moduleVersions.Select(delegate(ModuleVersion moduleVersion)
		{
			ModuleVersionHeader header = moduleVersion.Header;
			return new PublishedModule(moduleVersion.Metadata, moduleAssemblyLoader.GetServerAssembly(header.HeaderUid, header.VersionUid), moduleAssemblyLoader.GetClientAssembly(header.HeaderUid, header.VersionUid));
		});
	}
}

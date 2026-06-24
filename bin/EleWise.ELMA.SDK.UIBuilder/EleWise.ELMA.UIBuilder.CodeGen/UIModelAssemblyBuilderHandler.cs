using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.Analyzers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Services;
using EleWise.ELMA.UIBuilder.Analyzers;
using EleWise.ELMA.UIBuilder.CodeAnalyzers;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;
using EleWise.ELMA.UIBuilder.Services;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

[Component(Order = 0)]
internal sealed class UIModelAssemblyBuilderHandler : IModelAssemblyBuilderHandler, IEventHandler
{
	private readonly IJavaScriptCompilerService javaScriptCompilerService;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IEntityFormsService entityFormsService;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private readonly DbPreUpdater dbPreUpdater;

	internal static readonly Guid[] ignoreMetadataUids = new Guid[14]
	{
		new Guid("dd959698-9048-457e-9f20-08772dbb154f"),
		new Guid("e8ad1e72-5c44-4225-a74c-f94c127fd87d"),
		new Guid("c9f10bdc-93bb-45ad-831a-1ff2e63a3ef9"),
		new Guid("02062d1b-10e3-4799-ad8d-9bceddba7b30"),
		new Guid("3f73cd2d-c2c7-4b74-8b52-d81a08c286e9"),
		new Guid("b1401619-1df9-4d97-a2d8-c426abc127cc"),
		new Guid("ace00fad-4f16-4032-b361-e4e23bd4bd5b"),
		new Guid("0b9f4a56-fc45-43fe-b88b-fcc0b59fc15e"),
		new Guid("94ec0966-a965-41e2-9f66-e459666e5c32"),
		new Guid("625ae248-fca4-4a41-8b17-a61bb4845844"),
		new Guid("d0ae05a6-7176-46cc-86df-fcdccedda458"),
		new Guid("9341073b-746c-4804-8f60-c3449773b64d"),
		new Guid("f231b7d1-9108-4dac-8822-8a826d05ce4c"),
		new Guid("ded50eaa-8f9d-4457-b083-60b8b721705b")
	};

	private ISearchMetadataService searchMetadataService;

	private ISearchMetadataService SearchMetadataService
	{
		get
		{
			return searchMetadataService ?? (searchMetadataService = (Locator.Initialized ? Locator.GetService<ISearchMetadataService>() : null));
		}
		set
		{
			searchMetadataService = value;
		}
	}

	public UIModelAssemblyBuilderHandler(IJavaScriptCompilerService javaScriptCompilerService, IRuntimeApplication runtimeApplication, IMetadataRuntimeService metadataRuntimeService, IEntityFormsService entityFormsService, IUITypeGenerationFacade uiTypeGenerationFacade)
	{
		this.javaScriptCompilerService = javaScriptCompilerService;
		this.metadataRuntimeService = metadataRuntimeService;
		this.entityFormsService = entityFormsService;
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
		dbPreUpdater = runtimeApplication.DbPreUpdater;
	}

	public void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> publishMetadataList)
	{
		Contract.ArgumentNotNull(publishMetadataList, "publishMetadataList");
		if (dbPreUpdater != null)
		{
			AssemblyModelsMetadata assemblyModelsMetadata = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled).ToArray().FirstOrDefault((AssemblyModelsMetadata a) => a.Name == "ConfigurationUIModel") ?? new AssemblyModelsMetadata
			{
				Name = "ConfigurationUIModel"
			};
			EnumMetadata[] array = publishMetadataList.OfType<EnumMetadata>().ToArray();
			byte[] array2 = BuildAssembly("ConfigurationUIModel", array);
			if (array2 == null)
			{
				throw new MetadataPublishingException(SR.T("Ошибка компиляции сборки {0}", "ConfigurationUIModel"));
			}
			assemblyModelsMetadata.AssemblyRawStream = MemoryHelper.GetMemoryStream(array2.Length);
			assemblyModelsMetadata.AssemblyRawStream.Write(array2, 0, array2.Length);
			assemblyModelsMetadata.Status = AssemblyModelsMetadataStatus.PublishedDisabled;
			assemblyModelsMetadata.SetMetadata(array.Cast<AbstractMetadata>().ToArray());
			dbPreUpdater.SaveAssemblyModelsMetadata(assemblyModelsMetadata);
		}
	}

	public void DynamicModelAssemblyBuilt(IEnumerable<EntityMetadata> systemMetadata)
	{
		Contract.ArgumentNotNull(systemMetadata, "systemMetadata");
		EntityMetadata[] array = systemMetadata.ToArray();
		if (dbPreUpdater == null)
		{
			return;
		}
		AssemblyModelsMetadata[] array2 = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled).ToArray();
		AssemblyModelsMetadata assemblyModelsMetadata = array2.FirstOrDefault((AssemblyModelsMetadata a) => a.Name == "ConfigurationUIModel");
		if (assemblyModelsMetadata == null)
		{
			AssemblyModelsMetadata assemblyModelsMetadata2 = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.Published).FirstOrDefault((AssemblyModelsMetadata a) => a.Name == "EleWise.ELMA.ConfigurationModel");
			if (assemblyModelsMetadata2 == null)
			{
				return;
			}
			AbstractMetadata[] publishMetadataList = assemblyModelsMetadata2.RestoreMetadata();
			ConfigurationModelAssemblyBuilt(publishMetadataList);
			array2 = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled).ToArray();
			assemblyModelsMetadata = array2.FirstOrDefault((AssemblyModelsMetadata a) => a.Name == "ConfigurationUIModel");
			if (assemblyModelsMetadata == null)
			{
				return;
			}
		}
		else
		{
			SaveAssemblyLocal(assemblyModelsMetadata.AssemblyRawStream, assemblyModelsMetadata.Name, overrideIfExists: false);
		}
		if (ComponentManager.FindLoadedAssembly("EleWise.ELMA.DynamicModel", isFullName: false) == null)
		{
			BeforeDynamicUIModelsMetadata(assemblyModelsMetadata, array2);
		}
		array2 = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled).ToArray();
		AssemblyModelsMetadata assemblyModelsMetadata3 = array2.FirstOrDefault((AssemblyModelsMetadata a) => a.Name == "ExternalUIModel");
		if (assemblyModelsMetadata3 == null)
		{
			return;
		}
		using (MetadataServiceContext.Extend(array.Concat(assemblyModelsMetadata3.RestoreMetadata())))
		{
			AssemblyModelsMetadata assemblyModelsMetadata4 = array2.FirstOrDefault((AssemblyModelsMetadata a) => a.Name == "DynamicUIModel") ?? new AssemblyModelsMetadata
			{
				Name = "DynamicUIModel"
			};
			byte[] array3 = BuildAssembly("DynamicUIModel", array, new byte[2][]
			{
				assemblyModelsMetadata.AssemblyRawStream.ToArray(),
				assemblyModelsMetadata3.AssemblyRawStream.ToArray()
			});
			if (array3 == null)
			{
				throw new MetadataPublishingException(SR.T("Ошибка компиляции сборки {0}", "DynamicUIModel"));
			}
			assemblyModelsMetadata4.AssemblyRawStream = MemoryHelper.GetMemoryStream(array3.Length);
			assemblyModelsMetadata4.AssemblyRawStream.Write(array3, 0, array3.Length);
			assemblyModelsMetadata4.Status = AssemblyModelsMetadataStatus.PublishedDisabled;
			assemblyModelsMetadata4.SetMetadata(array.Cast<AbstractMetadata>().ToArray());
			dbPreUpdater.SaveAssemblyModelsMetadata(assemblyModelsMetadata4);
		}
	}

	public void AfterAll(IEnumerable<AbstractMetadata> publishMetadataList, IEnumerable<ScriptModule> scriptModules, IEnumerable<ScriptModule> clientScriptModules)
	{
		Contract.ArgumentNotNull(scriptModules, "scriptModules");
		Contract.ArgumentNotNull(clientScriptModules, "clientScriptModules");
		List<ScriptModule> list = scriptModules.ToList();
		List<ScriptModule> list2 = clientScriptModules.ToList();
		foreach (AbstractMetadata publishMetadata in publishMetadataList)
		{
			EntityMetadata entityMetadata = publishMetadata as EntityMetadata;
			if (entityMetadata == null)
			{
				continue;
			}
			ScriptModule scriptModule = list2.Find((ScriptModule script) => script.ObjectUid == entityMetadata.Uid);
			if (scriptModule != null)
			{
				ScriptModule scriptModule2 = list.Find((ScriptModule script) => script.ObjectUid == entityMetadata.Uid);
				BuildClientEntityScript(entityMetadata, scriptModule, scriptModule2);
			}
		}
	}

	private void BeforeDynamicUIModelsMetadata(AssemblyModelsMetadata configurationUiModelMetadata, IEnumerable<AssemblyModelsMetadata> publishedDisabled)
	{
		IEnumerable<EnumMetadata> second = configurationUiModelMetadata.RestoreMetadata().OfType<EnumMetadata>();
		IMetadata[] array = (from a in metadataRuntimeService.GetMetadataList()
			where !ignoreMetadataUids.Contains(a.Uid) && (a is EnumMetadata || (a is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.Entity))
			select a).Except(second, new CollectionExtensions.DelegateComparer<IMetadata>((IMetadata a, IMetadata b) => a.Uid == b.Uid, (IMetadata i) => i.Uid.GetHashCode())).ToArray();
		AssemblyModelsMetadata assemblyModelsMetadata = publishedDisabled.FirstOrDefault((AssemblyModelsMetadata a) => a.Name == "ExternalUIModel") ?? new AssemblyModelsMetadata
		{
			Name = "ExternalUIModel"
		};
		byte[] array2 = BuildAssembly("ExternalUIModel", array);
		if (array2 == null)
		{
			throw new MetadataPublishingException(SR.T("Ошибка компиляции сборки {0}", "ExternalUIModel"));
		}
		assemblyModelsMetadata.AssemblyRawStream = MemoryHelper.GetMemoryStream(array2.Length);
		assemblyModelsMetadata.AssemblyRawStream.Write(array2, 0, array2.Length);
		assemblyModelsMetadata.Status = AssemblyModelsMetadataStatus.PublishedDisabled;
		assemblyModelsMetadata.SetMetadata(array.Cast<AbstractMetadata>().ToArray());
		dbPreUpdater.SaveAssemblyModelsMetadata(assemblyModelsMetadata);
	}

	private byte[] BuildAssembly(string assemblyName, IEnumerable<IMetadata> metadataList, IEnumerable<byte[]> references = null)
	{
		UIModelAssemblyBuilder uIModelAssemblyBuilder = new UIModelAssemblyBuilder(assemblyName, javaScriptCompilerService, uiTypeGenerationFacade, scriptApiCheck: false);
		uIModelAssemblyBuilder.RegisterMetadataList(metadataList);
		if (references != null)
		{
			uIModelAssemblyBuilder.AddReferenceList(references);
		}
		byte[] assemblyRaw = uIModelAssemblyBuilder.BuildAssembly().AssemblyRaw;
		using MemoryStream assemblyRaw2 = MemoryHelper.GetMemoryStream(assemblyRaw, writable: false);
		SaveAssemblyLocal(assemblyRaw2, assemblyName);
		return assemblyRaw;
	}

	private static void SaveAssemblyLocal(MemoryStream assemblyRaw, string assemblyName, bool overrideIfExists = true)
	{
		int setting = SR.GetSetting("ModelRegistrar.FileAccessAttemptCount", 30);
		string text = Path.Combine(ComponentManager.Current.WorkDirectory, "CompiledUIModel");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		if (!File.Exists(Path.Combine(text, assemblyName + ".dll")) || overrideIfExists)
		{
			IOExtensions.WriteAllBytesWithAttempts(Path.Combine(text, assemblyName + ".dll"), assemblyRaw, TimeSpan.FromSeconds(1.0), setting);
		}
	}

	private void BuildClientEntityScript(EntityMetadata metadata, ScriptModule clientScriptModule, ScriptModule scriptModule)
	{
		string name = metadata.Name;
		IJavaScriptCompilerModel model = javaScriptCompilerService.CreateCompilerModel(name, scriptApiCheck: true);
		model.AddSourceCode(clientScriptModule.SourceCode);
		model.AddSourceCode(GenerateAssemblyInfo(metadata));
		GeneratedFileInfo[] array = ((ICodeGenerator)new EntityClientScriptGenerator(scriptModule, entityFormsService, uiTypeGenerationFacade)
		{
			Metadata = metadata
		}).Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			model.AddSourceCode(Encoding.UTF8.GetString(generatedFileInfo.Data));
		}
		AssemblyModelsMetadata[] publishedDisabled = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled).ToArray();
		AddReference("ConfigurationUIModel");
		AddReference("DynamicUIModel");
		AddReference("ExternalUIModel");
		foreach (DataClassAssemblyInfo item in SearchMetadataService.GetPublishedDataClassAssemblies().ToList())
		{
			model.AddReference(item.ClientAssemblyRaw);
		}
		DataClassUsageAnalyzer dataClassUsageAnalyzer = new DataClassUsageAnalyzer();
		ClientEntityUsageAnalyzer entityUsageAnalyzer = new ClientEntityUsageAnalyzer();
		EnumUsageAnalyzer enumUsageAnalyzer = new EnumUsageAnalyzer();
		model.AddAnalyzers((DiagnosticAnalyzer)entityUsageAnalyzer, (DiagnosticAnalyzer)enumUsageAnalyzer, (DiagnosticAnalyzer)dataClassUsageAnalyzer, new UIComponentsAnalyzer(), new ComponentControllerPublicClassesAnalyzer(), new AsynchronousCodeAnalyzer());
		FillReplaceViewModelMetadata(model.ReplaceModelMetadata, metadata, model.ProjectName, metadata.Name);
		JavaScriptCodeCompilerResult javaScriptCodeCompilerResult = javaScriptCompilerService.Compile(model, withoutJsOutput: false, delegate
		{
			BridgeCompilerServiceStatics.DefaultAction(model, entityUsageAnalyzer, enumUsageAnalyzer, dataClassUsageAnalyzer);
		});
		List<EnumDependency> list = new List<EnumDependency>();
		List<EntityDependency> list2 = new List<EntityDependency>();
		List<DataClassDependency> list3 = new List<DataClassDependency>();
		foreach (KeyValuePair<IMetadata, ICollection<IPropertyMetadata>> referenceMetadatum in entityUsageAnalyzer.CodeAnalyzerResult.CombineResult(dataClassUsageAnalyzer.CodeAnalyzerResult).CombineResult(enumUsageAnalyzer.CodeAnalyzerResult).ReferenceMetadata)
		{
			if (!(referenceMetadatum.Key is ICodeItemMetadata codeItemMetadata))
			{
				continue;
			}
			ICodeItemMetadata codeItemMetadata2 = codeItemMetadata;
			if (codeItemMetadata2 == null)
			{
				continue;
			}
			if (!(codeItemMetadata2 is EnumMetadata enumMetadata))
			{
				if (!(codeItemMetadata2 is EntityMetadata entityMetadata))
				{
					if (codeItemMetadata2 is DataClassMetadata dataClassMetadata)
					{
						DataClassMetadata metadata2 = dataClassMetadata;
						list3.Add(metadata2.GetSignature(referenceMetadatum.Value));
					}
				}
				else
				{
					EntityMetadata metadata3 = entityMetadata;
					list2.Add(metadata3.GetSignature(referenceMetadatum.Value));
				}
			}
			else
			{
				EnumMetadata metadata4 = enumMetadata;
				list.Add(metadata4.GetSignature());
			}
		}
		ScriptModuleDependencyContainer scriptModuleDependencyContainer = new ScriptModuleDependencyContainer();
		scriptModuleDependencyContainer.EnumDependencies.AddRange(list);
		scriptModuleDependencyContainer.EntityDependencies.AddRange(list2);
		scriptModuleDependencyContainer.DataClassDependencies.AddRange(list3);
		clientScriptModule.AssemblyRaw = javaScriptCodeCompilerResult.MinJsAssemblyRaw;
		clientScriptModule.DebugRaw = javaScriptCodeCompilerResult.JsAssemblyRaw;
		clientScriptModule.AssemblyName = metadata.Name;
		clientScriptModule.Dependencies = scriptModuleDependencyContainer;
		clientScriptModule.Save();
		void AddReference(string modelMetadataName)
		{
			AssemblyModelsMetadata assemblyModelsMetadata = Array.Find(publishedDisabled, (AssemblyModelsMetadata modelsMetadata) => modelsMetadata.Name == modelMetadataName);
			if (assemblyModelsMetadata?.AssemblyRawStream != null)
			{
				model.AddReference(assemblyModelsMetadata.AssemblyRawStream.ToArray());
			}
		}
	}

	private void FillReplaceViewModelMetadata(IList<IReplaceModelMetadata> listReplace, EntityMetadata targetMetadata, string moduleName, string metadataRootName)
	{
		if (targetMetadata?.ViewModelMetadata != null)
		{
			listReplace.Add(new ReplaceModelMetadata(targetMetadata?.ViewModelMetadata, moduleName, targetMetadata.Namespace + "." + metadataRootName + "Scripts." + targetMetadata.Name + targetMetadata.ViewModelMetadata.Name));
		}
		else if (targetMetadata.Type == EntityMetadataType.Interface && targetMetadata.BaseClassUid != Guid.Empty)
		{
			foreach (EntityMetadata item in from a in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>()
				where a.Type == EntityMetadataType.InterfaceExtension && a.BaseClassUid == targetMetadata.BaseClassUid
				select a)
			{
				FillReplaceViewModelMetadata(listReplace, item, moduleName, metadataRootName);
			}
		}
		Guid baseClassUid = targetMetadata.BaseClassUid;
		if (!(baseClassUid == Guid.Empty))
		{
			EntityMetadata targetMetadata2 = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(baseClassUid, loadImplementation: false);
			FillReplaceViewModelMetadata(listReplace, targetMetadata2, moduleName, metadataRootName);
		}
	}

	private static string GenerateAssemblyInfo(ClassMetadata metadata)
	{
		ICodeGenerator codeGenerator = new AssemblyInfoWebGenerator();
		codeGenerator.Metadata = metadata;
		codeGenerator.GenerationParams.FileName = metadata.Name + ".cs";
		codeGenerator.GenerationParams.Namespace = metadata.Namespace;
		return Encoding.UTF8.GetString(codeGenerator.GenerateMainFile().Data);
	}
}

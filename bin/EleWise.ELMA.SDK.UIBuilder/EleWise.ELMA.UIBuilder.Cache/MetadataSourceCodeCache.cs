using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.Cache;

[Service]
internal sealed class MetadataSourceCodeCache : IMetadataSourceCodeCache
{
	private readonly ICacheService cacheService;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IMetadataEditorService metadataEditorService;

	private readonly MetadataItemHeaderManager metadataItemHeaderManager;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private readonly IEnumerable<IMetadataTypeInfo> metadataTypeInfo;

	private const string ServerKey = "EleWise_ELMA_Cache_MetadataSourceCodeCache_Server";

	private const string ClientKey = "EleWise_ELMA_Cache_MetadataSourceCodeCache_Client";

	private const string InvalidCacheKey = "EleWise_ELMA_Cache_MetadataSourceCodeCache_InvalidCache";

	private static readonly string cacheFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "MetadataSourceCodeCache");

	private static readonly string serverFolderPath = Path.Combine(cacheFolderPath, "Server");

	private static readonly string clientFolderPath = Path.Combine(cacheFolderPath, "Client");

	public MetadataSourceCodeCache(ICacheService cacheService, IMetadataRuntimeService metadataRuntimeService, IMetadataEditorService metadataEditorService, MetadataItemHeaderManager metadataItemHeaderManager, IUITypeGenerationFacade uiTypeGenerationFacade, IEnumerable<IMetadataTypeInfo> metadataTypeInfo)
	{
		this.cacheService = cacheService;
		this.metadataRuntimeService = metadataRuntimeService;
		this.metadataEditorService = metadataEditorService;
		this.metadataItemHeaderManager = metadataItemHeaderManager;
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
		this.metadataTypeInfo = metadataTypeInfo;
	}

	public string GetFolderPath(CodeType codeType)
	{
		InitFolders();
		if (codeType != 0)
		{
			return serverFolderPath;
		}
		return clientFolderPath;
	}

	public bool IsGlobalCacheExists()
	{
		if (cacheService.Contains("EleWise_ELMA_Cache_MetadataSourceCodeCache_Server"))
		{
			return cacheService.Contains("EleWise_ELMA_Cache_MetadataSourceCodeCache_Client");
		}
		return false;
	}

	public void InvalidateCache(Guid metadataItemHeaderUid)
	{
		if (IsGlobalCacheExists())
		{
			if (!cacheService.TryGetValue<HashSet<Guid>>("EleWise_ELMA_Cache_MetadataSourceCodeCache_InvalidCache", out var value))
			{
				value = new HashSet<Guid>();
				cacheService.Insert("EleWise_ELMA_Cache_MetadataSourceCodeCache_InvalidCache", value);
			}
			value.Add(metadataItemHeaderUid);
		}
	}

	public void UpdateDiskCache()
	{
		InitFolders();
		if (!IsGlobalCacheExists())
		{
			RestoreGlobalCache();
			return;
		}
		if (cacheService.TryGetValue<HashSet<Guid>>("EleWise_ELMA_Cache_MetadataSourceCodeCache_InvalidCache", out var value))
		{
			value.Select((Guid u) => metadataEditorService.GetMetadata(u, loadImplementation: false)).OfType<ICodeItemMetadata>().ForEach(UpdateGlobalCache);
			value.Clear();
			cacheService.Remove("EleWise_ELMA_Cache_MetadataSourceCodeCache_InvalidCache");
		}
		foreach (KeyValuePair<string, byte[]> item in cacheService.Get<Dictionary<string, byte[]>>("EleWise_ELMA_Cache_MetadataSourceCodeCache_Server"))
		{
			WriteToDisk(item.Key, item.Value, CodeType.Server);
		}
		foreach (KeyValuePair<string, byte[]> item2 in cacheService.Get<Dictionary<string, byte[]>>("EleWise_ELMA_Cache_MetadataSourceCodeCache_Client"))
		{
			WriteToDisk(item2.Key, item2.Value, CodeType.Client);
		}
	}

	private void RestoreGlobalCache()
	{
		ReCreateFolders();
		List<ICodeItemMetadata> metadataDrafts = metadataEditorService.GetMetadataList(inherited: false).OfType<ICodeItemMetadata>().ToList();
		UpdateServerCache(metadataDrafts);
		UpdateClientCache(metadataDrafts);
		if (cacheService.TryGetValue<HashSet<Guid>>("EleWise_ELMA_Cache_MetadataSourceCodeCache_InvalidCache", out var value))
		{
			value.Clear();
			cacheService.Remove("EleWise_ELMA_Cache_MetadataSourceCodeCache_InvalidCache");
		}
	}

	private void UpdateGlobalCache(ICodeItemMetadata codeItemMetadata)
	{
		List<ICodeItemMetadata> list = new List<ICodeItemMetadata> { codeItemMetadata };
		EntityMetadata entityMetadata = codeItemMetadata as EntityMetadata;
		if (entityMetadata != null)
		{
			List<Guid> list2 = new List<Guid>();
			foreach (PropertyMetadata property in entityMetadata.Properties)
			{
				if (!(entityMetadata.Uid == property.SubTypeUid) && !(metadataRuntimeService.GetTypeByUidOrNull(property.SubTypeUid, loadImplementation: false) != null))
				{
					list2.Add(property.SubTypeUid);
				}
			}
			list.AddRange(list2.Select((Guid u) => metadataEditorService.GetMetadata(u, loadImplementation: false)).OfType<ICodeItemMetadata>());
		}
		UpdateServerCache(list, codeItemMetadata, writeToDisk: false);
		if (entityMetadata == null || entityMetadata.ViewModelMetadata != null)
		{
			UpdateClientCache(list, codeItemMetadata, writeToDisk: false);
		}
	}

	private void UpdateServerCache(List<ICodeItemMetadata> metadataDrafts, ICodeItemMetadata targetMetadata = null, bool writeToDisk = true)
	{
		if (!cacheService.TryGetValue<Dictionary<string, byte[]>>("EleWise_ELMA_Cache_MetadataSourceCodeCache_Server", out var serverCache))
		{
			serverCache = new Dictionary<string, byte[]>();
			cacheService.Insert("EleWise_ELMA_Cache_MetadataSourceCodeCache_Server", serverCache);
		}
		IEnumerable<IMetadata> metadataList = metadataEditorService.GetMetadataList().SelectRecursive((IMetadata m) => (!(m is ICompositeMetadata compositeMetadata)) ? Enumerable.Empty<IMetadata>() : compositeMetadata.GetCompositeParts());
		using (new MetadataServiceContext(new ExtendedMetadataService(metadataEditorService, metadataList)))
		{
			if (targetMetadata != null)
			{
				ProcessMetadata(targetMetadata);
				return;
			}
			foreach (ICodeItemMetadata metadataDraft in metadataDrafts)
			{
				ProcessMetadata(metadataDraft);
			}
		}
		void ProcessMetadata(ICodeItemMetadata metadata)
		{
			GeneratedFileInfo[] array = GenerateServerCode(metadata);
			foreach (GeneratedFileInfo generatedFileInfo in array)
			{
				if (generatedFileInfo.Type == GeneratedFileType.CS)
				{
					string text = metadata.Name + generatedFileInfo.Extension;
					serverCache[text] = generatedFileInfo.Data;
					if (writeToDisk)
					{
						WriteToDisk(text, generatedFileInfo.Data, CodeType.Server);
					}
				}
			}
		}
	}

	private void UpdateClientCache(List<ICodeItemMetadata> metadataDrafts, ICodeItemMetadata codeItemMetadata = null, bool writeToDisk = true)
	{
		if (!cacheService.TryGetValue<Dictionary<string, byte[]>>("EleWise_ELMA_Cache_MetadataSourceCodeCache_Client", out var clientCache))
		{
			clientCache = new Dictionary<string, byte[]>();
			cacheService.Insert("EleWise_ELMA_Cache_MetadataSourceCodeCache_Client", clientCache);
		}
		ConfigurationModelBuilderMetadataService configurationModelBuilderMetadataService = new ConfigurationModelBuilderMetadataService(metadataRuntimeService, metadataDrafts);
		using (new MetadataServiceContext(configurationModelBuilderMetadataService))
		{
			DynamicModelAssemblyBuilder dynamicModelAssemblyBuilder = new DynamicModelAssemblyBuilder("EleWise.ELMA.DynamicModel");
			List<Type> types = (from t in DynamicModelAssemblyBuilder.GetEntityInterfaceTypes()
				where ComponentManager.GetAssemblyLocation(t.Assembly) != null && ComponentManager.GetAssemblyShortName(t.Assembly) != "EleWise.ELMA.ConfigurationModel" && ComponentManager.GetAssemblyShortName(t.Assembly) != "EleWise.ELMA.DynamicModel" && ComponentManager.GetAssemblyShortName(t.Assembly) != "EleWise.ELMA.ConfigurationModel.Delta" && ComponentManager.GetAssemblyShortName(t.Assembly) != "EleWise.ELMA.DynamicModel.Delta"
				select t).ToList();
			dynamicModelAssemblyBuilder.RegisterTypes(types);
			dynamicModelAssemblyBuilder.RegisterTypes(DynamicModelAssemblyBuilder.GetAutoImplementTypes());
			dynamicModelAssemblyBuilder.RegisterMetadataList(metadataDrafts);
			List<EnumMetadata> list = metadataDrafts.OfType<EnumMetadata>().ToList();
			ICollection<EntityMetadata> implementationMetadataList = dynamicModelAssemblyBuilder.GetImplementationMetadataList();
			using (new MetadataServiceContext(new ExtendedMetadataService(configurationModelBuilderMetadataService, implementationMetadataList.Concat<IMetadata>(list))))
			{
				if (codeItemMetadata == null)
				{
					foreach (EnumMetadata item in list)
					{
						ProcessMetadata(item);
					}
					{
						foreach (EntityMetadata item2 in implementationMetadataList)
						{
							ProcessMetadata(item2);
						}
						return;
					}
				}
				if (codeItemMetadata is EnumMetadata)
				{
					ProcessMetadata(codeItemMetadata);
				}
				else
				{
					EntityMetadata entityMetadata;
					if ((entityMetadata = codeItemMetadata as EntityMetadata) == null)
					{
						return;
					}
					if (entityMetadata.Type == EntityMetadataType.Interface)
					{
						EntityMetadata entityMetadata2 = implementationMetadataList.FirstOrDefault((EntityMetadata md) => md.Uid == entityMetadata.ImplementationUid);
						if (entityMetadata2 != null)
						{
							ProcessMetadata(entityMetadata2);
						}
					}
					else if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
					{
						EntityMetadata entityMetadata3 = implementationMetadataList.FirstOrDefault((EntityMetadata md) => md.ImplementedExtensionUids != null && md.ImplementedExtensionUids.Contains(entityMetadata.Uid));
						if (entityMetadata3 != null)
						{
							ProcessMetadata(entityMetadata3);
						}
					}
				}
			}
		}
		void ProcessMetadata(ICodeItemMetadata metadata)
		{
			GeneratedFileInfo generatedFileInfo = GenerateClientCode(metadata);
			string text = metadata.Name + ".cs";
			clientCache[text] = generatedFileInfo.Data;
			if (writeToDisk)
			{
				WriteToDisk(text, generatedFileInfo.Data, CodeType.Client);
			}
		}
	}

	private GeneratedFileInfo[] GenerateServerCode(ICodeItemMetadata metadata)
	{
		Type metadataType = metadata.CastAsRealType().GetType();
		IMetadataTypeInfo metadataTypeInfo = this.metadataTypeInfo.FirstOrDefault((IMetadataTypeInfo m) => m.MetadataType == metadataType);
		if (metadataTypeInfo == null)
		{
			throw new Exception(SR.T("Не найдена информация о типе метаданных \"{0}\"", metadataType));
		}
		ICodeGenerator obj = (ICodeGenerator)Activator.CreateInstance(metadataTypeInfo.GeneratorType);
		obj.Metadata = metadata;
		obj.GenerationParams.FileName = metadata.Name + ".md";
		obj.GenerationParams.Namespace = metadata.Namespace;
		return obj.Generate();
	}

	private GeneratedFileInfo GenerateClientCode(IMetadata metadata)
	{
		ICodeGenerator codeGenerator2;
		if (!(metadata is EnumMetadata))
		{
			ICodeGenerator codeGenerator = new DataClassWebGenerator(uiTypeGenerationFacade);
			codeGenerator2 = codeGenerator;
		}
		else
		{
			ICodeGenerator codeGenerator = new EnumWebGenerator();
			codeGenerator2 = codeGenerator;
		}
		codeGenerator2.Metadata = metadata;
		codeGenerator2.GenerationParams = new GenerationParams();
		return codeGenerator2.GenerateMainFile();
	}

	private static void WriteToDisk(string fileName, byte[] data, CodeType codeType)
	{
		if (!Directory.Exists(cacheFolderPath))
		{
			InitFolders();
		}
		string path = Path.Combine((codeType == CodeType.Client) ? clientFolderPath : serverFolderPath, fileName);
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllText(path, Encoding.UTF8.GetString(data));
	}

	private static void InitFolders()
	{
		if (!Directory.Exists(cacheFolderPath))
		{
			Directory.CreateDirectory(cacheFolderPath);
		}
		if (!Directory.Exists(serverFolderPath))
		{
			Directory.CreateDirectory(serverFolderPath);
		}
		if (!Directory.Exists(clientFolderPath))
		{
			Directory.CreateDirectory(clientFolderPath);
		}
	}

	private static void ReCreateFolders()
	{
		if (Directory.Exists(cacheFolderPath))
		{
			Directory.Delete(cacheFolderPath, recursive: true);
		}
		Directory.CreateDirectory(cacheFolderPath);
		Directory.CreateDirectory(serverFolderPath);
		Directory.CreateDirectory(clientFolderPath);
	}
}

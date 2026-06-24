using System;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ModuleAssemblyLoader : IModuleAssemblyLoader
{
	private readonly ModuleMetadataItemManager itemManager;

	private readonly IMemoryCacheService cacheService;

	public ModuleAssemblyLoader(ModuleMetadataItemManager itemManager, IMemoryCacheService cacheService)
	{
		this.itemManager = itemManager;
		this.cacheService = cacheService;
	}

	public ServerBuildResult GetServerAssembly(Guid moduleUid, Guid versionUid)
	{
		if (TryGetFromCache(moduleUid, versionUid, out ServerBuildResult serverBuildResult))
		{
			return serverBuildResult;
		}
		ModuleMetadataItem moduleMetadataItem = itemManager.LoadOrNull(versionUid);
		if (moduleMetadataItem == null)
		{
			return null;
		}
		serverBuildResult = new ServerBuildResult(moduleMetadataItem.AssemblyRaw, moduleMetadataItem.DebugRaw, moduleMetadataItem.AssemblyName);
		ToCache(moduleUid, versionUid, serverBuildResult);
		return serverBuildResult;
	}

	public ClientBuildResult GetClientAssembly(Guid moduleUid, Guid versionUid)
	{
		if (TryGetFromCache(moduleUid, versionUid, out ClientBuildResult clientBuildResult))
		{
			return clientBuildResult;
		}
		ModuleMetadataItem moduleMetadataItem = itemManager.LoadOrNull(versionUid);
		if (moduleMetadataItem == null)
		{
			return null;
		}
		clientBuildResult = new ClientBuildResult(moduleMetadataItem.ClientRaw, moduleMetadataItem.ClientDebugRaw, moduleMetadataItem.ClientAssemblyRaw, ModuleMetadataItemManager.ClientAssemblyName((ModuleInfoMetadata)moduleMetadataItem.Metadata));
		ToCache(moduleUid, versionUid, clientBuildResult);
		return clientBuildResult;
	}

	private void ToCache(Guid moduleUid, Guid versionUid, ClientBuildResult clientBuildResult)
	{
		cacheService.Insert(ClientModuleAssemblyKey(moduleUid, versionUid), clientBuildResult);
	}

	private bool TryGetFromCache(Guid moduleUid, Guid versionUid, out ClientBuildResult clientBuildResult)
	{
		string key = ClientModuleAssemblyKey(moduleUid, versionUid);
		return cacheService.TryGetValue<ClientBuildResult>(key, out clientBuildResult);
	}

	private void ToCache(Guid moduleUid, Guid versionUid, ServerBuildResult serverBuildResult)
	{
		cacheService.Insert(ServerModuleAssemblyKey(moduleUid, versionUid), serverBuildResult);
	}

	private bool TryGetFromCache(Guid moduleUid, Guid versionUid, out ServerBuildResult serverBuildResult)
	{
		string key = ServerModuleAssemblyKey(moduleUid, versionUid);
		return cacheService.TryGetValue<ServerBuildResult>(key, out serverBuildResult);
	}

	private static string ClientModuleAssemblyKey(Guid moduleUid, Guid versionUid)
	{
		return string.Join("_", "ClientModuleAssemblyKey", moduleUid, versionUid);
	}

	private static string ServerModuleAssemblyKey(Guid moduleUid, Guid versionUid)
	{
		return string.Join("_", "ServerModuleAssemblyKey", moduleUid, versionUid);
	}
}

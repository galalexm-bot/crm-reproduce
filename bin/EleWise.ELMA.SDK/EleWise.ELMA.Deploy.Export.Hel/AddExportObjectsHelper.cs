using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Helpers;

public sealed class AddExportObjectsHelper
{
	internal static AddExportObjectsHelper Yoq5AwELmKVTUWxFDfio;

	public static void AddScriptModules(ref PacketMetadata packetMetadata, ref Dictionary<string, object> serviceData, IGroupedMetadata metadata, IMetadataItemHeader header, ScriptModuleManager scriptModuleManager, ExternalAssemblyManager externalAssemblyManager)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
			{
				PacketMetadata packetMetadata3 = packetMetadata;
				Dictionary<string, object> serviceData3 = serviceData;
				ScriptModule scriptModule = ((IMetadataItem)J58oPvELJlG6wIfnTo1Q(header)).ScriptModule;
				object obj = wphrXqEL9tP9MCOxpPxk(header);
				AddScriptModule(packetMetadata3, serviceData3, metadata, scriptModule, (ScriptModule)((obj != null) ? MtV8XAELdGX0hlkkwLFX(obj) : null), (string)LC98htELlFne3bBrMEOm(0x2ACE37D ^ 0x2AC15ED), scriptModuleManager, externalAssemblyManager);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
			{
				PacketMetadata packetMetadata2 = packetMetadata;
				Dictionary<string, object> serviceData2 = serviceData;
				object publishedScriptModule = Fshk90ELrutuA12pQjep(J58oPvELJlG6wIfnTo1Q(header));
				IMetadataItem current = header.Current;
				AddScriptModule(packetMetadata2, serviceData2, metadata, (ScriptModule)publishedScriptModule, (ScriptModule)((current != null) ? Fshk90ELrutuA12pQjep(current) : null), (string)LC98htELlFne3bBrMEOm(0x6A81B9B4 ^ 0x6A814C62), scriptModuleManager, externalAssemblyManager);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 2;
				}
				break;
			}
			}
		}
	}

	internal static void AddScriptModule(PacketMetadata packetMetadata, Dictionary<string, object> serviceData, IMetadata metadata, ScriptModule publishedScriptModule, ScriptModule currentScriptModule, string scriptModulePropertyName, ScriptModuleManager scriptModuleManager, ExternalAssemblyManager externalAssemblyManager)
	{
		if (publishedScriptModule != null)
		{
			Guid? value = null;
			if (currentScriptModule != null)
			{
				AddScriptModule(packetMetadata, serviceData, metadata, currentScriptModule, scriptModulePropertyName, scriptModuleManager, externalAssemblyManager);
				value = currentScriptModule.Uid;
			}
			packetMetadata.SubEntitiesBefore.Add(publishedScriptModule, value);
		}
	}

	private static void AddScriptModule(object packetMetadata, Dictionary<string, object> serviceData, object metadata, object currentScriptModule, object scriptModulePropertyName, object scriptModuleManager, object externalAssemblyManager)
	{
		((ScriptModuleManager)scriptModuleManager).ConvertOldReferences((ScriptModule)currentScriptModule);
		string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289413710) + ((ScriptModule)currentScriptModule).Uid;
		if (!serviceData.ContainsKey(key))
		{
			serviceData.Add(key, ((ScriptModule)currentScriptModule).Uid);
		}
		if (((ScriptModule)currentScriptModule).GlobalScriptModules != null)
		{
			foreach (AssemblyReference globalScriptModule in ((ScriptModule)currentScriptModule).GlobalScriptModules)
			{
				string key2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463ADDD6), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606735296), globalScriptModule.Uid);
				if (!serviceData.ContainsKey(key2))
				{
					serviceData.Add(key2, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A729327), globalScriptModule.Uid, globalScriptModule.Name));
				}
			}
		}
		if (((ScriptModule)currentScriptModule).LocalReferences != null)
		{
			List<KeyValuePair<IEntity, Guid?>> list = ((PacketMetadata)packetMetadata).SubEntitiesBefore.ToList();
			foreach (AssemblyReference localReference in ((ScriptModule)currentScriptModule).LocalReferences)
			{
				IExternalAssembly externalAssembly = ((AbstractNHEntityManager<IExternalAssembly, long>)externalAssemblyManager).LoadOrNull(localReference.Uid);
				if (externalAssembly != null)
				{
					list.Insert(0, new KeyValuePair<IEntity, Guid?>(externalAssembly, externalAssembly.Uid));
				}
			}
			((PacketMetadata)packetMetadata).SubEntitiesBefore = list.ToDictionary((KeyValuePair<IEntity, Guid?> x) => x.Key, (KeyValuePair<IEntity, Guid?> x) => x.Value);
		}
		((PacketMetadata)packetMetadata).SubUserMetadataInfo[((IMetadata)metadata).Uid].ScriptModules.Add((string)scriptModulePropertyName, ((ScriptModule)currentScriptModule).Uid);
	}

	public AddExportObjectsHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NrAxkAELgRFC7KbT5FMN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object J58oPvELJlG6wIfnTo1Q(object P_0)
	{
		return ((IMetadataItemHeader)P_0).Published;
	}

	internal static object wphrXqEL9tP9MCOxpPxk(object P_0)
	{
		return ((IMetadataItemHeader)P_0).Current;
	}

	internal static object MtV8XAELdGX0hlkkwLFX(object P_0)
	{
		return ((IMetadataItem)P_0).ScriptModule;
	}

	internal static object LC98htELlFne3bBrMEOm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Fshk90ELrutuA12pQjep(object P_0)
	{
		return ((IMetadataItem)P_0).ClientScriptModule;
	}

	internal static bool hedF4BELyPsc5tOurQ1N()
	{
		return Yoq5AwELmKVTUWxFDfio == null;
	}

	internal static AddExportObjectsHelper IJWpmsELMjn7ydXygsfe()
	{
		return Yoq5AwELmKVTUWxFDfio;
	}

	internal static void NrAxkAELgRFC7KbT5FMN()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

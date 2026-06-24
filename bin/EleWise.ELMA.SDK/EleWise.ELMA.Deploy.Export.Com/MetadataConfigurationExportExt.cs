using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Helpers;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Components;

public abstract class MetadataConfigurationExportExtension : IConfigExportExtension
{
	internal const string MetadataItemGroupKey = "MetadataItemGroup_";

	internal const string MetadataItemGroupUIKey = "MetadataItemGroupUI_";

	internal static MetadataConfigurationExportExtension SgUWYPEsZ0vnOmiHJ8ex;

	public MetadataItemHeaderManager MetadataItemHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataItemHeaderManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CMetadataItemHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ScriptModuleManager ScriptModuleManager
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptModuleManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CScriptModuleManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ExternalAssemblyManager ExternalAssemblyManager
	{
		[CompilerGenerated]
		get
		{
			return _003CExternalAssemblyManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CExternalAssemblyManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public abstract Dictionary<Guid, object> GetNewSettingObj();

	public abstract void AddExportObjects(ExportExtensionParams parameters);

	protected virtual PacketMetadata CreatePacketMetadata(IMetadata metadata, Dictionary<string, object> serviceData)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.metadata = metadata;
		if (CS_0024_003C_003E8__locals0.metadata == null || !(CS_0024_003C_003E8__locals0.metadata is ClassMetadata metaData) || !(CS_0024_003C_003E8__locals0.metadata is IGroupedMetadata groupedMetadata))
		{
			return null;
		}
		PacketMetadata packetMetadata = new PacketMetadata(metaData);
		if (CS_0024_003C_003E8__locals0.metadata.IsConfig())
		{
			IMetadataItemHeader metadataItemHeader = MetadataItemHeaderManager.LoadOrNull(CS_0024_003C_003E8__locals0.metadata.Uid);
			if (metadataItemHeader != null && metadataItemHeader.Published != null)
			{
				if (metadataItemHeader.Group != null)
				{
					foreach (IEntity item in AddInfoMetadataGroup(metadataItemHeader.Group, serviceData))
					{
						if (!packetMetadata.SubEntitiesBefore.ContainsKey(item))
						{
							packetMetadata.SubEntitiesBefore.Add(item, null);
						}
					}
				}
				AddInfoForUserMetadata(packetMetadata, CS_0024_003C_003E8__locals0.metadata, serviceData);
				packetMetadata.SubUserMetadataInfo[CS_0024_003C_003E8__locals0.metadata.Uid] = new SubUserMetadataInfo(groupedMetadata);
				AddExportObjectsHelper.AddScriptModules(ref packetMetadata, ref serviceData, groupedMetadata, metadataItemHeader, ScriptModuleManager, ExternalAssemblyManager);
			}
		}
		else
		{
			packetMetadata.SubSystemMetadata.Add(groupedMetadata);
			IEnumerable<EntityMetadata> enumerable = MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return _003C_003Ec__DisplayClass16_0.drwkLd8m3TCGBnLZjBJo(_003C_003Ec__DisplayClass16_0.o8i7bO8m1h6WkgZMGwKF(m), _003C_003Ec__DisplayClass16_0.N8Om8u8mNRaAQidL4XAn(CS_0024_003C_003E8__locals0.metadata));
					case 1:
						if (_003C_003Ec__DisplayClass16_0.Tkf0808mPt22XMpeTUqI(m) != EntityMetadataType.InterfaceExtension)
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
			if (enumerable != null)
			{
				foreach (EntityMetadata item2 in enumerable)
				{
					if (item2 == null)
					{
						continue;
					}
					if (item2.IsConfig())
					{
						IMetadataItemHeader metadataItemHeader2 = MetadataItemHeaderManager.LoadOrNull(item2.Uid);
						if (metadataItemHeader2 != null && metadataItemHeader2.Published != null)
						{
							packetMetadata.SubUserMetadataInfo[item2.Uid] = new SubUserMetadataInfo(item2);
							AddExportObjectsHelper.AddScriptModules(ref packetMetadata, ref serviceData, item2, metadataItemHeader2, ScriptModuleManager.Instance, ExternalAssemblyManager.Instance);
							AddInfoForSystemMetadata(packetMetadata, CS_0024_003C_003E8__locals0.metadata, serviceData);
						}
					}
					else
					{
						packetMetadata.SubSystemMetadata.Add(item2);
					}
				}
			}
		}
		IEntityMetadata entityMetadata = CS_0024_003C_003E8__locals0.metadata as IEntityMetadata;
		ExportFormDependencyHelper.AddFormDependenciesInfo(CS_0024_003C_003E8__locals0.metadata.Uid, (entityMetadata == null) ? string.Empty : entityMetadata.DisplayName, serviceData);
		return packetMetadata;
	}

	protected virtual void AddInfoForUserMetadata(PacketMetadata packetMetadata, IMetadata metadata, Dictionary<string, object> serviceData)
	{
	}

	protected virtual void AddInfoForSystemMetadata(PacketMetadata packetMetadata, IMetadata metadata, Dictionary<string, object> serviceData)
	{
	}

	protected List<IEntity> AddInfoMetadataGroup(IMetadataItemGroup group, Dictionary<string, object> serviceData)
	{
		List<IEntity> list = new List<IEntity>();
		if (group != null)
		{
			string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766092742) + group.Id;
			if (!group.IsSystem)
			{
				if (!serviceData.ContainsKey(key) && !list.Contains(group))
				{
					list.Add(group);
					serviceData.Add(key, group.Uid);
				}
			}
			else if (!serviceData.ContainsKey(key))
			{
				serviceData.Add(key, group.Namespace);
				key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2022B75F) + group.Uid;
				serviceData.Add(key, group.Namespace);
			}
			if (group.Parent != null && group != group.Parent)
			{
				foreach (IEntity item in AddInfoMetadataGroup(group.Parent, serviceData))
				{
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
				return list;
			}
		}
		return list;
	}

	protected List<IEntity> AddInfoMetadataGroup(MetadataItemGroupUI group, Dictionary<string, object> serviceData)
	{
		List<IEntity> list = new List<IEntity>();
		if (group != null)
		{
			string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7243CE1E) + group.Id;
			if (!serviceData.ContainsKey(key) && !list.Contains(group))
			{
				list.Add(group);
				serviceData.Add(key, group.Uid);
			}
			if (group.Parent != null && group != group.Parent)
			{
				foreach (IEntity item in AddInfoMetadataGroup(group.Parent, serviceData))
				{
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
				return list;
			}
		}
		return list;
	}

	protected MetadataConfigurationExportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WgQLAuEsVjQZ1AVraUUo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool sZuSnMEsuTUW8rDNUFV1()
	{
		return SgUWYPEsZ0vnOmiHJ8ex == null;
	}

	internal static MetadataConfigurationExportExtension fdm47TEsIKWMILSugU9N()
	{
		return SgUWYPEsZ0vnOmiHJ8ex;
	}

	internal static void WgQLAuEsVjQZ1AVraUUo()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

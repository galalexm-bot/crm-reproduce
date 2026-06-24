using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export;

[Component(Order = 200)]
public class ObjectsExportExtension : MetadataConfigurationExportExtension
{
	[Component]
	private sealed class ImportantData : IImportantData
	{
		internal static object k7cHli80b3nvoqqWxKTq;

		public static Guid Uid { get; }

		Guid IImportantData.Uid => rNF3MZ80EGZxZG2i3wsP();

		public IEnumerable<Version> Versions { get; }

		public string Module => null;

		public ImportantData()
		{
			//Discarded unreachable code: IL_0046, IL_004b
			DMkbH380fh3iZbkQoLu1();
			Versions = new Version[1]
			{
				new Version(4, 1, 0)
			};
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ImportantData()
		{
			int num = 2;
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
					Uid = new Guid((string)A0vYh180QVKyct9El8tZ(0x1A33FE36 ^ 0x1A35F78E));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					DMkbH380fh3iZbkQoLu1();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static Guid rNF3MZ80EGZxZG2i3wsP()
		{
			return Uid;
		}

		internal static void DMkbH380fh3iZbkQoLu1()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool yMBW2g80hcXv8E5JucbP()
		{
			return k7cHli80b3nvoqqWxKTq == null;
		}

		internal static ImportantData B6B1aH80GeuOq7faJCcI()
		{
			return (ImportantData)k7cHli80b3nvoqqWxKTq;
		}

		internal static object A0vYh180QVKyct9El8tZ(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	private static ObjectsExportExtension g0jEvFEYewncKNPImbud;

	public override Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			ObjectsExportConsts.ExportExtensionUid,
			new ObjectsExportSetting()
		} };
	}

	public override void AddExportObjects(ExportExtensionParams parameters)
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
				AddExportObjectsCustom(parameters.Parameters, parameters.Objects, parameters.ServiceData, parameters.PacketMetadatas, parameters.PacketEntities, parameters.Importants);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<IGroupedMetadata, bool> objects, Dictionary<string, object> serviceData, List<PacketMetadata> packetMetadatas, List<PacketEntity> packetEntities, ISet<Guid> importants)
	{
		if (!(parameters[ObjectsExportConsts.ExportExtensionUid] is ObjectsExportSetting objectsExportSetting))
		{
			return;
		}
		List<Guid> dataClasses = objectsExportSetting.DataClasses;
		if (dataClasses != null && dataClasses.Any())
		{
			List<Guid> dataClasses2 = objectsExportSetting.DataClasses;
			DataClassMetadataItemHeaderManager instance = DataClassMetadataItemHeaderManager.Instance;
			foreach (Guid item2 in dataClasses2)
			{
				DataClassMetadataItemHeader dataClassMetadataItemHeader = instance.LoadOrNull(item2);
				if (dataClassMetadataItemHeader?.Published == null)
				{
					continue;
				}
				DataClassMetadata dataClassMetadata = ClassSerializationHelper.CloneObjectByXml((DataClassMetadata)dataClassMetadataItemHeader.Published.Metadata);
				PacketMetadata packetMetadata = new PacketMetadata(dataClassMetadata);
				if (dataClassMetadataItemHeader.Group != null)
				{
					serviceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561356304) + dataClassMetadataItemHeader.Uid, dataClassMetadataItemHeader.Group.Uid);
					foreach (IEntity item3 in AddInfoMetadataGroup(dataClassMetadataItemHeader.Group, serviceData))
					{
						if (!packetMetadata.SubEntitiesBefore.ContainsKey(item3))
						{
							packetMetadata.SubEntitiesBefore.Add(item3, null);
						}
					}
				}
				importants.Add(ImportantData.Uid);
				packetMetadata.SubUserMetadataInfo[dataClassMetadata.Uid] = new SubUserMetadataInfo(dataClassMetadata);
				packetMetadatas.Add(packetMetadata);
			}
		}
		bool exportCatalogs = objectsExportSetting.ExportCatalogs;
		SerializableDictionary<Guid, bool> catalogs = objectsExportSetting.Catalogs;
		List<Guid> sysCatalogs = objectsExportSetting.SysCatalogs;
		bool exportEnums = objectsExportSetting.ExportEnums;
		List<Guid> enums = objectsExportSetting.Enums;
		if (!(exportCatalogs || exportEnums))
		{
			return;
		}
		List<Guid> list = new List<Guid>();
		if (sysCatalogs != null && exportCatalogs)
		{
			list.AddRange(sysCatalogs);
		}
		if (catalogs != null && exportCatalogs)
		{
			foreach (KeyValuePair<Guid, bool> item4 in catalogs)
			{
				if (!list.Contains(item4.Key))
				{
					list.Add(item4.Key);
				}
			}
		}
		if (enums != null && exportEnums)
		{
			foreach (Guid item5 in enums)
			{
				if (!list.Contains(item5))
				{
					list.Add(item5);
				}
			}
		}
		IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		foreach (Guid item6 in list)
		{
			IMetadata metadata = serviceNotNull.GetMetadata(item6, loadImplementation: false);
			IGroupedMetadata groupedMetadata = metadata as IGroupedMetadata;
			ClassMetadata classMetadata = metadata as ClassMetadata;
			if (metadata == null || groupedMetadata == null || classMetadata == null)
			{
				if (!(metadata is EnumMetadata))
				{
					continue;
				}
				EnumMetadata enumMetadata = metadata as EnumMetadata;
				if (enumMetadata.Type != 0 || metadata.IsSystem())
				{
					continue;
				}
				PacketMetadata packetMetadata2 = new PacketMetadata(enumMetadata);
				packetMetadata2.SubUserMetadataInfo.Add(enumMetadata.Uid, new SubUserMetadataInfo(enumMetadata));
				IMetadataItemHeader metadataItemHeader = base.MetadataItemHeaderManager.LoadOrNull(groupedMetadata.Uid);
				if (metadataItemHeader != null && metadataItemHeader.Published != null && metadataItemHeader.Group != null)
				{
					foreach (IEntity item7 in AddInfoMetadataGroup(metadataItemHeader.Group, serviceData))
					{
						if (!packetMetadata2.SubEntitiesBefore.ContainsKey(item7))
						{
							packetMetadata2.SubEntitiesBefore.Add(item7, null);
						}
					}
				}
				packetMetadatas.Add(packetMetadata2);
				continue;
			}
			if (catalogs != null && catalogs.ContainsKey(item6))
			{
				if (catalogs[item6])
				{
					objects.Add(groupedMetadata, value: true);
				}
			}
			else
			{
				objects.Add(groupedMetadata, value: true);
			}
			PacketMetadata item = CreatePacketMetadata(metadata, serviceData);
			packetMetadatas.Add(item);
		}
	}

	public ObjectsExportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool x4ZapxEYPgbPHUmJ7RdZ()
	{
		return g0jEvFEYewncKNPImbud == null;
	}

	internal static ObjectsExportExtension sHPo46EY1wiBXAwB2hLS()
	{
		return g0jEvFEYewncKNPImbud;
	}
}

using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.Export.Helpers;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export;

[Component(Order = 500)]
internal class FunctionExportExtension : MetadataConfigurationExportExtension
{
	[Component]
	private sealed class ImportantData : IImportantData
	{
		private static object uShAJ78xvJINOBSRuwiI;

		public static Guid Uid { get; }

		Guid IImportantData.Uid => tx1Dk78xuprjA2VNY3VK();

		public IEnumerable<Version> Versions { get; }

		public string Module => null;

		public ImportantData()
		{
			//Discarded unreachable code: IL_0046, IL_004b
			Pe4N0o8xI0wdFj5yeQmE();
			Versions = new Version[1]
			{
				new Version(4, 1, 0)
			};
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
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
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					Pe4N0o8xI0wdFj5yeQmE();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					Uid = new Guid((string)fjvu5u8xVrJgaKiBAedw(0x66F566B6 ^ 0x66F36FBC));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static Guid tx1Dk78xuprjA2VNY3VK()
		{
			return Uid;
		}

		internal static void Pe4N0o8xI0wdFj5yeQmE()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool Vq5GK88x81MG2R4YbcUA()
		{
			return uShAJ78xvJINOBSRuwiI == null;
		}

		internal static ImportantData dfSovY8xZ0MZo1tt02bd()
		{
			return (ImportantData)uShAJ78xvJINOBSRuwiI;
		}

		internal static object fjvu5u8xVrJgaKiBAedw(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	private static FunctionExportExtension I4lakgE5ot66f8j0NSK9;

	public override Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			FunctionExportConsts.ExportExtensionUid,
			new FunctionExportSetting()
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
				AddExportObjectsCustom(parameters.Parameters, parameters.PacketMetadatas, parameters.ServiceData, parameters.Importants);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, List<PacketMetadata> packetMetadatas, Dictionary<string, object> serviceData, ISet<Guid> importants)
	{
		if (!(parameters[FunctionExportConsts.ExportExtensionUid] is FunctionExportSetting functionExportSetting) || functionExportSetting.FunctionsIds.Count == 0)
		{
			return;
		}
		List<Guid> functionsIds = functionExportSetting.FunctionsIds;
		FunctionMetadataItemHeaderManager instance = FunctionMetadataItemHeaderManager.Instance;
		foreach (Guid item in functionsIds)
		{
			FunctionMetadataItemHeader functionMetadataItemHeader = instance.LoadOrNull(item);
			if (functionMetadataItemHeader == null)
			{
				continue;
			}
			FunctionMetadata functionMetadata = ClassSerializationHelper.CloneObjectByXml((FunctionMetadata)functionMetadataItemHeader.Published.Metadata);
			functionMetadata.Uid = functionMetadataItemHeader.Uid;
			PacketMetadata packetMetadata = new PacketMetadata(functionMetadata);
			if (functionMetadataItemHeader.Group != null)
			{
				serviceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AF687C) + functionMetadataItemHeader.Uid, functionMetadataItemHeader.Group.Uid);
				foreach (IEntity item2 in AddInfoMetadataGroup(functionMetadataItemHeader.Group, serviceData))
				{
					if (!packetMetadata.SubEntitiesBefore.ContainsKey(item2))
					{
						packetMetadata.SubEntitiesBefore.Add(item2, null);
					}
				}
			}
			importants.Add(ImportantData.Uid);
			packetMetadata.SubUserMetadataInfo[functionMetadata.Uid] = new SubUserMetadataInfo(functionMetadata);
			AddExportObjectsHelper.AddScriptModule(packetMetadata, serviceData, functionMetadata, functionMetadataItemHeader.Published.ScriptModule, functionMetadataItemHeader.Draft.ScriptModule, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC247DD), base.ScriptModuleManager, base.ExternalAssemblyManager);
			packetMetadatas.Add(packetMetadata);
		}
	}

	public FunctionExportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mhPJbpE5GIF6PHaeYsiG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NDrsB1E5b3S915CE1yKX()
	{
		return I4lakgE5ot66f8j0NSK9 == null;
	}

	internal static FunctionExportExtension KxQLRdE5hGfRG5ao0ugY()
	{
		return I4lakgE5ot66f8j0NSK9;
	}

	internal static void mhPJbpE5GIF6PHaeYsiG()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

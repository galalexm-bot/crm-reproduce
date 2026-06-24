using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

public class ExportExtensionParams
{
	private static ExportExtensionParams pwows4EjbYoRSQVprYAH;

	public Dictionary<Guid, object> Parameters { get; private set; }

	public Dictionary<IGroupedMetadata, bool> Objects { get; private set; }

	public ISet<Guid> Importants { get; }

	public Dictionary<string, object> ServiceData { get; private set; }

	public List<PacketEntity> PacketEntities { get; private set; }

	public List<PacketMetadata> PacketMetadatas { get; private set; }

	public List<PackageDescription> PackageDescriptions { get; private set; }

	public List<FormExportData> FormExportData { get; private set; }

	public List<Action<IExportImportFileService, string>> WriteComponentFileActions { get; private set; }

	public List<DeployLogMessage> Messages { get; private set; }

	public ElmaStoreComponentManifest Manifest
	{
		[CompilerGenerated]
		get
		{
			return _003CManifest_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
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

	public ExportExtensionParams(Dictionary<Guid, object> parameters, Dictionary<IGroupedMetadata, bool> objects, ISet<Guid> importants, Dictionary<string, object> serviceData, List<PacketEntity> packetEntities, List<PacketMetadata> packetMetadatas, List<PackageDescription> packageDescriptions, List<FormExportData> formExportData, List<Action<IExportImportFileService, string>> writeComponentFileActions, List<DeployLogMessage> messages, ElmaStoreComponentManifest manifest)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Parameters = parameters;
		Objects = objects;
		Importants = importants;
		ServiceData = serviceData;
		PacketEntities = packetEntities;
		PacketMetadatas = packetMetadatas;
		PackageDescriptions = packageDescriptions;
		FormExportData = formExportData;
		WriteComponentFileActions = writeComponentFileActions;
		Messages = messages;
		Manifest = manifest;
	}

	internal static bool jLfIbdEjhluJpcmCp9J6()
	{
		return pwows4EjbYoRSQVprYAH == null;
	}

	internal static ExportExtensionParams PvaC9pEjGisSohBhRgdA()
	{
		return pwows4EjbYoRSQVprYAH;
	}
}

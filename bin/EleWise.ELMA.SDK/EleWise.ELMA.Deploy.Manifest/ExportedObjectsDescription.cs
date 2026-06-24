using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NuGet;

namespace EleWise.ELMA.Deploy.Manifest;

public class ExportedObjectsDescription
{
	private static ExportedObjectsDescription ea6v0HEaEe8ADE8txVZm;

	public Dictionary<string, object> ExportServiceData { get; set; }

	public Dictionary<string, IPackage> ExportPackages { get; set; }

	public List<PacketEntity> ExportedPacketEntities { get; set; }

	public List<PacketMetadata> ExportedPacketMetadatas { get; set; }

	public Dictionary<IGroupedMetadata, bool> ExportedObjects { get; set; }

	public ExportedObjectsDescription()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TcN4kOEaCVrsZpJiDfQj();
		base._002Ector();
		int num = 4;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ExportPackages = new Dictionary<string, IPackage>();
				num = 5;
				break;
			case 4:
				ExportedPacketEntities = new List<PacketEntity>();
				num = 2;
				break;
			case 3:
				ExportedObjects = new Dictionary<IGroupedMetadata, bool>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num = 0;
				}
				break;
			default:
				ExportServiceData = new Dictionary<string, object>();
				num = 3;
				break;
			case 2:
				ExportedPacketMetadatas = new List<PacketMetadata>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num = 0;
				}
				break;
			case 5:
				return;
			}
		}
	}

	internal static void TcN4kOEaCVrsZpJiDfQj()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FjBiiwEafNsSyPvtrDD1()
	{
		return ea6v0HEaEe8ADE8txVZm == null;
	}

	internal static ExportedObjectsDescription X78WCCEaQQ6Lc6QilOhS()
	{
		return ea6v0HEaEe8ADE8txVZm;
	}
}

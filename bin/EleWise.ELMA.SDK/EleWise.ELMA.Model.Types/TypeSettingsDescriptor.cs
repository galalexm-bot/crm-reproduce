using System;
using System.Data;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class TypeSettingsDescriptor : CLRTypeDescriptor<TypeSettings, TypeSettingsSettings>
{
	public const string UID_S = "{6B39BAB6-1274-477B-A4E1-4C699EAB4C75}";

	public static readonly Guid UID;

	internal static TypeSettingsDescriptor g1oKuuo9Syd7CHHvn9yp;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => SR.T((string)diM5iZo9qmUV8DFwkcId(0x92F12D5 ^ 0x92D89E3));

	public override bool Visible
	{
		get
		{
			//Discarded unreachable code: IL_006b, IL_007a
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!base.Visible)
					{
						num2 = 2;
						break;
					}
					goto default;
				default:
					if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 1;
						}
						break;
					}
					return true;
				case 1:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 2:
					return false;
				}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public TypeSettingsDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xVEg9Qo9KR8CNnxXX9rg();
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

	static TypeSettingsDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886480661));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object diM5iZo9qmUV8DFwkcId(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool yGQ4hSo9i3UE0007CVwo()
	{
		return g1oKuuo9Syd7CHHvn9yp == null;
	}

	internal static TypeSettingsDescriptor X3efllo9RAxL2OfuiN3T()
	{
		return g1oKuuo9Syd7CHHvn9yp;
	}

	internal static void xVEg9Qo9KR8CNnxXX9rg()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

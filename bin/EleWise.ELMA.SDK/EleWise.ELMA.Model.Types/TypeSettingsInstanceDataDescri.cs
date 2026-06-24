using System;
using System.Data;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class TypeSettingsInstanceDataDescriptor : CLRTypeDescriptor<TypeSettingsInstanceData, TypeSettingsInstanceDataSettings>
{
	public const string UID_S = "{C0E3456C-53BA-4815-9D0A-262420F061A3}";

	public static readonly Guid UID;

	internal static TypeSettingsInstanceDataDescriptor yj28bWoyH0IGhv6uLyK3;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)SeyRR4oy0SxhD0gVjDlH(v1xWy9oyxS1dx1JjPCuB(-1217523399 ^ -1217624621));

	public override bool Visible
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return true;
				default:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				case 2:
					if (!base.Visible)
					{
						return false;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public TypeSettingsInstanceDataDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mJhnuMoymKDHcC3ycnI7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TypeSettingsInstanceDataDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)v1xWy9oyxS1dx1JjPCuB(-345420348 ^ -345253722));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				mJhnuMoymKDHcC3ycnI7();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object v1xWy9oyxS1dx1JjPCuB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object SeyRR4oy0SxhD0gVjDlH(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool rdeTtGoyArLCIsXpcj3P()
	{
		return yj28bWoyH0IGhv6uLyK3 == null;
	}

	internal static TypeSettingsInstanceDataDescriptor TRRycZoy7enSkugAcJXR()
	{
		return yj28bWoyH0IGhv6uLyK3;
	}

	internal static void mJhnuMoymKDHcC3ycnI7()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

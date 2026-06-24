using System;
using System.Linq;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public class EntityPropertyTablePartMetadata : EntityPropertyMetadata
{
	internal static EntityPropertyTablePartMetadata ilqBStbDuMV3igfMcnRo;

	public EntityPropertyTablePartMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EntityPropertyTablePartMetadata(EntityMetadata metadata, TablePartMetadata tablePart)
	{
		//Discarded unreachable code: IL_0037
		SingletonReader.JJCZtPuTvSt();
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.tablePart = tablePart;
		base._002Ector();
		int num = 6;
		int num2 = num;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 6:
				jWUaWMbDSixw35qi70RC(this, CS_0024_003C_003E8__locals0.tablePart.TablePartPropertyUid);
				num2 = 8;
				break;
			case 8:
				ljfIU8bDRJtx4WxNCsIE(this, xDbbmsbDipB6GClXcXwh(CS_0024_003C_003E8__locals0.tablePart));
				num2 = 3;
				break;
			case 7:
				O43JobbDT41GgusR2gUJ(this, P4kAtSbDXBpK4m0ulWqq(CS_0024_003C_003E8__locals0.tablePart));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
			{
				EntitySettings entitySettings = new EntitySettings();
				GH4I3AbDeKhdjHgbujIE(entitySettings, RelationType.OneToMany);
				befVc8bDPMVJ4sxDUkOS(entitySettings, qaAGHGbDOaUYImQgkR50(propertyMetadata));
				entitySettings.CascadeMode = CascadeMode.All;
				fZhQ4hbD1dPcQm8Gnhsr(this, entitySettings);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
				return;
			default:
				ikFHTXbDk04wAkBmJnOG(this, EntityDescriptor.UID);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				oXqsyEbDK6jMeRlrS7vp(this, dfTrDsbDqvF02UBk68p6(CS_0024_003C_003E8__locals0.tablePart));
				num2 = 7;
				break;
			case 2:
				propertyMetadata = CS_0024_003C_003E8__locals0.tablePart.Properties.First((PropertyMetadata p) => _003C_003Ec__DisplayClass1_0.bHaOneCDYiS0vccDA6rP(_003C_003Ec__DisplayClass1_0.xfTl4nCD5EjDKY9iL0xE(p), _003C_003Ec__DisplayClass1_0.tApxKpCDjVhNdbbEkPXE(CS_0024_003C_003E8__locals0.tablePart)));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				SubTypeUid = ((MlVPEjbDn7Rppferina8(metadata) == EntityMetadataType.InterfaceImplementation) ? mlDAKqbD2iJVBv7w4Zow(CS_0024_003C_003E8__locals0.tablePart) : qaAGHGbDOaUYImQgkR50(CS_0024_003C_003E8__locals0.tablePart));
				num2 = 2;
				break;
			}
		}
	}

	internal static bool MSPQNCbDIVS7HZvV3fCN()
	{
		return ilqBStbDuMV3igfMcnRo == null;
	}

	internal static EntityPropertyTablePartMetadata JDdNTrbDVYGAWCYoCHhr()
	{
		return ilqBStbDuMV3igfMcnRo;
	}

	internal static void jWUaWMbDSixw35qi70RC(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static object xDbbmsbDipB6GClXcXwh(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static void ljfIU8bDRJtx4WxNCsIE(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object dfTrDsbDqvF02UBk68p6(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void oXqsyEbDK6jMeRlrS7vp(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object P4kAtSbDXBpK4m0ulWqq(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static void O43JobbDT41GgusR2gUJ(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Description = (string)P_1;
	}

	internal static void ikFHTXbDk04wAkBmJnOG(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static EntityMetadataType MlVPEjbDn7Rppferina8(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid qaAGHGbDOaUYImQgkR50(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid mlDAKqbD2iJVBv7w4Zow(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static void GH4I3AbDeKhdjHgbujIE(object P_0, RelationType value)
	{
		((EntitySettings)P_0).RelationType = value;
	}

	internal static void befVc8bDPMVJ4sxDUkOS(object P_0, Guid value)
	{
		((EntitySettings)P_0).KeyColumnUid = value;
	}

	internal static void fZhQ4hbD1dPcQm8Gnhsr(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}
}

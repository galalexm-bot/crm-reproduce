using System;
using System.Data;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class ReferenceOnEntityTypeDecription : CLRTypeDescriptor<ReferenceOnEntityType, ReferenceOnEntityTypeSettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{2DF8E9CA-3AC4-4BA5-832F-18F6374397E7}";

	public static readonly Guid UID;

	public const string TypeUid_UID_S = "{D030EE61-94FB-401E-81FF-7171C34BBBEE}";

	public static readonly Guid TypeUid_UID;

	private static ReferenceOnEntityTypeDecription ojMhafoHowAfGRQCLxhH;

	public override Guid Uid => UID;

	public override string Name => (string)kN9vxtoHfOmo1Wx9b4ob(iZ1WJXoHEqRs0NRmHh68(-542721635 ^ -542885493));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
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
				mapper.Type<ReferenceOnEntityTypeNHType>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				xKcfeToHGIFWMWXDM3Qx(this, mapper, propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Guid);
	}

	public ReferenceOnEntityTypeDecription()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oUHI25oHQqHgZHJMohIv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ReferenceOnEntityTypeDecription()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				TypeUid_UID = new Guid((string)iZ1WJXoHEqRs0NRmHh68(0xA592A41 ^ 0xA5BAAD5));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				UID = new Guid((string)iZ1WJXoHEqRs0NRmHh68(-218496594 ^ -218594838));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				oUHI25oHQqHgZHJMohIv();
				num2 = 2;
				break;
			}
		}
	}

	internal static void xKcfeToHGIFWMWXDM3Qx(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<ReferenceOnEntityType>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool tSXd5woHbIHKyeXeUYGy()
	{
		return ojMhafoHowAfGRQCLxhH == null;
	}

	internal static ReferenceOnEntityTypeDecription TAasB9oHh8UwsJ4CfyTL()
	{
		return ojMhafoHowAfGRQCLxhH;
	}

	internal static object iZ1WJXoHEqRs0NRmHh68(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object kN9vxtoHfOmo1Wx9b4ob(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void oUHI25oHQqHgZHJMohIv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

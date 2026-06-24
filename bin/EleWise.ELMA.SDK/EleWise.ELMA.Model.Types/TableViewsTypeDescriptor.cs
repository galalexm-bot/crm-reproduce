using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class TableViewsTypeDescriptor : CLRTypeDescriptor<List<TableView>, TableViewsTypeSettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{C039DA91-30DE-4681-84D0-842C17D54BD6}";

	public static readonly Guid UID;

	internal static TableViewsTypeDescriptor dQY01OoHghnXAVw9TerI;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override bool Visible => false;

	public override string Name => SR.T((string)w9JQcqoHLZmeeBmgUiWt(0x34185E55 ^ 0x341ADCF9));

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				mapper.Type<TableViewsNHType>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				oHJWCJoHYhrnuNYsHVJs(this, mapper, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public TableViewsTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		irOOEKoHUW5wA0c36yMU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TableViewsTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				UID = new Guid((string)w9JQcqoHLZmeeBmgUiWt(-1317790512 ^ -1317626334));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				irOOEKoHUW5wA0c36yMU();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void oHJWCJoHYhrnuNYsHVJs(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<List<TableView>>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool i8fJdSoH5XJOSS7mr6No()
	{
		return dQY01OoHghnXAVw9TerI == null;
	}

	internal static TableViewsTypeDescriptor eoprJqoHjs6IrDFc2Pog()
	{
		return dQY01OoHghnXAVw9TerI;
	}

	internal static object w9JQcqoHLZmeeBmgUiWt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void irOOEKoHUW5wA0c36yMU()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

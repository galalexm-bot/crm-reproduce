using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class Int16Descriptor : CLRTypeDescriptor<short, Int16Settings>
{
	public const string UID_S = "{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	private static Int16Descriptor TPMeb8olDPgIa6yCEqOY;

	public override Guid Uid => UID;

	public override string Name => (string)K8uHLbol6IGSCkvLcbpG(NvuXkLol4jxIAyfwEvra(0x53CB464B ^ 0x53C9E65B));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override bool UseForId => true;

	public override bool AutoIncrementSupported => true;

	public override bool IsAvailibleEditPropertyInTable => true;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 2;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					fullTextPropertyDescriptor = (propertyDescriptor = new Int16PropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_006a, IL_0089, IL_011a, IL_0150, IL_015f
		int num = 7;
		int num2 = num;
		Int16Settings int16Settings = default(Int16Settings);
		short? defaultValue = default(short?);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (int16Settings == null)
				{
					num2 = 4;
					break;
				}
				defaultValue = int16Settings.DefaultValue;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				if (val == null)
				{
					num2 = 6;
					break;
				}
				goto case 11;
			case 11:
				if (!w3TC0qolHEZgqy2GhpOx(this, propertyMetadata, val))
				{
					num2 = 8;
					break;
				}
				goto case 6;
			case 2:
				return false;
			case 9:
				return true;
			case 13:
				if (!xq5FGJolAeXlKMQdJKT8(propertyMetadata))
				{
					int16Settings = (Int16Settings)propertyMetadata.Settings;
					num2 = 10;
				}
				else
				{
					num2 = 2;
				}
				break;
			case 1:
				if (!defaultValue.HasValue)
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 4:
				return true;
			case 3:
				defaultValue = int16Settings.DefaultValue;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return defaultValue.Equals(val);
			case 5:
				return false;
			case 6:
			case 12:
				return true;
			case 8:
				if (propertyMetadata != null)
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 9;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_00a0, IL_0117, IL_012a
		int num = 1;
		int num2 = num;
		short? defaultValue = default(short?);
		Int16Settings int16Settings = default(Int16Settings);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (defaultValue.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				OhMe5iol7M281L2jdWD4(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16771147));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
			case 6:
				return null;
			case 2:
				return (ISyntaxNode)bkPWKCol0HiAh6RgQ6rU(int16Settings.DefaultValue);
			case 3:
				defaultValue = int16Settings.DefaultValue;
				num2 = 8;
				break;
			case 7:
				if (int16Settings == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 3;
			default:
				if (!forFilter)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			case 9:
				return null;
			case 5:
				int16Settings = (Int16Settings)jUgWeuolx05q0V2Ui6Ko(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_00dd, IL_00e7, IL_010a, IL_016b, IL_01c6
		int num = 12;
		short? num5 = default(short?);
		short? num3 = default(short?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				short? num4;
				int value;
				switch (num2)
				{
				case 6:
					if (propertyMetadata == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 7;
				case 12:
					Contract.ArgumentNotNull(propertyMetadata, (string)NvuXkLol4jxIAyfwEvra(-3333094 ^ -3314360));
					num2 = 11;
					continue;
				case 9:
					return new PropertyValueContainer<short?>(num5);
				case 3:
				case 5:
					num3 = num5;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 10;
					}
					continue;
				case 4:
					goto end_IL_0012;
				case 13:
					num4 = num3;
					goto IL_01d7;
				case 11:
					if (!forFilter)
					{
						num2 = 8;
						continue;
					}
					goto end_IL_0012;
				case 10:
					if (!num3.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
						continue;
					}
					value = num3.GetValueOrDefault();
					break;
				case 8:
				{
					Int16Settings obj = (Int16Settings)jUgWeuolx05q0V2Ui6Ko(propertyMetadata);
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					num4 = obj.DefaultValue;
					goto IL_01d7;
				}
				case 7:
					if (!xq5FGJolAeXlKMQdJKT8(propertyMetadata))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				default:
					num3 = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					value = 0;
					break;
				case 2:
					{
						num4 = num3;
						goto IL_01d7;
					}
					IL_01d7:
					num5 = num4;
					num2 = 6;
					continue;
				}
				return new PropertyValueContainer<short>((short)value);
				continue;
				end_IL_0012:
				break;
			}
			num3 = null;
			num = 13;
		}
	}

	public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_003d, IL_006c, IL_00c3
		int num = 2;
		int num2 = num;
		Int16Settings int16Settings = default(Int16Settings);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				if (propertyMetadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 3;
			default:
				if (int16Settings != null)
				{
					num2 = 5;
					continue;
				}
				goto case 6;
			case 4:
				return UID;
			case 6:
				return Int16RangeDescriptor.UID;
			case 5:
				if (int16Settings.RangeInFilter)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 4;
			case 3:
				obj = null;
				break;
			case 1:
				obj = (Int16Settings)jUgWeuolx05q0V2Ui6Ko(propertyMetadata);
				break;
			}
			int16Settings = (Int16Settings)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
			{
				num2 = 0;
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_009c, IL_00ab
		int num = 3;
		int num2 = num;
		Int16Settings int16Settings = default(Int16Settings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (int16Settings == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 3:
				int16Settings = (Int16Settings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 2;
				continue;
			case 1:
			case 4:
				return int16Settings;
			}
			int16Settings.DefaultValue = null;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
			{
				num2 = 1;
			}
		}
	}

	public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		return true;
	}

	public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		return true;
	}

	public override IComparer GetComparer(Type sourceType, LambdaExpression propertyFunc, ListSortDirection order)
	{
		return (IComparer)cenA8LolmSsTnq55t6am(sourceType, propertyFunc, order);
	}

	public override bool IsSupportSort()
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Int16);
	}

	protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0051
		int num = 3;
		Int16Settings int16Settings = default(Int16Settings);
		short? defaultValue = default(short?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 3:
					int16Settings = propertyMetadata.Settings as Int16Settings;
					num2 = 2;
					continue;
				default:
					num3 = 0;
					break;
				case 5:
					if (!defaultValue.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					defaultValue = int16Settings.DefaultValue;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (int16Settings != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto default;
				case 4:
					goto end_IL_0012;
				case 1:
					num3 = defaultValue.Value;
					break;
				}
				return (short)num3;
				continue;
				end_IL_0012:
				break;
			}
			defaultValue = int16Settings.DefaultValue;
			num = 5;
		}
	}

	public Int16Descriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YWInQoolyqsiWOr41rlw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Int16Descriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				YWInQoolyqsiWOr41rlw();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)NvuXkLol4jxIAyfwEvra(0x463A0F3C ^ 0x4638AF00));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object NvuXkLol4jxIAyfwEvra(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object K8uHLbol6IGSCkvLcbpG(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool PMJoZeoltqfEhDWsCobZ()
	{
		return TPMeb8olDPgIa6yCEqOY == null;
	}

	internal static Int16Descriptor ShBOa2olwE6OIf4780VU()
	{
		return TPMeb8olDPgIa6yCEqOY;
	}

	internal static bool w3TC0qolHEZgqy2GhpOx(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static bool xq5FGJolAeXlKMQdJKT8(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static void OhMe5iol7M281L2jdWD4(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object jUgWeuolx05q0V2Ui6Ko(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object bkPWKCol0HiAh6RgQ6rU(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static object cenA8LolmSsTnq55t6am(Type sourceType, object P_1, ListSortDirection order)
	{
		return ComparerHelper.Create(sourceType, (LambdaExpression)P_1, order);
	}

	internal static void YWInQoolyqsiWOr41rlw()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

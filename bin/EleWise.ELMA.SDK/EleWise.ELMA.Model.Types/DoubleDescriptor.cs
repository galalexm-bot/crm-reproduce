using System;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 500)]
public class DoubleDescriptor : CLRTypeDescriptor<double, DoubleSettings>
{
	public const string UID_S = "{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static DoubleDescriptor Qg0rOCo9avkirKUUIhbw;

	public override Guid Uid => UID;

	public override string Name => SR.T((string)j1b4gho9wYIVsWNkOVcl(0x3CE17B75 ^ 0x3CE3E76D));

	public override bool IsAvailibleEditPropertyInTable => true;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				default:
					fullTextPropertyDescriptor = (propertyDescriptor = new DoublePropertyDescriptor(this));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
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
		//Discarded unreachable code: IL_00c1, IL_00d0, IL_017d, IL_018c, IL_019b
		int num = 11;
		int num2 = num;
		double? defaultValue = default(double?);
		DoubleSettings doubleSettings = default(DoubleSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return true;
			case 5:
				if (propertyMetadata == null)
				{
					num2 = 7;
					break;
				}
				if (!sgbwMSo96yDoi4MWPAQL(propertyMetadata))
				{
					num2 = 8;
					break;
				}
				goto case 2;
			case 4:
				if (defaultValue.HasValue)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 6;
					}
					break;
				}
				return false;
			case 1:
				return defaultValue.Equals(val);
			case 6:
				defaultValue = doubleSettings.DefaultValue;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return false;
			case 8:
				doubleSettings = (DoubleSettings)propertyMetadata.Settings;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 12;
				}
				break;
			case 12:
				if (doubleSettings != null)
				{
					num2 = 9;
					break;
				}
				goto default;
			case 7:
				return true;
			case 11:
				if (val != null)
				{
					num2 = 10;
					break;
				}
				goto case 3;
			default:
				return true;
			case 9:
				defaultValue = doubleSettings.DefaultValue;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				if (!JUTgkVo94yS3lYuvlGs4(this, propertyMetadata, val))
				{
					num2 = 5;
					break;
				}
				goto case 3;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		int num = 3;
		double? defaultValue = default(double?);
		DoubleSettings doubleSettings = default(DoubleSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return null;
				case 3:
					break;
				case 4:
					return (ISyntaxNode)UOGiAho973akDv3JTrCW(defaultValue.Value);
				case 6:
					if (doubleSettings != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 5:
					return null;
				default:
					defaultValue = doubleSettings.DefaultValue;
					num2 = 7;
					continue;
				case 7:
					if (defaultValue.HasValue)
					{
						defaultValue = doubleSettings.DefaultValue;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 5;
					}
					continue;
				case 2:
					if (!forFilter)
					{
						doubleSettings = (DoubleSettings)uQblWBo9AbfHD355Ca3L(propertyMetadata);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 1;
						}
					}
					continue;
				}
				break;
			}
			d2GlXAo9HTy6UV2UsrVM(propertyMetadata, j1b4gho9wYIVsWNkOVcl(-787452571 ^ -787471305));
			num = 2;
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_005e, IL_00b0, IL_00bf, IL_0141, IL_01ad
		int num = 11;
		int num2 = num;
		double value;
		double? num5 = default(double?);
		double? num3 = default(double?);
		while (true)
		{
			double? num4;
			switch (num2)
			{
			case 7:
				value = 0.0;
				break;
			case 12:
				return new PropertyValueContainer<double?>(num5);
			case 8:
				num3 = num5;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 6;
				}
				continue;
			case 5:
				num3 = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				if (num3.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 7;
			case 2:
				if (propertyMetadata == null)
				{
					num2 = 8;
					continue;
				}
				goto case 9;
			case 10:
				if (!forFilter)
				{
					DoubleSettings obj = (DoubleSettings)uQblWBo9AbfHD355Ca3L(propertyMetadata);
					if (obj == null)
					{
						num2 = 5;
						continue;
					}
					num4 = obj.DefaultValue;
					goto IL_01e0;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 4;
				}
				continue;
			case 9:
				if (propertyMetadata.Nullable)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				goto case 8;
			case 11:
				d2GlXAo9HTy6UV2UsrVM(propertyMetadata, j1b4gho9wYIVsWNkOVcl(-629844702 ^ -629859216));
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 9;
				}
				continue;
			case 1:
				num4 = num3;
				goto IL_01e0;
			case 4:
				num3 = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				num4 = num3;
				goto IL_01e0;
			default:
				{
					value = num3.GetValueOrDefault();
					break;
				}
				IL_01e0:
				num5 = num4;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return new PropertyValueContainer<double>(value);
	}

	public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_003e, IL_0048, IL_0057, IL_00ba, IL_00c9
		int num = 4;
		DoubleSettings doubleSettings = default(DoubleSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					obj = null;
					break;
				default:
					return UID;
				case 2:
					return DoubleRangeDescriptor.UID;
				case 6:
					if (doubleSettings != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 1:
					if (doubleSettings.RangeInFilter)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto default;
				case 4:
					if (propertyMetadata != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 3:
					obj = (DoubleSettings)uQblWBo9AbfHD355Ca3L(propertyMetadata);
					break;
				}
				doubleSettings = (DoubleSettings)obj;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		DoubleSettings doubleSettings = default(DoubleSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (doubleSettings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				doubleSettings = (DoubleSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return doubleSettings;
			default:
				doubleSettings.DefaultValue = null;
				num2 = 3;
				break;
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

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Double);
	}

	protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0041, IL_008b, IL_009a, IL_00b3
		int num = 4;
		int num2 = num;
		DoubleSettings doubleSettings = default(DoubleSettings);
		double? defaultValue = default(double?);
		double num3;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (doubleSettings == null)
				{
					num2 = 5;
					continue;
				}
				goto default;
			case 4:
				doubleSettings = uQblWBo9AbfHD355Ca3L(propertyMetadata) as DoubleSettings;
				num2 = 3;
				continue;
			default:
				defaultValue = doubleSettings.DefaultValue;
				num2 = 6;
				continue;
			case 2:
			case 5:
				num3 = 0.0;
				break;
			case 7:
				defaultValue = doubleSettings.DefaultValue;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				if (defaultValue.HasValue)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 2;
			case 1:
				num3 = defaultValue.Value;
				break;
			}
			break;
		}
		return num3;
	}

	public DoubleDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uFvkrAo9xU80gJmijsB6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DoubleDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)j1b4gho9wYIVsWNkOVcl(-882126494 ^ -882291372));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object j1b4gho9wYIVsWNkOVcl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Kis5ESo9D5gyUqjl6S5r()
	{
		return Qg0rOCo9avkirKUUIhbw == null;
	}

	internal static DoubleDescriptor RLCm2fo9tRhrdIYhl4MD()
	{
		return Qg0rOCo9avkirKUUIhbw;
	}

	internal static bool JUTgkVo94yS3lYuvlGs4(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static bool sgbwMSo96yDoi4MWPAQL(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static void d2GlXAo9HTy6UV2UsrVM(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object uQblWBo9AbfHD355Ca3L(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object UOGiAho973akDv3JTrCW(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static void uFvkrAo9xU80gJmijsB6()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

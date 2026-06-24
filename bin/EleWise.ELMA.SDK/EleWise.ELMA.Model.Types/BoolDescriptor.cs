using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 800)]
public class BoolDescriptor : CLRTypeDescriptor<bool, BoolSettings>
{
	public const string UID_S = "{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	private static BoolDescriptor IMuEvxo9n7j3Sqcfdvwc;

	public override Guid Uid => UID;

	public override string Name => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A63AE0A));

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
					fullTextPropertyDescriptor = (propertyDescriptor = new BoolPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
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
		//Discarded unreachable code: IL_006c, IL_007b, IL_008b, IL_009b, IL_00f1, IL_0100
		int num = 7;
		BoolSettings boolSettings = default(BoolSettings);
		bool? boolDefaultValue = default(bool?);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 9:
					return true;
				case 3:
					num3 = 0;
					goto IL_0191;
				default:
					if (boolSettings == null)
					{
						num = 4;
						break;
					}
					boolDefaultValue = boolSettings.BoolDefaultValue;
					num2 = 2;
					continue;
				case 4:
					return true;
				case 6:
				case 12:
					return true;
				case 2:
					if (boolDefaultValue.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 10:
					return flag.Equals(val);
				case 8:
					if (!IsEmpty(propertyMetadata, val))
					{
						if (propertyMetadata != null)
						{
							if (!propertyMetadata.Nullable)
							{
								num2 = 5;
								continue;
							}
							goto case 11;
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					num2 = 12;
					continue;
				case 7:
					if (val == null)
					{
						num2 = 6;
						continue;
					}
					goto case 8;
				case 11:
					return false;
				case 5:
					boolSettings = (BoolSettings)DDRADMo9elglbNDDub7G(propertyMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					{
						num3 = (boolDefaultValue.GetValueOrDefault() ? 1 : 0);
						goto IL_0191;
					}
					IL_0191:
					flag = (byte)num3 != 0;
					num = 10;
					break;
				}
				break;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_005b, IL_00bb, IL_00ca
		int num = 1;
		int num2 = num;
		bool? boolDefaultValue = default(bool?);
		BoolSettings boolSettings = default(BoolSettings);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return boolDefaultValue.Value.CreateSyntaxNode();
			case 7:
				if (boolSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 6;
			case 1:
				olVilKo913PQyAoAI74k(propertyMetadata, kRTcB8o9PBjqwRuLQwqP(-1088304168 ^ -1088322934));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return null;
			case 4:
				if (boolDefaultValue.HasValue)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 2;
			case 6:
				boolDefaultValue = boolSettings.BoolDefaultValue;
				num2 = 4;
				continue;
			case 2:
			case 5:
				return null;
			case 9:
				boolDefaultValue = boolSettings.BoolDefaultValue;
				num2 = 8;
				continue;
			}
			if (!forFilter)
			{
				boolSettings = (BoolSettings)DDRADMo9elglbNDDub7G(propertyMetadata);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 5;
				}
			}
			else
			{
				num2 = 3;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0084, IL_0093, IL_00a5, IL_012d, IL_0139, IL_0175, IL_0184
		int num = 12;
		int num2 = num;
		BoolSettings boolSettings = default(BoolSettings);
		bool? flag2 = default(bool?);
		int value;
		bool? flag3 = default(bool?);
		while (true)
		{
			bool? flag;
			switch (num2)
			{
			case 11:
				boolSettings = (BoolSettings)propertyMetadata.Settings;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				flag = flag2;
				goto IL_01ec;
			case 5:
				if (!flag2.HasValue)
				{
					num2 = 7;
					continue;
				}
				value = (flag2.GetValueOrDefault() ? 1 : 0);
				break;
			case 12:
				olVilKo913PQyAoAI74k(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107996852));
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 2;
				}
				continue;
			case 6:
				return new PropertyValueContainer<bool?>(flag3);
			case 1:
			case 2:
				flag2 = flag3;
				num2 = 5;
				continue;
			case 7:
				value = 0;
				break;
			case 13:
				flag = flag2;
				goto IL_01ec;
			case 9:
				flag2 = null;
				num2 = 13;
				continue;
			case 4:
				if (!forFilter)
				{
					if (boolSettings != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 8;
				}
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				if (!propertyMetadata.Nullable)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 14:
				if (propertyMetadata == null)
				{
					num2 = 2;
					continue;
				}
				goto case 10;
			case 8:
				flag2 = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				{
					flag = boolSettings.BoolDefaultValue;
					goto IL_01ec;
				}
				IL_01ec:
				flag3 = flag;
				num2 = 14;
				continue;
			}
			break;
		}
		return new PropertyValueContainer<bool>((byte)value != 0);
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		int num = 3;
		int num2 = num;
		BoolSettings boolSettings = default(BoolSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return boolSettings;
			default:
				boolSettings.BoolDefaultValue = null;
				num2 = 4;
				break;
			case 3:
				boolSettings = (BoolSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 2;
				break;
			case 4:
				UbKxado9NG2bmdDRNcb2(boolSettings, BoolDisplayType.RadioButtons);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (boolSettings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
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
		return (IComparer)vejQ1lo93RGGsbqEehEM(sourceType, propertyFunc, order);
	}

	public override bool IsSupportSort()
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Boolean);
	}

	protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0057, IL_0066, IL_00d4
		int num = 2;
		bool? boolDefaultValue = default(bool?);
		BoolSettings boolSettings = default(BoolSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 4:
					if (boolDefaultValue.HasValue)
					{
						boolDefaultValue = boolSettings.BoolDefaultValue;
						num2 = 6;
						continue;
					}
					goto end_IL_0012;
				default:
					boolDefaultValue = boolSettings.BoolDefaultValue;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					boolSettings = propertyMetadata.Settings as BoolSettings;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
				case 5:
					num3 = 0;
					break;
				case 1:
					if (boolSettings == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 6:
					num3 = (boolDefaultValue.Value ? 1 : 0);
					break;
				}
				return (byte)num3 != 0;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public BoolDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oCZUfCo9pMrVJyoWFw2h();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static BoolDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				oCZUfCo9pMrVJyoWFw2h();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)kRTcB8o9PBjqwRuLQwqP(-2112703338 ^ -2112868514));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool WWiPcko9OmMaLi0NVOxm()
	{
		return IMuEvxo9n7j3Sqcfdvwc == null;
	}

	internal static BoolDescriptor kyWRhco92oAg9aKNF14a()
	{
		return IMuEvxo9n7j3Sqcfdvwc;
	}

	internal static object DDRADMo9elglbNDDub7G(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object kRTcB8o9PBjqwRuLQwqP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void olVilKo913PQyAoAI74k(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void UbKxado9NG2bmdDRNcb2(object P_0, BoolDisplayType value)
	{
		((BoolSettings)P_0).DisplayType = value;
	}

	internal static object vejQ1lo93RGGsbqEehEM(Type sourceType, object P_1, ListSortDirection order)
	{
		return ComparerHelper.Create(sourceType, (LambdaExpression)P_1, order);
	}

	internal static void oCZUfCo9pMrVJyoWFw2h()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

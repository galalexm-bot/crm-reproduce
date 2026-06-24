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

public class Int32Descriptor : CLRTypeDescriptor<int, Int32Settings>
{
	public const string UID_S = "{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	private static Int32Descriptor Erwk8Aoroa9SgCqil4jj;

	public override Guid Uid => UID;

	public override string Name => (string)GgDKZWorEN8mjqCKWqAF(M8vfw6orGKEGl3fosob7(0x57A5235E ^ 0x57A78218));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override bool UseForId => true;

	public override bool AutoIncrementSupported => true;

	public override bool IsAvailibleEditPropertyInTable => true;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			while (true)
			{
				switch (num2)
				{
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					fullTextPropertyDescriptor = (propertyDescriptor = new Int32PropertyDescriptor(this));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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
		//Discarded unreachable code: IL_005d, IL_006c, IL_00eb, IL_0181, IL_0194, IL_01a3
		int num = 14;
		int num2 = num;
		int? defaultValue = default(int?);
		Int32Settings int32Settings = default(Int32Settings);
		while (true)
		{
			switch (num2)
			{
			case 10:
				return true;
			case 1:
				if (propertyMetadata != null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 11;
			case 9:
				if (!defaultValue.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 5;
			case 5:
				defaultValue = int32Settings.DefaultValue;
				num2 = 3;
				break;
			case 8:
				return true;
			default:
				defaultValue = int32Settings.DefaultValue;
				num2 = 9;
				break;
			case 11:
				return true;
			case 7:
				if (!pS7GT6orQ7CMgGpDtVxs(propertyMetadata))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 2;
			case 14:
				if (val != null)
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 10;
			case 13:
				if (!yel72korfhyGiRn13AiQ(this, propertyMetadata, val))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 10;
			case 2:
				return false;
			case 6:
				int32Settings = (Int32Settings)hD615forCyZOsCtV2qZN(propertyMetadata);
				num2 = 12;
				break;
			case 3:
				return defaultValue.Equals(val);
			case 4:
				return false;
			case 12:
				if (int32Settings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_00bd
		int num = 7;
		Int32Settings int32Settings = default(Int32Settings);
		int? defaultValue = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return null;
				case 2:
					if (int32Settings == null)
					{
						num = 4;
						break;
					}
					goto case 3;
				case 7:
					q8S5dGorv6VPkOvfCHZU(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3DA62C));
					num2 = 6;
					continue;
				case 4:
				case 5:
					return null;
				default:
					if (defaultValue.HasValue)
					{
						return int32Settings.DefaultValue.CreateSyntaxNode();
					}
					num = 5;
					break;
				case 6:
					if (!forFilter)
					{
						int32Settings = (Int32Settings)hD615forCyZOsCtV2qZN(propertyMetadata);
						num2 = 2;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					defaultValue = int32Settings.DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_009b, IL_010d, IL_0118, IL_0122, IL_0187
		int num = 8;
		int? num3 = default(int?);
		int? num5 = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int? num4;
				int value;
				switch (num2)
				{
				case 13:
					if (propertyMetadata == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 4:
					num3 = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (num3.HasValue)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				case 11:
					if (!propertyMetadata.Nullable)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 12:
					goto end_IL_0012;
				default:
					num4 = num3;
					goto IL_01be;
				case 10:
					value = 0;
					break;
				case 6:
					return new PropertyValueContainer<int?>(num5);
				case 1:
				case 3:
					num3 = num5;
					num2 = 5;
					continue;
				case 7:
				{
					if (forFilter)
					{
						num2 = 4;
						continue;
					}
					Int32Settings obj = (Int32Settings)hD615forCyZOsCtV2qZN(propertyMetadata);
					if (obj == null)
					{
						num2 = 12;
						continue;
					}
					num4 = obj.DefaultValue;
					goto IL_01be;
				}
				case 8:
					Contract.ArgumentNotNull(propertyMetadata, (string)M8vfw6orGKEGl3fosob7(0x1637C429 ^ 0x16378D7B));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					num4 = num3;
					goto IL_01be;
				case 9:
					{
						value = num3.GetValueOrDefault();
						break;
					}
					IL_01be:
					num5 = num4;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 13;
					}
					continue;
				}
				return new PropertyValueContainer<int>(value);
				continue;
				end_IL_0012:
				break;
			}
			num3 = null;
			num = 2;
		}
	}

	public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_006f
		int num = 3;
		int num2 = num;
		Int32Settings int32Settings = default(Int32Settings);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				if (!int32Settings.RangeInFilter)
				{
					num2 = 5;
					continue;
				}
				goto IL_00ab;
			case 4:
				obj = null;
				break;
			case 3:
				if (propertyMetadata != null)
				{
					num2 = 2;
					continue;
				}
				goto case 4;
			default:
				if (int32Settings != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_00ab;
			case 5:
				return UID;
			case 2:
				{
					obj = (Int32Settings)hD615forCyZOsCtV2qZN(propertyMetadata);
					break;
				}
				IL_00ab:
				return Int32RangeDescriptor.UID;
			}
			int32Settings = (Int32Settings)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num2 = 0;
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		int num = 2;
		Int32Settings int32Settings = default(Int32Settings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto end_IL_0012;
				case 1:
					if (int32Settings != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					int32Settings = (Int32Settings)base.CreateSettingsForFilterProperty(propertyMetadata);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				}
				return int32Settings;
				continue;
				end_IL_0012:
				break;
			}
			int32Settings.DefaultValue = null;
			num = 3;
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
		return (IComparer)XdY6J3or8loxZrrXBbYI(sourceType, propertyFunc, order);
	}

	public override bool IsSupportSort()
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Int32);
	}

	protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0077
		int num = 5;
		Int32Settings int32Settings = default(Int32Settings);
		int? defaultValue = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 5:
					int32Settings = propertyMetadata.Settings as Int32Settings;
					num2 = 4;
					continue;
				default:
					if (!defaultValue.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						defaultValue = int32Settings.DefaultValue;
						num2 = 2;
					}
					continue;
				case 1:
					num3 = 0;
					break;
				case 4:
					if (int32Settings != null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 3:
					defaultValue = int32Settings.DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num3 = defaultValue.Value;
					break;
				}
				return num3;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public Int32Descriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jI0T0MorZGZxxZpm24mL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Int32Descriptor()
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)M8vfw6orGKEGl3fosob7(-3333094 ^ -3177106));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object M8vfw6orGKEGl3fosob7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GgDKZWorEN8mjqCKWqAF(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool DJk5woorbQpCBupEBSKF()
	{
		return Erwk8Aoroa9SgCqil4jj == null;
	}

	internal static Int32Descriptor Fx9y03orhrvorgQ6p2Sp()
	{
		return Erwk8Aoroa9SgCqil4jj;
	}

	internal static bool yel72korfhyGiRn13AiQ(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static bool pS7GT6orQ7CMgGpDtVxs(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static object hD615forCyZOsCtV2qZN(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static void q8S5dGorv6VPkOvfCHZU(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object XdY6J3or8loxZrrXBbYI(Type sourceType, object P_1, ListSortDirection order)
	{
		return ComparerHelper.Create(sourceType, (LambdaExpression)P_1, order);
	}

	internal static void jI0T0MorZGZxxZpm24mL()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

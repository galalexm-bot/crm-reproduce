using System;
using System.Data;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 1000)]
public class MoneyDescriptor : CLRTypeDescriptor<Money, MoneySettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{38934BC2-601F-45DA-851F-1BBF1054D85E}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static MoneyDescriptor dKM5pEo7qtHYhlUXscia;

	public override Guid Uid => UID;

	public override string Name => SR.T((string)S9dJrJo7kTSwiPPNwc29(0x571EA399 ^ 0x571C24FB));

	public override bool CanBeNullable => false;

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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					fullTextPropertyDescriptor = (propertyDescriptor = new MoneyPropertyDescriptor(this));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 2;
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

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				mapper.Type<MoneyNHType>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
				mHnImio7TwiIVECbowWH(this, mapper, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_006a, IL_009e, IL_00ad
		int num = 5;
		int num2 = num;
		Money money = default(Money);
		while (true)
		{
			switch (num2)
			{
			default:
				return !money.HasValue;
			case 3:
				return false;
			case 4:
				return true;
			case 2:
				money = (Money)val;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (!(val is Money))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 5:
				if (val == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_00c2, IL_00d1, IL_00f2, IL_0101, IL_0111, IL_0120, IL_0181, IL_018b, IL_019e, IL_01ad, IL_01fd
		int num = 12;
		double? defaultValue = default(double?);
		MoneySettings moneySettings = default(MoneySettings);
		double num4 = default(double);
		Money money = default(Money);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double num3;
				switch (num2)
				{
				case 9:
					defaultValue = moneySettings.DefaultValue;
					num = 17;
					break;
				case 17:
					return defaultValue.Equals(num4);
				case 14:
					if (moneySettings != null)
					{
						num2 = 6;
						continue;
					}
					goto case 8;
				case 12:
					if (val == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 3;
				default:
					return false;
				case 10:
					moneySettings = (MoneySettings)propertyMetadata.Settings;
					num2 = 14;
					continue;
				case 13:
					money = (Money)val;
					num2 = 15;
					continue;
				case 4:
					num3 = (double)val;
					goto IL_02b8;
				case 11:
				case 16:
					return true;
				case 1:
					if (propertyMetadata != null)
					{
						num2 = 19;
						continue;
					}
					goto case 5;
				case 8:
					return true;
				case 6:
					if (UppvZgo7eGAwUy8L1DbI(val.GetType(), U6RoK4o72b5tvvJyKXhF(typeof(Money).TypeHandle)))
					{
						num2 = 13;
						continue;
					}
					goto case 2;
				case 20:
					num3 = 0.0;
					goto IL_02b8;
				case 7:
					if (!defaultValue.HasValue)
					{
						return false;
					}
					num = 9;
					break;
				case 3:
					if (!S04OqZo7n3xwg0JObree(this, propertyMetadata, val))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 18:
					defaultValue = moneySettings.DefaultValue;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					return true;
				case 19:
					if (!H4s84xo7OOXSCI6oeYOV(propertyMetadata))
					{
						num2 = 10;
						continue;
					}
					goto default;
				case 2:
					if (UppvZgo7eGAwUy8L1DbI(val.GetType(), U6RoK4o72b5tvvJyKXhF(typeof(double).TypeHandle)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 20;
				case 15:
					{
						num3 = money.Value;
						goto IL_02b8;
					}
					IL_02b8:
					num4 = num3;
					num2 = 18;
					continue;
				}
				break;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		int num = 3;
		int num2 = num;
		double? defaultValue = default(double?);
		MoneySettings moneySettings = default(MoneySettings);
		while (true)
		{
			switch (num2)
			{
			case 5:
				defaultValue = moneySettings.DefaultValue;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (forFilter)
				{
					num2 = 4;
					continue;
				}
				moneySettings = (MoneySettings)S9F2cto71VlssZrjvmIM(propertyMetadata);
				num2 = 6;
				continue;
			case 4:
				return null;
			case 6:
				if (moneySettings != null)
				{
					num2 = 5;
					continue;
				}
				goto case 1;
			case 1:
				return null;
			case 3:
				sJbmRKo7PUsgoUiHeEZO(propertyMetadata, S9dJrJo7kTSwiPPNwc29(-97972138 ^ -97953532));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			if (!defaultValue.HasValue)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return (ISyntaxNode)A7GPtoo7NM0WASIjweci(moneySettings.DefaultValue);
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0067, IL_00ed
		int num = 3;
		int num2 = num;
		double? num3 = default(double?);
		double? num5 = default(double?);
		Money value;
		Money money = default(Money);
		while (true)
		{
			double? num4;
			switch (num2)
			{
			case 3:
				sJbmRKo7PUsgoUiHeEZO(propertyMetadata, S9dJrJo7kTSwiPPNwc29(-1978478350 ^ -1978492512));
				num2 = 2;
				continue;
			default:
				num4 = num3;
				goto IL_013c;
			case 8:
				num3 = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
			{
				if (forFilter)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 8;
					}
					continue;
				}
				MoneySettings obj = (MoneySettings)S9F2cto71VlssZrjvmIM(propertyMetadata);
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					continue;
				}
				num4 = obj.DefaultValue;
				goto IL_013c;
			}
			case 5:
				if (!num5.HasValue)
				{
					num2 = 4;
					continue;
				}
				value = MpZPqRo73VKa9Kkqg9rj(num5.Value);
				break;
			case 1:
				num3 = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 6;
				}
				continue;
			case 7:
				value = money;
				break;
			case 4:
				money = default(Money);
				num2 = 7;
				continue;
			case 6:
				{
					num4 = num3;
					goto IL_013c;
				}
				IL_013c:
				num5 = num4;
				num2 = 5;
				continue;
			}
			break;
		}
		return new PropertyValueContainer<Money>(value);
	}

	public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_00bc
		int num = 4;
		int num2 = num;
		MoneySettings moneySettings = default(MoneySettings);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return UID;
			case 1:
				return MoneyRangeDescriptor.UID;
			case 4:
				if (propertyMetadata == null)
				{
					num2 = 3;
					continue;
				}
				obj = (MoneySettings)propertyMetadata.Settings;
				break;
			case 2:
				if (!lPhPVao7p8OuSCCJ58gT(moneySettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 5:
				if (moneySettings == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 3:
				obj = null;
				break;
			}
			moneySettings = (MoneySettings)obj;
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
			{
				num2 = 2;
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_008b, IL_009a
		int num = 1;
		int num2 = num;
		MoneySettings moneySettings = default(MoneySettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				moneySettings = (MoneySettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				moneySettings.DefaultValue = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
			case 4:
				return moneySettings;
			default:
				if (moneySettings == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
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

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_00b0, IL_00bf, IL_0126, IL_0135, IL_015c
		int num = 8;
		Money money = default(Money);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103FA027));
				case 4:
					if (criteria == null)
					{
						num2 = 10;
						continue;
					}
					break;
				case 2:
					if (!(value is Money))
					{
						num2 = 12;
						continue;
					}
					money = (Money)value;
					num2 = 6;
					continue;
				case 10:
					return;
				case 6:
					if (!money.HasValue)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 8:
					if (metadata != null)
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 5:
					return;
				case 11:
					return;
				case 1:
					throw new ArgumentNullException((string)S9dJrJo7kTSwiPPNwc29(-475857671 ^ -475875897));
				case 7:
					if (propertyMetadata != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 3:
					base.ApplyFilterValue(criteria, metadata, propertyMetadata, value, alias);
					num2 = 5;
					continue;
				case 12:
					return;
				case 9:
					break;
				}
				if (value == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Double);
	}

	protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00d6
		int num = 3;
		int num2 = num;
		MoneySettings moneySettings = default(MoneySettings);
		double? defaultValue = default(double?);
		double num3;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (moneySettings != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 5;
			case 1:
				defaultValue = moneySettings.DefaultValue;
				num2 = 4;
				continue;
			case 3:
				moneySettings = S9F2cto71VlssZrjvmIM(propertyMetadata) as MoneySettings;
				num2 = 2;
				continue;
			case 4:
				if (defaultValue.HasValue)
				{
					defaultValue = moneySettings.DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 5;
					}
				}
				continue;
			case 5:
				num3 = 0.0;
				break;
			default:
				num3 = defaultValue.Value;
				break;
			}
			break;
		}
		return num3;
	}

	public MoneyDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uKoRVZo7aWbIXkqnx50B();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MoneyDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				uKoRVZo7aWbIXkqnx50B();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)S9dJrJo7kTSwiPPNwc29(-957824448 ^ -957725390));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void mHnImio7TwiIVECbowWH(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<Money>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool v3XM5Eo7KDtwirGaSMOJ()
	{
		return dKM5pEo7qtHYhlUXscia == null;
	}

	internal static MoneyDescriptor uBC9NRo7X25GEErHi68v()
	{
		return dKM5pEo7qtHYhlUXscia;
	}

	internal static object S9dJrJo7kTSwiPPNwc29(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool S04OqZo7n3xwg0JObree(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static bool H4s84xo7OOXSCI6oeYOV(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type U6RoK4o72b5tvvJyKXhF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool UppvZgo7eGAwUy8L1DbI(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void sJbmRKo7PUsgoUiHeEZO(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object S9F2cto71VlssZrjvmIM(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object A7GPtoo7NM0WASIjweci(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static Money MpZPqRo73VKa9Kkqg9rj(double d)
	{
		return d;
	}

	internal static bool lPhPVao7p8OuSCCJ58gT(object P_0)
	{
		return ((MoneySettings)P_0).RangeInFilter;
	}

	internal static void uKoRVZo7aWbIXkqnx50B()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

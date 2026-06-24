using System;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 1100)]
public class UrlDescriptor : CLRTypeDescriptor<Uri, UrlSettings>, IMappingTypeDescriptor, IConvertableTypeDescriptor
{
	public const string UID_S = "{66A64042-0490-4AD6-B804-4D08FA6C85F0}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static UrlDescriptor DfnwEnoHsOsKOs1aPqGw;

	public override Guid Uid => UID;

	public override string Name => (string)vQpgapoAWEZQ9vhRhdBs(zHbsKxoABZOCRb7qWuYd(0x53CB464B ^ 0x53CBD6E7));

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
					fullTextPropertyDescriptor = (propertyDescriptor = new UrlPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				YxxRILoAFSlgs9HmBa7y(this, mapper, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			default:
				mapper.Type<UriNHType>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0071, IL_0080
		int num = 5;
		int num2 = num;
		UrlSettings urlSettings = default(UrlSettings);
		while (true)
		{
			switch (num2)
			{
			case 4:
				urlSettings = (UrlSettings)propertyMetadata.Settings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (urlSettings == null)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 1:
				if (hatmrOoAhWV917M0u3Zq(xnXXF8oAb4rk3UsiAAVD(urlSettings)))
				{
					num2 = 2;
					break;
				}
				return ((ISyntaxNode)QFsYn6oAEaVe2A80eUaD(eqMdtJoAG7k9HnUtoy44(typeof(Uri).TypeHandle))).ObjectCreationExpression((ISyntaxNode)ziAaeToAf3aTKmwdovFj(xnXXF8oAb4rk3UsiAAVD(urlSettings)), (ISyntaxNode)ziAaeToAf3aTKmwdovFj(UriKind.RelativeOrAbsolute));
			case 2:
			case 3:
				return null;
			case 5:
				Bqx4XDoAooNNTS4TOHoZ(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561060810));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0036, IL_00ad
		int num = 2;
		UrlSettings urlSettings = default(UrlSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object value;
				switch (num2)
				{
				case 3:
					obj = null;
					goto IL_00b9;
				case 1:
					urlSettings = (UrlSettings)hSAlTsoAQN6XrB8Ru1xK(propertyMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					Contract.ArgumentNotNull(propertyMetadata, (string)zHbsKxoABZOCRb7qWuYd(0x4EA5403C ^ 0x4EA5096E));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (urlSettings == null)
					{
						goto end_IL_0012;
					}
					obj = urlSettings.DefaultValue;
					goto IL_00b9;
				case 4:
					{
						value = null;
						break;
					}
					IL_00b9:
					if (hatmrOoAhWV917M0u3Zq(obj))
					{
						num2 = 4;
						continue;
					}
					value = new Uri(urlSettings.DefaultValue, UriKind.RelativeOrAbsolute);
					break;
				}
				return new PropertyValueContainer<Uri>((Uri)value);
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00f3, IL_0138, IL_0147
		int num = 8;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (propertyMetadata == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 2;
					}
					continue;
				}
				if (value == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 1;
			case 4:
				if (hatmrOoAhWV917M0u3Zq(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 2;
					}
					continue;
				}
				return new Uri(text, UriKind.RelativeOrAbsolute);
			case 2:
				return null;
			default:
				return null;
			case 1:
				if (value is Uri)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				if (!(value.GetType() == eqMdtJoAG7k9HnUtoy44(typeof(string).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 7:
				throw new ArgumentNullException((string)zHbsKxoABZOCRb7qWuYd(-1886646897 ^ -1886632739));
			case 3:
			case 6:
				return value;
			case 5:
				break;
			}
			text = (string)value;
			num2 = 4;
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		UrlSettings urlSettings = default(UrlSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (urlSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				urlSettings = (UrlSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 3;
				break;
			case 2:
				u3GSycoACnBatY0oEoBM(urlSettings, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return urlSettings;
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
		return new ColumnType(DbType.String, int.MaxValue);
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		int num = 2;
		int num2 = num;
		MatchMode anywhere = default(MatchMode);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 2:
				if (value == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (!Nat3XxoAZsAocmWEkNyL(BQmhgXoA8KeEls4C2qFY(mQjuy4oAvjdy3irRYpiH((Uri)value)), string.Empty))
				{
					anywhere = MatchMode.Anywhere;
					num2 = 5;
				}
				else
				{
					num2 = 4;
				}
				break;
			case 3:
				return;
			case 1:
				if (mQjuy4oAvjdy3irRYpiH((Uri)value) == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				criteria.Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike((string)(string.IsNullOrEmpty(alias) ? H2IyNKoAuS2mSXpEqXDP(propertyMetadata) : vbydbnoAIRamnedSPJvR(zHbsKxoABZOCRb7qWuYd(-1837662597 ^ -1837679495), alias, H2IyNKoAuS2mSXpEqXDP(propertyMetadata))), ((Uri)value).OriginalString, anywhere));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public UrlDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		E6aR5noAVOLArb5D6vTL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UrlDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)zHbsKxoABZOCRb7qWuYd(0x12441CA4 ^ 0x12469FE6));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				E6aR5noAVOLArb5D6vTL();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void YxxRILoAFSlgs9HmBa7y(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<Uri>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool dyAW8LoHcX5DWItJnwtU()
	{
		return DfnwEnoHsOsKOs1aPqGw == null;
	}

	internal static UrlDescriptor J5mJWJoHzWBtdp5uB93V()
	{
		return DfnwEnoHsOsKOs1aPqGw;
	}

	internal static object zHbsKxoABZOCRb7qWuYd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vQpgapoAWEZQ9vhRhdBs(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void Bqx4XDoAooNNTS4TOHoZ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object xnXXF8oAb4rk3UsiAAVD(object P_0)
	{
		return ((UrlSettings)P_0).DefaultValue;
	}

	internal static bool hatmrOoAhWV917M0u3Zq(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Type eqMdtJoAG7k9HnUtoy44(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object QFsYn6oAEaVe2A80eUaD(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object ziAaeToAf3aTKmwdovFj(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static object hSAlTsoAQN6XrB8Ru1xK(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static void u3GSycoACnBatY0oEoBM(object P_0, object P_1)
	{
		((UrlSettings)P_0).DefaultValue = (string)P_1;
	}

	internal static object mQjuy4oAvjdy3irRYpiH(object P_0)
	{
		return ((Uri)P_0).OriginalString;
	}

	internal static object BQmhgXoA8KeEls4C2qFY(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool Nat3XxoAZsAocmWEkNyL(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object H2IyNKoAuS2mSXpEqXDP(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object vbydbnoAIRamnedSPJvR(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void E6aR5noAVOLArb5D6vTL()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

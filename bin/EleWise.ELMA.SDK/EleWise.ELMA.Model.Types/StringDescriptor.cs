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
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public abstract class StringDescriptor<TSettings> : CLRTypeDescriptor<string, TSettings>, IMappingTypeDescriptor where TSettings : StringSettings
{
	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static object UICoF0o7balhZr6VEEjg;

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
					fullTextPropertyDescriptor = (propertyDescriptor = new StringPropertyDescriptor(this));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
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

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		StringSettings stringSettings = default(StringSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4C327B));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			default:
				Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD73D86));
				num2 = 3;
				break;
			case 2:
				base.ExtendSimplePropertyMapping(mapper, propertyMetadata);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				stringSettings = (StringSettings)propertyMetadata.Settings;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				Contract.CheckArgument(propertyMetadata.Settings is StringSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108143258));
				num2 = 4;
				break;
			case 6:
				mapper.Length((stringSettings.MaxValue > 0) ? stringSettings.MaxValue.Value : int.MaxValue);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_005d
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return true;
			case 1:
				if ((StringSettings)propertyMetadata.Settings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					break;
				}
				return string.IsNullOrEmpty((string)val);
			case 2:
				if (propertyMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				return true;
			}
		}
	}

	public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_006b, IL_008e
		int num = 5;
		StringSettings stringSettings = default(StringSettings);
		string value = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					return true;
				case 5:
					if (val != null)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 8:
					return true;
				default:
					stringSettings = (StringSettings)propertyMetadata.Settings;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (stringSettings == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 1;
						}
						break;
					}
					value = (string)val;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					return true;
				case 4:
					if (!IsEmpty(propertyMetadata, val))
					{
						if (propertyMetadata != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 8;
					}
					num2 = 9;
					break;
				case 3:
					return stringSettings.DefaultValue.Equals(value);
				case 6:
					return false;
				case 7:
					if (stringSettings.DefaultValue == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0084
		int num = 1;
		int num2 = num;
		StringSettings stringSettings = default(StringSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				return null;
			case 5:
				if (stringSettings == null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 3:
				if (!string.IsNullOrEmpty(stringSettings.DefaultValue))
				{
					return stringSettings.DefaultValue.CreateSyntaxNode();
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 2;
				}
				break;
			default:
				stringSettings = (StringSettings)propertyMetadata.Settings;
				num2 = 5;
				break;
			case 1:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876048387));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_003a, IL_0055
		int num = 2;
		int num2 = num;
		object value;
		StringSettings stringSettings = default(StringSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 4:
				value = null;
				break;
			default:
				if (stringSettings == null)
				{
					num2 = 4;
					continue;
				}
				goto case 5;
			case 5:
				if (string.IsNullOrEmpty(stringSettings.DefaultValue))
				{
					num2 = 3;
					continue;
				}
				value = stringSettings.DefaultValue;
				break;
			case 2:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951500620));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				stringSettings = (StringSettings)propertyMetadata.Settings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return new PropertyValueContainer<string>((string)value);
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_0098, IL_00b8, IL_00c7, IL_00d6, IL_019b, IL_01aa
		int num = 7;
		int num2 = num;
		int? maxValue = default(int?);
		StringSettings stringSettings = default(StringSettings);
		MatchMode matchMode = default(MatchMode);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				maxValue = stringSettings.MaxValue;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 9;
				}
				continue;
			case 18:
				matchMode = MatchMode.End;
				num2 = 20;
				continue;
			case 7:
				if (value != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 6;
					}
					continue;
				}
				return;
			case 5:
			{
				int length2 = text.Length;
				maxValue = stringSettings.MaxValue;
				if (length2 <= maxValue.Value - 2)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			}
			case 13:
			{
				int length3 = text.Length;
				maxValue = stringSettings.MaxValue;
				if (length3 > maxValue.Value)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
			case 9:
				if (maxValue.HasValue)
				{
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			case 16:
				text = (string)value;
				num2 = 15;
				continue;
			case 14:
			{
				int length = text.Length;
				maxValue = stringSettings.MaxValue;
				if (length == maxValue.Value - 1)
				{
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				goto case 13;
			}
			case 15:
				matchMode = MatchMode.Anywhere;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 4;
				}
				continue;
			case 10:
				if (maxValue.Value <= 0)
				{
					num2 = 2;
					continue;
				}
				goto case 5;
			case 19:
				maxValue = stringSettings.MaxValue;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 7;
				}
				continue;
			case 8:
				matchMode = MatchMode.Exact;
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 5;
				}
				continue;
			case 11:
				return;
			case 1:
				return;
			case 3:
			{
				int length4 = text.Length;
				maxValue = stringSettings.MaxValue;
				if (length4 == maxValue.Value)
				{
					num2 = 8;
					continue;
				}
				goto case 14;
			}
			case 6:
				if (!((string)value).Trim().Equals(string.Empty))
				{
					stringSettings = (StringSettings)propertyMetadata.Settings;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 12;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 12:
				throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x745D774), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A3E1DD), propertyMetadata.Name, text.Length));
			}
			criteria.Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike(string.IsNullOrEmpty(alias) ? propertyMetadata.Name : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29237407), alias, propertyMetadata.Name), (string)value, matchMode));
			num2 = 11;
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		int num = 3;
		int num2 = num;
		TSettings val = default(TSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				return val;
			case 3:
				val = (TSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				val.DefaultValue = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
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
		int num = 3;
		int num2 = num;
		StringSettings stringSettings = default(StringSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53CE5F1));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106361326));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Contract.CheckArgument(propertyMetadata.Settings is StringSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C51BD87));
				num2 = 4;
				break;
			case 4:
				stringSettings = (StringSettings)propertyMetadata.Settings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new ColumnType(DbType.String, (stringSettings != null && stringSettings.MaxValue > 0) ? stringSettings.MaxValue.Value : int.MaxValue);
			}
		}
	}

	protected StringDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool BLhWSGo7hKqoGYuHmJAv()
	{
		return UICoF0o7balhZr6VEEjg == null;
	}

	internal static object apM5olo7G4Yo6UeqbRSH()
	{
		return UICoF0o7balhZr6VEEjg;
	}
}
[Component(Order = 100)]
public class StringDescriptor : StringDescriptor<StringSettings>
{
	public const string UID_S = "{9B9AAC17-22BB-425C-AA93-9C02C5146965}";

	public static readonly Guid UID;

	internal static StringDescriptor KW8shXolsBwyeN7k8k5y;

	public override Guid Uid => UID;

	public override string Name => (string)GUo9inorB92GpdFGg5Qc(xwk4I1orFSnmuJw3m9Qu(-1088304168 ^ -1088186782));

	public override bool UseForId => true;

	public StringDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vpPnHVorWgZvDJ9eqFDr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static StringDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				vpPnHVorWgZvDJ9eqFDr();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)xwk4I1orFSnmuJw3m9Qu(0x20261A4F ^ 0x2024BAB9));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object xwk4I1orFSnmuJw3m9Qu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GUo9inorB92GpdFGg5Qc(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool Dpig5KolcsSHMNy20qJ7()
	{
		return KW8shXolsBwyeN7k8k5y == null;
	}

	internal static StringDescriptor BhE6p3olzMJPRDKj55ZB()
	{
		return KW8shXolsBwyeN7k8k5y;
	}

	internal static void vpPnHVorWgZvDJ9eqFDr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 700)]
public class RelativeDateTimeDescriptor : CLRTypeDescriptor<RelativeDateTime, DateTimeSettings>
{
	public const string UID_S = "{1B104510-6460-441A-B75E-F3B7E9115E72}";

	public static readonly Guid UID;

	private static RelativeDateTimeDescriptor uQGTCHoynxoCx5uE34dS;

	[XmlIgnore]
	public DateTimeRangeDescriptor DateTimeRangeDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CDateTimeRangeDescriptor_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
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
					_003CDateTimeRangeDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public BoolDescriptor BoolDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CBoolDescriptor_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
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
					_003CBoolDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool UseForEntity => false;

	public override Guid ParentUid => RangeTypesDescriptor.UID;

	public override Guid Uid => UID;

	public override string Name => (string)z3uOuooyPB8fs8C7XM4E(QQfnjVoyetf7YyqQHvqP(0x3A5D5EF ^ 0x3A741E7));

	public override bool CanBeNullable => false;

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object value)
	{
		//Discarded unreachable code: IL_0084
		int num = 3;
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					dateTime = ((RelativeDateTime)value).ToValue;
					num2 = 4;
					continue;
				case 2:
					return true;
				default:
					return true;
				case 6:
					if (!dateTime.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 7;
						}
						continue;
					}
					return false;
				case 4:
					return !dateTime.HasValue;
				case 5:
					return true;
				case 1:
					if (value != null)
					{
						dateTime = ((RelativeDateTime)value).FromValue;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 6;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 3:
					if (propertyMetadata == null)
					{
						break;
					}
					if ((DateTimeSettings)sCvAvXoy1BWDNLhrRac8(propertyMetadata) != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				}
				break;
			}
			num = 2;
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_00ef, IL_00fe
		int num = 1;
		int num2 = num;
		RelativeDateTime relativeDateTime = default(RelativeDateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if ((relativeDateTime = value as RelativeDateTime) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return new SerializableDictionary<string, object>
				{
					{
						(string)QQfnjVoyetf7YyqQHvqP(-1978478350 ^ -1978645310),
						BoolDescriptor.SerializeSimple(relativeDateTime.IsRelative)
					},
					{
						(string)QQfnjVoyetf7YyqQHvqP(-1638402543 ^ -1638571431),
						UQfXvIoyN9D3rwicJQ7p(relativeDateTime)
					},
					{
						(string)QQfnjVoyetf7YyqQHvqP(0x7247028A ^ 0x724596EE),
						mgGlRGoy3KRG5I8RMuc2(relativeDateTime)
					},
					{
						(string)QQfnjVoyetf7YyqQHvqP(0xE1229CF ^ 0xE10BDB3),
						DateTimeRangeDescriptor.SerializeSimple(relativeDateTime.DateTimeRange)
					}
				};
			default:
				return base.SerializeSimple(value, valueType, settings);
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0096, IL_014e, IL_015d, IL_016d, IL_017d, IL_0187, IL_01f7, IL_0280, IL_028a, IL_0299, IL_02ff, IL_030e
		int num = 21;
		string from = default(string);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		object value2 = default(object);
		string to = default(string);
		DateTimeRange dateTimeRange = default(DateTimeRange);
		object value5 = default(object);
		bool flag = default(bool);
		object value4 = default(object);
		object value3 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 2:
					from = null;
					num2 = 19;
					continue;
				case 21:
					KNgigVoypMeBUJGq8rAZ(deserializeToType, QQfnjVoyetf7YyqQHvqP(0x57A5235E ^ 0x57A56ADA));
					num2 = 20;
					continue;
				case 5:
				case 22:
					if (!dictionary.TryGetValue((string)QQfnjVoyetf7YyqQHvqP(-1751176224 ^ -1751269500), out value2))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 12;
				case 1:
				case 10:
					return new RelativeDateTime(from, to);
				case 25:
					dateTimeRange = DateTimeRangeDescriptor.DeserializeSimple(value5);
					num2 = 14;
					continue;
				case 24:
					obj = null;
					break;
				case 15:
					flag = BoolDescriptor.DeserializeSimple(value4);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (dictionary != null)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 14:
					return new RelativeDateTime(dateTimeRange.From, dateTimeRange.To);
				case 9:
					return base.DeserializeSimple(value, deserializeToType);
				default:
					if (!flag)
					{
						if (!dictionary.TryGetValue((string)QQfnjVoyetf7YyqQHvqP(-1852837372 ^ -1853004168), out value5))
						{
							return new RelativeDateTime();
						}
						num2 = 25;
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 2;
						}
					}
					continue;
				case 7:
					if (value3 != null)
					{
						num2 = 18;
						continue;
					}
					goto case 13;
				case 8:
					if (!dictionary.TryGetValue((string)QQfnjVoyetf7YyqQHvqP(0x638095EB ^ 0x638201DB), out value4))
					{
						num2 = 23;
						continue;
					}
					goto case 15;
				case 4:
					return null;
				case 3:
					flag = false;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 8;
					}
					continue;
				case 13:
					obj2 = null;
					goto IL_0372;
				case 16:
					if (!dictionary.TryGetValue((string)QQfnjVoyetf7YyqQHvqP(-210725949 ^ -210630773), out value3))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 7;
				case 19:
					to = null;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					if (value2 != null)
					{
						num2 = 6;
						continue;
					}
					goto case 24;
				case 17:
					dictionary = value as IDictionary<string, object>;
					num2 = 11;
					continue;
				case 20:
					if (!CegpdSoya45DgqLEEsvc(typeof(RelativeDateTime).TypeHandle).IsAssignableFrom(deserializeToType))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 17;
				case 18:
					obj2 = value3.ToString();
					goto IL_0372;
				case 6:
					{
						obj = value2.ToString();
						break;
					}
					IL_0372:
					from = (string)obj2;
					num2 = 5;
					continue;
				}
				to = (string)obj;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		int num = 6;
		ICriterion criterion = default(ICriterion);
		RelativeDateTime relativeDateTime = default(RelativeDateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					SiTfqeoy414Sdc0g0rt3(criteria, criterion);
					num2 = 2;
					continue;
				case 5:
					if (relativeDateTime == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					criterion = DateTimeRangeDescriptor.GetCriterion(PKMnxeoyD3tn6DUtUIMi(relativeDateTime), OQoeUtoytPEejRQOyJpj((DateTimeSettings)sCvAvXoy1BWDNLhrRac8(propertyMetadata)), alias, (string)nXGeUtoywC4pyyl3Z0JO(propertyMetadata));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return;
				case 6:
					break;
				case 3:
					return;
				default:
					base.ApplyFilterValue(criteria, metadata, propertyMetadata, value, alias);
					num2 = 3;
					continue;
				case 1:
					if (criterion == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			relativeDateTime = value as RelativeDateTime;
			num = 5;
		}
	}

	public static DateTimeRange GetDateTimeRange(RelativeDateTime value)
	{
		int num = 1;
		int num2 = num;
		DateTimeRange result = default(DateTimeRange);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
				result = default(DateTimeRange);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return result;
			default:
				return new DateTimeRange(value.FromValue, value.ToValue);
			}
		}
	}

	public static DateTimeRange GetDateTimeRange(string fromValue, string toValue)
	{
		return PKMnxeoyD3tn6DUtUIMi(new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = fromValue,
			RelativeTo = toValue
		});
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		throw new InvalidOperationException((string)z3uOuooyPB8fs8C7XM4E(QQfnjVoyetf7YyqQHvqP(0x7459E02 ^ 0x747E5D8)));
	}

	public RelativeDateTimeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RelativeDateTimeDescriptor()
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
				asaSM7oy6Yxh4kZPjxBu();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138253598));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool QYSZaNoyOdKRYDnKNNY2()
	{
		return uQGTCHoynxoCx5uE34dS == null;
	}

	internal static RelativeDateTimeDescriptor BdHDP2oy2M0EwDCrwL8u()
	{
		return uQGTCHoynxoCx5uE34dS;
	}

	internal static object QQfnjVoyetf7YyqQHvqP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object z3uOuooyPB8fs8C7XM4E(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object sCvAvXoy1BWDNLhrRac8(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object UQfXvIoyN9D3rwicJQ7p(object P_0)
	{
		return ((RelativeDateTime)P_0).RelativeFrom;
	}

	internal static object mgGlRGoy3KRG5I8RMuc2(object P_0)
	{
		return ((RelativeDateTime)P_0).RelativeTo;
	}

	internal static void KNgigVoypMeBUJGq8rAZ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type CegpdSoya45DgqLEEsvc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static DateTimeRange PKMnxeoyD3tn6DUtUIMi(object P_0)
	{
		return GetDateTimeRange((RelativeDateTime)P_0);
	}

	internal static bool OQoeUtoytPEejRQOyJpj(object P_0)
	{
		return ((DateTimeSettings)P_0).ShowTime;
	}

	internal static object nXGeUtoywC4pyyl3Z0JO(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object SiTfqeoy414Sdc0g0rt3(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void asaSM7oy6Yxh4kZPjxBu()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

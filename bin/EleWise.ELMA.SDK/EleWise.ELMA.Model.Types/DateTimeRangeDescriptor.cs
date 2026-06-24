using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class DateTimeRangeDescriptor : RangeTypeDescriptor<DateTimeRange, DateTime, DateTimeSettings>
{
	public const string UID_S = "{6FBBCA7C-A693-4791-902C-30B5984671A2}";

	public static readonly Guid UID;

	private static DateTimeRangeDescriptor WJPZW8oJAFrWrHg3scXb;

	[XmlIgnore]
	public DateTimeDescriptor DateTimeDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CDateTimeDescriptor_003Ek__BackingField;
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
					_003CDateTimeDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override Guid Uid => UID;

	public override string Name => (string)p4db5AoJmNrv5nbuixst(IcVlbAoJ0aCB6DmgdLJS(-1870892489 ^ -1870731133));

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_009e, IL_00ad, IL_0138, IL_0147
		int num = 3;
		int num2 = num;
		DateTime? dateTime = default(DateTime?);
		DateTimeRange dateTimeRange = default(DateTimeRange);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (!(dateTime.Value == DateTime.MinValue))
				{
					num2 = 11;
					break;
				}
				goto case 4;
			case 1:
				if (dateTime.HasValue)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 4:
				return true;
			default:
				return false;
			case 8:
				dateTime = dateTimeRange.To;
				num2 = 6;
				break;
			case 5:
				if (!stZk3HoJyHmKgh6TeUvJ(dateTime.Value, DateTime.MinValue))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 9:
				dateTime = dateTimeRange.To;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				dateTimeRange = (DateTimeRange)val;
				num2 = 2;
				break;
			case 7:
				if (dateTime.HasValue)
				{
					num2 = 10;
					break;
				}
				goto case 9;
			case 10:
				dateTime = dateTimeRange.From;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				dateTime = dateTimeRange.From;
				num2 = 7;
				break;
			}
		}
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		int num = 4;
		int num2 = num;
		ICriterion val = default(ICriterion);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (val != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 5:
				return;
			case 2:
				WCcnSZoJrnTL5dvhAxxL(criteria, val);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				UOAiZaoJMKDxNuPFrdhN(this, criteria, metadata, propertyMetadata, value, alias);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (value is DateTimeRange)
				{
					val = (ICriterion)MqtCbtoJlqLDARde05RC((DateTimeRange)value, HRwV0OoJ9AgwUhhgiKNx((DateTimeSettings)aHRJYXoJJXNC5qZnbuEb(propertyMetadata)), alias, vq2uDdoJdnr08EAOOdNm(propertyMetadata));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 7;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		object obj = default(object);
		SerializableDictionary<string, object> serializableDictionary = default(SerializableDictionary<string, object>);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					dateTimeRange = (DateTimeRange)obj;
					num = 10;
					break;
				case 2:
				{
					SerializableDictionary<string, object> serializableDictionary2 = serializableDictionary;
					string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EE70FE);
					DateTimeDescriptor dateTimeDescriptor = DateTimeDescriptor;
					dateTime = dateTimeRange.From;
					serializableDictionary2.Add(key, dateTimeDescriptor.SerializeSimple(dateTime.Value));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 1:
					return serializableDictionary;
				case 10:
					serializableDictionary = new SerializableDictionary<string, object>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					dateTime = dateTimeRange.From;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
				case 9:
					dateTime = dateTimeRange.To;
					num2 = 8;
					continue;
				case 4:
				{
					SerializableDictionary<string, object> serializableDictionary3 = serializableDictionary;
					string key2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124660F6);
					DateTimeDescriptor dateTimeDescriptor2 = DateTimeDescriptor;
					dateTime = dateTimeRange.To;
					serializableDictionary3.Add(key2, dateTimeDescriptor2.SerializeSimple(dateTime.Value));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 7:
					if (!((obj = value) is DateTimeRange))
					{
						return sfVy3RoJgEP58RDujXXJ(this, value, valueType, settings);
					}
					num = 6;
					break;
				case 5:
					if (!dateTime.HasValue)
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 8:
					if (dateTime.HasValue)
					{
						num = 4;
						break;
					}
					goto case 1;
				}
				break;
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0118, IL_0127
		int num = 6;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		object value2 = default(object);
		object value3 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (nlJD4boJjqiFO5aTg4sp(TypeOf<DateTimeRange>.Raw, deserializeToType))
					{
						num2 = 10;
						continue;
					}
					return C8CcOWoJYHDOY3euCxBk(this, value, deserializeToType);
				case 2:
					return dateTimeRange;
				case 9:
					if (dictionary != null)
					{
						if (dictionary.TryGetValue((string)IcVlbAoJ0aCB6DmgdLJS(-309639236 ^ -309773318), out value2))
						{
							num2 = 3;
							continue;
						}
						goto case 4;
					}
					num2 = 2;
					continue;
				case 4:
					if (!dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398549746), out value3))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 10:
					dateTimeRange = default(DateTimeRange);
					num2 = 8;
					continue;
				case 6:
					pOyh0ooJ5jBDBeka5axU(deserializeToType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A56ADA));
					num2 = 5;
					continue;
				default:
					return dateTimeRange;
				case 8:
					dictionary = value as IDictionary<string, object>;
					num = 9;
					break;
				case 3:
					dateTimeRange.From = ((value2 == null) ? null : new DateTime?(DateTimeDescriptor.DeserializeSimple(value2)));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					dateTimeRange.To = ((value3 == null) ? null : new DateTime?(DateTimeDescriptor.DeserializeSimple(value3)));
					num = 7;
					break;
				}
				break;
			}
		}
	}

	public static ICriterion GetCriterion(DateTimeRange dateTimeRange, bool showTime, string alias, string propName)
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_0101, IL_010b, IL_011a, IL_015e, IL_0168, IL_0177, IL_01bd, IL_0226, IL_0230, IL_023f, IL_024e
		int num = 15;
		int num2 = num;
		DateTime? dateTime = default(DateTime?);
		bool less = default(bool);
		string text = default(string);
		SimpleExpression val2 = default(SimpleExpression);
		SimpleExpression val = default(SimpleExpression);
		SimpleExpression obj;
		while (true)
		{
			object obj4;
			object obj2;
			object obj3;
			switch (num2)
			{
			case 14:
				if (NhidQHoJLJGeD0H9JJnI(alias))
				{
					num2 = 16;
					continue;
				}
				goto case 2;
			case 13:
				dateTime = dateTimeRange.From;
				num2 = 10;
				continue;
			case 15:
				dateTimeRange = NormalizeDates(dateTimeRange, showTime, out less);
				num2 = 14;
				continue;
			case 17:
				if (less)
				{
					num2 = 3;
					continue;
				}
				goto case 7;
			case 10:
				if (!dateTime.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj4 = stN7jnoJslB50v7Mi211(text, dateTimeRange.From);
				goto IL_0279;
			case 1:
				obj4 = null;
				goto IL_0279;
			case 4:
				if (dateTime.HasValue)
				{
					num2 = 17;
					continue;
				}
				goto case 6;
			default:
				return (ICriterion)x8JTfOoJzS1pkBnXRcFs(val2, val);
			case 9:
			case 12:
				obj = val2;
				if (obj == null)
				{
					num2 = 5;
					continue;
				}
				break;
			case 6:
				obj2 = null;
				goto IL_0298;
			case 8:
				dateTime = dateTimeRange.To;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 4;
				}
				continue;
			case 7:
				obj2 = Restrictions.Le(text, (object)dateTimeRange.To);
				goto IL_0298;
			case 18:
				if (val2 == null)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 11;
			case 11:
				if (val == null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto default;
			case 2:
				obj3 = c0MLJjoJUJlWNR4hylmy(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765834968), alias, propName);
				goto IL_025a;
			case 16:
				obj3 = propName;
				goto IL_025a;
			case 3:
				obj2 = ssAF0ioJc8M8wC0AtAt5(text, dateTimeRange.To);
				goto IL_0298;
			case 5:
				{
					obj = val;
					break;
				}
				IL_0279:
				val2 = (SimpleExpression)obj4;
				num2 = 8;
				continue;
				IL_025a:
				text = (string)obj3;
				num2 = 13;
				continue;
				IL_0298:
				val = (SimpleExpression)obj2;
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return (ICriterion)(object)obj;
	}

	public static DateTimeRange NormalizeDates(DateTimeRange dateTimeRange, bool showTime, out bool less)
	{
		//Discarded unreachable code: IL_011e, IL_012d, IL_02a3, IL_02b2, IL_02c2
		int num = 13;
		int num2 = num;
		DateTime? dateTime = default(DateTime?);
		DateTime dateTime2 = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				dateTime = dateTimeRange.To;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 4;
				}
				continue;
			case 8:
				if (YiJ8Jlo9BOb0xWCsf7g7(dateTime2.TimeOfDay, TimeSpan.Zero))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 9:
				if (!IWoWRYo9W9ZXPac5XUTB(dateTime.Value))
				{
					num2 = 17;
					continue;
				}
				goto case 18;
			case 10:
				if (!showTime)
				{
					num2 = 7;
					continue;
				}
				goto case 19;
			case 11:
				if (!l37LI2o9Fsxi0rG34fSH(dateTime.Value))
				{
					num2 = 3;
					continue;
				}
				goto default;
			case 14:
				if (showTime)
				{
					num2 = 15;
					continue;
				}
				goto case 2;
			case 18:
				return GetRangeForCriteria(dateTimeRange.From, dateTimeRange.To);
			case 20:
				less = true;
				num2 = 18;
				continue;
			case 19:
				dateTime = dateTimeRange.From;
				num2 = 11;
				continue;
			case 1:
				if (!dateTime.HasValue)
				{
					num2 = 16;
					continue;
				}
				goto case 10;
			case 4:
				if (dateTime.HasValue)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 14;
					}
					continue;
				}
				goto case 18;
			case 5:
				dateTime2 = dateTime.Value;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
			case 17:
				dateTime = dateTimeRange.To;
				dateTime2 = dateTime.Value.Date;
				dateTimeRange.To = dateTime2.AddDays(1.0);
				num2 = 20;
				continue;
			case 3:
			case 7:
				dateTime = dateTimeRange.From;
				dateTime2 = dateTime.Value;
				dateTimeRange.From = dateTime2.Date;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				continue;
			case 12:
				dateTime = dateTimeRange.From;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 1;
				}
				continue;
			case 13:
				less = false;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 12;
				}
				continue;
			case 15:
				dateTime = dateTimeRange.To;
				num2 = 5;
				continue;
			case 6:
				break;
			}
			dateTime = dateTimeRange.To;
			num2 = 9;
		}
	}

	public static DateTimeRange GetRangeForCriteria(DateTime? dateTimeFrom, DateTime? dateTimeTo)
	{
		DateTimeRange result = new DateTimeRange((dateTimeFrom == DateTime.MinValue) ? null : dateTimeFrom, (dateTimeTo == DateTime.MaxValue) ? null : dateTimeTo);
		ITransformationProvider service = Locator.GetService<ITransformationProvider>();
		if (service != null)
		{
			DateTime? from = ((result.From < service.Dialect.MinDateTime) ? new DateTime?(service.Dialect.MinDateTime) : result.From);
			DateTime? to = ((result.To > service.Dialect.MaxDateTime) ? new DateTime?(service.Dialect.MaxDateTime) : result.To);
			result = new DateTimeRange(from, to);
		}
		return result;
	}

	public DateTimeRangeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HISL7To9o7OtcidkmtJl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DateTimeRangeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)IcVlbAoJ0aCB6DmgdLJS(-629844702 ^ -629682236));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				HISL7To9o7OtcidkmtJl();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool lWiVwxoJ7wH78fbCAQJS()
	{
		return WJPZW8oJAFrWrHg3scXb == null;
	}

	internal static DateTimeRangeDescriptor t6jSBaoJxEYHvJcRiaIf()
	{
		return WJPZW8oJAFrWrHg3scXb;
	}

	internal static object IcVlbAoJ0aCB6DmgdLJS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object p4db5AoJmNrv5nbuixst(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool stZk3HoJyHmKgh6TeUvJ(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static void UOAiZaoJMKDxNuPFrdhN(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		((RangeTypeDescriptor<DateTimeRange, DateTimeSettings>)P_0).ApplyFilterValue((ICriteria)P_1, (EntityMetadata)P_2, (EntityPropertyMetadata)P_3, P_4, (string)P_5);
	}

	internal static object aHRJYXoJJXNC5qZnbuEb(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool HRwV0OoJ9AgwUhhgiKNx(object P_0)
	{
		return ((DateTimeSettings)P_0).ShowTime;
	}

	internal static object vq2uDdoJdnr08EAOOdNm(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object MqtCbtoJlqLDARde05RC(DateTimeRange dateTimeRange, bool showTime, object P_2, object P_3)
	{
		return GetCriterion(dateTimeRange, showTime, (string)P_2, (string)P_3);
	}

	internal static object WCcnSZoJrnTL5dvhAxxL(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object sfVy3RoJgEP58RDujXXJ(object P_0, object P_1, Type P_2, object P_3)
	{
		return ((RangeTypeDescriptor<DateTimeRange, DateTime, DateTimeSettings>)P_0).SerializeSimple(P_1, P_2, (EntitySerializationSettings)P_3);
	}

	internal static void pOyh0ooJ5jBDBeka5axU(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool nlJD4boJjqiFO5aTg4sp(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object C8CcOWoJYHDOY3euCxBk(object P_0, object P_1, Type P_2)
	{
		return ((RangeTypeDescriptor<DateTimeRange, DateTime, DateTimeSettings>)P_0).DeserializeSimple(P_1, P_2);
	}

	internal static bool NhidQHoJLJGeD0H9JJnI(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object c0MLJjoJUJlWNR4hylmy(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object stN7jnoJslB50v7Mi211(object P_0, object P_1)
	{
		return Restrictions.Ge((string)P_0, P_1);
	}

	internal static object ssAF0ioJc8M8wC0AtAt5(object P_0, object P_1)
	{
		return Restrictions.Lt((string)P_0, P_1);
	}

	internal static object x8JTfOoJzS1pkBnXRcFs(object P_0, object P_1)
	{
		return Restrictions.And((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static bool l37LI2o9Fsxi0rG34fSH(DateTime dateTime)
	{
		return dateTime.IsStartDamperTime();
	}

	internal static bool YiJ8Jlo9BOb0xWCsf7g7(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static bool IWoWRYo9W9ZXPac5XUTB(DateTime dateTime)
	{
		return dateTime.IsEndDamperTime();
	}

	internal static void HISL7To9o7OtcidkmtJl()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

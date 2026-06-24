using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public abstract class RangeTypeDescriptor<T, SettingsT> : CLRTypeDescriptor<T, SettingsT>
{
	private static object jgYrJSo6u6n7lh0yXdsQ;

	public override bool UseForEntity => false;

	public override Guid ParentUid => RangeTypesDescriptor.UID;

	public override bool CanBeNullable => false;

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object value)
	{
		//Discarded unreachable code: IL_0039, IL_00a3, IL_00b2
		int num = 1;
		int num2 = num;
		object toValue = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return true;
			case 4:
			{
				object fromValue = GetFromValue((T)value);
				toValue = GetToValue((T)value);
				if (fromValue != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			}
			case 1:
				if (value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				return toValue == null;
			case 5:
				return false;
			default:
				if (!(value.GetType() != typeof(T)))
				{
					num2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_00a4
		int num = 8;
		int num2 = num;
		object toValue = default(object);
		object fromValue = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				toValue = GetToValue((T)value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				if (toValue == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 8:
				if (value != null)
				{
					num2 = 7;
					continue;
				}
				return;
			case 3:
				return;
			case 1:
				if (fromValue != null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 2;
			case 4:
				return;
			case 9:
				return;
			case 7:
				if (!(value.GetType() != typeof(T)))
				{
					fromValue = GetFromValue((T)value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 4;
				}
				continue;
			case 6:
				criteria.Add((ICriterion)(object)Restrictions.Ge(string.IsNullOrEmpty(alias) ? propertyMetadata.Name : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638419437), alias, propertyMetadata.Name), fromValue));
				num2 = 2;
				continue;
			case 5:
				break;
			}
			criteria.Add((ICriterion)(object)Restrictions.Le(string.IsNullOrEmpty(alias) ? propertyMetadata.Name : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A5615C), alias, propertyMetadata.Name), toValue));
			num2 = 9;
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398550394)));
	}

	protected abstract object GetFromValue(T value);

	protected abstract object GetToValue(T value);

	protected RangeTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ykRjOmo6ImCCNNHTUh1P()
	{
		return jgYrJSo6u6n7lh0yXdsQ == null;
	}

	internal static object kloI0co6VporhElaS0Ei()
	{
		return jgYrJSo6u6n7lh0yXdsQ;
	}
}
public abstract class RangeTypeDescriptor<T, TRangeProperty, TSettings> : RangeTypeDescriptor<T, TSettings> where T : IRange<TRangeProperty> where TRangeProperty : struct
{
	private static object y800nuo6SemAh1ZqQSsH;

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_017b, IL_018a
		int num = 11;
		object obj = default(object);
		object toValue = default(object);
		T value2 = default(T);
		Type raw = default(Type);
		object fromValue = default(object);
		SerializableDictionary<string, object> serializableDictionary = default(SerializableDictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					if ((obj = value) is T)
					{
						num2 = 10;
						continue;
					}
					return base.SerializeSimple(value, valueType, settings);
				case 6:
					toValue = GetToValue(value2);
					num = 3;
					break;
				case 9:
					raw = TypeOf<TRangeProperty>.Raw;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					fromValue = GetFromValue(value2);
					num2 = 6;
					continue;
				case 3:
					if (fromValue == null)
					{
						num2 = 2;
						continue;
					}
					goto case 7;
				case 2:
				case 5:
					if (toValue != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 7:
					serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195734189), base.SerializeSimple(fromValue, raw, null));
					num = 5;
					break;
				case 10:
					value2 = (T)obj;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D4E40), base.SerializeSimple(toValue, raw, null));
					num2 = 8;
					continue;
				case 8:
					return serializableDictionary;
				case 4:
					serializableDictionary = new SerializableDictionary<string, object>();
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0137, IL_0146, IL_0156, IL_0176, IL_021e, IL_022d
		int num = 13;
		T val = default(T);
		object value2 = default(object);
		Type raw = default(Type);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		object value3 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					val.From = (TRangeProperty?)base.DeserializeSimple(value2, raw);
					num2 = 3;
					continue;
				case 1:
					if (dictionary != null)
					{
						num2 = 10;
						continue;
					}
					goto case 7;
				case 7:
					return val;
				case 10:
					break;
				case 11:
					val.To = (TRangeProperty?)base.DeserializeSimple(value3, raw);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 2;
					}
					continue;
				case 13:
					Contract.ArgumentNotNull(deserializeToType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D9D0A));
					num2 = 12;
					continue;
				case 12:
					if (!(TypeOf<T>.Raw == deserializeToType))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto default;
				default:
					val = Activator.CreateInstance<T>();
					num2 = 9;
					continue;
				case 3:
				case 6:
					if (!dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426195605), out value3))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 11;
				case 2:
				case 4:
					return val;
				case 5:
					return base.DeserializeSimple(value, deserializeToType);
				case 14:
					if (!dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EE70FE), out value2))
					{
						num2 = 6;
						continue;
					}
					goto case 8;
				case 9:
					dictionary = value as IDictionary<string, object>;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			raw = TypeOf<TRangeProperty?>.Raw;
			num = 14;
		}
	}

	protected override object GetFromValue(T value)
	{
		return value.From;
	}

	protected override object GetToValue(T value)
	{
		return value.To;
	}

	protected RangeTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ewQCVjo6iYbPknliGU4k()
	{
		return y800nuo6SemAh1ZqQSsH == null;
	}

	internal static object xpnRe5o6RAw6ESSNJM0L()
	{
		return y800nuo6SemAh1ZqQSsH;
	}
}

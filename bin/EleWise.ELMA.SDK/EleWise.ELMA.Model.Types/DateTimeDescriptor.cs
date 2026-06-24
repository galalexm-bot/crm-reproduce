using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 600)]
public class DateTimeDescriptor : CLRTypeDescriptor<DateTime, DateTimeSettings>, IMappingTypeDescriptor
{
	public const string ClientTimeZoneOffsetKey = "ClientTimeZoneOffsetKey";

	public const string UID_S = "{DAC9211E-E02B-47CD-8868-89A3BFC0F749}";

	public static readonly Guid UID;

	private static readonly TimeSpan afterDayStart;

	private static readonly TimeSpan beforDayEnd;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static DateTimeDescriptor vJakCkox4C9PYsRLjl8a;

	public override Guid Uid => UID;

	public override string Name => (string)ub4W5hox03iD4EKd4I3A(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811863318));

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
					fullTextPropertyDescriptor = (propertyDescriptor = new DateTimePropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
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
		//Discarded unreachable code: IL_0049, IL_0087
		int num = 8;
		DateTimeSettings dateTimeSettings = default(DateTimeSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (X6vmIUox7Owt3fTy4flO(dateTimeSettings))
					{
						num2 = 9;
						continue;
					}
					goto case 5;
				case 3:
					return;
				case 2:
					break;
				case 8:
					base.ExtendSimplePropertyMapping(mapper, propertyMetadata);
					num2 = 7;
					continue;
				case 1:
					if (dateTimeSettings == null)
					{
						num2 = 2;
						continue;
					}
					goto case 6;
				default:
					mapper.Type<DateTimeWithoutOffsetNHType>();
					num2 = 3;
					continue;
				case 5:
					if (!RKkCkMoxxYHx5GPTUZmJ(dateTimeSettings))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 4:
					return;
				case 7:
					dateTimeSettings = (DateTimeSettings)lAdMqKoxAhEQAyDtJ7RN(propertyMetadata);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			mapper.Type<DateTimeNHType>();
			num = 4;
		}
	}

	public override IDictionary<string, object> Serialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548BE7B4));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998520728));
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		object obj2 = property.GetValue(obj, null);
		if (ContextVars.TryGetValue<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x63821F2B), out var value) && propertyMetadata.Settings is DateTimeSettings dateTimeSettings && !dateTimeSettings.WithoutOffset && dateTimeSettings.ShowTime && obj2 is DateTime runtimeDateTime)
		{
			TZSettings settings2 = new TZSettings(dateTimeSettings.TZ?.Type ?? TZSettings.TZType.Custom, value);
			obj2 = runtimeDateTime.ToClientDateTime(settings2);
		}
		object value2 = SerializeSimple(obj2, property.PropertyType, settings);
		return new SerializableDictionary<string, object> { { propertyMetadata.Name, value2 } };
	}

	public override void Deserialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		if (obj == null || values == null)
		{
			return;
		}
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583759414));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE13227));
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanWrite || !values.TryGetValue(propertyMetadata.Name, out var value))
		{
			return;
		}
		try
		{
			object obj2 = DeserializeSimple(value, property.PropertyType);
			if (ContextVars.TryGetValue<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765951510), out var value2) && propertyMetadata.Settings is DateTimeSettings dateTimeSettings && !dateTimeSettings.WithoutOffset && dateTimeSettings.ShowTime && obj2 is DateTime clientDateTime)
			{
				TZSettings settings = new TZSettings(dateTimeSettings.TZ?.Type ?? TZSettings.TZType.Custom, value2);
				obj2 = clientDateTime.ToRuntimeDateTimeFromClient(settings);
			}
			property.SetValue(obj, obj2, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);
		}
		catch (Exception exception)
		{
			base.Logger.Debug(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606749714), Name, GetType(), propertyMetadata.Name, metadata.FullTypeName), exception);
		}
	}

	public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_0042, IL_0072, IL_00b7, IL_00c6
		int num = 7;
		int num2 = num;
		DateTimeSettings dateTimeSettings = default(DateTimeSettings);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 4:
				obj = null;
				break;
			default:
				if (!dateTimeSettings.RangeInFilter)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				return DateTimeRangeDescriptor.UID;
			case 2:
				if (!GIeBiqoxmFycuAI6uxvg(dateTimeSettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 7:
				if (propertyMetadata != null)
				{
					num2 = 6;
					continue;
				}
				goto case 4;
			case 5:
				return UID;
			case 3:
				return RelativeDateTimeDescriptor.UID;
			case 1:
				if (dateTimeSettings == null)
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 6:
				obj = (DateTimeSettings)lAdMqKoxAhEQAyDtJ7RN(propertyMetadata);
				break;
			}
			dateTimeSettings = (DateTimeSettings)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
			{
				num2 = 1;
			}
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0067
		int num = 1;
		int num2 = num;
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return dateTime.Value == DateTime.MinValue;
			case 2:
				return true;
			case 1:
				dateTime = (DateTime?)val;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!dateTime.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0051, IL_0152
		int num = 11;
		int num2 = num;
		DateTime? defaultValue = default(DateTime?);
		DateTimeSettings dateTimeSettings = default(DateTimeSettings);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (WICHSAoxy5rrrESD7xbY(this, propertyMetadata, val))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (propertyMetadata != null)
				{
					num2 = 2;
					break;
				}
				goto case 8;
			case 6:
				return defaultValue.Equals(val);
			case 7:
				return false;
			case 3:
				defaultValue = dateTimeSettings.DefaultValue;
				num2 = 6;
				break;
			default:
				if (!defaultValue.HasValue)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				return false;
			case 9:
				return true;
			case 11:
				if (val != null)
				{
					num2 = 10;
					break;
				}
				goto case 1;
			case 1:
				return true;
			case 4:
				if (dateTimeSettings != null)
				{
					defaultValue = dateTimeSettings.DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 9;
					}
				}
				break;
			case 8:
				return true;
			case 2:
				if (!KGpdsfoxM2S1esZfEnLQ(propertyMetadata))
				{
					dateTimeSettings = (DateTimeSettings)lAdMqKoxAhEQAyDtJ7RN(propertyMetadata);
					num2 = 4;
				}
				else
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0080, IL_008f, IL_0141
		int num = 9;
		int num2 = num;
		DateTime? defaultValue = default(DateTime?);
		DateTimeSettings dateTimeSettings = default(DateTimeSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (defaultValue.HasValue)
				{
					num2 = 6;
					break;
				}
				goto case 3;
			case 2:
				if (dateTimeSettings == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 6:
				return typeof(DateTime).CreateTypeSyntax().ObjectCreationExpression((ISyntaxNode)Xaf7bdoxg5iMH0U0ZM6H(dateTimeSettings.DefaultValue.Value.Ticks));
			case 3:
				return null;
			case 7:
				return null;
			case 8:
				if (!forFilter)
				{
					dateTimeSettings = (DateTimeSettings)lAdMqKoxAhEQAyDtJ7RN(propertyMetadata);
					num2 = 2;
					break;
				}
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				if (!CKR61woxd75ev4A5rSiK(dateTimeSettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 9:
				RpiVOkox9Aqi78kkwGhn(propertyMetadata, glVmmjoxJFuqb37mkUY1(-2107978722 ^ -2107996852));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return (ISyntaxNode)wZ6sySoxrBwswImuJLoG(foeCMroxlYI3XKq1QkL6(typeof(DateTime)), RKkCkMoxxYHx5GPTUZmJ(dateTimeSettings) ? glVmmjoxJFuqb37mkUY1(0x66F566B6 ^ 0x66F7ED7E) : glVmmjoxJFuqb37mkUY1(-1867198571 ^ -1867103185));
			default:
				defaultValue = dateTimeSettings.DefaultValue;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_0071, IL_00cd, IL_00dc, IL_0195, IL_01af, IL_01be
		int num = 15;
		DateTimeSettings dateTimeSettings = default(DateTimeSettings);
		DateTime? dateTime2 = default(DateTime?);
		DateTime dateTime3 = default(DateTime);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				DateTime value;
				switch (num2)
				{
				case 4:
					if (CKR61woxd75ev4A5rSiK(dateTimeSettings))
					{
						num2 = 9;
						continue;
					}
					dateTime2 = dateTimeSettings.DefaultValue;
					num2 = 18;
					continue;
				case 13:
					if (!KGpdsfoxM2S1esZfEnLQ(propertyMetadata))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 8;
				case 16:
					dateTime3 = default(DateTime);
					num2 = 12;
					continue;
				default:
					if (dateTimeSettings != null)
					{
						num2 = 4;
						continue;
					}
					goto case 18;
				case 15:
					Contract.ArgumentNotNull(propertyMetadata, (string)glVmmjoxJFuqb37mkUY1(-398663332 ^ -398678002));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (!KGpdsfoxM2S1esZfEnLQ(propertyMetadata))
					{
						num = 17;
						break;
					}
					goto case 11;
				case 1:
					dateTimeSettings = (DateTimeSettings)lAdMqKoxAhEQAyDtJ7RN(propertyMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (!RKkCkMoxxYHx5GPTUZmJ(dateTimeSettings))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					return new PropertyValueContainer<DateTime?>(NullableDefaultCurrentTime);
				case 12:
					value = dateTime3;
					goto IL_02c7;
				case 9:
					if (propertyMetadata != null)
					{
						num2 = 6;
						continue;
					}
					goto case 17;
				case 8:
					return new PropertyValueContainer<DateTime?>(dateTime2);
				case 3:
				case 19:
					dateTime = dateTime2;
					num2 = 2;
					continue;
				case 18:
					if (propertyMetadata == null)
					{
						num = 3;
						break;
					}
					goto case 13;
				case 7:
					if (!forFilter)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 18;
				case 10:
					return new PropertyValueContainer<DateTime?>(NullableDefaultCurrentDate);
				case 17:
					if (!dateTimeSettings.ShowTime)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					return new PropertyValueContainer<DateTime>(DefaultCurrentTime);
				case 14:
					dateTime2 = null;
					num2 = 7;
					continue;
				case 5:
					return new PropertyValueContainer<DateTime>(DefaultCurrentDate);
				case 2:
					{
						if (!dateTime.HasValue)
						{
							num = 16;
							break;
						}
						value = dateTime.GetValueOrDefault();
						goto IL_02c7;
					}
					IL_02c7:
					return new PropertyValueContainer<DateTime>(value);
				}
				break;
			}
		}
	}

	public override string FormatValue(object value, TypeSettings settings)
	{
		//Discarded unreachable code: IL_00ba, IL_00c4, IL_00d3, IL_0182, IL_019d, IL_01ac, IL_01bc, IL_01f1, IL_024e, IL_0262
		int num = 5;
		DateTime value2 = default(DateTime);
		DateTime? dateTime = default(DateTime?);
		bool flag = default(bool);
		bool flag2 = default(bool);
		DateTimeSettings dateTimeSettings = default(DateTimeSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				case 9:
					value2 = dateTime.Value;
					num2 = 16;
					continue;
				case 18:
					return value2.ToShortDateString();
				case 10:
					if (flag)
					{
						num2 = 9;
						continue;
					}
					return string.Empty;
				case 20:
					num4 = (JnM9E0oxj1kNWv17IP4i(value2.TimeOfDay, beforDayEnd) ? 1 : 0);
					break;
				case 5:
					dateTime = value as DateTime?;
					num2 = 4;
					continue;
				case 22:
					return value2.ToString((string)glVmmjoxJFuqb37mkUY1(-1710575414 ^ -1710602422));
				case 12:
					value2 = dateTime.Value;
					num2 = 19;
					continue;
				case 6:
					goto end_IL_0012;
				case 13:
					if (!(flag2 && flag))
					{
						if (!flag2)
						{
							num2 = 10;
							continue;
						}
						goto case 7;
					}
					num2 = 6;
					continue;
				case 19:
					if (!JnM9E0oxj1kNWv17IP4i(value2.TimeOfDay, afterDayStart))
					{
						num2 = 3;
						continue;
					}
					goto case 15;
				case 1:
					num4 = 1;
					break;
				case 17:
					if (dateTimeSettings != null)
					{
						num2 = 21;
						continue;
					}
					goto case 1;
				case 15:
					value2 = dateTime.Value;
					num2 = 20;
					continue;
				case 7:
					value2 = dateTime.Value;
					num2 = 18;
					continue;
				case 11:
					return base.FormatValue(value, settings);
				case 2:
					if (dateTimeSettings != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto default;
				case 16:
					return value2.ToShortTimeString();
				case 14:
					if (dateTime.HasValue)
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				default:
					num3 = 1;
					goto IL_02a6;
				case 21:
					if (RKkCkMoxxYHx5GPTUZmJ(dateTimeSettings))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 4:
					dateTimeSettings = settings as DateTimeSettings;
					num2 = 14;
					continue;
				case 8:
					num3 = (xJxhDEox5G5ixobmnG5D(dateTimeSettings) ? 1 : 0);
					goto IL_02a6;
				case 3:
					{
						num4 = 0;
						break;
					}
					IL_02a6:
					flag2 = (byte)num3 != 0;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 17;
					}
					continue;
				}
				flag = (byte)num4 != 0;
				num2 = 13;
				continue;
				end_IL_0012:
				break;
			}
			value2 = dateTime.Value;
			num = 22;
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
		return (IComparer)iFivbYoxYrPi8OPJspEM(sourceType, propertyFunc, order);
	}

	public override bool IsSupportSort()
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.DateTime);
	}

	private static DateTime DefaultCurrentDate()
	{
		return DateTime.Today;
	}

	private static DateTime DefaultCurrentTime()
	{
		return CtJmG0oxLJgbUhNUxNS7();
	}

	private static DateTime? NullableDefaultCurrentDate()
	{
		return DateTime.Today;
	}

	private static DateTime? NullableDefaultCurrentTime()
	{
		return DateTime.Now;
	}

	public DateTimeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fMf5UcoxUtB5rIs6Z84x();
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

	static DateTimeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				beforDayEnd = new TimeSpan(23, 59, 50);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				afterDayStart = new TimeSpan(0, 0, 10);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				fMf5UcoxUtB5rIs6Z84x();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)glVmmjoxJFuqb37mkUY1(-1633514411 ^ -1633679481));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object lAdMqKoxAhEQAyDtJ7RN(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool X6vmIUox7Owt3fTy4flO(object P_0)
	{
		return ((DateTimeSettings)P_0).WithoutOffset;
	}

	internal static bool RKkCkMoxxYHx5GPTUZmJ(object P_0)
	{
		return ((DateTimeSettings)P_0).ShowTime;
	}

	internal static bool AeEWIhox6UNlwS55nbgw()
	{
		return vJakCkox4C9PYsRLjl8a == null;
	}

	internal static DateTimeDescriptor xWVDmtoxHYtJmDo9lKui()
	{
		return vJakCkox4C9PYsRLjl8a;
	}

	internal static object ub4W5hox03iD4EKd4I3A(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool GIeBiqoxmFycuAI6uxvg(object P_0)
	{
		return ((DateTimeSettings)P_0).RelativeInFilter;
	}

	internal static bool WICHSAoxy5rrrESD7xbY(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static bool KGpdsfoxM2S1esZfEnLQ(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static object glVmmjoxJFuqb37mkUY1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void RpiVOkox9Aqi78kkwGhn(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool CKR61woxd75ev4A5rSiK(object P_0)
	{
		return ((DateTimeSettings)P_0).SetCurrentDate;
	}

	internal static object foeCMroxlYI3XKq1QkL6(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object wZ6sySoxrBwswImuJLoG(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).MemberAccessExpression((string)P_1);
	}

	internal static object Xaf7bdoxg5iMH0U0ZM6H(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static bool xJxhDEox5G5ixobmnG5D(object P_0)
	{
		return ((DateTimeSettings)P_0).ShowDate;
	}

	internal static bool JnM9E0oxj1kNWv17IP4i(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 != P_1;
	}

	internal static object iFivbYoxYrPi8OPJspEM(Type sourceType, object P_1, ListSortDirection order)
	{
		return ComparerHelper.Create(sourceType, (LambdaExpression)P_1, order);
	}

	internal static DateTime CtJmG0oxLJgbUhNUxNS7()
	{
		return DateTime.Now;
	}

	internal static void fMf5UcoxUtB5rIs6Z84x()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

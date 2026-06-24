using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class DateTimePropertyDescriptor : FullTextPropertyDescriptor
{
	private Func<IPropertyMetadata, string> IndexFieldName;

	private static DateTimePropertyDescriptor iT09vMGv8rnDWmrO9NK7;

	public DateTimePropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_005d, IL_0062
		SingletonReader.JJCZtPuTvSt();
		IndexFieldName = (IPropertyMetadata propMd) => (string)_003C_003Ec.tFX8oovjwJ0Zbpk1YghC(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767638753), _003C_003Ec.cBqH09vjDv88WD08b76d(_003C_003Ec.bBFh64vja6A8jewNaqiy(propMd).ToString()), _003C_003Ec.YNPVVqvjtNkPBZk8chiI(-1870892489 ^ -1870807229));
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return GetIndexField(obj, propMd);
			case 1:
				return GetReIndexField(obj, propMd);
			case 2:
				if (reindex)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList
		{
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem(IndexFieldName(propMd), null, FullTextFieldType.Long, FullTextFieldTag.Sort)
		};
	}

	private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 4:
				dateTime = (DateTime)obj;
				num2 = 3;
				break;
			default:
				if (obj != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_00c1;
			case 3:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), dateTime.ToString((string)FwVDe1GvIUB3rtgTleWA(0x10E41EDB ^ 0x10E4E95B)), FullTextFieldType.String),
					new FieldIndexListItem(IndexFieldName(propMd), dateTime.Ticks, FullTextFieldType.Long)
				};
			case 2:
				if (obj is DateTime)
				{
					num2 = 4;
					break;
				}
				goto IL_00c1;
			case 1:
				{
					if (propMd != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_00c1;
				}
				IL_00c1:
				return new FieldIndexList();
			}
		}
	}

	private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (propMd == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				if (obj is DateTime)
				{
					num2 = 3;
					break;
				}
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), string.Empty, FullTextFieldType.String),
					new FieldIndexListItem(IndexFieldName(propMd), null, FullTextFieldType.Long)
				};
			case 3:
				return GetIndexField(obj, propMd);
			case 1:
				return new FieldIndexList();
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0111, IL_0120, IL_0158, IL_0167, IL_0246, IL_0255, IL_02d4, IL_0305, IL_03d2, IL_03e1, IL_0504, IL_0513, IL_0583, IL_0592, IL_05cb, IL_05da, IL_05e9, IL_062e, IL_0655, IL_0664, IL_06a8, IL_06d9, IL_06e8, IL_06f8
		int num = 8;
		List<object> list = default(List<object>);
		DateTimeWrapper dateTimeWrapper = default(DateTimeWrapper);
		DateTime? dateTime = default(DateTime?);
		RelativeDateTimeWrapper relativeDateTimeWrapper = default(RelativeDateTimeWrapper);
		DateTimeRangeWrapper dateTimeRangeWrapper = default(DateTimeRangeWrapper);
		List<object> list7 = default(List<object>);
		List<object> list4 = default(List<object>);
		DateTimeRange dateTimeRange = default(DateTimeRange);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				List<object> list9;
				long? obj6;
				List<object> list8;
				long? obj5;
				List<object> list3;
				long? obj2;
				List<object> list2;
				long? obj;
				switch (num2)
				{
				case 41:
					return new FilterListItem(IndexFieldName(propMd), list, FilterListItemType.Between, FullTextFieldType.Long);
				case 55:
					dateTimeWrapper = value as DateTimeWrapper;
					num2 = 48;
					continue;
				case 35:
					if (dateTime.HasValue)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 16;
				case 30:
					if (dateTime.HasValue)
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 37:
					if (VTSNiXGvi7rShoRNYSSO(relativeDateTimeWrapper))
					{
						num2 = 29;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 57;
						}
						continue;
					}
					if (SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper) != null)
					{
						num2 = 56;
						continue;
					}
					goto case 6;
				case 17:
					dateTime = ((DateTimeRangeWrapper)SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper)).From.Value;
					num2 = 30;
					continue;
				case 12:
					dateTime = ((DateTimeWrapper)YOlJ5kGvVnIU2YydEP8Y(dateTimeRangeWrapper)).Value;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 17;
					}
					continue;
				case 31:
					return new FilterListItem(IndexFieldName(propMd), list7, FilterListItemType.Between, FullTextFieldType.Long);
				case 5:
					relativeDateTimeWrapper = value as RelativeDateTimeWrapper;
					num2 = 34;
					continue;
				case 6:
					return null;
				case 56:
					if (((DateTimeRangeWrapper)SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper)).From != null)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto default;
				case 2:
					return new FilterListItem(IndexFieldName(propMd), list4, FilterListItemType.Between, FullTextFieldType.Long);
				case 9:
					if (!dateTime.HasValue)
					{
						num2 = 24;
						continue;
					}
					goto case 11;
				case 43:
					_ = dateTime.Value;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 15;
					}
					continue;
				default:
					if (AfdNetGvSrifiKfadJO9(SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper)) == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 25;
				case 57:
					dateTimeRange = AbU2ldGvKWgwEJ3462V8(nql4AGGvRyYYnhjsSa7v(relativeDateTimeWrapper), SRM9F6GvqldQdYxkOMuP(relativeDateTimeWrapper));
					num2 = 23;
					continue;
				case 11:
					return new FilterListItem(IndexFieldName(propMd), new List<object> { dateTimeWrapper.Value.Value.Ticks }, FilterListItemType.Must, FullTextFieldType.Long);
				case 24:
				case 26:
					return null;
				case 4:
				case 38:
				case 40:
					return null;
				case 15:
				case 45:
					list7 = new List<object>();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 18;
					}
					continue;
				case 53:
					_ = dateTime.Value;
					num2 = 46;
					continue;
				case 13:
					if (!dateTime.HasValue)
					{
						num2 = 42;
						continue;
					}
					goto case 52;
				case 52:
					dateTime = dateTimeRange.To;
					num2 = 53;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 27;
					}
					continue;
				case 33:
					if (dateTime.HasValue)
					{
						num = 27;
						break;
					}
					goto case 51;
				case 49:
					dateTime = ((DateTimeWrapper)AfdNetGvSrifiKfadJO9(dateTimeRangeWrapper)).Value;
					num2 = 36;
					continue;
				case 7:
					if (dateTimeRangeWrapper == null)
					{
						num2 = 5;
						continue;
					}
					goto case 59;
				case 19:
					dateTime = ((DateTimeWrapper)AfdNetGvSrifiKfadJO9(dateTimeRangeWrapper)).Value;
					num2 = 43;
					continue;
				case 51:
					dateTime = dateTimeRange.To;
					num2 = 13;
					continue;
				case 44:
					_ = dateTime.Value;
					num2 = 45;
					continue;
				case 25:
					dateTime = ((DateTimeWrapper)AfdNetGvSrifiKfadJO9(SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper))).Value;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 35;
					}
					continue;
				case 23:
					dateTime = dateTimeRange.From;
					num2 = 33;
					continue;
				case 59:
					if (YOlJ5kGvVnIU2YydEP8Y(dateTimeRangeWrapper) != null)
					{
						num = 12;
						break;
					}
					goto case 39;
				case 48:
					if (dateTimeWrapper == null)
					{
						num2 = 26;
						continue;
					}
					goto case 47;
				case 22:
					if (dateTime.HasValue)
					{
						num2 = 54;
						continue;
					}
					goto case 39;
				case 27:
					dateTime = dateTimeRange.From;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 2;
					}
					continue;
				case 39:
					if (AfdNetGvSrifiKfadJO9(dateTimeRangeWrapper) == null)
					{
						num2 = 40;
						continue;
					}
					goto case 49;
				case 16:
				case 29:
					return null;
				case 3:
				case 10:
					list = new List<object>();
					num2 = 58;
					continue;
				case 36:
					if (!dateTime.HasValue)
					{
						num2 = 38;
						continue;
					}
					goto case 19;
				case 14:
				case 42:
					return null;
				case 1:
				case 46:
					list4 = new List<object>();
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					dateTimeRangeWrapper = value as DateTimeRangeWrapper;
					num2 = 7;
					continue;
				case 54:
					dateTime = ((DateTimeWrapper)YOlJ5kGvVnIU2YydEP8Y(dateTimeRangeWrapper)).Value;
					num2 = 44;
					continue;
				case 47:
					dateTime = dateTimeWrapper.Value;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 7;
					}
					continue;
				case 34:
					if (relativeDateTimeWrapper == null)
					{
						num2 = 55;
						continue;
					}
					goto case 37;
				case 20:
					_ = dateTime.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					list9 = list7;
					if (dateTimeRangeWrapper.From != null)
					{
						dateTime = ((DateTimeWrapper)YOlJ5kGvVnIU2YydEP8Y(dateTimeRangeWrapper)).Value;
						if (dateTime.HasValue)
						{
							_ = ((DateTimeWrapper)YOlJ5kGvVnIU2YydEP8Y(dateTimeRangeWrapper)).Value.Value;
							dateTime = dateTimeRangeWrapper.From.Value;
							obj6 = dateTime.Value.Ticks;
							goto IL_0781;
						}
					}
					obj6 = null;
					goto IL_0781;
				case 50:
					list8 = list7;
					if (AfdNetGvSrifiKfadJO9(dateTimeRangeWrapper) != null)
					{
						dateTime = dateTimeRangeWrapper.To.Value;
						if (dateTime.HasValue)
						{
							_ = ((DateTimeWrapper)AfdNetGvSrifiKfadJO9(dateTimeRangeWrapper)).Value.Value;
							dateTime = ((DateTimeWrapper)AfdNetGvSrifiKfadJO9(dateTimeRangeWrapper)).Value;
							obj5 = dateTime.Value.Ticks;
							goto IL_080a;
						}
					}
					obj5 = null;
					goto IL_080a;
				case 28:
				{
					List<object> list6 = list4;
					dateTime = dateTimeRange.From;
					long? obj4;
					if (dateTime.HasValue)
					{
						_ = dateTimeRange.From.Value;
						dateTime = dateTimeRange.From;
						obj4 = dateTime.Value.Ticks;
					}
					else
					{
						obj4 = null;
					}
					list6.Add(obj4);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 21;
					}
					continue;
				}
				case 21:
				{
					List<object> list5 = list4;
					dateTime = dateTimeRange.To;
					long? obj3;
					if (dateTime.HasValue)
					{
						_ = dateTimeRange.To.Value;
						dateTime = dateTimeRange.To;
						obj3 = dateTime.Value.Ticks;
					}
					else
					{
						obj3 = null;
					}
					list5.Add(obj3);
					num2 = 2;
					continue;
				}
				case 58:
					list3 = list;
					if (((DateTimeRangeWrapper)SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper)).From != null)
					{
						dateTime = ((DateTimeRangeWrapper)SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper)).From.Value;
						if (dateTime.HasValue)
						{
							dateTime = ((DateTimeWrapper)YOlJ5kGvVnIU2YydEP8Y(SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper))).Value;
							obj2 = dateTime.Value.Ticks;
							goto IL_0978;
						}
					}
					obj2 = null;
					goto IL_0978;
				case 32:
					{
						list2 = list;
						if (AfdNetGvSrifiKfadJO9(SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper)) != null)
						{
							dateTime = ((DateTimeWrapper)AfdNetGvSrifiKfadJO9(SsdBa6GvXYP3VVFThnPH(relativeDateTimeWrapper))).Value;
							if (dateTime.HasValue)
							{
								dateTime = ((DateTimeWrapper)AfdNetGvSrifiKfadJO9(relativeDateTimeWrapper.DateTimeRange)).Value;
								obj = dateTime.Value.Ticks;
								goto IL_09fa;
							}
						}
						obj = null;
						goto IL_09fa;
					}
					IL_09fa:
					list2.Add(obj);
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 1;
					}
					continue;
					IL_0978:
					list3.Add(obj2);
					num2 = 32;
					continue;
					IL_080a:
					list8.Add(obj5);
					num2 = 31;
					continue;
					IL_0781:
					list9.Add(obj6);
					num2 = 50;
					continue;
				}
				break;
			}
		}
	}

	public override List<string> GetReturnField(IPropertyMetadata propMd)
	{
		return new List<string> { IndexFieldName(propMd) };
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(IndexFieldName(propMd), FullTextFieldType.Long);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_00d8, IL_00e7, IL_0113, IL_0164, IL_0185, IL_0194, IL_01a3, IL_0234, IL_0243
		int num = 11;
		int num2 = num;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					int num4;
					if (long.TryParse(webDataItem.Value, out var result))
					{
						int num3 = 2;
						num4 = num3;
						goto IL_0076;
					}
					goto IL_00af;
					IL_0076:
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 2:
							goto IL_0090;
						case 1:
							break;
						case 3:
							return;
						case 0:
							return;
						}
						break;
						IL_0090:
						propertyCached.SetValue(obj, new DateTime(result), null);
						num4 = 3;
					}
					goto IL_00af;
					IL_00af:
					oXFECRGv2Z34fjDhwqpf(propertyCached, obj, null, null);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num4 = 0;
					}
					goto IL_0076;
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							return;
						}
						UgiAhTGvPdqElQgDpa3L(qQFHXcGveE7R3l5x8gva(), FwVDe1GvIUB3rtgTleWA(0x5DD55050 ^ 0x5DD69AB8), ex);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num5 = 1;
						}
					}
				}
			case 8:
				if (webDataItem == null)
				{
					num2 = 9;
					continue;
				}
				goto case 3;
			case 12:
				return;
			case 9:
				return;
			case 10:
				return;
			case 5:
				return;
			case 4:
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				if (lqBBnuGvOxNWcNDOJ1wx(p6kO1fGvnqtRkodYrt5S(webDataItem), IndexFieldName(propMd)))
				{
					return;
				}
				num2 = 4;
				continue;
			case 11:
				if (obj == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 10;
					}
					continue;
				}
				break;
			case 7:
				return;
			case 6:
				webDataItem = value as WebDataItem;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				if (ltG0RUGvkCL9lDDjVU4H(propertyCached, null))
				{
					return;
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				break;
			}
			if (propMd != null)
			{
				propertyCached = obj.GetType().GetPropertyCached((string)VlJRcZGvT3j39ClKtClo(propMd));
				num2 = 6;
			}
			else
			{
				num2 = 7;
			}
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_00e9, IL_01af, IL_01be, IL_01cd, IL_0240, IL_0257, IL_0266, IL_0275, IL_0285, IL_0294
		int num = 2;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		object value = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (!ltG0RUGvkCL9lDDjVU4H(propertyCached, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 2:
				if (obj != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				return;
			case 3:
				return;
			case 7:
				return;
			case 10:
				try
				{
					int num3;
					if (!HPUu1VGv1O4jcyCZbvox(propMd as PropertyMetadata))
					{
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num3 = 7;
						}
						goto IL_00ed;
					}
					goto IL_014d;
					IL_014d:
					propertyCached.SetValue(obj, null, null);
					num3 = 5;
					goto IL_00ed;
					IL_00ed:
					while (true)
					{
						switch (num3)
						{
						case 3:
							return;
						case 5:
							return;
						case 4:
							value = base.TypeDescriptor.SerializeSimple(null, lNGegcGv3lVdVc21Kd5Y(typeof(DateTime).TypeHandle));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							if ((propMd.Settings as DateTimeSettings).SetCurrentDate)
							{
								return;
							}
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num3 = 4;
							}
							continue;
						case 7:
						case 8:
							if (!(dcNGHpGvNVaw3uwcdNLw(propMd) is DateTimeSettings))
							{
								return;
							}
							num3 = 2;
							continue;
						case 1:
							obj2 = base.TypeDescriptor.DeserializeSimple(value, lNGegcGv3lVdVc21Kd5Y(typeof(DateTime).TypeHandle));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num3 = 6;
							}
							continue;
						case 6:
							oXFECRGv2Z34fjDhwqpf(propertyCached, obj, obj2, null);
							num3 = 3;
							continue;
						}
						break;
					}
					goto IL_014d;
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
					return;
				}
			case 5:
				return;
			default:
				if (fieldName != IndexFieldName(propMd))
				{
					num2 = 5;
					continue;
				}
				break;
			case 9:
				return;
			case 8:
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
				if (propMd != null)
				{
					propertyCached = obj.GetType().GetPropertyCached((string)VlJRcZGvT3j39ClKtClo(propMd));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 6;
					}
				}
				else
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 7;
					}
				}
				continue;
			case 4:
				break;
			}
			if (!(propMd is PropertyMetadata))
			{
				break;
			}
			num2 = 8;
		}
	}

	internal static bool vD3SS3GvZu1OjLO2IAMn()
	{
		return iT09vMGv8rnDWmrO9NK7 == null;
	}

	internal static DateTimePropertyDescriptor AUulPAGvuvgY2kaX6Xke()
	{
		return iT09vMGv8rnDWmrO9NK7;
	}

	internal static object FwVDe1GvIUB3rtgTleWA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YOlJ5kGvVnIU2YydEP8Y(object P_0)
	{
		return ((DateTimeRangeWrapper)P_0).From;
	}

	internal static object AfdNetGvSrifiKfadJO9(object P_0)
	{
		return ((DateTimeRangeWrapper)P_0).To;
	}

	internal static bool VTSNiXGvi7rShoRNYSSO(object P_0)
	{
		return ((RelativeDateTimeWrapper)P_0).IsRelative;
	}

	internal static object nql4AGGvRyYYnhjsSa7v(object P_0)
	{
		return ((RelativeDateTimeWrapper)P_0).RelativeFrom;
	}

	internal static object SRM9F6GvqldQdYxkOMuP(object P_0)
	{
		return ((RelativeDateTimeWrapper)P_0).RelativeTo;
	}

	internal static DateTimeRange AbU2ldGvKWgwEJ3462V8(object P_0, object P_1)
	{
		return RelativeDateTimeDescriptor.GetDateTimeRange((string)P_0, (string)P_1);
	}

	internal static object SsdBa6GvXYP3VVFThnPH(object P_0)
	{
		return ((RelativeDateTimeWrapper)P_0).DateTimeRange;
	}

	internal static object VlJRcZGvT3j39ClKtClo(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool ltG0RUGvkCL9lDDjVU4H(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object p6kO1fGvnqtRkodYrt5S(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool lqBBnuGvOxNWcNDOJ1wx(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void oXFECRGv2Z34fjDhwqpf(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object qQFHXcGveE7R3l5x8gva()
	{
		return Logger.Log;
	}

	internal static void UgiAhTGvPdqElQgDpa3L(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool HPUu1VGv1O4jcyCZbvox(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static object dcNGHpGvNVaw3uwcdNLw(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static Type lNGegcGv3lVdVc21Kd5Y(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}

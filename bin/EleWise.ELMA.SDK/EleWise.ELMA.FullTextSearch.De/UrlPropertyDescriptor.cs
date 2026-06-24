using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class UrlPropertyDescriptor : FullTextPropertyDescriptor
{
	internal static UrlPropertyDescriptor iVXhgjGZCsr61r6UdSCV;

	public override bool IsSupportedFullTextSearchInIndex => true;

	public UrlPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList
		{
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem(SortFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Sort)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (propMd == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), KvkhxLGZZcnPvEtJPfTx(obj), FullTextFieldType.String),
					new FieldIndexListItem(SortFieldName(propMd), mlVGwuGZuYduCxlgBs27(obj), FullTextFieldType.String)
				};
			default:
				return new FieldIndexList();
			}
		}
	}

	public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
	{
		int num = 1;
		int num2 = num;
		UriWrapper uriWrapper = default(UriWrapper);
		while (true)
		{
			switch (num2)
			{
			case 1:
				uriWrapper = value as UriWrapper;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new FieldListItem(ValueFieldName(propMd), (uriWrapper != null && gDIpMDGZIi215XhjFLyl(uriWrapper) != null) ? uriWrapper.UriValue : string.Empty);
			}
		}
	}

	public override List<string> GetReturnField(IPropertyMetadata propMd)
	{
		return new List<string> { ValueFieldName(propMd) };
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(SortFieldName(propMd), FullTextFieldType.String);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0086, IL_00b9, IL_0110, IL_0141, IL_0164, IL_0173, IL_0183, IL_0192
		int num = 3;
		PropertyInfo propertyCached = default(PropertyInfo);
		WebDataItem webDataItem = default(WebDataItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 6:
					return;
				case 7:
					try
					{
						uIa2amGZqx8qCh6x0avj(propertyCached, obj, new Uri((string)cxQekMGZRtre6QEjA05l(webDataItem), UriKind.RelativeOrAbsolute), null);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					catch (Exception exception)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								Logger.Log.Warn(ustCc4GZKMxHUVhPlYAe(-1633514411 ^ -1633597763), exception);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					}
				case 0:
					return;
				case 5:
					return;
				case 8:
					return;
				case 4:
					break;
				case 1:
					webDataItem = value as WebDataItem;
					num2 = 11;
					continue;
				case 3:
					if (obj == null)
					{
						num2 = 2;
						continue;
					}
					goto case 13;
				case 2:
					return;
				case 10:
					if (webDataItem == null)
					{
						num2 = 8;
						continue;
					}
					goto case 12;
				case 9:
					return;
				case 13:
					if (propMd != null)
					{
						propertyCached = obj.GetType().GetPropertyCached((string)x4Jb3oGZVBK7I5S9kvPV(propMd));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 6;
						}
					}
					continue;
				case 12:
					if ((string)Tlw5MJGZiERseEE9AS7x(webDataItem) != ValueFieldName(propMd))
					{
						return;
					}
					num2 = 4;
					continue;
				case 11:
					if (b0u4KwGZSwilhUhKwttU(propertyCached, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				}
				break;
			}
			num = 7;
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_008a, IL_0104, IL_0133, IL_0142, IL_01bc, IL_01cb, IL_020a, IL_0221, IL_0230, IL_0285, IL_0294, IL_02b0
		int num = 6;
		PropertyInfo propertyCached = default(PropertyInfo);
		object value = default(object);
		object obj2 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (obj == null)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 1:
					if (!(propMd is PropertyMetadata))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 8;
					}
					break;
				case 5:
					return;
				case 4:
					if (propMd != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 9:
					if (BiD9P3GZXNtyCED5rWhB(fieldName, ValueFieldName(propMd)))
					{
						num2 = 7;
						break;
					}
					goto case 1;
				case 8:
					try
					{
						int num3;
						if (!ABF9EmGZTjktXRhNW83a(propMd as PropertyMetadata))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num3 = 0;
							}
							goto IL_0108;
						}
						goto IL_01d6;
						IL_01d6:
						uIa2amGZqx8qCh6x0avj(propertyCached, obj, null, null);
						num3 = 4;
						goto IL_0108;
						IL_0108:
						while (true)
						{
							switch (num3)
							{
							default:
								value = base.TypeDescriptor.SerializeSimple(null, MsObLcGZknjnrbOsfhSS(typeof(Uri).TypeHandle));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num3 = 1;
								}
								continue;
							case 6:
								uIa2amGZqx8qCh6x0avj(propertyCached, obj, obj2, null);
								num3 = 3;
								continue;
							case 1:
								obj2 = base.TypeDescriptor.DeserializeSimple(value, MsObLcGZknjnrbOsfhSS(typeof(Uri).TypeHandle));
								num3 = 6;
								continue;
							case 4:
								return;
							case 5:
								break;
							case 3:
								return;
							}
							break;
						}
						goto IL_01d6;
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
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
				case 11:
					return;
				default:
					propertyCached = obj.GetType().GetPropertyCached((string)x4Jb3oGZVBK7I5S9kvPV(propMd));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 8;
					}
					break;
				case 10:
					if (!b0u4KwGZSwilhUhKwttU(propertyCached, null))
					{
						num2 = 9;
						break;
					}
					return;
				case 7:
					return;
				case 3:
					return;
				case 2:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	internal static bool blPtjCGZv6qc3BkgoQOd()
	{
		return iVXhgjGZCsr61r6UdSCV == null;
	}

	internal static UrlPropertyDescriptor XIXu2VGZ8To9VftyuN9W()
	{
		return iVXhgjGZCsr61r6UdSCV;
	}

	internal static object KvkhxLGZZcnPvEtJPfTx(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static object mlVGwuGZuYduCxlgBs27(object P_0)
	{
		return StringPropertyDescriptor.ConvertToSortable(P_0);
	}

	internal static object gDIpMDGZIi215XhjFLyl(object P_0)
	{
		return ((UriWrapper)P_0).UriValue;
	}

	internal static object x4Jb3oGZVBK7I5S9kvPV(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool b0u4KwGZSwilhUhKwttU(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object Tlw5MJGZiERseEE9AS7x(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static object cxQekMGZRtre6QEjA05l(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static void uIa2amGZqx8qCh6x0avj(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object ustCc4GZKMxHUVhPlYAe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool BiD9P3GZXNtyCED5rWhB(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool ABF9EmGZTjktXRhNW83a(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type MsObLcGZknjnrbOsfhSS(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}

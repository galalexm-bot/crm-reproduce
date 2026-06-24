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
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class GuidPropertyDescriptor : FullTextPropertyDescriptor
{
	private Func<IPropertyMetadata, string> indexFieldName;

	private static GuidPropertyDescriptor Pr3WiyG8tqUancHQnH5k;

	public GuidPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_0058, IL_005d
		VH8mfqG86o9UFsSKj2QN();
		indexFieldName = (IPropertyMetadata propMd) => (string)_003C_003Ec.zXglygvjcSadU2SO8hoh(_003C_003Ec.kH6h05vjUMNsfUlR52IM(-420743386 ^ -420825150), _003C_003Ec.lyv1ZVvjsTe78VkWnb9p(propMd).ToString(), _003C_003Ec.kH6h05vjUMNsfUlR52IM(-1710575414 ^ -1710522946));
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Sort),
			new FieldIndexListItem(indexFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		int num = 3;
		int num2 = num;
		Guid result = default(Guid);
		string value2 = default(string);
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (vAg87aG8H3AGLBtJd9hC(result, Guid.Empty))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 4;
			case 5:
				value2 = null;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (propMd == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 2;
					}
					break;
				}
				value = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				Guid.TryParse(obj.ToString(), out result);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				value = (string)anT4F0G8A48bc8emSGBG(result.ToString());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			default:
				value2 = result.ToString((string)m7ooolG87cgKfLeqQXit(0x34A6D230 ^ 0x34A62878));
				num2 = 4;
				break;
			case 4:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), value, FullTextFieldType.String),
					new FieldIndexListItem(indexFieldName(propMd), value2, FullTextFieldType.String)
				};
			case 6:
				if (obj != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 2:
				return new FieldIndexList();
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0035, IL_00b3, IL_00ee, IL_00fd, IL_0128, IL_0160, IL_016f
		switch (1)
		{
		case 1:
		{
			FilterListItem result = default(FilterListItem);
			try
			{
				int num;
				if (value == null)
				{
					num = 4;
					goto IL_0039;
				}
				goto IL_00bd;
				IL_0039:
				Guid result2 = default(Guid);
				while (true)
				{
					switch (num)
					{
					case 2:
						result = new FilterListItem(indexFieldName(propMd), new List<object> { result2.ToString((string)m7ooolG87cgKfLeqQXit(-1870892489 ^ -1870886785)) }, FilterListItemType.Must, FullTextFieldType.String);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num = 0;
						}
						continue;
					case 4:
						goto end_IL_0039;
					case 3:
						break;
					case 1:
						goto end_IL_0039;
					default:
						return result;
					case 0:
						return result;
					}
					goto IL_00bd;
					continue;
					end_IL_0039:
					break;
				}
				goto end_IL_0025;
				IL_00bd:
				if (Guid.TryParse(value.ToString(), out result2))
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num = 2;
					}
					goto IL_0039;
				}
				end_IL_0025:;
			}
			catch (Exception)
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						result = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return result;
					case 0:
						return result;
					}
				}
			}
			break;
		}
		}
		return null;
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.String);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_006e, IL_0095, IL_00a4, IL_00b4, IL_0121, IL_0172, IL_019f, IL_023b, IL_024a, IL_025a
		int num = 4;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					try
					{
						int num3;
						if (!Guid.TryParse((string)yrkotsG8M7c75jpk9Fu4(webDataItem), out var result))
						{
							num3 = 3;
							goto IL_0072;
						}
						goto IL_00d6;
						IL_0072:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							default:
								goto IL_00c2;
							case 2:
								break;
							case 4:
								return;
							}
							break;
							IL_00c2:
							SoiUT3G8J60yMw6FOqGC(propertyCached, obj, null, null);
							num3 = 4;
						}
						goto IL_00d6;
						IL_00d6:
						SoiUT3G8J60yMw6FOqGC(propertyCached, obj, result, null);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num3 = 0;
						}
						goto IL_0072;
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 1:
								dZWu0XG8dRw8KSU7C7pU(IYjA1bG8902F10Pea24h(), m7ooolG87cgKfLeqQXit(0x7EC153F ^ 0x7EFDFD7), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
								{
									num4 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
				case 0:
					return;
				case 3:
					return;
				case 12:
					webDataItem = value as WebDataItem;
					num2 = 8;
					continue;
				case 11:
					return;
				case 6:
					if (!sLB5BgG8yA5COh8pt0fa(z2LsjcG8mRvvZdHJPbH0(webDataItem), ValueFieldName(propMd)))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					return;
				case 4:
					if (obj == null)
					{
						num2 = 3;
						continue;
					}
					break;
				case 8:
					if (jYK8pRG805YumLji7Lsj(propertyCached, null))
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				case 7:
					return;
				case 9:
					return;
				case 10:
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (webDataItem == null)
					{
						return;
					}
					goto end_IL_0012;
				case 2:
					break;
				}
				if (propMd != null)
				{
					propertyCached = obj.GetType().GetPropertyCached((string)sCwe7SG8xjUWpD9lhuVX(propMd));
					num2 = 12;
					continue;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_00b0, IL_00bf, IL_00cf, IL_00de, IL_0136, IL_0161, IL_0170, IL_0219, IL_0230
		int num = 10;
		object obj2 = default(object);
		object value = default(object);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					return;
				case 1:
					if (!(fieldName != ValueFieldName(propMd)))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 7;
						}
						break;
					}
					return;
				case 9:
					if (propMd != null)
					{
						goto end_IL_0012;
					}
					num2 = 3;
					break;
				case 2:
					return;
				case 0:
					return;
				case 6:
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 4;
					}
					break;
				case 7:
					if (!(propMd is PropertyMetadata))
					{
						return;
					}
					num2 = 6;
					break;
				case 5:
					return;
				case 4:
					try
					{
						int num3;
						if (sS0sSfG8le9pjqiRrbXi(propMd as PropertyMetadata))
						{
							num3 = 3;
							goto IL_013a;
						}
						goto IL_01d7;
						IL_013a:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 5:
								return;
							case 4:
								obj2 = base.TypeDescriptor.DeserializeSimple(value, qWvhJFG8rG9y8nDmmPLc(typeof(Guid).TypeHandle));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								SoiUT3G8J60yMw6FOqGC(propertyCached, obj, null, null);
								num3 = 5;
								continue;
							case 1:
								SoiUT3G8J60yMw6FOqGC(propertyCached, obj, obj2, null);
								num3 = 2;
								continue;
							}
							break;
						}
						goto IL_01d7;
						IL_01d7:
						value = base.TypeDescriptor.SerializeSimple(null, qWvhJFG8rG9y8nDmmPLc(typeof(Guid).TypeHandle));
						num3 = 4;
						goto IL_013a;
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
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
				case 10:
					if (obj == null)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 9;
					}
					break;
				case 8:
					if (jYK8pRG805YumLji7Lsj(propertyCached, null))
					{
						num2 = 2;
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			propertyCached = obj.GetType().GetPropertyCached((string)sCwe7SG8xjUWpD9lhuVX(propMd));
			num = 8;
		}
	}

	internal static void VH8mfqG86o9UFsSKj2QN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool lh3oRRG8wTaE3NSi5r8c()
	{
		return Pr3WiyG8tqUancHQnH5k == null;
	}

	internal static GuidPropertyDescriptor p2LXhnG84Z4OIaxauVWS()
	{
		return Pr3WiyG8tqUancHQnH5k;
	}

	internal static bool vAg87aG8H3AGLBtJd9hC(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object anT4F0G8A48bc8emSGBG(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object m7ooolG87cgKfLeqQXit(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sCwe7SG8xjUWpD9lhuVX(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool jYK8pRG805YumLji7Lsj(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object z2LsjcG8mRvvZdHJPbH0(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool sLB5BgG8yA5COh8pt0fa(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object yrkotsG8M7c75jpk9Fu4(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static void SoiUT3G8J60yMw6FOqGC(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object IYjA1bG8902F10Pea24h()
	{
		return Logger.Log;
	}

	internal static void dZWu0XG8dRw8KSU7C7pU(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool sS0sSfG8le9pjqiRrbXi(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type qWvhJFG8rG9y8nDmmPLc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
